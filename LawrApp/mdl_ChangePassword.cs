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
using Objects.Processes;
using System.Threading;
using Access;

namespace LawrApp
{
	public partial class mdl_ChangePassword : MetroForm
	{
		private Login _lg = new Login();
		private ChangePassword _change = new ChangePassword();
		private bool _inAction = false;

		private Thread _hilo;

		public mdl_ChangePassword()
		{
			InitializeComponent();
		}

		private void Submit_ChangePassword()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._lg.SendChangePassword( this._change ) )
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, "SE CONSIGUIO MODIFICAR LA CONTRASEÑA", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );
				
				this.txtOldPassword.Clear();
				this.txtNewPassword.Clear();
				this.txtConfirmPassword.Clear();

				this.lblOldPassword_validator.Visible = true;
				this.lblNewPassword_Validator.Visible = true;
				this.lblConfirmPassword_Validator.Visible = true;

				this.panelMain.Enabled = true;
				this.Invoke( ( MethodInvoker ) delegate
				{
					this.txtOldPassword.Focus();
				});
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lg.MsgExceptionLogin, "Error Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		private bool ConfirmControls()
		{
			if ( string.IsNullOrWhiteSpace( this.txtOldPassword.Text ) )
			{
				this.ttValidator.Show( "Este campo es requerido", this.txtOldPassword, 2500 );
				this.txtOldPassword.Focus();
				return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtNewPassword.Text ) )
			{
				this.ttValidator.Show( "Este campo es requerido", this.txtNewPassword, 2500 );
				this.txtNewPassword.Focus();
				return false;
			}

			if ( ! string.Equals( this.txtNewPassword.Text.Trim(), this.txtConfirmPassword.Text.Trim() ) )
			{
				this.ttValidator.Show( "Debe Coincidir a la nueva contraseña", this.txtConfirmPassword, 2500 );
				this.txtConfirmPassword.Clear();
				this.txtConfirmPassword.Focus();
				return false;
			}

			return true;
		}

		private void TextBox_Leave( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;

			switch( txt.Name )
			{
				case "txtOldPassword":
					this.lblOldPassword_validator.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
					break;
				case "txtNewPassword":
					this.lblNewPassword_Validator.Visible = ( ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false );
					break;
				case "txtConfirmPassword":
					if ( ! string.IsNullOrWhiteSpace( txt.Text ) )
					{
						if ( ! string.Equals( txt.Text, this.txtNewPassword.Text ) )
						{
							this.lblConfirmPassword_Validator.Visible = true;
							ttValidator.Show( "Debe Coincidir a la nueva contraseña", this.lblConfirmPassword_Validator, 3000 );
						}
						else
						{
							this.lblConfirmPassword_Validator.Visible = false;
						}
					}
					else
					{
						this.lblConfirmPassword_Validator.Visible = true;
					}
					break;
			}
		}

		private void btnCambiar_Click( object sender, EventArgs e )
		{
			if ( !this.ConfirmControls() ) return;

			this._hilo = new Thread( new ThreadStart( this.Submit_ChangePassword ) );

			this._change.OldPassword = this.txtOldPassword.Text.Trim();
			this._change.NewPassword = this.txtNewPassword.Text.Trim();
			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._hilo.Start();
		}

		private void mdl_ChangePassword_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

	}
}
