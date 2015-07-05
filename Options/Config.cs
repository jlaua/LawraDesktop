using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace Options.App
{
    public class Config
    {
        private string _msgException;

        protected string MsgException
        {
            get { return this._msgException; }
        }

        protected bool setAppSettings( string key, string Value = "" )
        {
            try
            {
                Configuration conf = ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.None );

                if( string.IsNullOrEmpty(key) )
                    throw new System.ArgumentNullException( "El parametro no puede ser nulo", "key" );

                conf.AppSettings.Settings[key].Value = Value;

                conf.Save( ConfigurationSaveMode.Modified );

                ConfigurationManager.RefreshSection( "appSettings" );

                return true;

            }
            catch( Exception e )
            {
                this._msgException = e.Message;
                return false;
            }
        }

        protected string getAppSettings( string key )
        {
            try
            {
                Configuration conf = ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.None );

                if ( string.IsNullOrEmpty( key ) )
                    throw new System.ArgumentNullException( "El parametro no puede ser nulo", "key" );

                ConfigurationManager.RefreshSection( "appSettings" );

                return ConfigurationManager.AppSettings[key];

            }
            catch ( Exception e )
            {
                this._msgException = e.Message;
                return null;
            }
        }



    }
}
