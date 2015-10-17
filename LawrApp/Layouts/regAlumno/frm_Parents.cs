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
using MetroFramework.Controls;
using Registers.Students;
using Objects.Processes;
using System.Threading;
using Objects.Tables;
using Options;

namespace LawrApp.Layouts.regAlumno
{
	public partial class frm_Parents : MetroForm, IAlumno
	{
		private Parents _parent			= new Parents();
		private tApoderado _objParent	= new tApoderado();
		private DataGeneral _data;
		private Thread _hilo;

		private int _codAlumno;
		private int _codParient;
		private int _lengthAllowed;
		private bool _isNumeric, _isExactLength, _gotoModify, _inAction;
		private string error_debug;

		// DELEGADO QUE PERMITE INGRESAR AL EVENTO SELECTIONCHANGEDCOMMITTED 
		// DEL CBO TIPO PARIENTE DESDE UN SEGUNDO HILO
		delegate void ChangeTipoApoderadoCallback(object sender, EventArgs e);
		private delegate void LoadDataToGridView( List<lApoderados> Parents );
		public frm_Parents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		private void LoadListParents()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<lApoderados> list = this._parent.List( this._codAlumno );

			if ( list.Any() )
			{
				LoadDataToGrid( list );
			}
			else
			{
				this.pgsLoading.Visible = false;
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				MetroMessageBox.Show( this, "No existen apoderados registrados, para este alumno", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}

			this.panelListado.Enabled = true;
			this.btnSearchStudent.Enabled = true;

			this._inAction = false;
			this._hilo.Abort();
		}

		private void FindParents()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			this._objParent = this._parent.Find( this._codAlumno, this._codParient );

