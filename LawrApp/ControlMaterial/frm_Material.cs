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
using MetroFramework.Controls;
using MetroFramework.Forms;
using Objects.Processes;
using System.Threading;
using Objects.Tables;
using Options;
using ControlMaterial;

namespace LawrApp.ControlMaterial
{
	public partial class frm_Material : MetroForm
	{
		private Thread _hilo;
		private DataGeneral _data;
		private Material _cMaterial = new Material();
		private tMaterial _objMaterial = new tMaterial();

		private int _codMaterial;
		private int _codCategoria;
		private int _codMarca;

		private bool _isNewMarca     = false;
		private bool _isNewCategoria = false;
		private bool _inAction = false;

		private bool _gotoModify;

		public frm_Material( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region HILOS

		private void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			var mater = this._cMaterial.Listar();

			if ( mater != null )
			{
				if ( mater.Any() )
				{
					this._data.Tables["ListaMaterial"].Clear();

					foreach ( tMaterial Items in mater )
					{
						object[] temp = new object[3] 
						{ 
							Items.Codigo, 
							Items.Description,
							Items.ModifiedDate
						}; 

						this._data.Tables["ListaMaterial"].Rows.Add( temp );
					}

					this.dgvListado.DataSource = this._data.Tables["ListaMaterial"];

					this.dgvListado.Columns["Codigo"].Visible = false;

					this.dgvListado.Columns["Description"].FillWeight = 140;
					this.dgvListado.Columns["ModifiedDate"].FillWeight = 70;

					this.dgvListado.Columns["Description"].HeaderText = "Descripcion";
					this.dgvListado.Columns["ModifiedDate"].HeaderText = "Ult. Modificacion";

					this.btnModificar.Enabled = true;
					this.btnEliminar.Enabled = true;

					this.panelMain.Enabled = true;
					this.pgsLoad.Visible = false;
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show( this, "No se encontraron datos registrados", "Lista Vacia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
					this.btnEliminar.Enabled = false;
					this.btnModificar.Enabled = false;
					this.txtFiltrar.Enabled = false;
					this.btnbuscar.Enabled = false;
					this.panelMain.Enabled = true;
					
				}
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show( this, 
					this._cMaterial.EXception + "\nCierre la ventana e intentalo mas adelante.", 
					"Error al Consultar", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error 
				);

				this.panelMain.Enabled = false;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		private void FindMaterial()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._objMaterial = this._cMaterial.Find( this._codMaterial );

			if ( this._objMaterial != null )
			{
				this.txtDescripcion.Text = this._objMaterial.Description;
				this.cboCategoria.Text = this._objMaterial.Category.Name;
				this.cboMarca.Text = this._objMaterial.Marca.Name;

				this.txtModelo.Text = this._objMaterial.Model;
				this.txtCostoReparacion.Text = Convert.ToString( this._objMaterial.RestorationCost );
				this.txtObservaciones.Text = this._objMaterial.Observation;

				this.pgsLoad.Visible = false;
				this.panelRegister.Enabled = true;

				this.txtDescripcion.Focus();

				this.lblValidateCategoria.Visible = false;
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._hilo.Abort();
		}

		private void SubmitInsertOrUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( !this._gotoModify )
			{
				int codigo = this._cMaterial.Insert();

				if ( codigo > 0 )
				{
					if ( !this._isNewCategoria )
						this._cMaterial.DataCategoria.Name = this.cboCategoria.Text;

					if ( this.cboMarca.Text == "Seleccione..." )
						this._cMaterial.DataMarca.Name = string.Empty;

					this.pgsLoad.Visible = false;

					object[] d = new object[3]
					{
						codigo,
						this._cMaterial.DataMaterial.Description + "" + "_"  +
						this._cMaterial.DataMarca.Name + "" + "_"  +
						this._cMaterial.DataMaterial.Model + "" + "_" +
						this._cMaterial.DataCategoria.Name,
						DateTime.Now.ToString("yyyy-MM-dd H:mm:ss" )
					};

					this._data.Tables["ListaMaterial"].Rows.Add( d );


					this.panelSearch.Enabled = true;
					this.txtFiltrar.Text = string.Empty;
					this.btnbuscar.Enabled = true;

					this.tabpageMain.SelectedTab = this.tabpagMaterial;

					MetroMessageBox.Show( this, "El Material a sido registrado correctamente", "Correcto",
					MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.dgvListado.DataSource = this._data.Tables["ListaMaterial"];

					this.tabpageMain.SelectedTab = this.tabpagMaterial;

					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show( this, "Error al intentar registrar Material", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this._objMaterial = new tMaterial();
					this.panelMain.Enabled = true;
				}
			}
			else
			{
				if ( this._cMaterial.Update( this._codMaterial ) )
				{
					if ( !this._isNewCategoria )
						this._cMaterial.DataCategoria.Name = this.cboCategoria.Text;

					if ( !this._isNewMarca )
						this._cMaterial.DataMarca.Name = this.cboMarca.Text;

					this.dgvListado.CurrentRow.Cells[1].Value = this._cMaterial.DataMaterial.Description + "_" +
																this._cMaterial.DataMarca.Name + "_" +
																this._cMaterial.DataMaterial.Model + "_" +
																this._cMaterial.DataCategoria.Name;

					this.dgvListado.CurrentRow.Cells[2].Value = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );

					this.pgsLoad.Visible = false;

					MetroMessageBox.Show( this, "El Material a sido Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show( this, this._cMaterial.EXception, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.tabpageMain.SelectedTab = this.tabpagRegistro;
					this.panelMain.Enabled = true;
					this._objMaterial = new tMaterial();
				}
			}

			this._hilo.Abort();
		}

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( this._cMaterial.Delete( this._codMaterial ) )
			{
				this.pgsLoad.Visible = false;
				this.dgvListado.Rows.RemoveAt( this.dgvListado.CurrentRow.Index );
				MetroMessageBox.Show( this, "El Material a sido Eliminado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );

				if ( this.dgvListado.Rows.Count > 0 )
				{
					this.dgvListado.Enabled = true;
					this.panelSearch.Enabled = true;
					this.btnbuscar.Enabled = true;
					this.btnEliminar.Enabled = true;
					this.btnNuevo.Enabled = true;
					this.btnGuardar.Enabled = true;
					this.txtFiltrar.Enabled = true;
				}
				else
				{
					this.dgvListado.Enabled = false;
					this.txtFiltrar.Enabled = false;
					this.btnbuscar.Enabled = false;
					this.panelSearch.Enabled = true;
					this.btnSalir.Enabled = true;
					this.btnEliminar.Enabled = false;
					this.btnNuevo.Enabled = true;
					this.btnModificar.Enabled = false;
					this.btnGuardar.Enabled = false;
				}
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ActionForDelete()
		{
			if ( this.dgvListado.CurrentRow != null )
			{
				DialogResult result = MetroMessageBox.Show(
					this,
					"Realmente Deseas Eliminar EL Material seleccionado?\nPresiona Ok para Eliminar...",
					"ADVERTENCIA",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning
				);

				if ( result == DialogResult.OK )
				{
					this._hilo = new Thread( new ThreadStart( SubmitDelete ) );

					this.panelSearch.Enabled = false;
					this.btnbuscar.Enabled = false;
					this.pgsLoad.Visible = true;

					this._codMaterial = Convert.ToInt32( this.dgvListado.CurrentRow.Cells[0].Value );

					this._hilo.Start();
				}
			}
			else
				return;
		}

		void ResetControls()
		{
			this.txtDescripcion.Clear();
			this.cboCategoria.Text = "Seleccione...";
			this.cboMarca.Text = "Seleccione...";
			this.txtModelo.Clear();
			this.txtCostoReparacion.Clear();
			this.txtObservaciones.Clear();

			if ( this.dgvListado.Rows.Count > 0 )
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
				this.txtFiltrar.Enabled = true;
				this.dgvListado.Enabled = true;
				this.dgvListado.Enabled = true;
			}
			else
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.txtFiltrar.Enabled = false;
				this.dgvListado.Enabled = false;
				this.dgvListado.Enabled = false;
			}

			this._gotoModify = false;
			this._cMaterial.DataMaterial = new tMaterial();
		}

		void JoinData()
		{
			this._cMaterial.DataMaterial.Description = this.txtDescripcion.Text;

			//if es nuevo registro de categoria
			if ( this._isNewCategoria )
				this._cMaterial.DataCategoria.Name = this.cboCategoria.Text;
			else
				this._cMaterial.DataCategoria.Codigo = this._codCategoria;

			if ( this.cboMarca.Text != "Seleccione..." && !string.IsNullOrEmpty( this.cboMarca.Text ) )
			{
				if ( this._isNewMarca )
					this._cMaterial.DataMarca.Name = this.cboMarca.Text;
				else
					this._cMaterial.DataMarca.Codigo = this._codMarca;
			}

			this._cMaterial.DataMaterial.Model = this.txtModelo.Text;
			this._cMaterial.DataMaterial.RestorationCost = this.txtCostoReparacion.Text;
			this._cMaterial.DataMaterial.Observation = this.txtObservaciones.Text;
		}

		void ActionForModification()
		{
			this._hilo = new Thread( new ThreadStart( this.FindMaterial ) );
			this._gotoModify = true;

			this._codMaterial = Convert.ToInt32( this.dgvListado.CurrentRow.Cells[0].Value );

			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private bool ValidateData()
		{
			if ( string.IsNullOrWhiteSpace( this.txtDescripcion.Text ) )
			{
				this.toltipValid.Show( "Descripcion requerida", this.txtDescripcion, 3000 );
				this.txtDescripcion.Focus();
				return false;
			}

			if ( this.cboCategoria.Text == "Seleccione..." || string.IsNullOrEmpty( this.cboCategoria.Text ) )
			{
				this.toltipValid.Show( "Categoria requerida", this.cboCategoria, 3000 );
				this.cboCategoria.Focus();
				return false;
			}

			if ( string.IsNullOrEmpty( this.txtCostoReparacion.Text ) )
			{
				this.toltipValid.Show( "Costo de Reparacion requerido", this.txtCostoReparacion, 3000 );
				this.txtCostoReparacion.Focus();
				return false;
			}

			return true;
		}

		#endregion

		private void frmRegistrarMaterial_Load_1( object sender, EventArgs e )
		{
			this.cboCategoria.ValueMember = "Codigo";
			this.cboCategoria.DisplayMember = "Name";
			this.cboCategoria.DataSource = this._data.Tables["ListaCategoria"];
			this.cboCategoria.SelectedIndex = -1;
			this.cboCategoria.Text = "Seleccione...";

			this.cboMarca.ValueMember = "Codigo";
			this.cboMarca.DisplayMember = "Name";
			this.cboMarca.DataSource = this._data.Tables["ListaMarca"];
			this.cboMarca.SelectedIndex = -1;
			this.cboMarca.Text = "Seleccione...";

			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.panelSearch.Enabled = false;
			this.tabpageMain.SelectedTab = this.tabpagRegistro;
			this.lblValidateCategoria.Visible = true;
			this.panelRegister.Enabled = true;
			this.btnGuardar.Enabled = false;
			this.lblValidateCategoria.Visible = true;
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.panelSearch.Enabled = true;
			this.btnbuscar.Enabled = true;
			this.panelRegister.Enabled = false;
			this.ResetControls();
			this.dgvListado.Enabled = true;
			this.tabpageMain.SelectedTab = this.tabpagMaterial;
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentRow != null )
				this.ActionForModification();
			else
				return;
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateData() ) return;

			this._hilo = new Thread( new ThreadStart( this.SubmitInsertOrUpdate ) );

			this.btnGuardar.Enabled = false;
			this.JoinData();
			this.panelRegister.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void txtDescripcion_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this.txtDescripcion.Text ) )
				this.lblValidateDescripcion.Visible = true;
			else
				this.lblValidateDescripcion.Visible = false;
		}

		private void cboCategoria_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			if ( cbo.Text == "Seleccione..." && string.IsNullOrEmpty( cbo.Text ) && string.IsNullOrEmpty( this.txtCostoReparacion.Text ) )
				this.lblValidateCategoria.Visible = true;
			else
				this.lblValidateCategoria.Visible = false;

			this._codCategoria = Convert.ToInt32( cbo.SelectedValue );
			this._isNewCategoria = false;
		}

