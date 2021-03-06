﻿using System;
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

namespace LawrApp.Control_Material
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

		delegate void LoadtoDatagrid( List<tMaterial> material );
		
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

			List<tMaterial> mater = this._cMaterial.Listar();

			if ( mater == null )
				mater = this._cMaterial.Listar();

			if ( mater != null )
			{
				if ( mater.Any() )
				{
					this.loadDataToDatagrid( mater );

					this.btnModificar.Enabled = true;
					this.btnEliminar.Enabled = true;

					this.panelMain.Enabled = true;
					this.pgsLoad.Visible = false;
				}
				else
				{
					this.pgsLoad.Visible = false;
					this.btnEliminar.Enabled = false;
					this.btnModificar.Enabled = false;
					this.txtFiltrar.Enabled = false;
					this.btnbuscar.Enabled = false;
					MetroMessageBox.Show( this, "No se encontraron datos registrados", "Lista Vacia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
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
			this._inAction = true;

			tMaterial material = this._cMaterial.Find( this._codMaterial );

			if ( this._objMaterial != null )
			{
				this._codMaterial = material.Codigo;
				this._codMarca = material.Marca.Codigo;
				this._codCategoria = material.Category.Codigo;

				this.cboCategoria.SelectedValue = this._codCategoria;
				
				if ( this._codMarca > 0 )
				{
					this.cboMarca.SelectedValue = this._codMarca;
				}
				else
				{
					this.cboMarca.SelectedIndex = -1;
					this.cboMarca.Text = "";
				}

				this.txtDescripcion.Text = material.Description;
				this.txtModelo.Text = material.Model;
				this.txtCostoReparacion.Text = material.RestorationCost;
				this.txtObservaciones.Text = material.Observation;

				this.lblValidateCategoria.Visible = false;
				this.lblValidateDescripcion.Visible = false;

				this.tabpageMain.SelectedIndex = 1;
				this.pgsLoad.Visible = false;
				this.panelMain.Enabled = true;
				this.panelRegister.Enabled = true;
				this.panelSearch.Enabled = false;
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show( this, this._cMaterial.EXception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		private void SubmitInsertOrUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( !this._gotoModify )
			{
				tMaterial material = this._cMaterial.Insert();

				if ( material != null )
				{
					//Agregando a datatable
					object[] newRow = new object[3]
					{
						material.Codigo,
						material.Description + " - " + material.Category.Name,
						material.ModifiedDate
					};

					this._data.Tables["ListaMaterial"].Rows.Add( newRow );

					this.RefreshMarcaAndCategory( material );

					this.pgsLoad.Visible = false;

					MetroMessageBox.Show( this, "El Material a sido registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.panelMain.Enabled = true;

					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show( this, this._cMaterial.EXception, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.panelMain.Enabled = true;
				}
			}
			else
			{
				this._cMaterial.DataMaterial.Codigo = this._codMaterial;

				tMaterial material = this._cMaterial.Update( this._codMaterial );

				if ( material != null )
				{
					DataRow[] row = this._data.Tables["ListaMaterial"].Select("Codigo='" + material.Codigo + "'");
					
					row[0]["Description"] = material.Description + " - " + material.Category.Name;
					row[0]["ModifiedDate"] = material.ModifiedDate;

					this.RefreshMarcaAndCategory( material );

					this.pgsLoad.Visible = false;
					MetroMessageBox.Show( this, "El Material a sido Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question );
					this.panelMain.Enabled = true;

					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show( this, this._cMaterial.EXception, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.panelMain.Enabled = true;
				}
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( this._cMaterial.Delete( this._codMaterial ) )
			{
				DataRow[] row = this._data.Tables["ListaMaterial"].Select( "Codigo='" + this._codMaterial + "'" );
				
				if( row.Any() ) this._data.Tables["ListaMaterial"].Rows.Remove( row[0] );

				this.pgsLoad.Visible = false;

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

		void loadDataToDatagrid( List<tMaterial> materiales )
		{
			if ( ! this.InvokeRequired )
			{
				this._data.Tables["ListaMaterial"].Clear();

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

				this.dgvListado.DataSource = this._data.Tables["ListaMaterial"];

				this.dgvListado.Columns["Codigo"].Visible = false;

				this.dgvListado.Columns["Description"].FillWeight = 140;
				this.dgvListado.Columns["ModifiedDate"].FillWeight = 70;

				this.dgvListado.Columns["Description"].ReadOnly = true;
				this.dgvListado.Columns["ModifiedDate"].ReadOnly = true;
				this.dgvListado.Columns["Stock"].Visible = false;

				this.dgvListado.Columns["Description"].HeaderText = "Descripcion";
				this.dgvListado.Columns["ModifiedDate"].HeaderText = "Ult. Modificacion";
			}
			else
			{
				LoadtoDatagrid loadTo = new LoadtoDatagrid( this.loadDataToDatagrid );
				this.Invoke( loadTo, new object[] { materiales } );
			}
		}

		void RefreshMarcaAndCategory( tMaterial material )
		{
			//Actualizando lista de marcas
			DataRow[] rowMarca = this._data.Tables["ListaMarca"].Select( "Codigo='" + material.Marca.Codigo + "'" );

			if ( !rowMarca.Any() )
			{
				object[] newMarca = new object[3]
						{
							material.Marca.Codigo,
							material.Marca.Name,
							material.ModifiedDate
						};

				this._data.Tables["ListaMarca"].Rows.Add( newMarca );
			}

			//Actualizando Lista de Categorias
			DataRow[] rowCategory = this._data.Tables["listaCategoria"].Select( "Codigo='" + material.Category.Codigo + "'" );

			if ( !rowCategory.Any() )
			{
				object[] newCategory = new object[3]
						{
							material.Category.Codigo,
							material.Category.Name,
							material.ModifiedDate
						};

				this._data.Tables["listaCategoria"].Rows.Add( newCategory );
			}
		}

		void ActionForDelete()
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

				this.panelMain.Enabled = true;
				this.pgsLoad.Visible = true;

				this._codMaterial = Convert.ToInt32( this.dgvListado.CurrentRow.Cells[0].Value );

				this._hilo.Start();
			}
		}

		void ActionForModification()
		{
			this._hilo = new Thread( new ThreadStart( this.FindMaterial ) );

			this._codMaterial = Convert.ToInt32( this.dgvListado.CurrentRow.Cells[0].Value );

			this._gotoModify = true;
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		void ResetControls()
		{
			this.txtDescripcion.Clear();
			this.txtModelo.Clear();
			this.txtCostoReparacion.Clear();
			this.txtObservaciones.Clear();

			this.cboCategoria.SelectedIndex = -1;
			this.cboCategoria.Text = "";
			this._codMarca = 0;
			this._isNewMarca = false;

			this.cboMarca.SelectedIndex = -1;
			this.cboMarca.Text = "";
			this._codCategoria = 0;
			this._isNewCategoria = false;

			this.lblValidateCategoria.Visible = true;
			this.lblValidateDescripcion.Visible = true;

			if ( this.dgvListado.Rows.Count > 0 )
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
				this.txtFiltrar.Enabled = true;
				this.dgvListado.Enabled = true;
				this.btnbuscar.Enabled = true;
			}
			else
			{
				this.btnModificar.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.txtFiltrar.Enabled = false;
				this.dgvListado.Enabled = false;
				this.btnbuscar.Enabled = false;
			}

			this.panelRegister.Enabled = false;
			this.panelSearch.Enabled = true;

			this._gotoModify = false;
			this.panelMain.Enabled = true;
			this.tabpageMain.SelectedIndex = 0;
		}

		void JoinData()
		{
			this._cMaterial.DataMaterial.Description = this.txtDescripcion.Text;

			//if es nuevo registro de categoria
			if ( this._isNewCategoria )
				this._cMaterial.DataCategoria.Name = this.cboCategoria.Text;
			else
				this._cMaterial.DataCategoria.Codigo = this._codCategoria;

			if ( ! string.IsNullOrWhiteSpace( this.cboMarca.Text ) || cboMarca.SelectedIndex >= 0 )
			{
				if ( this._isNewMarca )
					this._cMaterial.DataMarca.Name = this.cboMarca.Text;
				else
					this._cMaterial.DataMarca.Codigo = this._codMarca;
			}
			else
			{
				this._cMaterial.DataMarca.Name = string.Empty;
				this._cMaterial.DataMarca.Codigo = 0;
			}

			this._cMaterial.DataMaterial.Model = this.txtModelo.Text;
			this._cMaterial.DataMaterial.RestorationCost = this.txtCostoReparacion.Text;
			this._cMaterial.DataMaterial.Observation = this.txtObservaciones.Text;
		}

		bool ValidateData()
		{
			if ( string.IsNullOrWhiteSpace( this.txtDescripcion.Text ) )
			{
				this.toltipValid.Show( "Descripcion requerida", this.txtDescripcion, 2500 );
				this.txtDescripcion.Focus();
				return false;
			}

			if ( string.IsNullOrWhiteSpace( this.cboCategoria.Text ) && cboCategoria.SelectedIndex < 0 )
			{
				this.toltipValid.Show( "Categoria requerida", this.cboCategoria, 2500 );
				this.cboCategoria.Focus();
				return false;
			}

			return true;
		}

		#endregion

		private void frm_Material_Load( object sender, EventArgs e )
		{
			this.tabpageMain.SelectedTab = this.tabpagMaterial;
			this.cboCategoria.ValueMember = "Codigo";
			this.cboCategoria.DisplayMember = "Name";
			this.cboCategoria.DataSource = this._data.Tables["ListaCategoria"];
			this.cboCategoria.SelectedIndex = -1;
			this.cboCategoria.Text = "";

			this.cboMarca.ValueMember = "Codigo";
			this.cboMarca.DisplayMember = "Name";
			this.cboMarca.DataSource = this._data.Tables["ListaMarca"];
			this.cboMarca.SelectedIndex = -1;
			this.cboMarca.Text = "";

			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void frm_Material_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.panelSearch.Enabled = false;
			this.panelRegister.Enabled = true;
			this.tabpageMain.SelectedIndex = 1;
			this._gotoModify = false;
			this._cMaterial.DataMaterial = new tMaterial();
			this._cMaterial.DataCategoria = new tCategoria();
			this._cMaterial.DataMarca = new tMarca();
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateData() ) return;

			this._hilo = new Thread( new ThreadStart( this.SubmitInsertOrUpdate ) );

			this.pgsLoad.Visible = true;
			this.panelMain.Enabled = false;
			this._inAction = true;

			this.JoinData();

			this._hilo.Start();
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentRow.Index >= 0 )
				this.ActionForModification();
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentRow.Index >= 0)
				this.ActionForDelete();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void txtDescripcion_TextChanged( object sender, EventArgs e )
		{
			this.lblValidateDescripcion.Visible = string.IsNullOrEmpty( this.txtDescripcion.Text ) ? true : false;
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

		private void cboCategoria_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			this.lblValidateCategoria.Visible = false;

			this._codCategoria = Convert.ToInt32( cbo.SelectedValue );
			this._isNewCategoria = false;
		}

		private void cboCategoria_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			try
			{
				if ( ! string.IsNullOrWhiteSpace(cbo.Text) )
				{
					DataRow[] dt = this._data.Tables["ListaCategoria"].Select( "Name = '" + cboCategoria.Text + "'" );

					if ( dt.Any() )
					{
						this._codCategoria = Convert.ToInt32( dt[0]["Codigo"] );
						this._isNewCategoria = false;
						this.lblValidateCategoria.Visible = false;
					}
					else
					{
						this._codCategoria = 0;
						this._isNewCategoria = true;
					}

				}
				else
				{
					this._codCategoria = 0;
					this._isNewCategoria = false;
					cbo.SelectedValue = null;
					this.lblValidateCategoria.Visible = true;
				}
				
			}
			catch ( Exception ex ) { }
		}

		private void cboCategoria_KeyDown( object sender, KeyEventArgs e )
		{
			if ( char.IsLetter( ( char ) e.KeyData ) || e.KeyData == Keys.Space )
			{
				this._isNewCategoria = true;
				this._codCategoria = 0;
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

			this._codMarca = Convert.ToInt32( cbo.SelectedValue );
			this._isNewMarca = false;
		}

		private void cboCategoria_TextChanged( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;
			this.lblValidateCategoria.Visible = (cbo.SelectedIndex < 0) ? true : false;
		}

		private void cboMarca_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			if ( ! string.IsNullOrWhiteSpace( cbo.Text ) && cbo.SelectedValue == null )
			{
				try
				{
					if ( ! string.IsNullOrWhiteSpace( cbo.Text ) )
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
					else
					{
						this._codMarca = 0;
						this._isNewMarca = false;
					}
				}

				catch ( Exception ex ) { }
			}
		}

		private void cboMarca_KeyDown( object sender, KeyEventArgs e )
		{
			if ( char.IsLetter( ( char ) e.KeyData ) || e.KeyData == Keys.Space )
			{
				this._isNewMarca = true;
				this._codMarca = 0;
			}
			else
			{
				if ( e.KeyData != Keys.Down && e.KeyData != Keys.Up && e.KeyData != Keys.Right && e.KeyData != Keys.Left && e.KeyData != Keys.Back )
					e.SuppressKeyPress = true;
			}
		}

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( this.dgvListado.CurrentRow.Index >= 0 )
				this.ActionForModification();
		}

		private void dgvListado_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
			{
				if ( this.dgvListado.CurrentRow.Index >= 0 )
					this.ActionForModification();
			}
			if ( e.KeyData == Keys.Delete )
			{
				if ( this.dgvListado.CurrentRow.Index >= 0 )
					this.ActionForDelete();
			}
			else if ( e.KeyData != Keys.Up && e.KeyData != Keys.Down && e.KeyData != Keys.Left && e.KeyData != Keys.Right )
			{
				e.Handled = true;
			}
		}

	}
}
