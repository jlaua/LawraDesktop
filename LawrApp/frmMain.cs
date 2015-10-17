using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Custom's
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;

using Access;
using Objects.Tables;
using System.Threading;

namespace LawrApp
{
    public partial class frmMain : MetroForm, IFrmMain
    {
        //el formulario login modifica esta variable
        private Login _log = new Login();
        private InitialData _preload = new InitialData();
        private DataGeneral _data;
        private Thread _tr;

		delegate void ValidateLevel();
		delegate void LoadSucursales();

		private int _codigoBranch = 0;

        public frmMain( DataGeneral dts )
        {
            _data = dts;
            InitializeComponent();
        }

        #region HILOS

		//public void LoadDataDefault()
		//{
		//	Thread.Sleep(200);
		//	CheckForIllegalCrossThreadCalls = false;

		//	//DATOS NO FILTRADOS SIMPRE IMPORTANTES
		//	if ( this._data.Tables["Departamentos"].Rows.Count == 0 )
		//	{
		//		this.lblLoadInfo.Text = "Cargando: Departamentos, Provincias, Distritos...";
		//		this._preload.ListUbigeo( this._data );
		//	}

		//	if ( this._data.Tables["TipoDocumento"].Rows.Count == 0 )
		//	{
		//		this.lblLoadInfo.Text = "Cargando: Tipos de Documentos...";
		//		this._preload.ListTipoDocumento( this._data );
		//	}

		//	//DATOS FILTRADOS POR SU NIVEL
		//	if ( this._log.UserLevel == 0 )
		//	{
		//		if ( this._data.Tables["TipoPersonal"].Rows.Count == 0 )
		//		{
		//			this.lblLoadInfo.Text = "Cargando: Tipos de Personal...";
		//			this._preload.ListTipoPersonal( this._data );
		//		}

		//		if ( this._data.Tables["Profesion"].Rows.Count == 0 )
		//		{
		//			this.lblLoadInfo.Text = "Cargando: Profesiones...";
		//			this._preload.ListProfesiones( this._data );
		//		}

		//		if ( this._data.Tables["Sucursal"].Rows.Count == 0 )
		//		{
		//			this.lblLoadInfo.Text = "Cargando: Sucursales...";
		//			this._preload.ListSucursales( this._data );
		//			this.LoadBranchesToCombo();
		//		}
		//		else
		//		{
		//			this.LoadBranchesToCombo();
		//		}

		//		if ( this._preload.getAppSettings("BranchCode") != "" )
		//		{
		//			this.cboBranches.SelectedValue = this._preload.getAppSettings( "BranchCode" );
		//		}
		//	}
		//	else if ( this._log.UserLevel == 1 )
		//	{
		//		this.lblLoadInfo.Text = "Cargando: Periodos...";
		//		this._preload.ListPeriodos( _data );

		//		this.cboPeriodos.ValueMember = "Codigo";
		//		this.cboPeriodos.DisplayMember = "Year";
		//		this.cboPeriodos.DataSource = this._data.Tables["Periodo"];

		//		if ( this._data.Tables["Periodo"].Rows.Count > 0 )
		//		{
		//			this.lblLoadInfo.Text = "Asignando Periodos...";
		//			this._preload.AsignYear( cboPeriodos.SelectedValue.ToString() );

		//			if ( this._data.Tables["TipoApoderado"].Rows.Count == 0 )
		//			{
		//				this.lblLoadInfo.Text = "Cargando: Tipos de Parientes...";
		//				this._preload.ListTipoApoderado( _data );
		//			}

		//			if ( this._data.Tables["Grados"].Rows.Count == 0 )
		//			{
		//				this.lblLoadInfo.Text = "Cargando: Grados, Secciones...";
		//				this._preload.ListaGradoSeccion( _data );
		//			}

		//			this.lblLoadInfo.Text = "Cargando: Estudiantes...";
		//			this._preload.ListaStudents( _data );
		//		}
		//		else
		//		{
		//			this.btnRegistrarAlumno.Enabled = false;
		//			this.cboPeriodos.Enabled = false;
		//			this.btnFichasStudents.Enabled = false;
		//			MetroMessageBox.Show( this, "No Existe ningun Periodo Configurado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
		//		}
		//	}

		//	this.lblLoadInfo.Text = "";
		//	this.pgsLoadDataDefault.Visible = false;

		//	this.AsignLevel();
		//	//this.ControlsEnabled( true );
		//}