		private void cboCategoria_KeyDown( object sender, KeyEventArgs e )
		{
			if ( char.IsLetter( ( char ) e.KeyData ) )
			{
				this._isNewCategoria = true;
			}
			else
			{
				if ( e.KeyData != Keys.Down && e.KeyData != Keys.Up && e.KeyData != Keys.Right && e.KeyData != Keys.Left && e.KeyData != Keys.Back )
				{
					e.SuppressKeyPress = true;
				}
			}
		}

		private void cboMarca_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;
			this.lblValidateCategoria.Visible = false;

			this._codMarca = Convert.ToInt32( cbo.SelectedValue );
			this._isNewMarca = false;
		}

		private void cboMarca_KeyDown( object sender, KeyEventArgs e )
		{
			if ( char.IsLetter( ( char ) e.KeyData ) )
			{
				this._isNewMarca = true;
			}
			else
			{
				if ( e.KeyData != Keys.Down && e.KeyData != Keys.Up && e.KeyData != Keys.Right && e.KeyData != Keys.Left && e.KeyData != Keys.Back )
					e.SuppressKeyPress = true;
			}
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.Rows.Count > 0 )
				this.ActionForDelete();
		}

		private void txtFiltrar_TextChanged( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;
			this._data.Tables["ListaMaterial"].DefaultView.RowFilter = ( "Description Like '%" + this.txtFiltrar.Text + "%'" );
			this.dgvListado.DataSource = this._data.Tables["ListaMaterial"].DefaultView;

			if ( string.IsNullOrEmpty( this.txtFiltrar.Text ) )
				this._data.Tables["ListaMaterial"].DefaultView.RowFilter = string.Empty;

			if ( this.dgvListado.Rows.Count == 0 )
			{
				this.dgvListado.Enabled = false;
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
			}
			else
			{
				this.dgvListado.Enabled = true;
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
			}
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void txtCostoReparacion_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( this.txtCostoReparacion.Text.Contains( '.' ) )
			{
				if ( !char.IsDigit( e.KeyChar ) )
					e.Handled = true;
				if ( e.KeyChar == '\b' )
					e.Handled = false;
			}
			else
			{
				if ( !char.IsDigit( e.KeyChar ) )
					e.Handled = true;
				if ( e.KeyChar == '.' || e.KeyChar == '\b' )
					e.Handled = false;
			}
		}

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( this.dgvListado.CurrentRow != null )
				this.ActionForModification();
			else
				return;
		}

		private void dgvListado_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
			{
				if ( this.dgvListado.CurrentRow != null )
					this.ActionForModification();
				else
					return;
			}
			if ( e.KeyData == Keys.Delete )
			{
				if ( this.dgvListado.Rows.Count > 0 )
					this.ActionForDelete();
				else
					return;
			}
		}

		private void frmRegistrarMaterial_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}

		private void cboCategoria_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			if ( !string.IsNullOrEmpty( this.txtDescripcion.Text ) && !string.IsNullOrEmpty( cbo.Text )
				&& cbo.Text != "Seleccione..." && !string.IsNullOrEmpty( this.txtCostoReparacion.Text )
			   )
				this.btnGuardar.Enabled = true;
			else
				this.btnGuardar.Enabled = false;

			try
			{
				DataRow[] dt = this._data.Tables["ListaCategoria"].Select( "Name = '" + cboCategoria.Text + "'" );

				if ( dt.Length > 0 )
				{
					this._codCategoria = Convert.ToInt32( dt[0]["Codigo"] );
					this._isNewCategoria = false;

				}
				else
				{
					this._codCategoria = 0;
					this._isNewCategoria = true;
				}
			}

			catch ( Exception ex ) { }
		}

		private void cboMarca_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			if ( this.cboMarca.Text != "Seleccione..." && !string.IsNullOrEmpty( this.cboMarca.Text ) )
			{
				try
				{
					DataRow[] dt = this._data.Tables["ListaMarca"].Select( "Name = '" + this.cboMarca.Text + "'" );

					if ( dt.Length > 0 )
					{
						this._codMarca = Convert.ToInt32( dt[0]["Codigo"] );
						this._isNewMarca = false;
					}
					else
					{
						if ( !string.IsNullOrEmpty( this.cboMarca.Text ) )
						{
							this._codMarca = 0;
							this._isNewMarca = true;
						}
					}
				}

				catch ( Exception ex ) { }
			}
		}

		private void txtDescripcion_Leave( object sender, EventArgs e )
		{
			if ( !string.IsNullOrEmpty( this.txtDescripcion.Text ) &&
				!string.IsNullOrEmpty( cboCategoria.Text ) && cboCategoria.Text != "Seleccione..." &&
				!string.IsNullOrEmpty( this.txtCostoReparacion.Text ) )
				this.btnGuardar.Enabled = true;
			else
				this.btnGuardar.Enabled = false;
		}

		private void txtCostoReparacion_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this.txtCostoReparacion.Text ) )
				this.lblValidateCostoResparacion.Visible = true;
			else
				this.lblValidateCostoResparacion.Visible = false;
		}

		private void cboCategoria_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this.cboCategoria.Text ) )
				this.lblValidateCategoria.Visible = true;
			else
				this.lblValidateCategoria.Visible = false;
		}
	}
}
