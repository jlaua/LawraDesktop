﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;

using Objects.Processes;
using Newtonsoft.Json;
using Objects.Tables;
using RestSharp;
using Options;

namespace Registers.Students
{
	public class Alumnos : Connection
	{
		private string _msgExceptionRegAlumno;

		private string _AlumnoCtrl		= "api/students", //Registro de alumno fuera de un asistente de proceso
                        _pAlumnoCtrl	= "api/process/enrollment/registers/students",
                        _schoolsCtrl	= "api/initial/lastschool";

		private pAlumno _dataMain							= new pAlumno();
		private tAlumno _dataAlumno							= new tAlumno();

		private List<tDocumentoAlumno>_dataDocumento		= new List<tDocumentoAlumno>();
		private List<tApoderado> _dataApoderado				= new List<tApoderado>();
		private List<tCursoExonerado> _dataCursoExonerado	= new List<tCursoExonerado>();

		private Dictionary<string, string> _File			=   new Dictionary<string, string>();

#region PROPIEDADES

		public string MsERegistrarAlumno
		{
			get { return this._msgExceptionRegAlumno; }
		}

		public tAlumno DataAlumno
		{
			get { return this._dataAlumno; }
			set
			{
				this._dataAlumno = value;
			}
		}

		public tDocumentoAlumno DataDocumento
		{
			set
			{
				this._dataDocumento.Add( value );
			}
		}

		public tApoderado DataApoderado
		{
			set
			{
				this._dataApoderado.Add( value );
			}
		}

		public tCursoExonerado DataCursoExonerado
		{
			set
			{
				this._dataCursoExonerado.Add( value );
			}
		}

#endregion

#region METODOS

		public void FindDocumentNumber( string NumeroDocumento )
		{
			int i = 0;

			for ( i = 0; i <= this._dataDocumento.Count; i++ )
			{
				if ( this._dataDocumento[i].DocumentNumber == NumeroDocumento )
				{
					this._dataDocumento.RemoveAt( i );
					break;
				}
			}
		}

		public void FindParentName( string NombrePariente )
		{
			int i = 0;

			for ( i = 0; i <= this._dataApoderado.Count; i++ )
			{
				string nombrecompleto = this._dataApoderado[i].Names + " " + this._dataApoderado[i].LastNames;

				if ( nombrecompleto == NombrePariente )
				{
					this._dataApoderado.RemoveAt( i );
					break;
				}
			}
		}

