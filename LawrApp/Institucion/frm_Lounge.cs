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
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Objects.Tables;
using Institution;

namespace LawrApp.Institucion
{
	public partial class frm_Lounge : MetroForm
	{
		private tSalon _tSal = new tSalon();
		private Lounge _lon = new Lounge();
		
		private Thread _hilo;
		
		private int _codigoLounge = 0;
		private bool _inAction;
		private bool _isInsert = false;

		delegate void ReturnFocusToControl( Control ctr );

		public frm_Lounge()
		{
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			List<tSalon> tSalon = this._lon.Listar();

			if ( tSalon != null )
			{
				if ( tSalon.Any() )
				{
					foreach ( tSalon item in tSalon )
					{
						object[] row = new object[4] 
						{
							item.Codigo,
							item.Name,
							item.MaxCapacity,
							item.ModifiedDate
						};

						this.dgvListado.Rows.Add( row );
					}

					this.pgsLoading.Visible = false;
					this.panelMain.Enabled = true;
					this.btnModificar.Enabled = true;
					this.btnEliminar.Enabled = true;
				}
				else
				{
					this.pgsLoading.Visible = false;
					MetroMessageBox.Show( this, "NO EXISTEN DATOS REGISTRADOS", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Warning );
					this.btnModificar.Enabled = false;
					this.btnEliminar.Enabled = false;
					this.panelMain.Enabled = true;
				}
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lon.EXception, "Error al Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._inAction = false;
			this._hilo.Abort();

		}

		void FindData()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			this._tSal = this._lon.Find( this._codigoLounge );

			if ( this._tSal != null )
			{
				this.txtNombre.Text = this._tSal.Name;
				this.lblNombre_Validator.Visible = false;
				this.nudCapacidad.Value = this._tSal.MaxCapacity;
				this.lblCapacidad_Validator.Visible = false;
				this.txtObservacion.Text = this._tSal.Observation;
				this._codigoLounge = this._tSal.Codigo;

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;

				this.gbGestion.Enabled = true;
				this.btnNuevo.Enabled = false;
				this.btnEliminar.Enabled = false;
				this.btnModificar.Enabled = false;

				this.ReturnFocus( this.txtNombre );
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lon.EXception, "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			int Codigo = this._lon.Insert();

			if ( Codigo > 0 )
			{
				object[] row = new object[4] 
				{
					Codigo,
					this.txtNombre.Text,
					(int) this.nudCapacidad.Value,
					DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
				};

				this.dgvListado.Rows.Add( row );

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._isInsert = false;
				this.ResetControls();
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lon.EXception, "ERROR AL INTENTAR REGISTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._inAction = true;

			if ( this._lon.Update( this._codigoLounge ) )
			{
				this.dgvListado.CurrentRow.Cells[1].Value = this.txtNombre.Text;
				this.dgvListado.CurrentRow.Cells[2].Value = ( int ) this.nudCapacidad.Value;
				this.dgvListado.CurrentRow.Cells[3].Value = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );

				pgsLoading.Visible = false;
				panelMain.Enabled = true;
				this._codigoLounge = 0;
				this._isInsert = false;
				this.ResetControls();
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lon.EXception, "ERROR AL MOMENTO DE MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._lon.Delete( this._codigoLounge ) )
			{
				this.dgvListado.Rows.RemoveAt( this.dgvListado.CurrentRow.Index );
				
				this.ResetControls();

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._codigoLounge = 0;

				this.ReturnFocus( this.btnNuevo );
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._lon.EXception, "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS	

		void ResetControls()
		{
			this.gbGestion.Enabled = false;
			this.txtNombre.Clear();
			this.txtObservacion.Clear();
			this.nudCapacidad.Value = 0;

			this.lblCapacidad_Validator.Visible = true;
			this.lblNombre_Validator.Visible = true;

			this.btnNuevo.Enabled = true;

			if ( this.dgvListado.Rows.Count > 0 )
			{
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
			}
			else
			{
				this.btnEliminar.Enabled = false;
				this.btnModificar.Enabled = false;
			}

			this._isInsert = false;
			this.pgsLoading.Visible = false;
			this.btnNuevo.Focus();
		}

		void ReturnFocus( Control ctr )
		{
			if ( ! this.InvokeRequired )
			{
				ctr.Focus();
			}
			else
			{
				ReturnFocusToControl ret = new ReturnFocusToControl( ReturnFocus );
				this.Invoke( ret, new object[] { ctr } );
			}
		}

		#endregion

		private void frm_Lounge_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._hilo.Start();
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this.btnNuevo.Enabled = false;
			this.btnModificar.Enabled = false;
			this.btnEliminar.Enabled = false;
			this.gbGestion.Enabled = true;
			
			this._isInsert = true;

			this.txtNombre.Focus();
		}

		private void AsignAndValidate_Leave( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;

			switch( txt.Name )
			{
				case "txtNombre": 
					this._tSal.Name = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? string.Empty : txt.Text;
					this.lblNombre_Validator.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
					break;
				case "txtObservacion":
					this._tSal.Observation = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? string.Empty : txt.Text;
					break;
			}
		}

		private void nudCapacidad_Leave( object sender, EventArgs e )
		{
			NumericUpDown num = ( NumericUpDown ) sender;

			this._tSal.MaxCapacity = (int) num.Value;
			this.lblCapacidad_Validator.Visible = ( ( int ) ( num.Value ) < 1 ) ? true : false;
		}

		private void btnDone_Click( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtNombre.Text ) || ( ( int ) this.nudCapacidad.Value ) < 1 ) return;

			if ( this._isInsert )
				this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );
			else
				this._hilo = new Thread( new ThreadStart( this.SubmitUpdate ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;
			this._lon.Data = this._tSal;

			this._hilo.Start();
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
		}

		private void dgvListado_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindData ) );

