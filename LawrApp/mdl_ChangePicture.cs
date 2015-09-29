using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Customs
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Access;

namespace LawrApp
{
	public partial class mdl_ChangePicture : MetroForm
	{
		private Login _lg = new Login();
		private bool _inAction = false;
		private string _source = "";

		private Thread _hilo;

		public mdl_ChangePicture()
		{
			InitializeComponent();
		}

		void SubmitChangePicture()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._lg.SendChangePicture(this._source) )
			{
				pgsLoading.Visible = false;
				MetroMessageBox.Show(
					this,
					"La foto de perfil ha sido modificada, los cambios harán efecto en el proximo inicio de sesión",
					"Correcto",
					MessageBoxButtons.OK, 
					MessageBoxIcon.Question
				);

				panelMain.Enabled = true;

				this._source = string.Empty;
				this.btnCambiar.Enabled = false;
				this.lblSource.Text = this._lg.getAppSettings( "UserPictureUrl" );
			}
			else
			{
				pgsLoading.Visible = false;
				MetroMessageBox.Show(this, this._lg.MsgExceptionLogin, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void LoadPicture()
		{
			this.OpenFile.Filter = "Images | *.jpg; *.png; *.jpeg";

			DialogResult result = this.OpenFile.ShowDialog();

			if ( result == DialogResult.OK )
			{
				string src = this.OpenFile.FileName;

				System.IO.FileInfo info = new System.IO.FileInfo( src );

				if ( ( info.Length / 1048576 ) < 1.5 )
				{
					this.ptbPicture.Load( src );
					this.lblSource.Text = src;
					this._source = src;
					this.btnCambiar.Enabled = true;
					this.btnSalir.Enabled = true;
				}
				else
				{
					MetroMessageBox.Show( this, "El Tamaño maximo para una imagen es de 1.5MB.", "LA imagen a superado el tamaño Maximo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				}
			}
		}

		private void ptbPicture_Click( object sender, EventArgs e )
		{
			this.LoadPicture();
		}

		private void mdl_ChangePicture_Load( object sender, EventArgs e )
		{
			this.ptbPicture.ImageLocation = this._lg.getAppSettings( "UserPictureUrl" );
			this.lblSource.Text = this._lg.getAppSettings( "UserPictureUrl" );
		}

		private void btnCambiar_Click( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this._source ) ) return;

			this._hilo = new Thread( new ThreadStart( this.SubmitChangePicture ) );

			this.pgsLoading.Visible = true;
			this.panelMain.Enabled = false;
			this._inAction = true;

			this._hilo.Start();
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void mdl_ChangePicture_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}
	}
}
