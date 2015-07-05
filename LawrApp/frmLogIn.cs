using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

using Access;
using System.Threading;

namespace LawrApp
{
    public partial class frmLogIn : MetroForm
    {
        private Thread  tr;
        public Login classLog = new Login();
        private DataGeneral _data;

        public frmLogIn( DataGeneral dts )
        {
            this._data = dts;
            InitializeComponent();
        }

        #region THREAD´S

        public void sendDataLogin()
        {
            CheckForIllegalCrossThreadCalls = false;

            if ( this.classLog.SendLogin() )
            {
                this.panelDatos.Enabled = false;
                this.pgsload.Visible = false;
                this.btnacceder.Enabled = false;
                MetroMessageBox.Show( this, 
                    "\n" + this.classLog.UserFullName + "\n\nPulsa OK para continuar...", 
                    "Bienvenido!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Question );

                this.Close();
            }
            else
            {
                this.panelDatos.Enabled = true;
                this.pgsload.Visible = false;
                this.btnacceder.Enabled = true;

                MetroMessageBox.Show( this, this.classLog.MsgExceptionLogin, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error );

            }
        }

        #endregion

        #region EVENTOS

        private void btnacceder_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrWhiteSpace( txtpassword.Text ) && string.IsNullOrWhiteSpace( txtuser_nick.Text ) )
                return;//no avanzar si las cajas de texto estan avacias

            this.tr = new Thread( new ThreadStart( this.sendDataLogin ) );

            classLog.InputName = this.txtuser_nick.Text;
            classLog.InputPass = this.txtpassword.Text;

            this.txtpassword.Clear();
            this.panelDatos.Enabled = false;
            this.pgsload.Visible = true;
            this.btnacceder.Enabled = false;

            this.tr.Start();

            this.txtpassword.Focus();

        }

        private void frmLogIn_FormClosing( object sender, FormClosingEventArgs e )
        {
            frmMain main = new frmMain( _data );
            main.Show();
        }

        #endregion

    }
}