		public DataSet ListSchool( DataSet dts )
		{
			Query query = new Query( this._schoolsCtrl );

			try
			{

				if ( dts.Tables["UltimoColegio"].Rows.Count > 0 ) dts.Tables["UltimoColegio"].Clear();

				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Ultimos Colegios" );

				List<tUltimoColegio> schools = JsonConvert.DeserializeObject<List<tUltimoColegio>>( query.ResponseContent );

				foreach ( tUltimoColegio Items in schools )
				{
					object[] temp = new object[4] { 
						Items.Codigo, 
						Items.Name, 
						Items.TypeSchool ? "PARTICULAR" : "ESTATAL", 
						Items.ModifiedDate 
					};

					dts.Tables["UltimoColegio"].Rows.Add( temp );
				}

				return dts;

			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public DataSet ListStudents( DataSet dts )
		{
			Query query = new Query( this._AlumnoCtrl );

			try
			{
				if ( dts.Tables["ListaAlumnos"].Rows.Count > 0 ) dts.Tables["ListaAlumnos"].Clear();

				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Estudiantes" );

				List<lAlumnos> AlumnosData = JsonConvert.DeserializeObject<List<lAlumnos>>( query.ResponseContent );

				foreach ( lAlumnos Items in AlumnosData )
				{
					object[] temp = new object[4] { 
						Items.Codigo, 
						Items.Key,
						Items.Names, 
						Items.ModifiedDate 
					};

					dts.Tables["ListaAlumnos"].Rows.Add( temp );
				}

				return dts;

			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public List<tCurso> ListaCursos( int idClase )
		{
			Query query = new Query( "api/clase/" + idClase + "/curso" );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Cursos" );

				return JsonConvert.DeserializeObject<List<tCurso>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public List<FillClases> FindClases( int pgrado, int pseccion )
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

		public tNivelParametro ParametersLevel( int idClass )
		{
			Query query = new Query( "api/clase/cursos/" + idClass );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Cursos" );

				return JsonConvert.DeserializeObject<tNivelParametro>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public tAlumno FindStudents( int CodigoAlumno )
		{
			Query query = new Query( this._AlumnoCtrl + "/" + CodigoAlumno );
			
			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( query.ResponseContent, "Busqueda de Alumno" );

				 return JsonConvert.DeserializeObject<tAlumno>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgExceptionRegAlumno = ex.Message;
				return null;
			}
		}

		public int CreateStudent( bool Individual = false )
		{
			Query query = new Query(  ( ! Individual ) ? this._pAlumnoCtrl : this._AlumnoCtrl );

			this._dataMain.Alumno = this._dataAlumno;

			if ( ! Individual ) //si no solo se registraran datos unicos del alumno
			{
				this._dataMain.Documentos = this._dataDocumento;
				this._dataMain.Apoderado = this._dataApoderado;
				this._dataMain.CursosExonerados = this._dataCursoExonerado;
			}

			//limpiando los datos de imagen de perfil y agregandolo al contenedor de imagenes
			if ( !string.IsNullOrEmpty( DataAlumno.ImageKey ) && !string.IsNullOrEmpty( DataAlumno.ImageSrc ) )
			{
				this._File.Add( this.DataAlumno.ImageKey, this.DataAlumno.ImageSrc );
				this._dataMain.Alumno.ImageSrc = string.Empty;
			}

			if ( !Individual )
			{
				int con = 0;

				//limpiando los datos de imagen de documento y agregandolos al contenedor de imagens
				foreach ( tDocumentoAlumno items in this._dataMain.Documentos )
				{
					if ( !string.IsNullOrEmpty( items.ImageSrc ) && !string.IsNullOrEmpty( items.ImageKey ) )
					{
						this._File.Add( items.ImageKey, items.ImageSrc );
						this._dataMain.Documentos[con].ImageSrc = string.Empty;
						con++;
					}
				}
			}
			
			query.RequestParameters = this._dataMain;
			
			if ( this._File.Any() )
				query.AddRequestFiles( this._File );

			try
			{
				query.SendRequestPOST();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL REGISTRO" );

				return Convert.ToInt32( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this._msgExceptionRegAlumno = e.Message;
				return 0;
			}
		}

		public bool ModifyStudent( int Codigo )
		{
			Query query = new Query( this._AlumnoCtrl + "/" + Codigo );

			this._dataMain.Alumno = this._dataAlumno;

			if ( !string.IsNullOrEmpty( this._dataAlumno.ImageKey ) && !string.IsNullOrEmpty( this._dataAlumno.ImageSrc ) )
			{
				this._File.Add( this._dataAlumno.ImageKey, this._dataAlumno.ImageSrc );
				this._dataMain.Alumno.ImageSrc = string.Empty;
			}

			query.RequestParameters = this._dataMain;

			if ( this._File.Any() )
				query.AddRequestFiles( this._File );

			try
			{
				query.SendRequestPUT();

				if ( query.ResponseStatusCode != HttpStatusCode.Accepted )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL MODIFICAR EL ESTUDIANTE" );

				return true;
			}
			catch ( Exception e )
			{
				this._msgExceptionRegAlumno = e.Message;
				return false;
			}
		}

		public bool DeleteStudent( int codalumno )
		{
			Query query = new Query( this._AlumnoCtrl + "/" + codalumno );

			try
			{
				query.SendRequestDELETE();

				if ( query.ResponseStatusCode != HttpStatusCode.Accepted )
					throw new ArgumentException( query.MsgExceptionQuery, "ERROR AL ELIMINARR EL ALUMNO" );

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
