using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

//Custom's
using Objects.Processes;
using Newtonsoft.Json;
using Objects.Tables;
using RestSharp;
using Options;
using System.Net;

namespace ControlMaterial
{
	public class Material
	{
		private tMaterial _dataMaterial = new tMaterial();
		private tCategoria _dataCategoria = new tCategoria();
		private tMarca _dataMarca = new tMarca();

		private string _msgException;

		#region PROPIEDADES

		public string EXception
		{
			get { return this._msgException; }
			internal set { this._msgException = value; }
		}

		public tMaterial DataMaterial
		{
			get { return this._dataMaterial; }
			set
			{
				this._dataMaterial = value;
			}
		}
		public tCategoria DataCategoria
		{
			get { return this._dataCategoria; }
			set
			{
				this._dataCategoria = value;
			}
		}
		public tMarca DataMarca
		{
			get { return this._dataMarca; }
			set
			{
				this._dataMarca = value;
			}
		}

		#endregion

		public int Insert()
		{
			Query query = new Query( "api/material/" );

			this._dataMaterial.Category = this._dataCategoria;
			this._dataMaterial.Marca = this._dataMarca;

			query.RequestParameters = this._dataMaterial;

			try
			{
				query.SendRequestPOST();

				if ( query.ResponseStatusCode != HttpStatusCode.Created )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL REGISTRAR UN MATERIAL" );

				return Convert.ToInt32( query.ResponseContent ); ;
			}
			catch ( Exception e )
			{
				this._msgException = e.Message;
				return 0;
			}
		}

		public List<Claves> ListarKeys( AsignMaterialRequest asign )
		{
			Query query = new Query( "api/material/asign/Aula/" + asign.CodigoSalon );

			try
			{
				query.RequestParameters = asign;

				query.SendRequestPOST();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Materiales" );

				return JsonConvert.DeserializeObject<List<Claves>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public List<tMaterial> Listar()
		{
			Query oQuery = new Query( "api/control/material" );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n", "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<List<tMaterial>>( resp.data );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public List<lMaterialOfAula> ListforAula( int codAula )
		{
			Query query = new Query( "api/material/aula/" + codAula );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Materiales" );

				return JsonConvert.DeserializeObject<List<lMaterialOfAula>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public List<lReporteIndividualOfMaterial> ListReportedMaterials()
		{
			Query query = new Query( "api/material/reporteIndividual" );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Materiales Reportados" );

				return JsonConvert.DeserializeObject<List<lReporteIndividualOfMaterial>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public lReportEspecifico ReporteIndividual()
		{
			Query query = new Query( "api/material/condicion" );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Informacion" );

				return JsonConvert.DeserializeObject<lReportEspecifico>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public List<lMaterial> ListforAulaAndCondicion( int codAula, string Condicion )
		{
			Query query = new Query( "api/students/parents_show/" + codAula + " /" + Condicion );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Materiales" );

				return JsonConvert.DeserializeObject<List<lMaterial>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public tMaterial Find( int Codigo )
		{
			Query query = new Query( "api/material/show/" + Codigo );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( query.ResponseContent, "ERROR AL OBTENER INFORMACION DEL MATERIAL" );

				return JsonConvert.DeserializeObject<tMaterial>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public bool Update( int Codigo )
		{
			Query query = new Query( "api/material/" + Codigo );

			this._dataMaterial.Category = this._dataCategoria;
			this._dataMaterial.Marca = this._dataMarca;
			query.RequestParameters = this._dataMaterial;

			try
			{
				query.SendRequestPUT();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( query.MsgExceptionQuery, "HUBO UN ERROR AL INTENTAR MODIFICAR AL APODERADO" );

				return Convert.ToBoolean( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this._msgException = e.Message;
				return false;
			}
		}

		public bool Delete( int Codigo )
		{
			Query query = new Query( "api/material/" + Codigo );
			try
			{
				query.SendRequestDELETE();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentException( query.MsgExceptionQuery, "ERROR AL ELIMINAR EL MATERIAL" );

				return Convert.ToBoolean( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this._msgException = e.Message;
				return false;
			}
		}
	}
}
