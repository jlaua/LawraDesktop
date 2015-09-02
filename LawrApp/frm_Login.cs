using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Access;

namespace LawrApp
{
	public partial class frm_Login : MetroForm
	{
		private DataGeneral _data;
		private Login _lg = new Login();
		private ConfigServer _cf = new ConfigServer();

		private bool isLogged = false;
		private bool _inAction = false;
		private bool _needPassword = false;
		private bool _notContinue = true; //Cuando Cierras el login pero sigues logeo, se debe cerrar toda la aplicacion
		private Thread _hilo;

		private delegate void ReturnFocus( TextBox Control );
		private delegate void ErrorConfirmLogged( int CodigoError );

		public frm_Login( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();

			bool rememberme = Convert.ToBoolean( this._lg.getAppSettings( "Remember_me" ) );

			if ( ! rememberme )
			{
				this._cf.RemembermeOf();
			}

			if ( string.IsNullOrEmpty( this._lg.getAppSettings( "Auth-Token" ) ) )
			{
				this.panelLogin.Enabled = true;
				this.panelAcceder.Enabled = false;
				this.spcPaneles.Panel1Collapsed = false;
				this.spcPaneles.Panel2Collapsed = true;
				this.panelMain.Enabled = true;
				this.AcceptButton = this.btnIngresar;
				this.isLogged = false;
				this.tgRemenber1.Checked = Convert.ToBoolean( this._lg.getAppSettings( "Remember_me" ) );
			}
			else
			{
				this.panelLogin.Enabled = false;
				this.panelAcceder.Enabled = true;

				this.panelInputPassword2.Visible = false;
				this.metroLabel2.Visible = false;
				this.tgRemenber2.Visible = false;

				this.ptbImagePorfile.Location = new Point( 129, 60 );
				this.lblFullName.Location = new Point( 50, 211 );
				this.lblCargo.Location = new Point( 6, 239 );
				this.btnContinuar.Location = new Point( 145, 310 );
				this.btnCambiar.Location = new Point( 72, 310 );
				this.spcPaneles.Panel1Collapsed = true;
				this.spcPaneles.Panel2Collapsed = false;

				string src = this._lg.getAppSettings( "UserPictureUrl" );

				if ( !string.IsNullOrEmpty(src) )
				{
					this.ptbImagePorfile.ImageLocation = src;
				}
				else
				{
					this.ptbImagePorfile.Image = LawrApp.Properties.Resources.user_tie_grey;
				}

				this.lblFullName.Text = this._lg.getAppSettings( "UserName" );
				this.lblCargo.Text = this._lg.getAppSettings( "UserType" );
				this.tgRemenber2.Checked = Convert.ToBoolean( this._lg.getAppSettings( "Remember_me" ) );
				this.AcceptButton = this.btnContinuar;
				this.isLogged = true;
				this.panelMain.Enabled = true;
			}
		}

		#region THREAD'S