		void AsignSucursal()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( ! this._preload.AsignBranch( this._codigoBranch ) )
			{
				MetroMessageBox.Show( this, this._preload.ExceptionUbigeo, "Existe un Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelTitles.Enabled = false;
				this.tsmItemRegisterAlumno.Enabled = false;
				this.tsmItemRegisterPersonal.Enabled = false;
				this.tsmItemReportes.Enabled = false;
				this.tsmItemPeriodos.Enabled = false;

				this.menuOptions.Enabled = true;
				this.tableTiles.Enabled = true;
				this.pgsLoadDataDefault.Visible = false;
				this.panelLogged.Enabled = true;
			}
			else
			{
				this.panelTitles.Enabled = true;
				this.tsmItemRegisterAlumno.Enabled = true;
				this.tsmItemRegisterPersonal.Enabled = true;
				this.tsmItemReportes.Enabled = true;
				this.tsmItemPeriodos.Enabled = true;

				this.menuOptions.Enabled = true;
				this.tableTiles.Enabled = true;
				this.pgsLoadDataDefault.Visible = false;
				this.panelLogged.Enabled = true;
			}

			this._tr.Abort();
		}

        #endregion

        #region METODOS

        private void ControlsVisible( bool IsIt )
        {
            this.menuOptions.Visible = IsIt;
            this.panelLogged.Visible = IsIt;
            this.panelLoginIn.Visible = !IsIt;
            this.tableTiles.Visible = IsIt;
            this.panelTitles.Visible = IsIt;
        }

        private void ControlsEnabled( bool IsIt )
        {
            this.menuOptions.Enabled = IsIt;
            this.panelLogged.Enabled = IsIt;
            this.panelLoginIn.Enabled = !IsIt;
            this.tableTiles.Enabled = IsIt;
			this.panelTitles.Visible = IsIt;
        }

		private void AsignLevel()
		{
			if ( ! this.InvokeRequired )
			{
				this.ControlsEnabled( false );

				this.btnLogin.Enabled = false;

				//switch ( this._log.UserLevel )
				//{
				//	case 0:
				//	this.tableTiles.Enabled = false;
				//	this.panelTitles.Enabled = false;
				//	this.cboPeriodos.Visible = false;
				//	this.lblBranchAddress.Visible = false;
				//	this.lblPeriodo.Visible = false;
				//	this.ptbLogo.Visible = false;
				//	this.lblNameInstitution.Text = "Administrador General";
				//	this.panelLogged.Enabled = true;
				//	this.lblNameInstitution.Location = new Point(570, 3);
				//	this.cboBranches.Location = new Point( 718, 42 );
				//	this.cboBranches.Visible = true;
				//	this.cboBranches.Text = "Seleccione una Sucursal";
				//	this.lblSucursal.Location = new Point( 632, 47 );
				//	this.lblSucursal.Visible = true;
				//	this.tsmItemPeriodos.Visible = false;
				//	//this.tsmItemReportes.Visible = false;
				//	this.tsmItemRegisterAlumno.Enabled = false;
				//	this.menuOptions.Enabled = true;
				//	this.menuOptions.Visible = true;
				//	break;
				//}
			}
			else
			{
				ValidateLevel tipo = new ValidateLevel( AsignLevel );
				this.Invoke( tipo, new object[] {  } );
			}
			
		}

		void LoadBranchesToCombo()
		{
			if ( ! InvokeRequired )
			{
				this.cboBranches.ValueMember = "Codigo";
				this.cboBranches.DisplayMember = "ConcatColumn";
				this.cboBranches.DataSource = this._data.Tables["Sucursal"];
				this.cboBranches.SelectedIndex = -1;
			}else
			{
				LoadSucursales tipo = new LoadSucursales( LoadBranchesToCombo );
				this.Invoke( tipo, new object[] {  } );
			}
		}

		public void ReloadData( bool Reload )
		{
			//if ( Reload )
			//{
			//	this._tr = new Thread( new ThreadStart( this.LoadDataDefault ) );

			//	this.ControlsVisible( true );
			//	this.ControlsEnabled( false );
			//	this.btnLogin.Enabled = false;

			//	this.pgsLoadDataDefault.Visible = true;

			//	this._tr.Start();
			//}
		}

		public void DeletedSucursal( int CodigoSucursal )
		{

		}

        #endregion

        #region EVENTOS

