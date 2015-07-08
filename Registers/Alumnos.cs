using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;

using Objects.Processes;
using Objects.Processes.Response;
using Objects.Tables;
using RestSharp;
using Newtonsoft.Json;
using Options;

namespace Registers
{
    public class Alumnos : Connection
    {
        private string _msgExceptionRegAlumno, 
                        _registerController = "api/process/enrollment/registers/students",
                        _schoolController = "api/lastschool";

        private OpSRegisterAlumno _dataAlumno    = new OpSRegisterAlumno();
        private List<Document>    _dataDocuments = new List<Document>();
		private List<Parent>      _dataParent    = new List<Parent>();
		private List<ExoneratedCours>_dataExoneratedCourses = new List<ExoneratedCours>();
        private Dictionary<string, string> _File =   new Dictionary<string, string>();

        #region PROPIEDADES

        public string MsERegistrarAlumno
        {
            get { return this._msgExceptionRegAlumno; }
        }
        public OpSRegisterAlumno DataAlumno
        {
            get { return this._dataAlumno; }
            set
            {
                this._dataAlumno = value;
            }
        }
        public Document DataDocuments
        {
            set
            {
                this._dataDocuments.Add( value );
            }
        }
      
        public Parent DataParent
        {
            set
            {
                this._dataParent.Add( value );
            }
        }

		public ExoneratedCours DataExoneratedCurses
		{
			set
			{
				this._dataExoneratedCourses.Add( value );
			}
		}

        #endregion


        #region METODOS

        public void FindDocumentNumber( string NumeroDocumento )
        {
            int i = 0;

            for ( i = 0; i <= this._dataDocuments.Count; i++ )
            {
                if ( this._dataDocuments[i].DocumentNumber == NumeroDocumento )
                {
                    this._dataDocuments.RemoveAt( i );
                    break;
                }
            }
        }

        public void FindParentName( string NombrePariente )
        {
            int i = 0;

            for ( i = 0; i <= _dataParent.Count; i++ )
            {
                string nombrecompleto = _dataParent[i].Names + " " + _dataParent[i].LastName;

                if ( nombrecompleto == NombrePariente )
                {
                    this._dataParent.RemoveAt( i );
                    break;
                }
            }
        }

        public DataSet ListSchool( DataSet dts )
        {
            Query query = new Query( this._schoolController );

            try
            {

                if( dts.Tables["lastschool"].Rows.Count > 0 ) dts.Tables["lastschool"].Clear();

                query.SendRequestGET();

                if ( query.ResponseStatusCode != HttpStatusCode.OK )
                    throw new ArgumentNullException( "No se encontraron datos", "Ultimos Colegios" );

                List<LastSchool> schools = JsonConvert.DeserializeObject<List<LastSchool>>( query.ResponseContent );

                foreach ( LastSchool Items in schools )
                {
                    var temp = new object[3] { Items.Id, Items.Name, Items.type };
                    dts.Tables["lastschool"].Rows.Add( temp );
                }

                return dts;

            }
            catch ( Exception ex )
            {
                this._msgExceptionRegAlumno = ex.Message;
                return null;
            }
        }

		public List<ListCursos> ListaCursos(  int IdClase )
		{
			Query query = new Query( "api/cursos/clase/" + IdClase );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Cursos" );

				List<ListCursos> cursos = JsonConvert.DeserializeObject<List<ListCursos>>( query.ResponseContent );

				return cursos;
			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public DataSet ListStudents( DataSet dts )
		{
			Query query = new Query( this._registerController );

			try
			{

				if ( dts.Tables["liststudents"].Rows.Count > 0 ) dts.Tables["liststudents"].Clear();

				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Estudiantes" );

				List<ListAlumnos> AlumnosData = JsonConvert.DeserializeObject<List<ListAlumnos>>( query.ResponseContent );

				foreach ( ListAlumnos Items in AlumnosData )
				{
					var temp = new object[] { 
						Items.Id, 
						Items.Key,
						Items.Name, 
						Items.type 
					};

					dts.Tables["liststudents"].Rows.Add( temp );
				}

				return dts;

			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public List<FillClases> fillClases( int pgrado, int pseccion )
		{
			Query query = new Query( "api/process/enrollment/filter/classes/degree/" + pgrado + "/section/" + pseccion );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Clases" );

				List<FillClases> classes = JsonConvert.DeserializeObject<List<FillClases>>( query.ResponseContent );

				return classes;
			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

        public bool SendDataStudent( DataSet dts )
        {
            Query query = new Query( this._registerController );

            this._dataAlumno.Documents			= this._dataDocuments;
            this._dataAlumno.Parents			= this._dataParent;
			this._dataAlumno.ExoneratedCourses	= this._dataExoneratedCourses;

            if(!string.IsNullOrEmpty(DataAlumno.ImageKey) &&  !string.IsNullOrEmpty(DataAlumno.Imagesrc))
            {
				this._File.Add(this.DataAlumno.ImageKey, this.DataAlumno.Imagesrc);
				this._dataAlumno.Imagesrc = string.Empty;
            }

            int con = 0;

            foreach(Document items in this.DataAlumno.Documents)
            {
				if ( !string.IsNullOrEmpty( items.Imagesrc ) && !string.IsNullOrEmpty( items.ImageKey ) )
				{
					this._File.Add( items.ImageKey, items.Imagesrc );
					this._dataAlumno.Documents[con].Imagesrc = string.Empty;
					con++;
				}
            }

            query.RequestParameters = this._dataAlumno;
            query.AddRequestFiles(this._File);

            try
            {
                query.SendRequestPOST();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL REGISTRO" );

				ResponseAlumno alumno = JsonConvert.DeserializeObject<ResponseAlumno>( query.ResponseContent );

				object[] objAlumno = new object[] 
				{
					alumno.Id,
					alumno.Names,
					alumno.LastName,
					alumno.Sexo,
					alumno.Birthday,
					alumno.Imagesrc,
					alumno.Address,
					alumno.Usuario,
					alumno.IdLastSchool
				};

				dts.Tables["student"].Rows.Add( objAlumno );

				foreach ( ResponseDocument docs in alumno.Documents )
				{
					object[] objDocuments = new object[4] 
					{
						docs.TypeDocument,
						docs.DocumentNumber,
						docs.Expire,
						alumno.Id
					};

					dts.Tables["Documents"].Rows.Add( objDocuments );
				}

				foreach ( ResponseParent parent in alumno.Parents )
				{
					object[] objParents = new object[9] 
					{
						parent.Names,
						parent.LastName,
						parent.TypeParent,
						parent.GenderParent,
						parent.TypeDocument,
						parent.DocumentNumber,
						parent.Phone,
						parent.Email,
						alumno.Id
					};

					dts.Tables["Parents"].Rows.Add( objParents );
				}

                return true;
            }
            catch ( Exception e )
            {
                this._msgExceptionRegAlumno = e.Message;
                return false;
            }
        }

        #endregion

    }
}