			if ( this._objParent != null )
			{
				this.txtNames.Text = this._objParent.Names;
				this.TxtLasName.Text = this._objParent.LastNames;

				this.cboSexo.SelectedIndex = ( this._objParent.Gender ) ? 1 : 0;
				this.cboSexo_SelectionChangeCommitted( this.cboSexo, EventArgs.Empty );

				this.dtpBirthday.Value = Convert.ToDateTime( this._objParent.Birthday );
				this.cboparentesco.SelectedValue = this._objParent.CodigoTipoApoderado;

				this.cboTypeDocument.SelectedValue = this._objParent.CodigoTipoDocumento;
				this.cboTypeDocument_SelectionChangeCommitted( this.cboTypeDocument, null );

				this.txtDocumentNumber.Text = this._objParent.DocumentNumber;
				this.txtPhones.Text = this._objParent.Phone;
				this.txtEmail.Text = this._objParent.Email;
				this.txtAddress.Text = this._objParent.Address;

				this.pgsLoading.Visible = false;
				this.panelRegistros.Enabled = true;
				this.txtNames.Focus();
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._parent.MsgExceptionParents, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		private void SubmitInsertOrUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( ! this._gotoModify )
			{
				int codigo = this._parent.Insert( this._codAlumno );

				if ( codigo > 0 )
				{
					object[] temp = new object[4]
					{
						codigo,
						this._objParent.Names + " " + this._objParent.LastNames,
						this.cboparentesco.Text,
						DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
					};

					this.dgvListado.Rows.Add( temp );

					this.pgsLoading.Visible = false;
					MetroMessageBox.Show( this, "El Apoderado a sido registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.ResetControls();
					this.tabControl.SelectedTab = this.tabPageListado;
				}
				else
				{
					this.pgsLoading.Visible = false;
					MetroMessageBox.Show( this, "Error al intentar registrar al apoderado", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.tabControl.SelectedTab = this.tabPageRegistro;
					this.panelRegistros.Enabled = false;
					this._objParent = new tApoderado();
				}
			}
			else
			{
				if ( this._parent.Update( this._codAlumno, this._codParient ) )
				{
					this.dgvListado.CurrentRow.Cells[1].Value = this._objParent.Names + " " + this._objParent.LastNames;
					this.dgvListado.CurrentRow.Cells[2].Value = this.cboparentesco.Text;
					this.dgvListado.CurrentRow.Cells[3].Value = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
					
					this.pgsLoading.Visible = false;

					MetroMessageBox.Show( this, "El Apoderado a sido Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.ResetControls();
					this.tabControl.SelectedTab = this.tabPageListado;
				}
				else
				{
					this.pgsLoading.Visible = false;
					MetroMessageBox.Show( this, "Error al intentar Modificar al apoderado", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.tabControl.SelectedTab = this.tabPageRegistro;
					this._objParent = new tApoderado();
				}
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._parent.Delete( this._codAlumno, this._codParient ) )
			{
				this.pgsLoading.Visible = false;
				this.dgvListado.Rows.RemoveAt( this.dgvListado.CurrentRow.Index );
				MetroMessageBox.Show( this, "El Apodereado a sido Eliminado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.ResetControls();
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._parent.MsgExceptionParents, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS DE INTERFACE

		public void ChooseStudent( string nameAlumno, int idAlumno ) 
		{
			this._hilo = new Thread( new ThreadStart( this.LoadListParents ) );
			
			this.txtNameStudent.Text	= nameAlumno;
			this._codAlumno				= idAlumno;

			this.dgvListado.Rows.Clear();

			this.tabControl.SelectedTab		= this.tabPageListado;
			this.panelListado.Enabled		= false;
			this.btnSearchStudent.Enabled	= false;
			this.pgsLoading.Visible			= true;
			this._inAction					= true;

			this._hilo.Start();

		}

		public void AddSchool( string Name, int Codigo, string Type ) { }

		#endregion

		#region METODOS

		void LoadDataToGrid( List<lApoderados> Parents )
		{
			if( ! this.InvokeRequired )
			{
				foreach ( lApoderados item in Parents )
				{
					object[] objTemp = new object[4] 
					{
						item.Codigo,
						item.Names,
						item.TipoApoderado,
						item.ModifiedDate
					};

					this.dgvListado.Rows.Add( objTemp );
				}

				this.pgsLoading.Visible = false;
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
			}
			else
			{
				LoadDataToGridView dtp = new LoadDataToGridView( LoadDataToGrid );
				this.Invoke( dtp, new object[] { Parents } );
			}
		}

		void ActionForCreation()
		{
			this._gotoModify = false;
			this.panelListado.Enabled		= false;
			this.btnSearchStudent.Enabled	= false;

			this.panelRegistros.Enabled		= true;

			this.tabControl.SelectedTab = this.tabPageRegistro;
			this.txtNames.Focus();
		}

		void ActionForModification()
		{
			this._hilo = new Thread( new ThreadStart( this.FindParents ) );

			this._codParient = (int) this.dgvListado.CurrentRow.Cells[0].Value;

			this.panelListado.Enabled = false;
			this.panelRegistros.Enabled = false;
			this.btnSearchStudent.Enabled = false;
			this.pgsLoading.Visible = true;
			this.tabControl.SelectedTab = this.tabPageRegistro;
			this._gotoModify = true;
			this._inAction = true;

			this._hilo.Start();
		}

		void ActionForDelete()
		{
			DialogResult result = MetroMessageBox.Show( 
				this, 
				"Realmente Deseas Eliminar al Apoderado seleccionado?\nPresiona Ok para Eliminar...", 
				"ADVERTENCIA",
				MessageBoxButtons.OKCancel, 
				MessageBoxIcon.Warning
			);

			if ( result == DialogResult.OK )
			{
				this._hilo = new Thread( new ThreadStart( SubmitDelete ) );

				this.panelListado.Enabled = false;
				this.btnSearchStudent.Enabled = false;
				this.pgsLoading.Visible = true;

				this._codParient = (int) this.dgvListado.CurrentRow.Cells[0].Value;
				this._inAction = true;

				this._hilo.Start();
			}
		}

		void ResetControls()
		{
			this.txtNames.Clear();
			this.TxtLasName.Clear();
			this.txtDocumentNumber.Clear();
			this.txtEmail.Clear();
			this.txtPhones.Clear();
			this.txtAddress.Clear();

			this.cboparentesco.Text = "Seleccione...";

			this.cboSexo.SelectedIndex = -1;
			this.cboSexo.Text = "Seleccione...";

			this.cboTypeDocument.SelectedIndex = -1;
			this.cboTypeDocument.Text = "Seleccione...";

			this.dtpBirthday.Value = dtpBirthday.MaxDate;

			this._codParient = 0;
			this._gotoModify = false;
			this._objParent = new tApoderado();

			this._isExactLength = false;
			this._isNumeric = false;
			this._lengthAllowed = 0;

			this.panelRegistros.Enabled = false;
			this.panelListado.Enabled = true;
			this.btnSearchStudent.Enabled = true;
			this.pgsLoading.Visible = false;

			if ( dgvListado.Rows.Count == 0 )
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
			}
			else
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
			}

			this.tabControl.SelectedTab = this.tabPageListado;
		}

		void JoinData()
		{
			this._objParent.Names = this.txtNames.Text;
			this._objParent.LastNames = this.TxtLasName.Text;
			this._objParent.Gender = this.cboSexo.SelectedIndex == 1 ? true : false;
			this._objParent.Birthday = this.dtpBirthday.Value.ToString( "yyyy-MM-dd" );
			this._objParent.CodigoTipoApoderado = (int) this.cboparentesco.SelectedValue;
			this._objParent.CodigoTipoDocumento = ( int ) this.cboTypeDocument.SelectedValue;
			this._objParent.DocumentNumber = this.txtDocumentNumber.Text;
			this._objParent.Phone = this.txtPhones.Text;
			this._objParent.Email = this.txtEmail.Text;
			this._objParent.Address = this.txtAddress.Text;

			this._parent.Data = this._objParent;
		}

		#endregion

		#region FUNCIONES

		private bool ValidateData()
		{
			// Nombres
			if ( string.IsNullOrWhiteSpace( this.txtNames.Text ) )
			{
				this.toltipValid.Show( "Nombre del Pariente es requerido", this.txtNames, 3000 );
				this.txtNames.Focus();
				return false;
			}

			//Apellidos
			if ( string.IsNullOrWhiteSpace( this.TxtLasName.Text ) )
			{
				this.toltipValid.Show( "Apellido del pariente es requerido", this.TxtLasName, 3000 );
				this.TxtLasName.Focus();
				return false;
			}

			//Sexo
			if ( this.cboSexo.SelectedIndex < 0 )
			{
				this.toltipValid.Show( "Sexo del pariente es requerido ", this.cboSexo, 3000 );
				this.cboSexo.Focus();
				return false;
			}

			// Fecha de Nacimiento
			if ( !Helper.ValidacionMayoriaDeEdad( this.dtpBirthday.Value ) )
			{
				this.toltipValid.Show( "El Apoderado debe ser mayor de edad", this.dtpBirthday, 3000 );
				this.dtpBirthday.Focus();
				return false;
			}

			// Tipo de Apoderado
			if ( this.cboparentesco.SelectedIndex < 0 )
			{
				this.toltipValid.Show( "Debes seleccionar el parentesco", this.cboparentesco, 3000 );
				this.cboparentesco.Focus();
				return false;
			}

			// Tipo de Documento
			if ( cboTypeDocument.SelectedIndex < 0)
			{
				this.toltipValid.Show( "Minimo es un documento requerido  ", this.cboTypeDocument, 3000 );
				this.cboTypeDocument.Focus();
				return false;
			}

			// Numero de Documento
			if ( string.IsNullOrWhiteSpace( txtDocumentNumber.Text ) )
			{
				this.toltipValid.Show( "Este campo es requerido", this.txtDocumentNumber, 3000 );
				this.txtDocumentNumber.Focus();
				return false;
			}

			// Dirección
			if ( string.IsNullOrWhiteSpace( this.txtAddress.Text ) )
			{
				this.toltipValid.Show( "Este campo es requerido", this.txtAddress, 3000 );
				this.txtAddress.Focus();
				return false;
			}

			// A cumplido todas las validaciones
			return true;
		}

		#endregion

		#region EVENTOS

		private void frm_Parents_Load( object sender, EventArgs e )
		{
			this.tabControl.SelectedTab = this.tabPageListado;
			
			this.cboTypeDocument.DisplayMember	= "ShortName";
			this.cboTypeDocument.ValueMember	= "Codigo";
			this.cboTypeDocument.DataSource		= this._data.Tables["TipoDocumento"];

			this.cboTypeDocument.SelectedIndex	= -1;
			this.cboTypeDocument.Text			= "Seleccione...";

			this.dtpBirthday.MaxDate = DateTime.Now.AddYears( -18 );
			this.dtpBirthday.MinDate = DateTime.Now.AddYears( -90 );
		}

		private void frm_Parents_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
				e.Cancel = true;
		}

		#region CLICK & DOUBLECLICK

		private void btnSearchStudent_Click( object sender, EventArgs e )
		{
			try
			{
				mdl_ListAlumno search = new mdl_ListAlumno( this._data );
				search.Owner = this;
				search.ShowDialog( this );
			}
			catch( Exception ex )
			{
				this.error_debug = ex.Message;
			}
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.ActionForCreation();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateData() ) return;
			
			this._hilo = new Thread( new ThreadStart( this.SubmitInsertOrUpdate ) );

			this.panelRegistros.Enabled = false;
			this.pgsLoading.Visible = true;

			this.JoinData();
			this._inAction = true;

			this._hilo.Start();
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.Rows.Count > 0 )
				this.ActionForModification();
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.Rows.Count > 0 )
				this.ActionForDelete();
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex >= 0 )
				this.ActionForModification();
		}

