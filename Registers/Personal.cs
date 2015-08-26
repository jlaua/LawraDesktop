using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Options;
using Objects.Processes;
using Objects.Tables;
using Newtonsoft.Json;
using System.Data;
using System.Net;

namespace Registers
{
    public class Personal : Connection
    {
        private string _msgExceptionPersonal,
                       _Controller = "api/personal";

        private tPersonal  _data = new tPersonal();
		private Dictionary<string, string> _file = new Dictionary<string, string>();

        #region Propiedades

        public string ExceptionPersonal
        {
            get { return this._msgExceptionPersonal; }
        }

        public tPersonal Data
        {
            get { return this._data; }
            set
            {
                this._data = value;
            }
        }

        #endregion

        #region Metodos
        
		public List<lPersonal> List()
		{
			Query oQuery = new Query( "api/personal" );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionPersonal, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<List<lPersonal>>( resp.data );

			}catch ( Exception ex )
			{
				this._msgExceptionPersonal = ex.Message.ToString();
				return null;
			}
		}

		public tPersonal Find( int ID )
		{
			Query oQuery = new Query( "api/personal/" + ID );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionPersonal, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tPersonal>( resp.data );
			}
			catch ( Exception ex )
			{
				this._msgExceptionPersonal = ex.Message.ToString();
				return null;
			}
		}

		public tPersonal Insert ()
		{
			Query query = new Query( "api/personal" );

			if ( !string.IsNullOrEmpty( this._data.ImageKey ) && !string.IsNullOrEmpty( this._data.ImageSrc ) )
			{
				this._file.Add( this._data.ImageKey, this._data.ImageSrc );
				this._data.ImageSrc = string.Empty;
			}

			query.RequestParameters = this._data;

			if ( this._file.Any() )
				query.AddRequestFiles( this._file );

			try
			{
				query.SendRequestPOST();

				if ( query.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionPersonal, "Error en el Servidor" );
				else if ( query.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( query.ResponseContent );

				if ( query.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				string[] str = resp.data.Split( '-' );
				
				this._data.Codigo =  Convert.ToInt32(str[0]);
				this._data.Key = str[1];

				return this._data;
			}
			catch ( Exception e )
			{
				this._msgExceptionPersonal = e.Message;
				return null;
			}
		}

		public bool Modify( int Codigo )
		{
			Query query = new Query( "api/personal/" + Codigo );

			if ( !string.IsNullOrEmpty( this._data.ImageKey ) && !string.IsNullOrEmpty( this._data.ImageSrc ) )
			{
				this._file.Add( this._data.ImageKey, this._data.ImageSrc );
				this._data.ImageSrc = string.Empty;
			}

			query.RequestParameters = this._data;

			if ( this._file.Any() )
				query.AddRequestFiles( this._file );

			try
			{
				query.SendRequestPUT();

				if ( query.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionPersonal, "Error en el Servidor" );
				else if ( query.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( query.ResponseContent );

				if ( query.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean(resp.data);
			}
			catch ( Exception e )
			{
				this._msgExceptionPersonal = e.Message;
				return false;
			}
		}

		public bool Delete( int Codigo )
		{
			Query query = new Query( "api/personal/" + Codigo );

			try
			{
				query.SendRequestDELETE();

				if ( query.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionPersonal, "Error en el Servidor" );
				else if ( query.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( query.ResponseContent );

				if ( query.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception e )
			{
				this._msgExceptionPersonal = e.Message;
				return false;
			}
		}

        #endregion
    }
}
