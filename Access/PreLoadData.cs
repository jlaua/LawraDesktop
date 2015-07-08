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
using Objects.Tables;

namespace Access
{
    public class PreLoadData : Connection
    {
        private string _ubigeoController		= "api/ubigeo";
        private string _tipoDocController		= "api/tipodocumento";
        private string _tipoParentController	= "api/typeparents";

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
			Query query = new Query( "api/listperiods" );

			try
			{
				query.SendRequestGET();

				dts.Tables["periodos"].Clear();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
				{
					throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
				}

				List<Periodos> peri = JsonConvert.DeserializeObject<List<Periodos>>( query.ResponseContent );

				foreach ( Periodos Item in peri )
				{
					object[] td = new object[8]  {
						Item.Codigo, Item.Name, Item.Year, Item.Description, Item.StartDate, Item.EndDate, Item.IsActive, Item.ModifiedDate
                    };

					dts.Tables["periodos"].Rows.Add( td );
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

                List<Departamentos> departamentos = JsonConvert.DeserializeObject<List<Departamentos>>( query.ResponseContent );

                int countProv = 1, countDist = 1;

                foreach ( Departamentos depItem in departamentos )
                {
                    string[] camposdep = new string[2] { depItem.Id.ToString(), depItem.Departamento};
                    dts.Tables["Departamentos"].Rows.Add(camposdep);

                    foreach ( Provincias proItem in depItem.Provincias )
                    {
                        string[] campospro = new string[4] { countProv.ToString(), camposdep[0], proItem.Id.ToString(), proItem.Provincia };
                        dts.Tables["Provincias"].Rows.Add( campospro );

                        foreach ( Distritos disItem in proItem.Distritos )
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

                dts.Tables["tipodocumento"].Clear();

                if ( query.ResponseStatusCode != HttpStatusCode.OK )
                {
                    throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
                }

                List<TipoDocumento> tipo = JsonConvert.DeserializeObject<List<TipoDocumento>>( query.ResponseContent );

                foreach ( TipoDocumento Item in tipo )
                {
                    object[] td = new object[6]  { 
                        Item.Id, Item.LongName, Item.ShortName, Item.Length, Item.IsNumeric, Item.IsExactLength
					};

                    dts.Tables["tipodocumento"].Rows.Add( td );
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

                dts.Tables["tipoapoderado"].Clear();

                if (query.ResponseStatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentNullException("No se ha podido acceder a los datos", "Datos de Tipo de Documentos");
                }

                List<TypeParent> tipo = JsonConvert.DeserializeObject<List<TypeParent>>(query.ResponseContent);

                foreach (TypeParent Item in tipo)
                {
                    object[] td = new object[3] { Item.Id, Item.Name, Item.type };

                    dts.Tables["tipoapoderado"].Rows.Add(td);
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
			Query query = new Query( "api/liststudents" );

			try
			{
				query.SendRequestGET();

				dts.Tables["liststudents"].Clear();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
				{
					throw new ArgumentNullException( "No se ha podido acceder a los datos", "Datos de Tipo de Documentos" );
				}

				List<ListStudents> tipo = JsonConvert.DeserializeObject<List<ListStudents>>( query.ResponseContent );

				foreach ( ListStudents Item in tipo )
				{
					object[] td = new object[4] { Item.Codigo, Item.Key, Item.Names, Item.ModifiedDate };

					dts.Tables["liststudents"].Rows.Add( td );
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
			Query query = new Query( "api/gradoseccion" );

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

				foreach ( Grados Item in grs.Grados )
				{
					object[] td = new object[7] { 
						Item.Codigo, Item.CodigoNivel, Item.Name, Item.Preview, Item.Next, Item.Description, Item.ModifiedDate
					};

					dts.Tables["Grados"].Rows.Add( td );
				}

				foreach ( Secciones Item in grs.Secciones )
				{
					object[] td = new object[4] { 
						Item.Codigo, Item.Name, Item.Character, Item.ModifiedDate
					};

					dts.Tables["Secciones"].Rows.Add( td );
				}

				foreach ( Niveles Item in grs.Niveles )
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