		#endregion

		#region SELECTIONCHANGECOMMITTED

		private void cboSexo_SelectionChangeCommitted( object sender, EventArgs e )
		{
			if ( ! this.cboSexo.InvokeRequired )
			{
				ComboBox cbo = ( ComboBox ) sender;

				if ( cbo.SelectedIndex >= 0 )
				{
					this.cboparentesco.ValueMember = "Codigo";
					this.cboparentesco.DisplayMember = "Name";

					this.cboparentesco.DataSource = this._data.Tables["TipoApoderado"].Select( "Gender=" + cbo.SelectedIndex ).CopyToDataTable();

					this.cboparentesco.SelectedIndex = -1;
					this.cboparentesco.Text = "Seleccione...";

					this.lblGender_Validator.Visible = false;
				}
				else
				{
					this.cboparentesco.DataSource = null;
					this.lblGender_Validator.Visible = true;
				}
				
			}
			else
			{
				ChangeTipoApoderadoCallback tipo = new ChangeTipoApoderadoCallback( cboSexo_SelectionChangeCommitted );
				this.Invoke( tipo, new object[] { sender, e } );
			}
		}

		private void cboTypeDocument_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			this.lblTipoDocument_Validator.Visible = false;
			this.txtDocumentNumber.Enabled = true;

