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
using System.Threading;
using ControlMaterial;
using Objects.Tables;

namespace LawrApp.Control_Material
{
	public partial class mdl_Materiales_nc : MetroForm
	{
		private DataGeneral _data;
		private Material _cMaterial = new Material();
		private Thread _hilo;

		private bool _inAction = false;
		private bool _viewStock = false;

		public delegate void getMaterial( int Codigo );
		public event getMaterial SendMaterial;

		public mdl_Materiales_nc( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		public bool ViewStock
		{
			get { return this._viewStock; }
			set { this._viewStock = value; }
		}

		void ReloadData(  )
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<tMaterial> materiales = this._cMaterial.Listar();

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
			
			this.pgsLoading.Visible = false;
			this.panelMain.Enabled = true;

			this._inAction = false;
			this._hilo.Abort();
		}

		private void mdl_Materiales_nc_Load( object sender, EventArgs e )
		{
			this._data.Tables["ListaMaterial"].DefaultView.RowFilter = string.Empty;
			this.dgvListado.DataSource = this._data.Tables["ListaMaterial"];

			this.dgvListado.Columns[0].Visible = false;

			if ( this.ViewStock )
			{
				this.dgvListado.Columns[2].Visible = true;
				this.dgvListado.Columns[2].FillWeight = 25;
				this.dgvListado.Columns["ModifiedDate"].Visible = false;
			}
			else
			{
				this.dgvListado.Columns["ModifiedDate"].Visible = true;
				this.dgvListado.Columns["ModifiedDate"].FillWeight = 65;
				this.dgvListado.Columns[2].Visible = false;
			}
			

			this.dgvListado.Columns["Description"].ReadOnly = true;
			this.dgvListado.Columns["ModifiedDate"].ReadOnly = true;

			

			this.dgvListado.Columns["Description"].HeaderText = "Descripcion";
			this.dgvListado.Columns["ModifiedDate"].HeaderText = "Ult. Modificacion";
		}

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			DataGridView dgv = ( DataGridView ) sender;

			if ( dgv.CurrentRow.Index >= 0 )
			{
				this.SendMaterial( Convert.ToInt32( dgv.Rows[e.RowIndex].Cells["Codigo"].Value ) );
				this.Close();
			}
		}

		private void dgvListado_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
			{
				DataGridView dgv = ( DataGridView ) sender;

				if ( dgv.CurrentRow.Index >= 0 )
				{
					this.SendMaterial( Convert.ToInt32( dgv.CurrentRow.Cells["Codigo"].Value ) );
					this.Close();
				}
			}
			else if( e.KeyData != Keys.Up && e.KeyData != Keys.Down )
			{
				e.Handled = true;
			}
		}

		private void btnAgregar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.CurrentRow != null )
			{
				if ( this.dgvListado.CurrentRow.Index >= 0 )
				{
					this.SendMaterial( Convert.ToInt32( this.dgvListado.CurrentRow.Cells["Codigo"].Value ) );
					this.Close();
				}
			}
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btnReload_Click( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.ReloadData ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._hilo.Start();
		}

		private void mdl_Materiales_nc_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}

		private void btnbuscar_Click( object sender, EventArgs e )
		{
			this._data.Tables["ListaMaterial"].DefaultView.RowFilter = ( "Description Like '%" + this.txtfiltro.Text + "%'" );
			this.dgvListado.DataSource = this._data.Tables["ListaMaterial"].DefaultView;

			if ( this.dgvListado.Rows.Count == 0 )
				this.btnAgregar.Enabled = false;
			else
				this.btnAgregar.Enabled = true;
		}

		private void txtfiltro_TextChanged( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;

			this._data.Tables["ListaMaterial"].DefaultView.RowFilter = ( "Description Like '%" + txt.Text + "%'" );
			this.dgvListado.DataSource = this._data.Tables["ListaMaterial"].DefaultView;

			if ( this.dgvListado.Rows.Count == 0 )
				this.btnAgregar.Enabled = false;
			else
				this.btnAgregar.Enabled = true;
		}
	}
}
