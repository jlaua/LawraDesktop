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
using Objects.Tables;
using System.Threading;
using Institution;

namespace LawrApp.Institucion
{
	public partial class frm_Branches : MetroForm
	{
		public DataGeneral _data;
		public Thread _hilo;

		public Branches _cBranch = new Branches();
		public tBranch _tBranch = new tBranch();
		public tBranch _tBranch_Old = new tBranch();

		public bool _submitInsert = false;
		public bool _inAction = false;
		public string _codigoBranch;

		delegate void ChangeStateUbigeo( object sender, EventArgs e );
		delegate void RestoreDataTocontrols();

		public frm_Branches( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;
			this._tBranch_Old = this._tBranch;
			this._tBranch = this._cBranch.Insert();

			if ( this._tBranch == null )
			{
				pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._tBranch = this._tBranch_Old;
				MetroMessageBox.Show(this, "Error al intentar Guardar: \n" + this._cBranch.ExceptionHistory, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;

				object[] temp = new object[6] 
				{
 					this._tBranch.Codigo,
					this._tBranch.Address,
					this._tBranch.IsMain,
					this._tBranch.LocalCode,
					DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
					this._tBranch.Codigo + "-" + this._tBranch.Address
				};

				this._data.Tables["Sucursal"].Rows.Add(temp);

				MetroMessageBox.Show( this, "Se ha Registrado una nueva Sucursal", "Muy bien!", MessageBoxButtons.OK, MessageBoxIcon.Question );
				
				this.ResetControls();
			}

			this._hilo.Abort();
		}

		void SubmitUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;
			this._tBranch_Old = this._tBranch;
			this._cBranch.Data = this._tBranch;

			if ( this._cBranch.Modify() )
			{
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;

				MetroMessageBox.Show( this, "Se ha Modificado la sucursal", "Muy Bien", MessageBoxButtons.OK, MessageBoxIcon.Question );
				
				DataRow[] row = this._data.Tables["Sucursal"].Select( "Codigo=" + this._tBranch.Codigo );

				row[0]["Address"] = this._tBranch.Address;
				row[0]["IsMain"] = this._tBranch.IsMain;
				row[0]["LocalCode"] = this._tBranch.LocalCode;
				row[0]["ModifiedDate"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

				this.ResetControls();
			}
			else
			{
				this.pgsLoading.Visible = false;
				this._inAction = false;
				this.panelMain.Enabled = true;
				MetroMessageBox.Show( this, this._cBranch.ExceptionHistory, "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;

			if ( this._cBranch.Delete( Convert.ToInt32(this._codigoBranch) ) )
			{
				DataRow[] row = this._data.Tables["Sucursal"].Select( "Codigo=" + this._codigoBranch );
				row[0].Delete();

				this._codigoBranch = string.Empty;
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
			}
			else
			{
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				MetroMessageBox.Show( this, this._cBranch.ExceptionHistory, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void FindBranch()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;
			this._tBranch_Old = this._tBranch;

			this._tBranch = this._cBranch.Find( this._codigoBranch );

			if ( this._tBranch == null )
			{
				pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._tBranch = this._tBranch_Old;
				MetroMessageBox.Show( this, this._cBranch.ExceptionHistory, "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			else
			{
				pgsLoading.Visible = false;
				this.RestoreData();
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		private bool ValidateData()
		{
			// Dirección
			if ( string.IsNullOrWhiteSpace( this.txtDireccion.Text.Trim() ) )
			{
				this.toltipMore.Show( "Este campo es Requerido", this.txtDireccion, 3000 );
				this.txtDireccion.Focus();
				return false;
			}

			// Ubigeo
			if ( cboDistrito.SelectedValue == null )
			{
				this.toltipMore.Show( "Debes Seleccionar una Opción", this.cboDistrito, 3000 );
				this.cboDistrito.Focus();
				return false;
			}

			// Codigo de Local
			if ( string.IsNullOrWhiteSpace( this.txtCodigoLocal.Text.Trim() ) )
			{
				this.toltipMore.Show( "Este campo es Requerido", this.txtCodigoLocal, 3000 );
				this.txtCodigoLocal.Focus();
				return false;
			}

			return true;
		}

		void ResetControls()
		{
			this.txtDireccion.Clear();
			this.chboPrincipal.Checked = false;
			this.cboDepartamento.SelectedIndex = -1;
			this.cboDepartamento_SelectionChangeCommitted( this.cboDepartamento, EventArgs.Empty );
			this.txtCodigoLocal.Clear();
			this.txtTelefono.Clear();
			this.txtEmail.Clear();
			this.txtLatitud.Clear();
			this.txtLongitud.Clear();
			this.nudZoom.Value = 13;

			this._submitInsert = false;
			this._tBranch = new tBranch();
			this._inAction = false;

			this.panelRegistro.Enabled = false;
			this.panelListado.Enabled = true;
			this.tabControl.SelectedIndex = 0;
		}

		void LoadSucursales()
		{
			this.dgvListado.DataSource = this._data.Tables["Sucursal"];

			this.dgvListado.Columns["Codigo"].Visible			= false;
			this.dgvListado.Columns["ConcatColumn"].Visible		= false;
			this.dgvListado.Columns["Address"].HeaderText		= "Dirección";
			this.dgvListado.Columns["IsMain"].HeaderText		= "Principal";
			this.dgvListado.Columns["LocalCode"].HeaderText		= "C. Local";
			this.dgvListado.Columns["ModifiedDate"].HeaderText	= "Modificado";

			this.dgvListado.Columns["IsMain"].FillWeight		= 50;
			this.dgvListado.Columns["LocalCode"].FillWeight		= 60;
			this.dgvListado.Columns["ModifiedDate"].FillWeight	= 70;
		}

		void LoadUbigeoData()
		{
			this.cboDepartamento.ValueMember	= "CodDepartamento";
			this.cboDepartamento.DisplayMember	= "NombreDepartamento";
			this.cboDepartamento.DataSource		= this._data.Tables["Departamentos"];
			this.cboDepartamento.SelectedIndex = -1;
			this.cboDepartamento.Text = "Seleccione...";
		}

		void RestoreData()
		{
			if ( ! this.InvokeRequired )
			{
				this.txtDireccion.Text = this._tBranch.Address;
				this.chboPrincipal.Checked = this._tBranch.IsMain;
				this.txtCodigoLocal.Text = this._tBranch.LocalCode;
				this.txtTelefono.Text = this._tBranch.Phone;
				this.txtEmail.Text = this._tBranch.Email;
				this.txtLatitud.Text = this._tBranch.Latitud;
				this.txtLongitud.Text = this._tBranch.Longitud;
				this.nudZoom.Value = (this._tBranch.Zoom == 0) ? 13 : this._tBranch.Zoom;

				string[] ubigeo = new string[3] 
				{ 
					this._tBranch.Ubigeo.Substring(0, 2), 
					this._tBranch.Ubigeo.Substring(2, 2), 
					this._tBranch.Ubigeo.Substring(4, 2),
				};

				this.cboDepartamento.SelectedValue = Convert.ToInt32( ubigeo[0] );
				this.cboDepartamento_SelectionChangeCommitted( this.cboDepartamento, EventArgs.Empty );

				this.cboProvincia.SelectedIndex = -1;
				this.cboProvincia.SelectedValue = Convert.ToInt32(ubigeo[1]).ToString();
				this.cboProvincia_SelectionChangeCommitted( this.cboProvincia, EventArgs.Empty );

				this.cboDistrito.SelectedValue = Convert.ToInt32( ubigeo[2] ).ToString();
				this.cboDistrito_SelectionChangeCommitted( this.cboDistrito, EventArgs.Empty );

				this.panelMain.Enabled = true;
				this.panelRegistro.Enabled = true;
				this.panelListado.Enabled = false;
				this.tabControl.SelectedTab = this.tabPageRegistro;
			}else
			{
				RestoreDataTocontrols rest = new RestoreDataTocontrols( this.RestoreData );
				this.Invoke( rest );
			}
		}

		#endregion

		private void frm_Branches_Load( object sender, EventArgs e )
		{
			this.cboDepartamento.DropDownHeight = 106;
			this.cboProvincia.DropDownHeight = 106;
			this.cboDistrito.DropDownHeight = 106;

			this.LoadSucursales();
			this.LoadUbigeoData();

			if ( dgvListado.Rows.Count > 0 )
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
				this.btnBuscar.Enabled = true;
				this.txtBuscar.Enabled = true;
			}
			else
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.btnBuscar.Enabled = false;
				this.txtBuscar.Enabled = false;
			}

			this.tabControl.SelectedTab = this.tabPageListado;
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.panelRegistro.Enabled = true;
			this.panelListado.Enabled = false;
			this._submitInsert = true;
			this.tabControl.SelectedTab = this.tabPageRegistro;
			this.txtDireccion.Focus();
		}

		private void AsignDataAndValidate_TextBox_Leave( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;

			switch ( txt.Name )
			{
				case "txtDireccion":
					this._tBranch.Address = txt.Text.Trim();
					break;
				case "txtCodigoLocal":
					this._tBranch.LocalCode = txt.Text.Trim();
					break;
				case "txtTelefono":
					this._tBranch.Phone = txt.Text.Trim();
					break;
				case "txtEmail":
					this._tBranch.Email = txt.Text.Trim();
					break;
				case "txtLatitud":
					this._tBranch.Latitud = txt.Text.Trim();
					break;
				case "txtLongitud":
					this._tBranch.Longitud = txt.Text.Trim();
					break;
			}
		}

		private void nudZoom_Leave( object sender, EventArgs e )
		{
			NumericUpDown num = ( NumericUpDown ) sender;
			this._tBranch.Zoom = (int) num.Value;
		}

		private void chboPrincipal_CheckedChanged( object sender, EventArgs e )
		{
			MetroCheckBox chk = ( MetroCheckBox ) sender;
			this._tBranch.IsMain = chk.CheckState == CheckState.Checked ? true : false;
		}

		private void cboDepartamento_SelectionChangeCommitted( object sender, EventArgs e )
		{
			if ( ! this.cboDepartamento.InvokeRequired )
			{
				ComboBox cbo = ( ( ComboBox ) sender );

				if ( cbo.SelectedValue != null )
				{
					this.cboProvincia.ValueMember = "ClaveUbigeo";
					this.cboProvincia.DisplayMember = "NombreProvincia";

					this.cboProvincia.DataSource = this._data.Tables["Provincias"].Select( "Cod_Departamento=" + cbo.SelectedValue );

					this.cboProvincia.SelectedIndex = -1;
					this.cboProvincia.Text = "Seleccione...";

					if ( this.cboDistrito.Items.Count > 0 ) this.cboDistrito.DataSource = null;

					this.cboDistrito.SelectedIndex = -1;
					this.cboDistrito.Text = "Seleccione...";

					this._tBranch.Ubigeo = "";
				}
				else
				{
					this.cboDistrito.DataSource = null;
					this.cboProvincia.DataSource = null;

					this.cboDistrito.Items.Clear();
					this.cboDistrito.DropDownHeight = 106;

					this.cboProvincia.Items.Clear();
					this.cboProvincia.DropDownHeight = 106;

					this.cboDistrito.Text = "Seleccione...";
					this.cboProvincia.Text = "Seleccione...";
					this.cboDepartamento.Text = "Seleccione...";

					this._tBranch.Ubigeo = "";
				}
				
			}
			else
			{
				ChangeStateUbigeo state = new ChangeStateUbigeo( cboDepartamento_SelectionChangeCommitted );
				this.Invoke( state, new object[] { sender, e } );
			}
		}

		private void cboProvincia_SelectionChangeCommitted( object sender, EventArgs e )
		{
			if ( ! this.cboDistrito.InvokeRequired )
			{
				ComboBox cbo = ( ( ComboBox ) sender );

				if ( cbo.SelectedValue != null )
				{
					var strQuery = this._data.Tables["Provincias"].Select( "ClaveUbigeo = " + cbo.SelectedValue + "AND Cod_Departamento=" +
					this.cboDepartamento.SelectedValue );

					DataRow[] codProvincia = strQuery;
					Object[] cods = codProvincia[0].ItemArray;

					this.cboDistrito.ValueMember = "ClaveUbigeo";
					this.cboDistrito.DisplayMember = "NombreDistrito";
					this.cboDistrito.DataSource = this._data.Tables["Distritos"].Select( "Cod_Provincia=" + cods[0].ToString() );
					this.cboDistrito.SelectedIndex = -1;
					this.cboDistrito.Text = "Seleccione...";
					this._tBranch.Ubigeo = "";
				}
				else
				{
					this.cboDistrito.DataSource = null;

					this.cboDistrito.Items.Clear();
					this.cboDistrito.DropDownHeight = 106;

					this.cboDistrito.Text = "Seleccione...";

					this._tBranch.Ubigeo = "";
				}
			}
			else
			{
				ChangeStateUbigeo ubi = new ChangeStateUbigeo( this.cboProvincia_SelectionChangeCommitted );
				this.Invoke( ubi, new object[] { sender, e } );
			}
		}

		private void cboDistrito_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ( ComboBox ) sender );

			var depa = Convert.ToInt32( this.cboDepartamento.SelectedValue );
			var prov = Convert.ToInt32( this.cboProvincia.SelectedValue );
			var dist = Convert.ToInt32( cbo.SelectedValue );

			string ubigeo = ( depa < 10 ) ? "0" + depa : depa.ToString();
			ubigeo += ( prov < 10 ) ? "0" + prov : prov.ToString();
			ubigeo += ( dist < 10 ) ? "0" + dist : dist.ToString();

			this._tBranch.Ubigeo = ubigeo;
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateData() ) return;

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
			this._cBranch.Data = this._tBranch;

			this._hilo.Start();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
		}

		private void frm_Branches_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}

		private void btnPreview_Click( object sender, EventArgs e )
		{
			if ( ! string.IsNullOrWhiteSpace( this.txtLongitud.Text.Trim() ) && 
					! string.IsNullOrWhiteSpace( this.txtLatitud.Text.Trim() ) )
			{
				mdl_Preview pre = new mdl_Preview();
				pre.Latitud = this.txtLatitud.Text.Trim();
				pre.Longitud = this.txtLongitud.Text.Trim();
				pre.Zoom = (int) this.nudZoom.Value;

				pre.Owner = this;
				pre.ShowDialog( this );
			}
		}

		private void dgvListado_CellMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
		{
			if ( e.RowIndex >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindBranch ) );

				this._codigoBranch = this.dgvListado.CurrentRow.Cells[0].Value.ToString();

				this.panelMain.Enabled = false;
				this._submitInsert = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
		}

		private void dgvListado_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter && this.dgvListado.CurrentCell.RowIndex >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindBranch ) );

