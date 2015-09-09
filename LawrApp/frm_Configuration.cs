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
using Access;

namespace LawrApp
{
	public partial class frm_Configuration : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;

		private int _codigoBranch = 0;

		private ConfigServer _cf = new ConfigServer();
		private InitialData _initial = new InitialData();

		delegate void LoadSucursales();

		public frm_Configuration( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();

			this.lblFullName.Text = this._cf.getAppSettings( "UserName" );
			this.lblCargo.Text = this._cf.getAppSettings( "UserType" );
			this.ptbImagePorfile.ImageLocation = this._cf.getAppSettings( "UserPictureUrl" );
		}

		#region THREAD'S

		public void LoadDataDefault()
		{
			Thread.Sleep( 200 );
			CheckForIllegalCrossThreadCalls = false;

			//DATOS NO FILTRADOS SIMPRE IMPORTANTES
			if ( this._data.Tables["Departamentos"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Departamentos, Provincias, Distritos...";
				this._initial.ListUbigeo( this._data );
			}

			if ( this._data.Tables["TipoDocumento"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Tipos de Documentos...";
				this._initial.ListTipoDocumento( this._data );
			}

			//DATOS FILTRADOS POR SU NIVEL
			if ( this._data.Tables["TipoPersonal"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Tipos de Personal...";
				this._initial.ListTipoPersonal( this._data );
			}

			if ( this._data.Tables["Profesion"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Profesiones...";
				this._initial.ListProfesiones( this._data );
			}

			if ( this._data.Tables["Sucursal"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Sucursales...";
				this._initial.ListSucursales( this._data );
				this.LoadBranchesToCombo();
			}
			else
			{
				this.LoadBranchesToCombo();
			}

			if ( this._initial.getAppSettings( "BranchCode" ) != "" )
			{
				this.cboBranches.SelectedValue = this._initial.getAppSettings( "BranchCode" );
			}

			this.lblLoadInfo.Text = "";
			this.pgsLoading.Visible = false;
		}

		#endregion

		#region METODOS

		void LoadBranchesToCombo()
		{
			if ( !InvokeRequired )
			{
				this.cboBranches.ValueMember = "Codigo";
				this.cboBranches.DisplayMember = "ConcatColumn";
				this.cboBranches.DataSource = this._data.Tables["Sucursal"];
				this.cboBranches.SelectedIndex = -1;
			}
			else
			{
				LoadSucursales tipo = new LoadSucursales( LoadBranchesToCombo );
				this.Invoke( tipo, new object[] { } );
			}
		}

		void AsignSucursal()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( this._initial.AsignBranch( this._codigoBranch ) )
			{
				this.pgsLoading.Visible = false;
				this.tsMenu_Personal.Enabled = true;
				this.tsMenu_ConfSucursal.Enabled = true;
				this.panelMain.Enabled = true;
				this.tilePersonal.Enabled = true;
				this.tileAulas.Enabled = true;
				this.tileGrados.Enabled = true;
				this.tileSeccion.Enabled = true;
			}
			else
			{
				this.pgsLoading.Visible = false;
				this.tsMenu_Personal.Enabled = false;
				this.tsMenu_ConfSucursal.Enabled = false;
				this.panelMain.Enabled = false;
				this.tilePersonal.Enabled = false;
				this.tileAulas.Enabled = true;
				this.tileGrados.Enabled = false;
				this.tileSeccion.Enabled = false;
			}

			this.panelMain.Enabled = true;
			this._hilo.Abort();
		}

		#endregion

		private void frm_Configuration_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( LoadDataDefault ) );
			
			this.panelMain.Enabled = true;
			this.pgsLoading.Visible = true;

			this._hilo.Start();
		}

		private void tileSucursales_Click( object sender, EventArgs e )
		{
			Institucion.frm_Branches bran = new Institucion.frm_Branches( this._data );
			bran.Owner = this;
			bran.ShowDialog( this );
		}

		private void cboBranches_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.AsignSucursal ) );

			MetroComboBox cbo = ( MetroComboBox ) sender;

			this._codigoBranch = ( int ) cbo.SelectedValue;

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;

			this._hilo.Start();
		}

		private void tsmItem_GestionarPersonal_Click( object sender, EventArgs e )
		{
			int branchCode = Convert.ToInt32( this._initial.getAppSettings( "BranchCode" ) );

			if ( branchCode > 0 )
			{
				Layouts.regPersonal.frm_Registers personal = new Layouts.regPersonal.frm_Registers( this._data );
				personal.Owner = this;
				personal.ShowDialog( this );
			}
			else
			{
				MetroMessageBox.Show( this, "No se puede Gestionar al Personal si no hay una Sucursal Elegida", "Debes Elegir una Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}

		private void tilePersonal_Click( object sender, EventArgs e )
		{
			int branchCode = Convert.ToInt32( this._initial.getAppSettings( "BranchCode" ) );

			if ( branchCode > 0 )
			{
				Layouts.regPersonal.frm_Registers personal = new Layouts.regPersonal.frm_Registers( this._data );
				personal.Owner = this;
				personal.ShowDialog( this );
			}
			else
			{
				MetroMessageBox.Show( this, "No se puede Gestionar al Personal si no hay una Sucursal Elegida", "Debes Elegir una Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}

		private void tsmItem_DatosGenerales_Click( object sender, EventArgs e )
		{
			Institucion.frm_Information info = new Institucion.frm_Information( this._data );
			info.Owner = this;
			info.ShowDialog( this );
		}

		private void tsmItem_Historia_Click( object sender, EventArgs e )
		{
			Institucion.frm_History his = new Institucion.frm_History();
			his.Owner = this;
			his.ShowDialog( this );
		}

		private void tsmItem_Sucursales_Click( object sender, EventArgs e )
		{
			Institucion.frm_Branches bran = new Institucion.frm_Branches( this._data );
			bran.Owner = this;
			bran.ShowDialog( this );
		}

		private void tileDatos_Institucionales_Click( object sender, EventArgs e )
		{
			Institucion.frm_Information info = new Institucion.frm_Information( this._data );
			info.Owner = this;
			info.ShowDialog( this );
		}

		private void tileVisionMision_Click( object sender, EventArgs e )
		{
			Institucion.frm_VisionMision vimi = new Institucion.frm_VisionMision();
			vimi.Owner = this;
			vimi.ShowDialog( this );
		}

		private void tsmItem_VisionAndMision_Click( object sender, EventArgs e )
		{
			Institucion.frm_VisionMision vimi = new Institucion.frm_VisionMision();
			vimi.Owner = this;
			vimi.ShowDialog( this );
		}

		private void tileHistoria_Click( object sender, EventArgs e )
		{
			Institucion.frm_History his = new Institucion.frm_History();
			his.Owner = this;
			his.ShowDialog( this );
		}

		private void tileLogos_Click( object sender, EventArgs e )
		{
			Institucion.frm_Logos log = new Institucion.frm_Logos();
			log.Owner = this;
			log.ShowDialog( this );
		}

		private void tileAulas_Click( object sender, EventArgs e )
		{
			if ( this._codigoBranch > 0 )
			{
				Institucion.frm_Lounge lon = new Institucion.frm_Lounge();
				lon.Owner = this;
				lon.ShowDialog( this );
			}
			else
			{
				MetroMessageBox.Show( this, "DEBES ESCOJER UNA SUCURSAL ANTES DE PROCEDER A REGISTRAR UN SALON", "ESCOJE UNA SUCURSAL", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

	}
}
