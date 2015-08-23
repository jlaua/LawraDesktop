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
					throw new ArgumentNullException( "El Servidor Presenta Errores, Vuelve a intentarlo mas tarde.", "Error de Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "El Recurso no existe", "Recurso no Encontrado" );

				return JsonConvert.DeserializeObject<List<lPersonal>>( oQuery.ResponseContent );

			}catch ( Exception ex )
			{
				this._msgExceptionPersonal = ex.Message.ToString();
				return null;
			}
		}

		public tPersonal Find( int ID )
		{
			Query oQuery = new Query( "api/personal" );

			try
			{
				oQuery.SendRequestGET( "" + ID );

				if ( oQuery.ResponseStatusCode == System.Net.HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "El Servidor Presenta Errores, Vuelve a intentarlo mas tarde.", "Error de Servidor" );
				else if ( oQuery.ResponseStatusCode == System.Net.HttpStatusCode.NotFound )
					throw new ArgumentNullException( "El Recurso no existe", "Recurso no Encontrado" );

				return JsonConvert.DeserializeObject<tPersonal>( oQuery.ResponseContent );

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
					throw new ArgumentNullException( "El Servidor Presenta Errores, Vuelve a intentarlo mas tarde.", "Error de Servidor" );
				else if ( query.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "El Recurso no existe", "Recurso no Encontrado" );

				return JsonConvert.DeserializeObject<tPersonal>( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this._msgExceptionPersonal = e.Message;
				return null;
			}
		}

        #endregion
    }
}