		private void ConfirmLogged()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._lg.ConfirmLogged() )
			{
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
			}
			else
			{
				this.pgsLoading.Visible = false;
				string[] msg = this._lg.MsgExceptionLogin.Split( '-' );
				
				MetroMessageBox.Show( this, msg[0], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.ChangeDesignErrorConfirmLogged( Convert.ToInt32( msg[1] ) );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		public void sendDataLogin()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( this._lg.SendLogin() )
			{
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
				this.panelLogin.Enabled = true;
				this._inAction = false;
				this._notContinue = false;
				this.Close();
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lg.MsgExceptionLogin, "Hay un Problema", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this.ReturnFocusToInput( this.txtPassword1 );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ReturnFocusToInput( TextBox txt )
		{
			if ( ! this.InvokeRequired )
			{
				txt.Clear();
				txt.Focus();
			}
			else
			{
				ReturnFocus rf = new ReturnFocus( ReturnFocusToInput );
				this.Invoke( rf, new object[] { txt } );
			}
		}

		void MovedControls( TextBox txt )
		{
			if ( ! this.InvokeRequired )
			{
				this.panelInputPassword2.Visible = false;
				this.metroLabel2.Visible = false;
				this.tgRemenber2.Visible = false;

				this.ptbImagePorfile.Location = new Point( 129, 60 );
				this.lblFullName.Location = new Point( 50, 211 );
				this.lblCargo.Location = new Point( 6, 239 );
				this.btnContinuar.Location = new Point( 145, 310 );
				this.btnCambiar.Location = new Point( 72, 310 );
			}
			else
			{
				ReturnFocus rf = new ReturnFocus( MovedControls );
				this.Invoke( rf, new object[] { txt } );
			}
		}

		public void ChangeDesignErrorConfirmLogged( int CodigoError )
		{
			if ( ! this.InvokeRequired )
			{
				if ( CodigoError == 1 )
				{
					this.spcPaneles.Panel1Collapsed = false;
					this.spcPaneles.Panel2Collapsed = true;
					this._cf.RemembermeOf();
					this.panelAcceder.Enabled = false;
					this.panelLogin.Enabled = true;
					this.AcceptButton = this.btnIngresar;
					this._needPassword = false;
					this.txtUser1.Focus();
				}
				else
				{
					this.spcPaneles.Panel1Collapsed = true;
					this.spcPaneles.Panel2Collapsed = false;
					this.panelAcceder.Enabled = true;
					this.panelLogin.Enabled = false;
					this.AcceptButton = this.btnContinuar;
					this._needPassword = true;
					this.txtPassword2.Focus();
				}
			}
			else
			{
				ErrorConfirmLogged log = new ErrorConfirmLogged( ChangeDesignErrorConfirmLogged );
				this.Invoke( log, new object[] { CodigoError } );
			}
		}

		#endregion

		private void frm_Login_Load( object sender, EventArgs e )
		{
			if ( this.isLogged )
			{
				this._hilo = new Thread( new ThreadStart( this.ConfirmLogged ) );

				this._inAction = true;
				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
			else
			{
				this.txtUser1.Focus();
				this.txtUser1.Select();
			}
		}

		private void btnCambiar_Click( object sender, EventArgs e )
		{
			this.panelAcceder.Enabled = false;
			this.spcPaneles.Panel1Collapsed = false;
			this.spcPaneles.Panel2Collapsed = true;
			this.panelLogin.Enabled = true;
			this.AcceptButton = this.btnIngresar;
			this.txtUser1.Focus();
		}

		private void btnIngresar_Click( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( txtUser1.Text ) || string.IsNullOrWhiteSpace( txtPassword1.Text ) )
			{
				this.txtUser1.Focus();
				return;
			}

			this._hilo = new Thread( new ThreadStart( this.sendDataLogin ) );

			this._lg.InputName = this.txtUser1.Text.Trim();
			this._lg.InputPass = this.txtPassword1.Text.Trim();
			this._lg.RememberMe = this.tgRemenber1.Checked;

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._hilo.Start();
		}

		private void btnContinuar_Click( object sender, EventArgs e )
		{
			if ( ! this._needPassword )
			{
				this._inAction = false;
				this._notContinue = false;
				this._lg.AccessLevel = Convert.ToInt32( this._lg.getAppSettings( "UserLevel" ) );
				this.Close();
			}
			else
			{

			}
		}

		private void frm_Login_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
			else if ( ! this._notContinue )
			{
				switch( this._lg.AccessLevel )
				{
					case 0:
						frm_Configuration conf = new frm_Configuration( this._data );
						conf.Show();
						break;
					case 1:
						frm_Director dir = new frm_Director( this._data );
						dir.Show();
						break;
					case 2:
						frm_Personal per = new frm_Personal( this._data );
						per.Show();
						break;
				}
			}
		}
	}
}
