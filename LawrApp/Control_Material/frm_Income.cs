using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Customs
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using ControlMaterial;
using Objects.Tables;

namespace LawrApp.Control_Material
{
	public partial class frm_Income : MetroForm
	{
		private Thread _hilo;
		private DataGeneral _data;
		private Material _cMaterial = new Material();
		private Income_Expenses _inex = new Income_Expenses();

		private bool _inAction = false;
		private int _codigoMaterial = 0;

		private delegate void ReturnFocus( Control ctrl );

		public frm_Income( DataGeneral dts )
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
					this.ReturnFocusToControl( this.btnbuscar );
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
				this.txtDescripcion.Text = material.Description;
				this.txtCategoria.Text = material.Category.Name;
				this.txtMarca.Text = material.Marca.Name;
				this.txtModelo.Text = material.Model;

				this.cboTipoIngreso.Enabled = true;
				this.dtpFecha_Compra.Enabled = true;
				this.txtCosto.Enabled = true;
				this.nudCantidad.Enabled = true;
				this.txtNDocumento.Enabled = true;

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;

				this.lblValidateTipoIngreso.Visible = true;
				this.lblValidateCosto.Visible = true;
				this.lblValidateN_Documento.Visible = true;

				this.ReturnFocusToControl( cboTipoIngreso );
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

		private void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._inex.Insert() )
			{
				this.txtDescripcion.Clear();
				this.txtCategoria.Clear();
				this.txtMarca.Clear();
				this.txtModelo.Clear();
				this.txtNDocumento.Clear();
				this.txtCosto.Clear();
				
				this.cboTipoIngreso.SelectedIndex = -1;
				this.cboTipoIngreso.Text = string.Empty;

				this.dtpFecha_Compra.Value = dtpFecha_Compra.MaxDate;
				this.nudCantidad.Value = 1;

				this.nudCantidad.Enabled		= false;
				this.txtNDocumento.Enabled		= false;
				this.txtCosto.Enabled			= false;
				this.txtDescripcion.Enabled		= false;
				this.dtpFecha_Compra.Enabled	= false;
				this.cboTipoIngreso.Enabled		= false;

				this.lblValidateTipoIngreso.Visible = true;
				this.lblValidateCosto.Visible = true;
				this.lblValidateN_Documento.Visible = true;

				this._codigoMaterial = 0;

				MetroMessageBox.Show( this,
					"La Adquisicion se ha registrado correctamente",
					"Correcto",
					MessageBoxButtons.OK,
					MessageBoxIcon.Question
				);

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this.ReturnFocusToControl( this.btnbuscar );
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._inex.EXception, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this.ReturnFocusToControl( this.btnGuardar );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ReturnFocusToControl( Control ctrl )
		{
			if ( ! this.InvokeRequired )
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

			this.txtNDocumento.Clear();
			this.txtCosto.Clear();

			this.cboTipoIngreso.SelectedIndex = -1;
			this.cboTipoIngreso.Text = string.Empty;

			this.dtpFecha_Compra.Value = this.dtpFecha_Compra.MaxDate;
			this.nudCantidad.Value = 1;

			this._hilo.Start();

			this.lblValidateCosto.Visible = true;
			this.lblValidateCantidad.Visible = true;
			this.lblValidateN_Documento.Visible = true;
		}

		private bool ValidateData()
		{
			int duration = 2500;

			if ( this._codigoMaterial < 1 )
			{
				this.toltipValid.Show( "DEBES ESCOJE ALGUN MATERIAL", this.btnbuscar, duration );
				this.btnbuscar.Focus();
				return false;
			}

			if ( this.cboTipoIngreso.SelectedIndex < 0 )
			{
				this.toltipValid.Show( "Tipo de Ingreso requerido", this.cboTipoIngreso, duration );
				this.cboTipoIngreso.Focus();
				return false;
			}

			if ( this.cboTipoIngreso.SelectedIndex == 1 )
			{
				if ( string.IsNullOrWhiteSpace( this.txtCosto.Text ) )
				{
					this.toltipValid.Show( "Costo requerido", this.txtCosto, duration );
					this.txtCosto.Focus();
					return false;
				}
			}

			if ( this.nudCantidad.Value < 1 )
			{
				this.toltipValid.Show( "minimo un material", this.txtCosto, duration );
				this.txtNDocumento.Focus();
				return false;
			}

			if ( this.cboTipoIngreso.SelectedIndex == 1 )
			{
				if ( string.IsNullOrEmpty( this.txtNDocumento.Text ) )
				{
					this.toltipValid.Show( "Numero de Documento requerido", this.txtCosto, duration );
					this.txtNDocumento.Focus();
					return false;
				}
			}

			return true;
		}

		private void JoinData()
		{
			this._inex.Data.CodigoMaterial = this._codigoMaterial;
			this._inex.Data.TypeIncome = ( this.cboTipoIngreso.SelectedIndex == 1 ) ? true : false;
			this._inex.Data.TypeReg = false;
			this._inex.Data.Quantity = Convert.ToInt32( this.nudCantidad.Value );
			this._inex.Data.PurchaseDate = this.dtpFecha_Compra.Text;
			this._inex.Data.PurchasePrice = string.IsNullOrWhiteSpace(this.txtCosto.Text ) ? 0 : Convert.ToDecimal( this.txtCosto.Text );
			this._inex.Data.SerialNumber = this.txtNDocumento.Text;
		}

		#endregion

		private void frm_Income_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( LoadDataMaterial ) );

