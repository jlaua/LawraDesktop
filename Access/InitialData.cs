using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Data;

using Options;
using Newtonsoft.Json;
using RestSharp;
using Objects.Processes;
using Objects.Tables;

namespace Access
{
    public class InitialData : Connection
    {
        private string _ubigeoController		= "api/initial/ubigeo";
        private string _tipoDocController		= "api/initial/type/documents";
        private string _tipoParentController	= "api/initial/type/parents";

        private string _exceptionUbigeo;

		#region PROPIEDADES

		public string ExceptionUbigeo
        {
            get { return this._exceptionUbigeo; }
        }

		public bool AsignYear( string IdPeriod )
		{
			this.setAppSettings( "YearAcademy", IdPeriod );
			return true;
		}

		#endregion

		#region METODOS	

		public DataSet ListPeriodos( DataSet dts )
		{
			Query query = new Query( "api/initial/periods" );

			try
			{
				query.SendRequestGET();

				dts.Tables["Periodo"].Clear();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
				{
					throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
				}

				List<tPeriodo> peri = JsonConvert.DeserializeObject<List<tPeriodo>>( query.ResponseContent );

				foreach ( tPeriodo Item in peri )
				{
					object[] td = new object[8]  
					{
						Item.Codigo, 
						Item.Name, 
						Item.Year, 
						Item.Description, 
						Item.StartDate, 
						Item.EndDate, 
						Item.Active, 
						Item.ModifiedDate
                    };

					dts.Tables["Periodo"].Rows.Add( td );
				}

				return dts;

			}
			catch ( Exception e )
			{
				this._exceptionUbigeo = e.Message;
				return null;
			}
		}

        public DataSet ListUbigeo( DataSet dts )
        {
            Query query = new Query( this._ubigeoController );

            try
            {
                query.SendRequestGET();

                dts.Tables["Departamentos"].Clear();
                dts.Tables["Provincias"].Clear();
                dts.Tables["Distritos"].Clear();

                if( query.ResponseStatusCode != HttpStatusCode.OK )
                {
                    throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Ubigeo" );
                }

                List<tDepartamentos> departamentos = JsonConvert.DeserializeObject<List<tDepartamentos>>( query.ResponseContent );

                int countProv = 1, countDist = 1;

                foreach ( tDepartamentos depItem in departamentos )
                {
                    string[] camposdep = new string[2] { depItem.Id.ToString(), depItem.Departamento};
                    dts.Tables["Departamentos"].Rows.Add(camposdep);

                    foreach ( tProvincias proItem in depItem.Provincias )
                    {
                        string[] campospro = new string[4] { countProv.ToString(), camposdep[0], proItem.Id.ToString(), proItem.Provincia };
                        dts.Tables["Provincias"].Rows.Add( campospro );

                        foreach ( tDistritos disItem in proItem.Distritos )
                        {
                            string[] camposdis = new string[4] { countDist.ToString(), campospro[0], disItem.Id.ToString(), disItem.Distrito };
                            dts.Tables["Distritos"].Rows.Add( camposdis );
                            countDist++;
                        }

                        countProv++;
                    }
                }

                return dts;

            }catch(Exception e)
            {
                this._exceptionUbigeo = e.Message;
                return null;
            }
        }

        public DataSet ListTipoDocumento( DataSet dts )
        {
            Query query = new Query( this._tipoDocController );

            try
            {
                query.SendRequestGET();

				dts.Tables["TipoDocumento"].Clear();

                if ( query.ResponseStatusCode != HttpStatusCode.OK )
                {
                    throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
                }

                List<tTipoDocumento> tipo = JsonConvert.DeserializeObject<List<tTipoDocumento>>( query.ResponseContent );

                foreach ( tTipoDocumento Item in tipo )
                {
                    object[] td = new object[8]  { 
                        Item.Codigo, 
						Item.Name, 
						Item.ShortName, 
						Item.Length, 
						Item.Numeric, 
						Item.Numeric,
						Item.Description,
						Item.ModifiedDate
					};

					dts.Tables["TipoDocumento"].Rows.Add( td );
                }

                return dts;

            }
            catch ( Exception e )
            {
                this._exceptionUbigeo = e.Message;
                return null;
            }
        }

        public DataSet ListTipoApoderado(DataSet dts) 
        {
            Query query = new Query(this._tipoParentController);

            try
            {
                query.SendRequestGET();

				dts.Tables["TipoApoderado"].Clear();

                if (query.ResponseStatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentNullException("No se ha podido acceder a los datos", "Datos de Tipo de Documentos");
                }

                List<tTipoApoderado> tipo = JsonConvert.DeserializeObject<List<tTipoApoderado>>(query.ResponseContent);

                foreach (tTipoApoderado Item in tipo)
                {
                    object[] td = new object[5] 
					{ 
						Item.Codigo, 
						Item.Name, 
						Item.Gender, 
						Item.Description, 
						Item.ModifiedDate 
					};

					dts.Tables["TipoApoderado"].Rows.Add( td );
                }

                return dts;

            }
            catch (Exception e)
            {
                this._exceptionUbigeo = e.Message;
                return null;
            }
        }

		public DataSet ListaStudents( DataSet dts )
		{
			Query query = new Query( "api/students" );

			try
			{
				query.SendRequestGET();

				dts.Tables["ListaAlumnos"].Clear();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
				{
					throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
				}

				List<lAlumnos> tipo = JsonConvert.DeserializeObject<List<lAlumnos>>( query.ResponseContent );

				foreach ( lAlumnos Item in tipo )
				{
					object[] td = new object[4] { Item.Codigo, Item.Key, Item.Names, Item.ModifiedDate };

					dts.Tables["ListaAlumnos"].Rows.Add( td );
				}

				return dts;

			}
			catch ( Exception e )
			{
				this._exceptionUbigeo = e.Message;
				return null;
			}
		}

		public DataSet ListaGradoSeccion( DataSet dts )
		{
			Query query = new Query( "api/initial/gradoseccion" );

			try
			{
				query.SendRequestGET();

				dts.Tables["Grados"].Clear();
				dts.Tables["Secciones"].Clear();
				dts.Tables["Niveles"].Clear();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
				{
					throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Grados y Secciones" );
				}

				GradoSeccion grs = JsonConvert.DeserializeObject<GradoSeccion>( query.ResponseContent );

				foreach ( tGrado Item in grs.Grados )
				{
					object[] td = new object[7] { 
						Item.Codigo, Item.CodigoNivel, Item.Name, Item.Preview, Item.Next, Item.Description, Item.ModifiedDate
					};

					dts.Tables["Grados"].Rows.Add( td );
				}

				foreach ( tSeccion Item in grs.Secciones )
				{
					object[] td = new object[4] { 
						Item.Codigo, Item.Name, Item.Character, Item.ModifiedDate
					};

					dts.Tables["Secciones"].Rows.Add( td );
				}

				foreach ( tNivel Item in grs.Niveles )
				{
					object[] td = new object[4] { 
						Item.Codigo, Item.Name, Item.Description, Item.ModifiedDate
					};

					dts.Tables["Niveles"].Rows.Add( td );
				}

				return dts;

			}
			catch ( Exception e )
			{
				this._exceptionUbigeo = e.Message;
				return null;
			}
		}

		#endregion

	}
}
