using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

//Custom's
using Objects.Processes;
using Objects.Tables;
using Newtonsoft.Json;
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

		private string _ExceptionCM;

		#region PROPIEDADES

		public string EXception
		{
			get { return this._ExceptionCM; }
			set { this._ExceptionCM = value; }
		}

		public tMaterial DataMaterial
		{
			get { return this._dataMaterial; }
			set { this._dataMaterial = value; }
		}

		public tCategoria DataCategoria
		{
			get { return this._dataCategoria; }
			set { this._dataCategoria = value; }
		}

		public tMarca DataMarca
		{
			get { return this._dataMarca; }
			set { this._dataMarca = value; }
		}

		#endregion

		//public List<Claves> ListarKeys( AsignMaterialRequest asign )
		//{
		//	Query query = new Query( "api/material/asign/Aula/" + asign.CodigoSalon );

		//	try
		//	{
		//		query.RequestParameters = asign;

		//		query.SendRequestPOST();

		//		if ( query.ResponseStatusCode != HttpStatusCode.OK )
		//			throw new ArgumentNullException( "No se encontraron datos", "Materiales" );

		//		return JsonConvert.DeserializeObject<List<Claves>>( query.ResponseContent );
		//	}
		//	catch ( Exception ex )
		//	{
		//		this._ExceptionCM = ex.Message;
		//		return null;
		//	}
		//}

		//public List<lReporteIndividualOfMaterial> ListReportedMaterials()
		//{
		//	Query query = new Query( "api/material/reporteIndividual" );

		//	try
		//	{
		//		query.SendRequestGET();

		//		if ( query.ResponseStatusCode != HttpStatusCode.OK )
		//			throw new ArgumentNullException( "No se encontraron datos", "Materiales Reportados" );

		//		return JsonConvert.DeserializeObject<List<lReporteIndividualOfMaterial>>( query.ResponseContent );
		//	}
		//	catch ( Exception ex )
		//	{
		//		this._ExceptionCM = ex.Message;
		//		return null;
		//	}
		//}

		//public lReportEspecifico ReporteIndividual()
		//{
		//	Query query = new Query( "api/material/condicion" );

		//	try
		//	{
		//		query.SendRequestGET();

		//		if ( query.ResponseStatusCode != HttpStatusCode.OK )
		//			throw new ArgumentNullException( "No se encontraron datos", "Informacion" );

		//		return JsonConvert.DeserializeObject<lReportEspecifico>( query.ResponseContent );
		//	}
		//	catch ( Exception ex )
		//	{
		//		this._ExceptionCM = ex.Message;
		//		return null;
		//	}
		//}

		//public List<lMaterial> ListforAulaAndCondicion( int codAula, string Condicion )
		//{
		//	Query query = new Query( "api/students/parents_show/" + codAula + " /" + Condicion );

		//	try
		//	{
		//		query.SendRequestGET();

		//		if ( query.ResponseStatusCode != HttpStatusCode.OK )
		//			throw new ArgumentNullException( "No se encontraron datos", "Materiales" );

		//		return JsonConvert.DeserializeObject<List<lMaterial>>( query.ResponseContent );
		//	}
		//	catch ( Exception ex )
		//	{
		//		this._ExceptionCM = ex.Message;
		//		return null;
		//	}
		//}

		#region CRUD Material

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
				this._ExceptionCM = ex.Message;
				return null;
			}
		}

		public tMaterial Find( int Codigo )
		{
			Query oQuery = new Query( "api/control/material/" + Codigo );

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

				return JsonConvert.DeserializeObject<tMaterial>( resp.data );
			}
			catch ( Exception ex )
			{
				this._ExceptionCM = ex.Message;
				return null;
			}
		}

		public tMaterial Insert()
		{
			Query oQuery = new Query( "api/control/material" );

			this._dataMaterial.Category = this._dataCategoria;
			this._dataMaterial.Marca = this._dataMarca;

			oQuery.RequestParameters = this._dataMaterial;

			try
			{
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n", "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tMaterial>( resp.data );
			}
			catch ( Exception e )
			{
				this._ExceptionCM = e.Message;
				return null;
			}
		}

		public tMaterial Update( int Codigo )
		{
			Query oQuery = new Query( "api/control/material/" + Codigo );

			this._dataMaterial.Category = this._dataCategoria;
			this._dataMaterial.Marca = this._dataMarca;
			oQuery.RequestParameters = this._dataMaterial;

			try
			{
				oQuery.SendRequestPUT("put");

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n", "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tMaterial>( resp.data );
			}
			catch ( Exception e )
			{
				this._ExceptionCM = e.Message;
				return null;
			}
		}

		public bool Delete( int Codigo )
		{
			Query oQuery = new Query( "api/control/material/" + Codigo );
			try
			{
				oQuery.SendRequestDELETE();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n", "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception e )
			{
				this._ExceptionCM = e.Message;
				return false;
			}
		}

		public List<tMaterialSalon> ListforAula( int CodigoSalon )
		{
			Query oQuery = new Query( string.Format("api/control/aula/{0}/material", CodigoSalon ) );

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

				return JsonConvert.DeserializeObject<List<tMaterialSalon>>( resp.data );
			}
			catch ( Exception ex )
			{
				this._ExceptionCM = ex.Message;
				return null;
			}
		}

		public List<tMaterialSalon> AsignMaterialsToAula( int CodigoSalon, int CodigoMaterial, int Cantidad )
		{
			Query oQuery = new Query( string.Format( "api/control/aula/{0}/material/{1}/quantity/{2}", CodigoSalon, CodigoMaterial, Cantidad ) );

			try
			{
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n", "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<List<tMaterialSalon>>( resp.data );
			}
			catch ( Exception ex )
			{
				this._ExceptionCM = ex.Message;
				return null;
			}
		}

		#endregion

	}
}