			Object[] docs = this._data.Tables["TipoDocumento"].Select( "Codigo=" + cbo.SelectedValue )[0].ItemArray;

			this._lengthAllowed = ( int ) docs[3];
			this._isNumeric = ( bool ) docs[4];
			this._isExactLength = ( bool ) docs[5];

			this.txtDocumentNumber.Clear();
		}

		private void cboparentesco_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this.lblTipoParent_Validator.Visible = false;
		}

		#endregion

		#region KEYDOWN & PREVIEWKEYDOWN

		private void txtDocumentNumber_KeyDown( object sender, KeyEventArgs e )
		{
			MetroTextBox txt = ( MetroTextBox ) sender;

			if ( e.KeyData != Keys.Back && e.KeyData != Keys.Delete )
			{
				if ( this._isNumeric )
				{
					if ( ( txt.Text.Trim() ).Length >= this._lengthAllowed || Helper.solonumeros( ( char ) e.KeyValue ) )
						e.SuppressKeyPress = true;
				}
				else
				{
					if ( ( txt.Text.Trim() ).Length >= this._lengthAllowed )
						e.SuppressKeyPress = true;
				}
			}
		}

		private void txtNames_KeyDown( object sender, KeyEventArgs e )
		{
			if ( Helper.solotexto( ( char ) e.KeyValue ) )
				e.SuppressKeyPress = true;
		}

		private void TxtLasName_KeyDown( object sender, KeyEventArgs e )
		{
			if ( Helper.solotexto( ( char ) e.KeyValue ) )
				e.SuppressKeyPress = true;
		}

		private void cboSexo_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

		private void dgvListado_PreviewKeyDown( object sender, PreviewKeyDownEventArgs e )
		{
			if ( ( (DataGridView) sender ).Rows.Count > 0 )
			{
				if ( e.KeyData == Keys.Enter )
					this.ActionForModification();
				else if ( e.KeyData == Keys.Delete )
					this.ActionForDelete();
			}
		}

		#endregion

		#region TEXTCHANGED & VALUECHANGED

		private void txtEmail_TextChanged( object sender, EventArgs e )
		{
			if ( ! string.IsNullOrWhiteSpace( txtEmail.Text ) )
			{
				if ( ! Helper.CorreoElectronico( this.txtEmail.Text ) )
					this.lblEmail_Validator.Visible = true;
				else
					this.lblEmail_Validator.Visible = false;
			}
			else
				this.lblEmail_Validator.Visible = false;
		}

		private void txtNames_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtNames.Text ) )
				this.lblNames_Validator.Visible = true;
			else
				this.lblNames_Validator.Visible = false;
		}

		private void TxtLasName_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtNames.Text ) )
				this.lblLastNames_Validator.Visible = true;
			else
				this.lblLastNames_Validator.Visible = false;
		}

		private void txtDocumentNumber_TextChanged( object sender, EventArgs e )
		{
			if ( !string.IsNullOrWhiteSpace( this.txtDocumentNumber.Text ) )
				this.lblNumberDocument_Validator.Visible = false;
			else
				this.lblNumberDocument_Validator.Visible = true;
		}

		private void dtpBirthday_ValueChanged( object sender, EventArgs e )
		{
			if ( ! Helper.ValidacionMayoriaDeEdad( dtpBirthday.Value ) )
			{
				lblBirthday_Validator.Visible = true;
			}
			else
			{
				lblBirthday_Validator.Visible = false;
			}
		}

		#endregion

		private void txtEmail_Leave( object sender, EventArgs e )
		{
			if ( !string.IsNullOrWhiteSpace( txtEmail.Text ) )
			{
				if ( !Helper.CorreoElectronico( this.txtEmail.Text ) )
				{
					this.lblEmail_Validator.Visible = false;
					this.toltipValid.Show( "El texto no parece un Email", this.txtEmail, 3000 );
				}
				else
					this.lblEmail_Validator.Visible = false;
			}
			else
				this.lblEmail_Validator.Visible = false;
		}

		#endregion

	}
}