        private void frmMain_Load( object sender, EventArgs e )
        {
			//if ( this._log.TokenIsRegistered() )
			//{
			//	this._tr = new Thread( new ThreadStart( this.LoadDataDefault ) );

			//	//this.lblUserName.Text = this._log.UserFullName;
			//	//this.lblUserType.Text = this._log.UserType;
			//	//this.pbUserPicture.ImageLocation = this._log.LocationImage;

			//	this.panelLogged.Visible = true;
			//	this.pgsLoadDataDefault.Visible = true;

			//	this._tr.Start();
			//}
			//else
			//{
			//	this.ControlsVisible( false );
			//	this.ControlsEnabled( false );
			//	this.btnLogin.Enabled = true;
			//	this.pgsLoadDataDefault.Visible = false;
			//}
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            frmLogIn frmlog = new frmLogIn( this._data );
            frmlog.classLog = this._log;
            frmlog.Show();
            this.Close();
		}

		private void btnRegistrarAlumno_Click( object sender, EventArgs e )
		{
			Layouts.prsMatricula.frmInitialMessage alumno = new Layouts.prsMatricula.frmInitialMessage( this._data );
			alumno.Show();
			this.Close();
		}

		private void btnLogOut_Click( object sender, EventArgs e )
		{
			DialogResult result = MetroMessageBox.Show( this,
				"\nDeseas Realmente Cerrar Sesión? \n\n Pulsa OK para cerrar sesión...",
				"Advertencia",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Exclamation );

			if ( result == DialogResult.Cancel ) return;

			if ( _log.SendLogOut() ) ControlsVisible( false );

			this.btnLogin.Enabled = true;
			this.panelLoginIn.Enabled = true;

		}

		private void btnNewAcademyYear_Click( object sender, EventArgs e )
		{
			Layouts.prsApertura.frmInitialMessage frminitprs = new Layouts.prsApertura.frmInitialMessage( this._data );
			frminitprs.Show();
			this.Close();
		}

		private void cambiarServidorToolStripMenuItem_Click( object sender, EventArgs e )
		{
			LawrApp.frmConfigServer server = new frmConfigServer();
			server.Owner = this;
			server.ShowDialog( this );
		}

        #endregion

		private void datosDeAlumnoToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Reportes.Formularios.frm_MaterialEnAula ma = new Reportes.Formularios.frm_MaterialEnAula( this._data, 1 );
			ma.Show();
		}

		private void modificarDatosDeAlumnosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_FindAlumno falumno = new Layouts.regAlumno.frm_FindAlumno( this._data );
			falumno.Show();
			this.Close();
		}

		private void documentosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Documents documents = new Layouts.regAlumno.frm_Documents( this._data );
			documents.Show();
			this.Close();
		}

		private void apoderadosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Parents documents = new Layouts.regAlumno.frm_Parents( this._data );
			documents.Show();
			this.Close();
		}

		private void btnFichasStudents_Click( object sender, EventArgs e )
		{
			Layouts.Fichas.Students.frmSearchStudents search = new Layouts.Fichas.Students.frmSearchStudents( this._data );
			search.Show();
			this.Close();
		}

		private void tsmItemDatosInstitucion_Click( object sender, EventArgs e )
		{
			Institucion.frm_Information info = new Institucion.frm_Information( this._data );
			info.Owner = this;
			info.ShowDialog(this);
		}

		private void tsmItemHistory_Click( object sender, EventArgs e )
		{
			Institucion.frm_History history = new Institucion.frm_History();
			history.Owner = this;
			history.ShowDialog( this );
		}

		private void tsmItemRegisterPersonal_Click( object sender, EventArgs e )
		{
			int branchCode = Convert.ToInt32( this._preload.getAppSettings( "BranchCode" ) );

			if ( branchCode > 0 )
			{
				Layouts.regPersonal.frm_Registers personal = new Layouts.regPersonal.frm_Registers( this._data );
				personal.Show();
				this.Close();
			}
			else
			{
				MetroMessageBox.Show( this, "No se puede Gestionar al Personal si no hay una Sucursal Elegida", "Debes Elegir una Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}

		private void tsmItemSucursales_Click( object sender, EventArgs e )
		{
			Institucion.frm_Branches branch = new Institucion.frm_Branches( this._data );
			branch.Owner = this;
			branch.ShowDialog( this );
		}

		private void cboBranches_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this._tr = new Thread( new ThreadStart( this.AsignSucursal ) );
			MetroComboBox cbo = ( MetroComboBox ) sender;
			this._codigoBranch = (int) cbo.SelectedValue;
			this.menuOptions.Enabled = false;
			this.tableTiles.Enabled = false;
			this.pgsLoadDataDefault.Visible = true;
			this.panelLogged.Enabled = false;
			this._tr.Start();
		}

		private void cboBranches_SelectedValueChanged( object sender, EventArgs e )
		{

		}
	}
}
