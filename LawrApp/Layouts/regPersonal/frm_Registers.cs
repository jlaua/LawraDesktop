using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Registers;
using Objects.Tables;
using Objects.Processes;
using Options;

namespace LawrApp.Layouts.regPersonal
{
	public partial class frm_Registers : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;
		private Personal _cPersonal = new Personal();

		private tPersonal _tPersonal = new tPersonal();
		private tPersonal _tPersonal_Old = new tPersonal();
		private tProfesiones _tProfesion = new tProfesiones();

		private bool _submitInsert = false;
		private bool _inputManual = false;

		public frm_Registers( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lPersonal> tempPersonal = this._cPersonal.List();

			if( tempPersonal != null )
			{
				foreach ( lPersonal item in tempPersonal )
				{
					object[] temp = new object[7]
					{
						item.Codigo,
						item.Key,
						item.Description,
						item.TipoPersonal,
						item.UserActive,
						item.Sucursal,
						item.ModifiedDate
					};

					this.dgvListado.Rows.Add( temp );
				}

				this.pgsLoading.Visible = false;
				panelMain.Enabled = true;
			}
			else
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.btnDesactivar.Enabled = false;
				this.txtSearch.Enabled = false;
				this.btnSearch.Enabled = false;
				this.pgsLoading.Visible = false;
			}

