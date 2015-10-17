using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//agregados
using Options;
using Objects.Processes;
using Newtonsoft.Json;
using System.Net;

namespace Access
{

    public class Login : Connection
    {
        private string _msgExceptionLogin, _InputName, _InputPass;
        private string _Controller = "api/prslog";
		private int _accessLevel;
		private bool _inputRememberMe;

        #region PROPIEDADES

        public string MsgExceptionLogin
        {
            get { return this._msgExceptionLogin; }
        }

		public bool RememberMe
		{
			get { return this._inputRememberMe; }
			set { this._inputRememberMe = value; }
		}

        public string InputName
        {
            get { return this._InputName; }
            set { this._InputName = value; }
        }

        public string InputPass
        {
            get { return this._InputPass; }
            set { this._InputPass = value; }
        }

		public int AccessLevel
		{
			get { return this._accessLevel; }
			set { this._accessLevel = value; }
		}

        #endregion

        #region METODOS

        public bool TokenIsRegistered()
        {
            string token = this.AuthToken;

            if ( string.IsNullOrEmpty( token ) )
                return false;
            else
                return true;
        }

        public bool SendLogin()
        {
            RequestLogin objSend	= new RequestLogin();
			Query oQuery			= new Query( this._Controller );

            try
            {
                objSend.UserNick = this._InputName;
                objSend.UserPass = this._InputPass;

                oQuery.RequestParameters = objSend;

                oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionLogin, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				LoginData obj = JsonConvert.DeserializeObject<LoginData>( resp.data );

				if ( obj.UserLevel != "0" && obj.UserLevel != "1" && obj.UserLevel != "2" )
					throw new InvalidOperationException( "TU NIVEL DE ACCESO NO ESTA PERMITIDO PARA ESTE SISTEMA" );

				this.setAppSettings( "User", this.InputName );
				this.setAppSettings( "UserName", obj.FullName );
				this.setAppSettings( "UserType", obj.UserType );
				this.setAppSettings( "UserLevel", obj.UserLevel );
				this.setAppSettings( "UserPictureUrl", this.ConfigBaseUrl + obj.ImagePath );

				this.setAppSettings( "InstitutionName", obj.Institution.NameInstitution );
				this.setAppSettings( "InstitutionLogo", obj.Institution.LogoInstitution );
				this.setAppSettings( "BranchCode", obj.Institution.BranchCode.ToString() );
				this.setAppSettings( "BranchAddress", obj.Institution.BranchAddress );
				this.setAppSettings( "Remember_me", this.RememberMe.ToString() );

				this.AuthToken = obj.Token;
				this.AccessLevel = Convert.ToInt32( obj.UserLevel );

                return true;
            }
            catch(Exception e)
            {
                this._msgExceptionLogin = e.Message;
                return false;
            }
        }

        public bool SendLogOut()
        {
            Query Oquery = new Query( this._Controller );

            try
            {

                Oquery.SendRequestPUT();

                if ( Oquery.ResponseStatusCode == HttpStatusCode.Accepted )
                {
                    this.setAppSettings( "UserName", "" );
                    this.setAppSettings( "UserType", "" );
                    this.setAppSettings( "UserPictureUrl", "" );
                    this.AuthToken =  "";
                }

                return true;
            }
            catch ( Exception e )
            {
                this._msgExceptionLogin = e.Message;
                return false;
            }
        }

		public bool ConfirmLogged()
		{
			Query oQuery = new Query( "api/prslog/confirm" );

			try
			{
				object arq = new object[2] { this.getAppSettings( "User" ), 1 };

				oQuery.RequestParameters = arq;

				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionLogin, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				LoginData obj = JsonConvert.DeserializeObject<LoginData>( resp.data );

				if ( obj.UserLevel != "0" && obj.UserLevel != "1" && obj.UserLevel != "2" )
					throw new InvalidOperationException( "TU NIVEL DE ACCESO NO ESTA PERMITIDO PARA ESTE SISTEMA" );

				this.setAppSettings( "UserName", obj.FullName );
				this.setAppSettings( "UserType", obj.UserType );
				this.setAppSettings( "UserLevel", obj.UserLevel );
				this.setAppSettings( "UserPictureUrl", ( ! string.IsNullOrEmpty(obj.ImagePath) ) ? this.ConfigBaseUrl + obj.ImagePath : "" );

				this.setAppSettings( "InstitutionName", obj.Institution.NameInstitution );
				this.setAppSettings( "InstitutionLogo", obj.Institution.LogoInstitution );
				this.setAppSettings( "BranchCode", obj.Institution.BranchCode.ToString() );
				this.setAppSettings( "BranchAddress", obj.Institution.BranchAddress );
				this.setAppSettings( "Remember_me", "true" );

				this.AuthToken = obj.Token;
				this.AccessLevel = Convert.ToInt32( obj.UserLevel );

				return true;

			}
			catch ( Exception e )
			{
				this._msgExceptionLogin = e.Message;
				return false;
			}
		}

		public bool SendChangePassword( ChangePassword change )
		{
			Query oQuery = new Query( this._Controller + "/change_password" );

			try
			{
				change.UserNick = this.getAppSettings("User");
				oQuery.RequestParameters = change;
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionLogin, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception e )
			{
				this._msgExceptionLogin = e.Message;
				return false;
			}
		}

		public bool SendChangePicture( string Source )
		{
			Query oQuery = new Query( this._Controller + "/change_picture/" );
			Dictionary<string, string> file = new Dictionary<string, string>();
			object obj = new object();

			obj = new object[2]{this.getAppSettings( "User" ), 1};
			
			try
			{
				file.Add( "Picture", Source );
				
				oQuery.AddRequestFiles(file);
				oQuery.RequestParameters = obj;

				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this._msgExceptionLogin, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				this.setAppSettings( "UserPictureUrl", Convert.ToString(resp.data) );

				return true;
			}
			catch ( Exception e )
			{
				this._msgExceptionLogin = e.Message;
				return false;
			}
		}

        #endregion

    }

}
