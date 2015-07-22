using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using RestSharp.Deserializers;
using System.Net;
using System.IO;

namespace Options
{
    public class Query : Connection
    {

        private string _msgQueryException, 
                        _ResponseContent, 
                        _FullURL,
                        _RequestFormat;

        private HttpStatusCode _StatusCode;
        private IList<RestSharp.Parameter> _Header;

        private object _RequestParameters;
		private Dictionary<string, string> _requestFiles = new Dictionary<string,string>();
        private RestClient Client;
        private RestRequest Request;

        #region PROPIEDADES

        public string FullURL
        {
            get { return this._FullURL; }
        }

        public string MsgExceptionQuery 
        { 
            get { return this._msgQueryException; } 
        }

        public string ResponseContent 
        { 
            get { return this._ResponseContent; } 
        }

        public HttpStatusCode ResponseStatusCode 
        { 
            get { return this._StatusCode; } 
        }

        public IList<RestSharp.Parameter> ResponseHeader 
        { 
            get { return this._Header; } 
        }

        public string RequestFormat
        {
            set
            {
                if( value.ToLower() == "xml" )
                {
                    this.Client.ClearHandlers();
                    this.Client.AddHandler( "application/xml", new XmlDeserializer() );
                    this.Request.RequestFormat = DataFormat.Xml;
                    this._RequestFormat = value.ToLower();
                }
            }
        }

		public Dictionary<string, string> RequestFiles
		{
			get { return this._requestFiles; }
			set { this._requestFiles = value; }
		}

        public object RequestParameters
        {
            set
            {
                if ( value != null )
                {
					this.Request.AddParameter( "data", this.Request.JsonSerializer.Serialize( value ) );
                    this._RequestParameters = value;
                }
            }
        }

        #endregion


        #region CONSTRUCTOR

        public Query( string Controller, string BaseURL = null )
        {
            this._FullURL = ( string.IsNullOrEmpty( BaseURL ) ? this.ConfigBaseUrl : BaseURL ) + Controller;

            this.Client = new RestClient( string.IsNullOrEmpty( BaseURL ) ? this.ConfigBaseUrl : BaseURL );
            this.Request = new RestRequest( Controller );

			this.Client.ClearHandlers();
			this.Client.UserAgent = "API From Windows Desktop Cliente";

			this.Client.AddHandler( "application/json", new JsonDeserializer() );

			this.Request.RequestFormat = DataFormat.Json;
            this.Request.AddHeader( "Auth-Token", this.AuthToken );
			this.Request.AddHeader( "YearAcademy", this.getAppSettings("YearAcademy") );

			this.Request.AlwaysMultipartFormData = true;
        }

        #endregion


        #region METODOS


        public void AddRequestHeader( string Name, string Value )
        {
            if( ! string.IsNullOrEmpty(Name) )
            {
                this.Request.AddHeader(Name, Value);
            }
        }

        public void AddRequestFiles( Dictionary<string, string> Files )
        {
            if ( Files != null )
            {
                foreach ( KeyValuePair<string,string> Item in Files )
                {
					string[] extends = Item.Value.Split( '.' );
					string mime = extends[extends.Length - 1] == "jpg" ? "jpeg" : extends[extends.Length - 1];
					this.Request.AddFile( Item.Key, Item.Value, "image/" + mime );
                }
            }
        }

        private void SendRequest()
        {
            RestResponse response = (RestResponse) this.Client.Execute( this.Request );

            this._ResponseContent	= response.Content;
            this._Header			= response.Headers;
            this._StatusCode		= response.StatusCode;
        }


        //PETICIONES CON SUS METODOS
        public bool SendRequestPOST()
        {

            this.Request.Method = Method.POST;

            try
            {
                if ( this._RequestParameters == null )
                    throw new ArgumentNullException("Para este metodo se necesita minimo un parametro", "RequestParameters");

                this.SendRequest();

                return true;
            }
            catch( Exception e )
            {
                this._msgQueryException = e.Message;

                return false;
            }
            
        }



        /// <summary>
        /// Ejecuta una petición de tipo GET al servidor
        /// </summary>
        /// <param name="ID">Cadena de parametros que sera agregada a la URL</param>
        /// <returns>Confirmación de la Petición</returns>
        public bool SendRequestGET( string ID = null )
        {
            if ( ! string.IsNullOrEmpty( ID ) )
                this.Client.AddDefaultUrlSegment( this._FullURL, ID );
            
            this.Request.Method = Method.GET;
            
            try
            {
                this.SendRequest();

                return true;
            }
            catch( Exception e )
            {
                this._msgQueryException = e.Message;
                return false;
            }
        }



        /// <summary>
        /// Ejecuta una petición de tipo PUT al servidor
        /// </summary>
        /// <param name="ID">Codigo de la fila que será modifica.</param>
        /// <param name="parameters">Colección de Parametros que serán enviados junto a la petición</param>
        /// <param name="Files">Colección de Archivos que serán enviados junto a la petición</param>
        /// <returns>Confirmación de la Petición</returns>
        public bool SendRequestPUT()
        {
			this.Request.AddParameter( "_method", "put" );
			
			if ( !this._requestFiles.Any() )
				this.Request.AlwaysMultipartFormData = false;

            this.Request.Method = Method.POST;

			try
            {
                if ( this._RequestParameters == null )
                    throw new ArgumentNullException( "Para este metodo se necesita minimo un parametro", "RequestParameters" );

                this.SendRequest();

                return true;
            }
            catch ( Exception e )
            {
                this._msgQueryException = e.Message;

                return false;
            }

        }



        /// <summary>
        /// Ejecuta una petición de tipo DELETE al servidor
        /// </summary>
        /// <param name="ID">ID del Elemento que desea Eliminar</param>
        /// <returns>Confirmación de la Petición</returns>
        public bool SendRequestDELETE()
        {
            try
			{
				this.Request.Method = Method.DELETE;
				this.SendRequest();
                return true;
            }
            catch ( Exception e )
            {
                this._msgQueryException = e.Message;
                return false;
            }

        }

        #endregion

    }
}
