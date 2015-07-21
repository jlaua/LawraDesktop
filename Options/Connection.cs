using Options.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;

namespace Options
{
    public class Connection : Config
    {
        private string _BaseUrl, 
                        _token;

        #region PROPIEDADES

        public string ConfigBaseUrl 
        { 
            get { return this._BaseUrl; }
            set
            {
                this.setAppSettings( "BaseUrl", value );
                this._BaseUrl = value;
            }
        }

        protected string AuthToken 
        { 
            get { return this._token; }
            set
            {
                this.setAppSettings( "Auth-Token", value );
                this._token = value;
            }
        }

        #endregion

        #region CONSTRUCCION

        /// <summary>
        /// Constructor que obtiene la la información de la url base para costruir las consultas
        /// </summary>
        protected Connection()
        {
            this._BaseUrl = this.getAppSettings( "BaseUrl" );
            this._token = this.getAppSettings( "Auth-Token" );
        }

        #endregion

        #region METODOS


        protected bool ExistAuthToken()
        {
            if ( string.IsNullOrEmpty( this.getAppSettings( "Auth-Token" ) ) )
                return true;
            else
                return false;
        }


        /// <summary>
        /// Metodo que nos permite verificar si es que el servidor que hemos configurado, está funcionando.
        /// </summary>
        /// <returns>Devueve TRUE cuando existe conexión con el servidor.</returns>
        protected bool ServerStatus()
        {
            return true;
        }

        #endregion

    }
}
