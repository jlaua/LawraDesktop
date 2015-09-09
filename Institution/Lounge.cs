using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Custom's
using Newtonsoft.Json;
using Objects.Tables;
using System.Net;
using Options;
using Objects.Processes;

namespace Institution
{
	public class Lounge : Connection
	{
		private string _exceptionLounge, _resource;
		private tSalon _data = new tSalon();
		private int CodigoSucursal;

		public tSalon Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public string EXception
		{
			get { return this._exceptionLounge; }
			internal set { this._exceptionLounge = value; }
		}

		//__CONSTRUCTOR
		public Lounge()
		{
			string Codigo = this.getAppSettings( "BranchCode" );
			this._resource = string.Format( "api/institution/branches/{0}/lounge", 
								( string.IsNullOrEmpty( Codigo ) ) ? "0" : Codigo 
							);
		}

		public List<tSalon> Listar()
		{
			Query oQuery = new Query( this._resource );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<List<tSalon>>( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return null;
			}
		}

		public tSalon Find( int Codigo )
		{
			Query oQuery = new Query( string.Format( "{0}/{1}", this._resource, Codigo ) );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tSalon>( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return null;
			}
		}

		public int Insert()
		{
			Query oQuery = new Query( this._resource );

			try
			{
				oQuery.RequestParameters = this.Data;

				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToInt32( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return 0;
			}
		}

		public bool Update( int Codigo )
		{
			Query oQuery = new Query( string.Format("{0}/{1}", this._resource, Codigo) );

			try
			{
				oQuery.RequestParameters = this.Data;

				oQuery.SendRequestPUT("put");

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return false;
			}
		}

		public bool Delete( int Codigo )
		{
			Query oQuery = new Query( string.Format( "{0}/{1}", this._resource, Codigo ) );

			try
			{
				oQuery.SendRequestDELETE();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return false;
			}
		}

	}
}
