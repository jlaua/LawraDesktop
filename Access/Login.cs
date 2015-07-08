using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//agregados
using Options;
using Objects.Processes.Response;
using Objects.Processes;
using Newtonsoft.Json;
using System.Net;

namespace Access
{

    public class Login : Connection
    {
        private string _msgExceptionLogin, _InputName, _InputPass, _UserFullName, _UserType, _LocationImage;
		private int _yearActive;
        private string _Controller = "api/prslog";

        #region PROPIEDADES

        public string MsgExceptionLogin
        {
            get { return this._msgExceptionLogin; }
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

        public string UserFullName
        {
            get { return this._UserFullName; }
        }

        public string UserType
        {
            get { return this._UserType; }
        }

        public string LocationImage
        {
            get { return this._LocationImage; }
        }

		public int YearActive
		{
			get { return this._yearActive; }
			set { this._yearActive = value; }
		}

        #endregion

        #region CONSTRUCTOR

        public Login()
        {
            this._UserFullName      = this.getAppSettings( "UserName" );
            this._UserType          = this.getAppSettings( "UserType" );
            this._LocationImage     = this.getAppSettings( "UserPictureUrl" );
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
            OpSendLogin objSend		= new OpSendLogin();
			Query Oquery			= new Query( this._Controller );

            try
            {
                objSend.UserNick = this._InputName;
                objSend.UserPass = this._InputPass;

                Oquery.RequestParameters = objSend;

                Oquery.SendRequestPOST();

                OpLogin obj = JsonConvert.DeserializeObject<OpLogin>( Oquery.ResponseContent );

                if( Oquery.ResponseStatusCode == HttpStatusCode.OK )
                {
                    this.setAppSettings( "UserName", obj.data.FullName );
                    this.setAppSettings( "UserType", obj.data.TypeUser );
                    this.setAppSettings( "UserPictureUrl", this.ConfigBaseUrl + obj.data.ImagePath );

                    this.AuthToken = Oquery.ResponseHeader[0].Value.ToString();

                    this._UserFullName  = obj.data.FullName;
                    this._UserType      = obj.data.TypeUser;
                    this._LocationImage = this.ConfigBaseUrl + obj.data.ImagePath;
                }
                else
                {
                    throw new Exception( obj.msg );
                }

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
            var parameters = new Dictionary<string, string>();
            Query Oquery = new Query( this._Controller );

            OpLogin objlogin = new OpLogin();
            OpLoginData objdata = new OpLoginData();

            objlogin.msg = "Soy un mensaje";

            objdata.FullName = "soy un fullname";
            objdata.ImagePath = "soy un imagepath";
            objdata.TypeUser = "soy un tpo de usuario";

            objlogin.data = objdata;

            Oquery.RequestParameters = objlogin;

            try
            {

                Oquery.SendRequestPUT("0");

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

        #endregion

    }

}
