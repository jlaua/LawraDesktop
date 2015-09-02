using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

using Options;

namespace Access
{
	public class ConfigServer : Connection
	{
		private string _msgException;

		public string msgExceptionConfigServer
		{
			get { return this._msgException; }
		}

		/// <summary>
		/// Obtiene o Establece la URL base para la Conexión con la Web Service.
		/// </summary>
		public string BaseUrl
		{
			get { return this.ConfigBaseUrl; }
			set { this.ConfigBaseUrl = value; }
		}

		/// <summary>
		/// Metodo que nos permite saber si es que existe conexion a internet.
		/// </summary>
		/// <returns>Devuelve TRUE cuando detacta conexión ha internet</returns>
		public bool VerifyConnections( string strURL )
		{
			try
			{
				Ping Pings = new Ping();
				string url = ( strURL.Replace( "http://", "" ) ).Replace( "https://", "" ).Replace( "/", "" );
				int timeout = 1000;

				if ( string.IsNullOrEmpty( url ) )
					throw new ArgumentNullException( "No es una Url", "URL" );

				if ( Pings.Send( url, timeout ).Status == IPStatus.Success )
					return true;

				return false;
			}
			catch ( Exception e )
			{
				this._msgException = e.Message;
				return false;
			}
		}

		public bool VerifyApplication( string strUrl )
		{
			strUrl = (strUrl.Substring( ( strUrl.Length - 1 ), 1 ) != "/") ? strUrl + "/" : strUrl;

			Query query = new Query( "api", strUrl );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.Accepted )
					throw new ArgumentNullException( "Existen errores en el servidor", "Errores en Servidor" );

				return true;

			}
			catch ( Exception e )
			{
				this._msgException = e.Message;
				return false;
			}
		}

		public void RemembermeOf()
		{
			this.setAppSettings( "InstitutionCode", "" );
			this.setAppSettings( "InstitutionName", "" );
			this.setAppSettings( "InstitutionLogo", "" );
			this.setAppSettings( "BranchCode", "" );
			this.setAppSettings( "BranchAddress", "" );
			this.setAppSettings( "YearAcademy", "" );
			this.setAppSettings( "Auth-Token", "" );
			this.setAppSettings( "UserName", "" );
			this.setAppSettings( "UserType", "" );
			this.setAppSettings( "UserLevel", "" );
			this.setAppSettings( "UserPictureUrl", "" );
			this.setAppSettings( "remember_me", "false" );
		}

	}
}