				this._codigoBranch = this.dgvListado.CurrentRow.Cells[0].Value.ToString();

				this.panelMain.Enabled = false;
				this._submitInsert = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
			else if( e.KeyData == Keys.Delete && this.dgvListado.CurrentCell.RowIndex >= 0 )
			{
				DialogResult result = MetroMessageBox.Show( this, "Si realmente deseas eliminar esta fila presiona OK", "¿Deseas Eliminar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );

				if ( result == DialogResult.OK )
				{
					this._hilo = new Thread( new ThreadStart( this.SubmitDelete ) );

					this._codigoBranch = this.dgvListado.CurrentRow.Cells[0].Value.ToString();

					this.panelMain.Enabled = false;
					this._submitInsert = false;
					this.pgsLoading.Visible = true;

					this._hilo.Start();
				}
			}

			e.Handled = true;
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this._inAction = false;
			this.Close();
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentCell.RowIndex >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindBranch ) );

				this._codigoBranch = this.dgvListado.CurrentRow.Cells[0].Value.ToString();

				this.panelMain.Enabled = false;
				this._submitInsert = false;
				this.pgsLoading.Visible = true;

				this._hilo.Start();
			}
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentCell.RowIndex >= 0 )
			{
				DialogResult result = MetroMessageBox.Show( this, "Si realmente deseas eliminar esta fila presiona OK", "¿Deseas Eliminar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );

				if ( result == DialogResult.OK )
				{
					this._hilo = new Thread( new ThreadStart( this.SubmitDelete ) );

					this._codigoBranch = this.dgvListado.CurrentRow.Cells[0].Value.ToString();

					this.panelMain.Enabled = false;
					this._submitInsert = false;
					this.pgsLoading.Visible = true;

					this._hilo.Start();
				}
			}
		}

		private void txtBuscar_TextChanged( object sender, EventArgs e )
		{
			this._data.Tables["Sucursal"].DefaultView.RowFilter = ( "Address Like '%" + this.txtBuscar.Text + "%' OR LocalCode like '%" + this.txtBuscar.Text + "%'" );
			this.dgvListado.DataSource = this._data.Tables["Sucursal"].DefaultView;
		}

		
	}
}