			this.panelMain.Enabled = true;
			this._hilo.Abort();
		}

		void SubmitInsert(  )
		{
			CheckForIllegalCrossThreadCalls = false;

			this._tPersonal = this._cPersonal.Insert();

			if ( this._tPersonal != null )
			{
				this._tPersonal_Old = this._tPersonal;
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
			}
			else
			{
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, "Error:\n" + this._cPersonal.ExceptionPersonal, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );

			}

			this._hilo.Abort();

		}

		#endregion

		#region METODOS

		void ResetControls()
		{
			//limpiar
			this.txtNombres.Clear();
			this.txtApellidos.Clear();
			this.txtN_Documento.Clear();
			this.txtEmail.Clear();
			this.txtTelefono.Clear();
			this.txtDireccion.Clear();
			this.lblSrcImage.Text = "";
			this.ptbImage.Image = null;
			this.dtpBirthday.Value = dtpBirthday.MaxDate;
			this.CboGenero.SelectedIndex = -1;
			this.CboGenero.Text = "Seleccione...";
			this.cboProfesion.SelectedIndex = -1;
			this.cboProfesion.Text = "";
			this.cboDocumento.SelectedIndex = -1;
			this.cboDocumento.Text = "Seleccione...";
			this.cboTipoPersonal.SelectedIndex = -1;
			this.cboTipoPersonal.Text = "Seleccione...";

			//regresar estados por defecto
			this.panelRegistros.Enabled = false;
			this.tabControl.SelectedTab = this.tabPageListado;
			this.btnNuevo.Enabled = true;
			
			if ( this.dgvListado.Rows.Count == 0 )
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.btnDesactivar.Enabled = false;
				this.txtSearch.Enabled = false;
				this.btnSearch.Enabled = false;
			}
			else
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
				this.btnDesactivar.Enabled = true;
				this.txtSearch.Enabled = true;
				this.btnSearch.Enabled = true;
			}
		}

		#endregion

		#region FUNCIONES

		private bool ValidateData()
		{
			// Nombres
			if ( string.IsNullOrWhiteSpace( this.txtNombres.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtNombres );
				this.txtNombres.Focus();
				return false;
			}

			// Apellidos
			if ( string.IsNullOrWhiteSpace( this.txtNombres.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtApellidos );
				this.txtApellidos.Focus();
				return false;
			}

			// Genero
			if ( this.CboGenero.SelectedIndex < 0 )
			{
				this.toltipMore.Show( "Seleccione una Opción", this.CboGenero );
				this.CboGenero.Focus();
				return false;
			}

			// Profesión
			if ( this._inputManual )
			{
				if ( string.IsNullOrWhiteSpace( this.cboProfesion.Text ) )
				{
					this.toltipMore.Show( "Si desea registrar una nueva profesión, Digite su nombre aquí o Escoja una de las Opciones", this.cboProfesion );
					this.cboProfesion.Focus();
					return false;
				}
			}
			else
			{
				if ( this.cboProfesion.SelectedValue == null )
				{
					this.toltipMore.Show( "Si desea registrar una nueva profesión, Digite su nombre aquí o Escoja una de las Opciones", this.cboProfesion );
					this.cboProfesion.Focus();
					return false;
				}
			}

			//Documento
			if ( this.cboDocumento.SelectedValue == null )
			{
				this.toltipMore.Show( "Seleccione una Opción", this.cboDocumento );
				this.cboDocumento.Focus();
				return false;
			}

			// N° de Documento
			if ( string.IsNullOrWhiteSpace( this.txtN_Documento.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtN_Documento );
				this.txtN_Documento.Focus();
				return false;
			}

			// Tipo de Personal
			if ( this.cboTipoPersonal.SelectedValue == null )
			{
				this.toltipMore.Show( "Seleccione una Opción", this.cboTipoPersonal );
				this.cboTipoPersonal.Focus();
				return false;
			}

			//Dirección
			if ( string.IsNullOrWhiteSpace( this.txtDireccion.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtDireccion );
				this.txtDireccion.Focus();
				return false;
			}

			return true;
		}

		#endregion

		private void frm_Registers_Load( object sender, EventArgs e )
		{
			this.tabControl.SelectedTab = this.tabPageListado;

			this._hilo = new Thread( new ThreadStart( LoadData ) );

			this.cboDocumento.ValueMember = "Codigo";
			this.cboDocumento.DisplayMember = "ShortName";
			this.cboDocumento.DataSource = this._data.Tables["TipoDocumento"];
			this.cboDocumento.SelectedIndex = -1;
			this.cboDocumento.Text = "Seleccione...";

			this.cboTipoPersonal.DisplayMember = "Name";
			this.cboTipoPersonal.ValueMember = "Codigo";
			this.cboTipoPersonal.DataSource = this._data.Tables["TipoPersonal"];
			this.cboTipoPersonal.SelectedIndex = -1;
			this.cboTipoPersonal.Text = "Seleccione...";

			this.cboProfesion.DisplayMember = "Name";
			this.cboProfesion.ValueMember = "Codigo";
			this.cboProfesion.DataSource = this._data.Tables["Profesion"];
			this.cboProfesion.SelectedIndex = -1;

			this.dtpBirthday.MaxDate = DateTime.Now.AddYears( -18 );
			this.dtpBirthday.MinDate = DateTime.Now.AddYears( -90 );

			this._hilo.Start();
		}

		private void frm_Registers_FormClosing( object sender, FormClosingEventArgs e )
		{
			frmMain main = new frmMain( this._data );
			main.Show();
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.panelRegistros.Enabled = true;
			this.btnNuevo.Enabled = false;
			this.tabControl.SelectedTab = this.tabPageRegistro;
			this._submitInsert = true;
			this.txtNombres.Focus();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this._submitInsert = false;
			this.ResetControls();
		}

		private void OnlyLetter_TextBox_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( ! char.IsLetter(e.KeyChar) && 
					(e.KeyChar != (char) Keys.Back) && 
					( e.KeyChar != (char) Keys.Left ) && 
					( e.KeyChar != (char) Keys.Right ) && 
					( e.KeyChar != (char) Keys.Space ) )
			{
				e.Handled = true;
				return;
			}
		}

		private void CboOnlyUpDown_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData != Keys.Up && e.KeyData != Keys.Down )
			{
				e.SuppressKeyPress = true;
			}
		}

		private void btnSearchImage_Click( object sender, EventArgs e )
		{
			this.openPerfilPicture.Filter = "Images | *.jpg; *.png; *.jpeg";
			
			DialogResult result = this.openPerfilPicture.ShowDialog();

			if ( result == DialogResult.OK )
			{
				string src = this.openPerfilPicture.FileName;

				System.IO.FileInfo info = new System.IO.FileInfo( src );

				if ( ( info.Length / 1048576 ) < 5 )
				{
					this.ptbImage.Load( src );
					this.lblSrcImage.Text = src;
					this.toltipMore.SetToolTip( this.lblSrcImage, src );
					this._tPersonal.ImageSrc = src;
					this._tPersonal.ImageKey = Helper.NameImageRandom( 10 );
				}
				else
					MetroMessageBox.Show( this, "El Tamaño maximo para una imagen es de 5MB.", "LA imagen a superado el tamaño Maximo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}

		private void AsignDataAndValidate_TextBox_Leave( object sender, EventArgs e )
		{
			TextBox txt = ( (TextBox) sender );

			switch( txt.Name )
			{
				case "txtNombres":
					this._tPersonal.Names = txt.Text.Trim();
				break;
				case "txtApellidos":
					this._tPersonal.LastNames = txt.Text.Trim();
				break;
				case "txtN_Documento":
					this._tPersonal.DocumentNumber = txt.Text.Trim();
				break;
				case "txtEmail":
				this._tPersonal.Email = txtEmail.Text.Trim();
				break;
				case "txtTelefono":
				this._tPersonal.Phone = txtTelefono.Text.Trim();
				break;
				case "txtDireccion":
				this._tPersonal.Address = txtDireccion.Text.Trim();
				break;
			}
		}

		private void AsignDataAndValidate_ComboBox_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			switch( cbo.Name )
			{
				case "cboGenero":
				this._tPersonal.Gender = ( ( cbo.SelectedIndex > 0 ) ? Convert.ToBoolean(cbo.SelectedIndex) : false );
				break;
				case "cboProfesion":
				if( this._inputManual )
				{
					this._tProfesion.Name = this.cboProfesion.Text;
				}
				else
				{
					this._tProfesion.Codigo = ( int ) ( ( cboProfesion.SelectedValue == null ) ? 0 : cboProfesion.SelectedValue );
				}
				break;
				case "cboDocumento":
				this._tPersonal.CodigoTipoDocumento = ( int ) ( ( cboDocumento.SelectedValue == null ) ? 0 : cboDocumento.SelectedValue );
				break;
				case "cboTipoPersonal":
				this._tPersonal.CodigoTipoPersonal = ( int ) ( (cboTipoPersonal.SelectedValue == null ) ? 0 : cboTipoPersonal.SelectedValue );
				break;
			}
		}

		private void dtpBirthday_Leave( object sender, EventArgs e )
		{
			this._tPersonal.Birthday = this.dtpBirthday.Value.ToString( "yyyy-MM-dd" );
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateData() ) return;

			this._tPersonal.Birthday = this.dtpBirthday.Value.ToString( "yyyy-MM-dd" );
			this._tPersonal.Profesion = this._tProfesion;

			if ( this._submitInsert )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );
			}
			else
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );
			}

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;

			this._cPersonal.Data = this._tPersonal;

			this._hilo.Start();
		}

		private void cboProfesion_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData != Keys.Up && e.KeyData != Keys.Down )
			{
				this._inputManual = true;
			}
		}

		private void cboProfesion_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this._inputManual = false;
		}

	}
}