			this._inAction = true;
			this.pgsLoading.Visible = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();

			this.dtpFecha_Compra.MaxDate = DateTime.Now;
		}

		private void btnbuscar_Click( object sender, EventArgs e )
		{
			mdl_Materiales_nc search = new mdl_Materiales_nc( this._data );
			search.Owner = this;
			search.SendMaterial += new mdl_Materiales_nc.getMaterial( this.getCodigoMaterial );
			search.ShowDialog(this);
		}

		private void cboTipoIngreso_SelectionChangeCommitted( object sender, EventArgs e )
		{
			MetroComboBox mcbo = ( MetroComboBox ) sender;

			if ( mcbo.SelectedIndex == 0 )
			{
				this.txtCosto.Enabled = false;
				this.txtCosto.Clear();

				this.txtNDocumento.Enabled = true;
				this.nudCantidad.Enabled = true;
				this.dtpFecha_Compra.Enabled = true;

				this.lblValidateCantidad.Visible = false;
				this.lblValidateCosto.Visible = false;
				this.lblValidateN_Documento.Visible = false;
			}
			else
			{
				this.txtCosto.Enabled = true;
				this.nudCantidad.Enabled = true;
				this.dtpFecha_Compra.Enabled = true;
				this.txtNDocumento.Enabled = true;
				this.nudCantidad.Enabled = true;

				this.lblValidateCosto.Visible = true;
				this.lblValidateCantidad.Visible = true;
				this.lblValidateN_Documento.Visible = true;
			}

			this.lblValidateTipoIngreso.Visible = false;
		}

		private void txtCosto_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( this.txtCosto.Text.Contains( '.' ) )
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

		private void txtCosto_Leave( object sender, EventArgs e )
		{
			if ( this.cboTipoIngreso.SelectedIndex == 1 )
			{
				TextBox txt = ( TextBox ) sender;
				this.lblValidateCosto.Visible = string.IsNullOrWhiteSpace( txt.Text ) ? true : false;
			}
		}

		private void txtNDocumento_Leave( object sender, EventArgs e )
		{
			if ( this.cboTipoIngreso.SelectedIndex == 1 )
			{
				TextBox txt = ( TextBox ) sender;
				this.lblValidateN_Documento.Visible = string.IsNullOrWhiteSpace( txt.Text ) ? true : false;
			}
		}

		private void nudCantidad_Leave( object sender, EventArgs e )
		{
			NumericUpDown nud = (NumericUpDown) sender;
			this.lblValidateCantidad.Visible = ( ( int ) nud.Value ) < 1 ? true : false;
		}

		private void btnsalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void frm_Income_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
				e.Cancel = true;
		}

		private void btnGuardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateData() ) return;

			this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );

			this.JoinData();
			this.panelMain.Enabled = false;
			this.btnbuscar.Enabled = true;
			this.cboTipoIngreso.Enabled = true;
			this.pgsLoading.Visible = true;

			this._hilo.Start();
		}

	}
}
