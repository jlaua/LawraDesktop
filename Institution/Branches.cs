using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Custom's
using Newtonsoft.Json;
using Objects.Tables;
using Objects.Processes;
using System.Net;
using Options;

namespace Institution
{
	public class Branches
	{
		private string _exceptionHistory;
		private tBranch _data = new tBranch();

		public string ExceptionHistory
		{
			get { return this._exceptionHistory; }
			internal set { this._exceptionHistory = value; }
		}

		public tBranch Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public List<tBranch> List()
		{
			Query oQuery = new Query( "api/institution/branches" );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NoContent )
					throw new ArgumentNullException( "No se han encontrado datos", "Lista Vacia" );
				else if ( oQuery.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );

				return JsonConvert.DeserializeObject<List<tBranch>>( oQuery.ResponseContent );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return null;
			}
		}

		public tBranch Find( string Codigo )
		{
			if ( string.IsNullOrEmpty( Codigo ) )
				throw new InvalidOperationException( "No hay un Codigo Asignado a este recurso" );

			Query oQuery = new Query( "api/institution/branches/" + Codigo );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );
				
				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tBranch>( resp.data );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return null;
			}
		}

		public tBranch Insert()
		{
			Query oQuery = new Query( "api/institution/branches" );

			try
			{
				oQuery.RequestParameters = this._data;

				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				this._data.Codigo = Convert.ToInt32( resp.data );
				return this._data;
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return null;
			}
		}

		public bool Modify()
		{
			Query oQuery = new Query( "api/institution/branches/" + this._data.Codigo );

			try
			{
				oQuery.RequestParameters = this._data;

				oQuery.SendRequestPUT("put");

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );
				
				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return true;
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return false;
			}
		}

		public bool Delete( int CodigoBranch )
		{
			Query oQuery = new Query( "api/institution/branches/" + CodigoBranch );

			try
			{
				oQuery.SendRequestDELETE();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return true;
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return false;
			}
		}
	}
}
