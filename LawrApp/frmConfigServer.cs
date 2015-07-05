using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using Access;
using System.Threading;

namespace LawrApp
{
	public partial class frmConfigServer : MetroForm
	{
		private ConfigServer config = new ConfigServer();
		private Thread _hilo;

		public frmConfigServer()
		{
			InitializeComponent();
		}

		void ContactApp()
		{
			CheckForIllegalCrossThreadCalls = false;

			lblmensaje.ForeColor = MetroColors.Black;
			lblmensaje.Text = "Verificando Conexión...";

			if ( this.config.VerifyConnections( this.txtURL.Text.Trim() ) )
			{
				lblmensaje.Text = "Comprobando Aplicación...";
				if ( this.config.VerifyApplication( this.txtURL.Text.Trim() ) )
				{
					lblmensaje.Text = "La Conexión Fue Exitosa!, Cambiando de Servidor...";
					lblmensaje.ForeColor = MetroColors.Green;

					string strUrl	= this.txtURL.Text.Trim();
					strUrl			= ( strUrl.Substring( ( strUrl.Length - 1 ), 1 ) != "/" ) ? strUrl + "/" : strUrl;
					
					this.config.BaseUrl = strUrl;

					this.ServerChange();
					this.Close();
				}
				else
				{
					lblmensaje.Text = "No se encontró nuestra APP";
					lblmensaje.ForeColor = MetroColors.Red;
				}
			}
			else
			{
				lblmensaje.Text = "No hay Conexión con el Servidor";
				lblmensaje.ForeColor = MetroColors.Red;
			}

			this.psLoad.Visible = false;
			this.btnAplicar.Enabled = true;

		}

		private void ServerChange()
		{
			LawrApp.IFrmMain IMain = this.Owner as IFrmMain;

			if ( IMain != null )
			{
				IMain.ReloadData( true );
				this.Close();
			}
		}

		private void server_Load( object sender, EventArgs e )
		{
			this.txtURL.Text = this.config.BaseUrl;
			this.txtURL.Focus();
			lblmensaje.Text = this.Owner.Name;
		}

		private void btnAplicar_Click( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.ContactApp ) );
			
			this.btnAplicar.Enabled = false;
			this.psLoad.Visible = true;

			this._hilo.Start();

			//this.con.ConfigBaseUrl = this.txtURL.Text;
			//this.ServerChange();
		}
	}
}
