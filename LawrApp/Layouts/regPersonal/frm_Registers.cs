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

		private bool _submitInsert	= false;
		private bool _inputManual	= false;
		private bool _inAction		= false;
		private bool _Changes		= false;

		private int _idPersonal = 0;

		private delegate void RestoreDataToControls();

		public frm_Registers( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;

			List<lPersonal> tempPersonal = this._cPersonal.List();

			if( tempPersonal != null )
			{
				foreach ( lPersonal item in tempPersonal )
				{
					object[] temp = new object[6]
					{
						item.Codigo,
						item.Key,
						item.Description,
						item.TipoPersonal,
						item.IsActive,
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
				this.txtSearch.Enabled = false;
				this.btnSearch.Enabled = false;
				this.pgsLoading.Visible = false;
			}

			this.panelMain.Enabled = true;
			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitInsert(  )
		{
			CheckForIllegalCrossThreadCalls = false;

			this._tPersonal_Old = this._tPersonal;
			this._tPersonal = this._cPersonal.Insert();

			if ( this._tPersonal != null )
			{
				DataRow[] row = this._data.Tables["TipoPersonal"].Select("Codigo=" + this._tPersonal.CodigoTipoPersonal );

				object[] temp = new object[6]
				{
					this._tPersonal.Codigo,
					this._tPersonal.Key,
					this._tPersonal.Names + " " + this._tPersonal.LastNames,
					row[0]["Name"].ToString(),
					row[0]["IsUser"],
					DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
				};

				this.dgvListado.Rows.Add( temp );

				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;

				MetroMessageBox.Show( this, "Se ha registrado al Personal", "Muy Bien!", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.ResetControls();
			}
			else
			{
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
				this._tPersonal = this._tPersonal_Old;
				MetroMessageBox.Show( this, this._cPersonal.ExceptionPersonal, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );

			}

			this._hilo.Abort();
		}

		void SubmitUpdate(  )
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;
			this._tPersonal_Old = this._tPersonal;

			if ( this._cPersonal.Modify( this._tPersonal.Codigo ) )
			{
				DataRow[] row = this._data.Tables["TipoPersonal"].Select( "Codigo=" + this._tPersonal.CodigoTipoPersonal );

				this.dgvListado.CurrentRow.Cells[2].Value = this._tPersonal.Names + " " + this._tPersonal.LastNames;
				this.dgvListado.CurrentRow.Cells[3].Value = row[0]["Name"];
				this.dgvListado.CurrentRow.Cells[4].Value = row[0]["IsUser"];

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				MetroMessageBox.Show( this, "Se ha Modificado al Personal", "Muy Bien!", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.ResetControls();
			}
			else
			{
				this._tPersonal = this._tPersonal_Old;
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show(this, this._cPersonal.ExceptionPersonal, "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitDelete(  )
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._cPersonal.Delete( this._idPersonal ) )
			{
				this.dgvListado.Rows.RemoveAt( this.dgvListado.CurrentRow.Index );
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
			}
			else
			{
				pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cPersonal.ExceptionPersonal, "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this._idPersonal = 0;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void FindPersonal( )
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;

			this._tPersonal = this._cPersonal.Find( this._idPersonal );

			if ( this._tPersonal == null )
			{
				pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._tPersonal = new tPersonal();
				MetroMessageBox.Show( this, this._cPersonal.ExceptionPersonal, "Error en la Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			else
			{
				this._tPersonal_Old = this._tPersonal;
				this._tProfesion = this._tPersonal.Profesion;
				this.RestoreData();
			}

			this._inAction = false;

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
			this.panelListado.Enabled = true;
			this.tabControl.SelectedTab = this.tabPageListado;
			this.btnNuevo.Enabled = true;
			this.lblLastModified.Text = string.Empty;
			
			if ( this.dgvListado.Rows.Count == 0 )
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.txtSearch.Enabled = false;
				this.btnSearch.Enabled = false;
			}
			else
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
				this.txtSearch.Enabled = true;
				this.btnSearch.Enabled = true;
			}

			this.lblNombres_Validator.Visible = true;
			this.lblApellidos_Validator.Visible = true;
			this.lblGenero_Validator.Visible = true;
			this.lblTipoDocumento_Validator.Visible = true;
			this.lblDocumento_Validator.Visible = true;
			this.lblTipoPersonal_Validator.Visible = true;
			this.lblDireccion_Validator.Visible = true;

			this._tPersonal = new tPersonal();
		}

		void RestoreData()
		{
			if( ! this.InvokeRequired )
			{
				this.ptbImage.ImageLocation = this._cPersonal.ConfigBaseUrl + this._tPersonal.ImageSrc;
				this.txtNombres.Text = this._tPersonal.Names;
				this.lblNombres_Validator.Visible = ( string.IsNullOrEmpty( this._tPersonal.Names ) ) ? true : false;
				this.txtApellidos.Text = this._tPersonal.LastNames;
				this.lblApellidos_Validator.Visible = ( string.IsNullOrEmpty( this._tPersonal.LastNames ) ) ? true : false;
				this.dtpBirthday.Value = Convert.ToDateTime( this._tPersonal.Birthday );
				this.CboGenero.SelectedIndex = ( this._tPersonal.Gender ) ? 1 : 0;
				this.lblGenero_Validator.Visible = false;

				if ( this._tPersonal.Profesion.Codigo == 0 )
				{
					this.cboProfesion.SelectedIndex = -1;
					this.cboProfesion.Text = string.Empty;
				}
				else
				{
					this.cboProfesion.SelectedValue = this._tPersonal.Profesion.Codigo;
				}
				this._inputManual = true;
				this.cboDocumento.SelectedValue = this._tPersonal.CodigoTipoDocumento;
				this.lblTipoDocumento_Validator.Visible = false;
				this.txtN_Documento.Text = this._tPersonal.DocumentNumber;
				this.lblDocumento_Validator.Visible = ( string.IsNullOrEmpty( this._tPersonal.DocumentNumber ) ) ? true : false;
				this.cboTipoPersonal.SelectedValue = this._tPersonal.CodigoTipoPersonal;
				this.lblTipoPersonal_Validator.Visible = false;
				this.txtTelefono.Text = this._tPersonal.Phone;
				this.txtEmail.Text = this._tPersonal.Email;
				this.txtDireccion.Text = this._tPersonal.Address;
				this.lblDireccion_Validator.Visible = ( string.IsNullOrEmpty( this._tPersonal.Address ) ) ? true : false;
				this.lblLastModified.Text = "Ult. Modificación: " + this._tPersonal.ModifiedDate;

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this.panelRegistros.Enabled = true;
				this.panelListado.Enabled = false;

				this.tabControl.SelectedIndex = 1;

				this._Changes = false;
				this.txtNombres.Focus();
			}
			else
			{
				RestoreDataToControls toco = new RestoreDataToControls( RestoreData );
				this.Invoke( toco, new object[] { } );
			}
		}

		#endregion

		#region FUNCIONES

		private bool ValidateData()
		{
			// Nombres
			if ( string.IsNullOrWhiteSpace( this.txtNombres.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtNombres, 2500 );
				this.txtNombres.Focus();
				return false;
			}

			// Apellidos
			if ( string.IsNullOrWhiteSpace( this.txtNombres.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtApellidos, 2500 );
				this.txtApellidos.Focus();
				return false;
			}

			// Genero
			if ( this.CboGenero.SelectedIndex < 0 )
			{
				this.toltipMore.Show( "Seleccione una Opción", this.CboGenero, 2500 );
				this.CboGenero.Focus();
				return false;
			}

			//Documento
			if ( this.cboDocumento.SelectedValue == null )
			{
				this.toltipMore.Show( "Seleccione una Opción", this.cboDocumento, 2500 );
				this.cboDocumento.Focus();
				return false;
			}

			// N° de Documento
			if ( string.IsNullOrWhiteSpace( this.txtN_Documento.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtN_Documento, 2500 );
				this.txtN_Documento.Focus();
				return false;
			}

			// Tipo de Personal
			if ( this.cboTipoPersonal.SelectedValue == null )
			{
				this.toltipMore.Show( "Seleccione una Opción", this.cboTipoPersonal, 2500 );
				this.cboTipoPersonal.Focus();
				return false;
			}

			//Dirección
			if ( string.IsNullOrWhiteSpace( this.txtDireccion.Text ) )
			{
				this.toltipMore.Show( "Este Campo es Requerido", this.txtDireccion, 2500 );
				this.txtDireccion.Focus();
				return false;
			}

			return true;
		}

		#endregion

		private void frm_Registers_Load( object sender, EventArgs e )
		{
			this.lblSucursal.Text = "Dirección: " + this._cPersonal.getAppSettings( "BranchAddress" );
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
			//if ( ! this._inAction )
			//{
			//	frmMain main = new frmMain( this._data );
			//	main.Show();
			//}
			//else
			//{
			//	e.Cancel = true;
			//}
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.panelRegistros.Enabled = true;
			this.btnNuevo.Enabled = false;
			this.tabControl.SelectedTab = this.tabPageRegistro;
			this._Changes = false;
			this._submitInsert = true;
			this.txtNombres.Focus();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this._submitInsert = false;
			this.ResetControls();
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
				this._hilo = new Thread( new ThreadStart( this.SubmitUpdate ) );
			}

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;

			this._cPersonal.Data = this._tPersonal;

			this._hilo.Start();
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
					this.lblNombres_Validator.Visible = ( string.IsNullOrWhiteSpace( txt.Text.Trim() ) ) ? true : false;
				break;
				case "txtApellidos":
					this._tPersonal.LastNames = txt.Text.Trim();
					this.lblApellidos_Validator.Visible = ( string.IsNullOrWhiteSpace( txt.Text.Trim() ) ) ? true : false;
				break;
				case "txtN_Documento":
					this._tPersonal.DocumentNumber = txt.Text.Trim();
					this.lblDocumento_Validator.Visible = ( string.IsNullOrWhiteSpace( txt.Text.Trim() ) ) ? true : false;
				break;
				case "txtEmail":
					this._tPersonal.Email = txtEmail.Text.Trim();
				break;
				case "txtTelefono":
					this._tPersonal.Phone = txtTelefono.Text.Trim();
				break;
				case "txtDireccion":
					this._tPersonal.Address = txtDireccion.Text.Trim();
					this.lblDireccion_Validator.Visible = ( string.IsNullOrWhiteSpace( txt.Text.Trim() ) ) ? true : false;
				break;
			}
		}

		private void AsignDataAndValidate_ComboBox_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			switch( cbo.Name )
			{
				case "CboGenero":
				this._tPersonal.Gender = ( ( cbo.SelectedIndex == 1 ) ? true : false );
				this.lblGenero_Validator.Visible = (cbo.SelectedIndex > -1) ? false : true;
				break;
				case "cboProfesion":
				if( this._inputManual )
				{
					if ( string.IsNullOrWhiteSpace( cbo.Text.Trim() ) )//POR SI HE BORRADO TODO PORQUE NO TIENE PROFESION
					{
						this._tProfesion.Codigo = 0;
						this._tProfesion.Name = string.Empty;
					}
					else
					{
						DataRow[] row = this._data.Tables["Profesion"].Select( "Name = '" + this.cboProfesion.Text.Trim() + "'" );

						if ( row.Any() )
						{
							this.cboProfesion.SelectedValue = row[0]["Codigo"];
							this.cboProfesion_SelectionChangeCommitted( this.cboProfesion, EventArgs.Empty );
							this._tProfesion.Codigo = ( int ) row[0]["Codigo"];
						}
						else
						{
							this._tProfesion.Name = this.cboProfesion.Text;
						}
					}
				}
				else
				{
					this._tProfesion.Codigo = ( int ) ( ( cboProfesion.SelectedValue == null ) ? 0 : cboProfesion.SelectedValue );
				}

				break;
				case "cboDocumento":
				this._tPersonal.CodigoTipoDocumento = ( int ) ( ( cboDocumento.SelectedValue == null ) ? 0 : cboDocumento.SelectedValue );
				this.lblTipoDocumento_Validator.Visible = false;
				break;
				case "cboTipoPersonal":
				this._tPersonal.CodigoTipoPersonal = ( int ) ( (cboTipoPersonal.SelectedValue == null ) ? 0 : cboTipoPersonal.SelectedValue );
				this.lblTipoPersonal_Validator.Visible = false;
				break;
			}
		}

		private void dtpBirthday_Leave( object sender, EventArgs e )
		{
			this._tPersonal.Birthday = this.dtpBirthday.Value.ToString( "yyyy-MM-dd" );
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

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindPersonal ) );

				this._idPersonal = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
		}

		private void dgvListado_KeyDown( object sender, KeyEventArgs e )
		{
			if ( this.dgvListado.CurrentRow.Index >= 0 )
			{
				if ( e.KeyData == Keys.Enter )
				{
					this._hilo = new Thread( new ThreadStart( this.FindPersonal ) );

					this._idPersonal = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

					this.panelMain.Enabled = false;
					this.pgsLoading.Visible = true;

					this._hilo.Start();

					e.Handled = true;
				}
				else if ( e.KeyData == Keys.Delete )
				{
					DialogResult res = MetroMessageBox.Show( this, "Si realmente deseas Eliminar esta fila Presiona OK", "¿Deseas Eliminar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );

					if ( res == DialogResult.OK )
					{
						this._hilo = new Thread( new ThreadStart( this.SubmitDelete ) );

						this._idPersonal = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

						this.panelMain.Enabled = false;
						this.pgsLoading.Visible = true;

						this._hilo.Start();
					}

					e.Handled = true;
				}
			}
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentRow.Index >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindPersonal ) );

				this._idPersonal = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			DialogResult res = MetroMessageBox.Show( this, "Si realmente deseas Eliminar esta fila Presiona OK", "¿Deseas Eliminar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );

			if ( res == DialogResult.OK )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitDelete ) );

				this._idPersonal = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
		}
	}
}
