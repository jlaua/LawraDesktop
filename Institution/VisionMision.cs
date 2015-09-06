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
	public class VisionMision
	{
		private string _exceptionHistory;
		private TVisionMision _data = new TVisionMision();

		public string ExceptionHistory
		{
			get { return this._exceptionHistory; }
			internal set { this._exceptionHistory = value; }
		}

		public TVisionMision Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public TVisionMision Find()
		{
			Query oQuery = new Query( "api/institution/vision_mision" );

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

				return JsonConvert.DeserializeObject<TVisionMision>( resp.data );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return null;
			}
		}

		public bool Insert()
		{
			Query oQuery = new Query( "api/institution/vision_mision" );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return false;
			}
		}

		public bool Update()
		{
			Query oQuery = new Query( "api/institution/vision_mision/" + this._data.Codigo );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPUT( "put" );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._exceptionHistory, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return false;
			}
		}
	}
}
