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
using ControlMaterial;
using Objects.Tables;

namespace LawrApp.Control_Material
{
	public partial class frm_AssignMaterials : MetroForm
	{
		private Thread _hilo;
		private DataGeneral _data;
		private Material _cMaterial = new Material();

		private int _codigoMaterial = 0;
		private int _codigoSalon = 0;
		private int _cantidad = 0;

		private bool _inAction = false;

		private delegate void ReturnFocus( Control ctrl );
		private delegate void RefreshTable( List<tMaterialSalon> materiales, bool IsAsign );
		private delegate void RefreshBeforeDelete( List<string> Claves );

		public frm_AssignMaterials( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREADS

		void LoadDataMaterial()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<tMaterial> materiales = this._cMaterial.Listar();

			if ( materiales == null )
				materiales = this._cMaterial.Listar();

			this._data.Tables["ListaMaterial"].Clear();

			if ( materiales != null )
			{
				if ( materiales.Any() )
				{
					foreach ( tMaterial Items in materiales )
					{
						object[] temp = new object[4] 
						{ 
							Items.Codigo, 
							Items.Description,
							Items.Stock,
							Items.ModifiedDate
						};

						this._data.Tables["ListaMaterial"].Rows.Add( temp );
					}

					this.pgsLoading.Visible = false;
					this.panelMain.Enabled = true;
					this.ReturnFocusToControl( this.cboSalones );
				}
				else
				{
					this.pgsLoading.Visible = false;
					MetroMessageBox.Show( this,
						"NO EXISTEN DATOS DE MATERIALES REGISTRADOS, \nCIERRA ESTA VENTANA Y VE A REGISTRARLOS",
						"LISTA VACIA DE MATERIALES", MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this,
					"AL MOMENTO DE REALIZAR NO SE PUDO ENLAZAR CON EL SERVIDOR, \nCIERRA ESTA VENTANA Y VUELVA ABRIRLA",
					"ERROR AL MOMENTO DE CONECTARSE CON LA API", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}


			this._inAction = false;
			this._hilo.Abort();
		}

		void FindDataMaterial()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			tMaterial material = this._cMaterial.Find( this._codigoMaterial );

			if ( material != null )
			{
				this._codigoMaterial = material.Codigo;
				this.txtDescription.Text = material.Description;
				this.txtCategoria.Text = material.Category.Name;
				this.txtMarca.Text = material.Marca.Name;
				this.txtModelo.Text = material.Model;

				this.nudCantidad.Maximum = ( ( int ) material.Stock);

				if ( material.Stock < 1 )
				{
					this.btnAgregar.Enabled = false;
					this.nudCantidad.Enabled = false;
					this.nudCantidad.Minimum = 0;
					this.nudCantidad.Value = 0;
				}
				else
				{
					this.btnAgregar.Enabled = true;
					this.nudCantidad.Enabled = true;
					this.nudCantidad.Value = 1;
					this.nudCantidad.Minimum = 1;
				}

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this.btnCancelar.Enabled = true;

				this.ReturnFocusToControl( this.nudCantidad );
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void List_SalonMaterials()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<tMaterialSalon> materiales = this._cMaterial.ListforAula( this._codigoSalon );

			if ( materiales != null )
			{
				this.RefreshDataGrid( materiales, false );

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this.btnBuscar.Enabled = true;
				this.panelRegistros.Enabled = ( materiales.Any() ) ? true : false;
				this.btnAgregar.Enabled = false;
				this.nudCantidad.Enabled = false;
				this.btnCancelar.Enabled = false;

				this._codigoMaterial = 0;
				this.txtDescription.Clear();
				this.txtMarca.Clear();
				this.txtModelo.Clear();
				this.txtCategoria.Clear();
				this.nudCantidad.Value = this.nudCantidad.Minimum;
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "UN ERROR A OCURRIDO", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void AsignMaterialsToSalon()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<tMaterialSalon> materiales = this._cMaterial.AsignMaterialsToAula( 
				this._codigoSalon, this._codigoMaterial, this._cantidad 
			);

			if ( materiales != null )
			{
				this.RefreshDataGrid( materiales, true );

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;

				this.ResetControls();
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "UN ERROR A OCURRIDO", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void DeleteMaterialsToSalon()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<string> claves = new List<string>();

			foreach ( DataGridViewRow row in this.dgvListado.SelectedRows )
			{
					claves.Add( row.Cells[0].Value.ToString() );
			}

			string keysUrl = string.Join( "_", claves.ToArray() );

			if ( this._cMaterial.DeleteMaterialsToAula( this._codigoSalon, keysUrl ) )
			{
				this.RefreshDataGridBeforeDelete( claves );

				//foreach ( string clave in claves )
				//{
				//	var itemRow = this._data.Tables["ListaMaterialsAsign"].AsEnumerable().Where( r => r.Field<int>( "Codigo" ) == Convert.ToInt32(clave) );

				//	if ( itemRow.Any() )
				//	{
				//		foreach ( var row in itemRow.ToList() )
				//			row.Delete();
				//	}

				//	//DataRow[] itemRow = this._data.Tables["ListaMaterialsAsign"].Select( "Codigo='" + clave + "'" );
				//	//this._data.Tables["ListaMaterialsAsign"].Rows.RemoveAt( this._data.Tables["ListaMaterialsAsign"].Rows.IndexOf( itemRow[0] ) );
				//}

				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
				this.ReturnFocusToControl( this.btnBuscar );
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "ERROR DESDE EL SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this.ReturnFocusToControl( this.btnElimar );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ReturnFocusToControl( Control ctrl )
		{
			if ( !this.InvokeRequired )
			{
				ctrl.Focus();
			}
			else
			{
				ReturnFocus rf = new ReturnFocus( ReturnFocusToControl );
				this.Invoke( rf, new object[] { ctrl } );
			}
		}

		void getCodigoMaterial( int Codigo )
		{
			this._hilo = new Thread( new ThreadStart( FindDataMaterial ) );

			this._codigoMaterial = Codigo;

			this._inAction = true;
			this.pgsLoading.Visible = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();
		}

		void ResetControls()
		{
			this.btnBuscar.Enabled = true;
			this.btnAgregar.Enabled = false;
			this.btnCancelar.Enabled = false;
			this.nudCantidad.Enabled = false;

			this._codigoMaterial = 0;
			this._cantidad = 0;

			this.txtDescription.Clear();
			this.txtMarca.Clear();
			this.txtModelo.Clear();
			this.txtCategoria.Clear();
			this.nudCantidad.Value = this.nudCantidad.Minimum;

			this.panelRegistros.Enabled = ( this.dgvListado.Rows.Count > 0 ) ? true : false;
		}

		/// <summary>
		/// RECARGA EL DATATABLE EN EL HILO DE LA APLICACIÓN (IMPORTANTE)
		/// </summary>
		/// <param name="materiales">LISTA DE MATERIALES RECIBIDAS DEL SERVICIO WEB</param>
		void RefreshDataGrid( List<tMaterialSalon> materiales, bool IsAsign )
		{
			if ( ! this.InvokeRequired )
			{
				this._data.Tables["ListaMaterialsAsign"].Rows.Clear();

				if ( materiales.Any() )
				{
					foreach ( tMaterialSalon item in materiales )
					{
						string[] desc = item.Description.Split( '|' );

						object[] row = new object[4]
						{
							item.Codigo,
							item.Key,
							desc[0],
							( string.IsNullOrEmpty( desc[1] ) ) ? string.Empty : desc[1]
						};

						this._data.Tables["ListaMaterialsAsign"].Rows.Add( row );
					}

					if ( IsAsign )
					{
						DataRow[] rows = this._data.Tables["ListaMaterial"].Select( "Codigo='" + this._codigoMaterial + "'" );
						rows[0]["Stock"] = ( ( int ) rows[0]["Stock"] ) - this._cantidad;
					}
				}
			}
			else
			{
				RefreshTable rt = new RefreshTable( this.RefreshDataGrid );
				this.Invoke( rt, new object[] { materiales, IsAsign } );
			}
		}

		void RefreshDataGridBeforeDelete( List<string> Claves )
		{
			if ( ! this.InvokeRequired )
			{
				DataRow[] itemRow = null;

				itemRow = this._data.Tables["ListaMaterialsAsign"].AsEnumerable().Where(
				r => Claves.Contains( ( r.Field<int>( "Codigo" ) ).ToString() )
				).ToArray();

				foreach ( DataRow row in itemRow )
					this._data.Tables["ListaMaterialsAsign"].Rows.Remove( row );

				if ( this._data.Tables["ListaMaterialsAsign"].Rows.Count < 1 )
					this.panelRegistros.Enabled = false;

				this.dgvListado.DataSource = this._data.Tables["ListaMaterialsAsign"];

				this.txtFilters.Clear();
			}
			else
			{
				RefreshBeforeDelete rf = new RefreshBeforeDelete( RefreshDataGridBeforeDelete );
				this.Invoke( rf, new object[] { Claves } );
			}
		}

		#endregion

		private void frm_AssignMaterials_Load( object sender, EventArgs e )
		{
			if ( this._data.Tables["ListaSalones"].Rows.Count > 0 )
			{
				this.dgvListado.DataSource = this._data.Tables["ListaMaterialsAsign"];

				this.dgvListado.Columns["Codigo"].Frozen = false;
				this.dgvListado.Columns["Key"].Frozen = false;
				this.dgvListado.Columns["Description"].Frozen = false;
				this.dgvListado.Columns["Categoria"].Frozen = false;

				this.dgvListado.Columns["Codigo"].Visible = false;
				this.dgvListado.Columns["Key"].FillWeight = 40;
				this.dgvListado.Columns["Categoria"].FillWeight = 65;

				this.cboSalones.DisplayMember = "Description";
				this.cboSalones.ValueMember = "Codigo";
				this.cboSalones.DataSource = this._data.Tables["ListaSalones"];

				this.cboSalones.SelectedIndex = -1;
				this.cboSalones.Text = string.Empty;

				this._hilo = new Thread( new ThreadStart( LoadDataMaterial ) );

				this._inAction = true;
				this.pgsLoading.Visible = true;
				this.panelMain.Enabled = false;

				this._hilo.Start();
			}
			else
			{
				this.panelMain.Enabled = false;
				MetroMessageBox.Show( this,
					"NO HAY SALONES ASIGNADOS A ESTA SUCURSAL A LA CUAL PERTENECES.\n" +
					"PONTE EN CONTACTO CON EL ADMINISTRADO DEL SISTEMA PARA SOLUCIONAR ESTE INCONVENIENTE", 
					"MENSAJE", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Warning 
				);
			}
		}

		private void btnBuscar_Click( object sender, EventArgs e )
		{
			mdl_Materiales_nc search = new mdl_Materiales_nc( this._data );
			search.Owner = this;
			search.ViewStock = true;
			search.SendMaterial += new mdl_Materiales_nc.getMaterial( this.getCodigoMaterial );
			search.ShowDialog( this );
		}

		private void cboSalones_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this._codigoSalon = Convert.ToInt32(( ( MetroComboBox ) sender ).SelectedValue);

			this._hilo = new Thread( new ThreadStart( this.List_SalonMaterials ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._hilo.Start();
		}

		private void btnAgregar_Click( object sender, EventArgs e )
		{
			if ( ( ( int ) this.nudCantidad.Value ) < 0 ) return;

			this._hilo = new Thread( new ThreadStart( this.AsignMaterialsToSalon ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._cantidad = (int) this.nudCantidad.Value;

			this._hilo.Start();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void frm_AssignMaterials_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
				e.Cancel = true;
		}

		private void btnElimar_Click( object sender, EventArgs e )
		{
			if ( dgvListado.SelectedRows.Count == 0 || cboSalones.SelectedIndex < 0 ) return;

			DialogResult result = MetroMessageBox.Show( this,
				"Se Procedera a eliminar todas las filas que estan seleccionadas.\nSi estas seguro de continuar presiona OK",
				"Eliminando materiales", 
				MessageBoxButtons.OKCancel, 
				MessageBoxIcon.Warning 
			);

			if ( result == DialogResult.OK )
			{
				this._hilo = new Thread( new ThreadStart( this.DeleteMaterialsToSalon ) );

				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;
				this._codigoSalon = Convert.ToInt32( this.cboSalones.SelectedValue );
				this._inAction = true;

				this._hilo.Start();
			}
		}

		private void txtFilters_TextChanged( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;
			this._data.Tables["ListaMaterialsAsign"].DefaultView.RowFilter = ( "Description like '%" + txt.Text + "%' OR Key like '%" + txt.Text + "%'" );
			this.dgvListado.DataSource = this._data.Tables["ListaMaterialsAsign"].DefaultView;
		}
	}
}