				DataGridView grid = (DataGridView) sender;
				
				this._codigoLounge = (int) grid.CurrentRow.Cells[0].Value;
				
				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;
				this._inAction = true;
				this._isInsert = false;

				this._hilo.Start();
			}
		}

		private void dgvListado_KeyDown( object sender, KeyEventArgs e )
		{
			int index = this.dgvListado.CurrentRow.Index;

			if ( e.KeyData == Keys.Enter )
			{
				if ( index >= 0 )
				{
					this._hilo = new Thread( new ThreadStart( this.FindData ) );

					DataGridView grid = ( DataGridView ) sender;

					this._codigoLounge = ( int ) grid.CurrentRow.Cells[0].Value;

					this.panelMain.Enabled = false;
					this.pgsLoading.Visible = true;
					this._inAction = true;
					this._isInsert = false;

					this._hilo.Start();
				}

				e.Handled = true;
			}
			else if ( e.KeyData == Keys.Delete )
			{
				DialogResult result = MetroMessageBox.Show( this, 
					"SI DESEAS REALMENTE ELIMINAR ESTE SALON, PRESIONA OK", 
					"ELIMINAR SALON SELECCIONADO", 
					MessageBoxButtons.OKCancel, 
					MessageBoxIcon.Warning, 
					MessageBoxDefaultButton.Button2 
				);

				if ( result == DialogResult.OK )
				{
					this._hilo = new Thread( new ThreadStart( this.SubmitDelete ) );

					DataGridView grid = ( DataGridView ) sender;

					this._codigoLounge = ( int ) grid.CurrentRow.Cells[0].Value;

					this.panelMain.Enabled = false;
					this.pgsLoading.Visible = true;
					this._inAction = true;
					this._isInsert = false;

					this._hilo.Start();
				}
			}
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			int index = this.dgvListado.CurrentRow.Index;

			if ( index >= 0 )
			{
				this._hilo = new Thread( new ThreadStart( this.FindData ) );

				this._codigoLounge = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;
				this._inAction = true;
				this._isInsert = false;

				this._hilo.Start();
			}
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			if ( this.dgvListado.Rows.Count <= 0 ) return;

			DialogResult result = MetroMessageBox.Show( this,
				"SI DESEAS REALMENTE ELIMINAR ESTE SALON, PRESIONA OK",
				"ELIMINAR SALON SELECCIONADO",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning,
				MessageBoxDefaultButton.Button2
			);

			if ( result == DialogResult.OK )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitDelete ) );

				this._codigoLounge = ( int ) this.dgvListado.CurrentRow.Cells[0].Value;

				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;
				this._inAction = true;
				this._isInsert = false;

				this._hilo.Start();
			}
		}

		private void frm_Lounge_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction ) e.Cancel = true;
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}
	}
}
