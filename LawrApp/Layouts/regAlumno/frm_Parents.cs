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
		private bool _isNumeric, _isExactLength, _gotoModify;

		delegate void ChangeTipoApoderadoCallback(object sender, EventArgs e);

		public frm_Parents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		private void LoadListParents()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lApoderados> list = this._parent.List( this._codAlumno );

			if ( list.Any() )
			{
				foreach ( lApoderados item in list )
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
				this.pgsLoading.Visible = false;
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				MetroMessageBox.Show( this, "No existen apoderados registrados, para este alumno", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}

			this.panelListado.Enabled = true;
			this.btnSearchStudent.Enabled = true;

			this._hilo.Abort();
		}

		private void FindParents()
		{
			CheckForIllegalCrossThreadCalls = false;

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

			this._hilo.Abort();
		}

		private void InsertOrUpdateParent()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( ! this._gotoModify )
			{
				
			}
			else
			{

			}

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

			this._hilo.Start();

		}

		public void AddSchool( string Name, int Codigo, string Type ) { }

		#endregion

		#region METODOS

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
			
			this._hilo.Start();
		}

		void ResetControls()
		{
			this.txtNames.Clear();
			this.TxtLasName.Clear();
			this.txtDocumentNumber.Clear();
			this.txtEmail.Clear();
			this.txtPhones.Clear();
			this.txtAddress.Clear();

			this.cboSexo.SelectedIndex = -1;
			this.cboSexo.Text = "Seleccione...";

			this.cboparentesco.DataSource = null;
			this.cboparentesco.Text = "Seleccione...";

			this.cboTypeDocument.SelectedIndex = -1;
			this.cboTypeDocument.Text = "Seleccione...";

			this.dtpBirthday.Value = DateTime.Now;

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

			this.tabControl.SelectedTab = this.tabPageListado;
		}

		#endregion

		private void frm_Parents_Load( object sender, EventArgs e )
		{
			this.tabControl.SelectedTab = this.tabPageListado;
			
			this.cboTypeDocument.DisplayMember	= "ShortName";
			this.cboTypeDocument.ValueMember	= "Codigo";
			this.cboTypeDocument.DataSource		= this._data.Tables["TipoDocumento"];

			this.cboTypeDocument.SelectedIndex	= -1;
			this.cboTypeDocument.Text			= "Seleccione...";
		}

		private void btnSearchStudent_Click( object sender, EventArgs e )
		{
			mdl_ListAlumno search = new mdl_ListAlumno( this._data );
			search.Owner = this;
			search.ShowDialog( this );
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.ActionForCreation();
		}

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex >= 0 )
				this.ActionForModification();
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.Rows.Count > 0 )
				this.ActionForModification();
		}

		private void cboSexo_SelectionChangeCommitted( object sender, EventArgs e )
		{
			if ( ! this.cboSexo.InvokeRequired )
			{
				ComboBox cbo = ( ComboBox ) sender;

				this.cboparentesco.ValueMember = "Codigo";
				this.cboparentesco.DisplayMember = "Name";

				this.cboparentesco.DataSource = this._data.Tables["TipoApoderado"].Select( "Gender=" + cbo.SelectedIndex ).CopyToDataTable();

				this.cboparentesco.SelectedIndex = -1;
				this.cboparentesco.Text = "Seleccione...";
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

			this.lbValidacionTipoDocumento.Visible = false;
			this.txtDocumentNumber.Enabled = true;

			Object[] docs = this._data.Tables["TipoDocumento"].Select( "Codigo=" + cbo.SelectedValue )[0].ItemArray;

			this._lengthAllowed = ( int ) docs[3];
			this._isNumeric = ( bool ) docs[4];
			this._isExactLength = ( bool ) docs[5];

			this.txtDocumentNumber.Clear();
		}

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

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
		}

	}
}
