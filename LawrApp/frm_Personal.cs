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
	public partial class frm_Personal : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;

		private int _codigoBranch = 0;

		private ConfigServer _cf = new ConfigServer();
		private InitialData _initial = new InitialData();

		delegate void LoadSucursales();

		public frm_Personal( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();

			this.lblFullName.Text = this._cf.getAppSettings( "UserName" );
			this.lblCargo.Text = this._cf.getAppSettings( "UserType" );
			this.ptbImagePorfile.ImageLocation = this._cf.getAppSettings( "UserPictureUrl" );

			this.lblNameInstitucion.Text = this._cf.getAppSettings( "InstitutionName" ).ToUpper();
			this.lblAddressInstitucion.Text = this._cf.getAppSettings( "BranchAddress" );
			this.ptbLogoInstitucion.ImageLocation = this._cf.ConfigBaseUrl + this._cf.getAppSettings( "InstitutionLogo" );
		}

		void LoadDataDefault()
		{
			CheckForIllegalCrossThreadCalls = false;

			//DATOS NO FILTRADOS, SIMPRE IMPORTANTES
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

			if ( this._data.Tables["ListaSalones"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Salones...";
				this._initial.ListSalones( this._data );
			}

			if ( this._data.Tables["ListaMarca"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Marcas...";
				this._initial.ListMarcas( this._data );
			}

			if ( this._data.Tables["listaCategoria"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Categorias...";
				this._initial.ListCategorias( this._data );
			}

			if ( this._data.Tables["TipoApoderado"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Tipos de Parientes...";
				this._initial.ListTipoApoderado( _data );
			}

			this.lblLoadInfo.Text = "Cargando: Periodos...";
			this._initial.ListPeriodos( _data );

			this.cboYearPeriod.ValueMember = "Codigo";
			this.cboYearPeriod.DisplayMember = "Year";
			this.cboYearPeriod.DataSource = this._data.Tables["Periodo"];

			if ( this._data.Tables["Periodo"].Rows.Count > 0 )
			{
				this.lblLoadInfo.Text = "Asignando Periodos...";
				this._initial.AsignYear( this.cboYearPeriod.SelectedValue.ToString() );

				if ( this._data.Tables["Grados"].Rows.Count == 0 )
				{
					this.lblLoadInfo.Text = "Cargando: Grados, Secciones...";
					this._initial.ListaGradoSeccion( _data );
				}

				this.lblLoadInfo.Text = "Cargando: Estudiantes...";
				this._initial.ListaStudents( _data );
			}
			else
			{
				//alumnoToolStripMenuItem.Enabled = false;
				//matriculasToolStripMenuItem.Enabled = false;
				MetroMessageBox.Show( this, "No Existe ningun Periodo Configurado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}

			this.lblLoadInfo.Text = "";
			this.pgsLoading.Visible = false;
			this.panelMain.Enabled = true;

			this._hilo.Abort();
		}

		void LoadMessages()
		{
			for ( int i = 0; i <= 10; i++ )
			{
				Panel pn = new Panel();
				MetroLink mlk = new MetroLink();
				MetroLabel mlblDate = new MetroLabel();
				MetroLabel mlblDesc = new MetroLabel();
				// 
				// panel Interno
				// 
				pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				pn.Controls.Add( mlblDesc );
				pn.Controls.Add( mlblDate );
				pn.Controls.Add( mlk );
				this.flpanel_Mensajes.SetFlowBreak( pn, true );
				pn.Location = new System.Drawing.Point( 3, 3 );
				pn.Name = "panel_" + ( ( i < 10 ) ? "0" : "" ) + i;
				pn.Size = new System.Drawing.Size( 223, 95 );
				pn.TabIndex = i + 1;
				// 
				// Descripción
				// 
				mlblDesc.FontSize = MetroFramework.MetroLabelSize.Small;
				mlblDesc.Location = new System.Drawing.Point( 3, 40 );
				mlblDesc.Name = "metroLabel_" + ( ( i < 10 ) ? "0" : "" ) + i;
				mlblDesc.Size = new System.Drawing.Size( 215, 45 );
				mlblDesc.TabIndex = 1;
				mlblDesc.Text = "Lorem Ipsum dolor sit amet siempre y cuando estemos todos unidos";
				mlblDesc.WrapToLine = true;
				// 
				// Nombre de la Persona
				// 
				mlk.Location = new System.Drawing.Point( 3, 6 );
				mlk.Name = "metroLink_" + ( ( i < 10 ) ? "0" : "" ) + i;
				mlk.Size = new System.Drawing.Size( 215, 14 );
				mlk.TabIndex = 0;
				mlk.Text = "José Alejandro Vilchez M._" + i;
				mlk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				mlk.UseSelectable = true;
				mlk.Click += LinkDinamic_Click;
				// 
				// Fecha de enviado
				// 
				mlblDate.FontSize = MetroFramework.MetroLabelSize.Small;
				mlblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
				mlblDate.Location = new System.Drawing.Point( 3, 23 );
				mlblDate.Name = "metroLabel_" + ( ( i < 10 ) ? "0" : "" ) + i;
				mlblDate.Size = new System.Drawing.Size( 215, 15 );
				mlblDate.TabIndex = i;
				mlblDate.Text = DateTime.Now.ToString();

				this.flpanel_Mensajes.Controls.Add( pn );
			}
		}

		void LinkDinamic_Click( object sender, EventArgs e )
		{
			MetroLink met = ( MetroLink ) sender;
			Panel pn = ( Panel ) met.Parent;

			DialogResult res = MessageBox.Show( this, "Borrarlo", "Pregunta?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question );

			if ( res == DialogResult.OK )
			{
				FlowLayoutPanel fpn = ( FlowLayoutPanel ) pn.Parent;
				fpn.Controls.Remove( pn );
			}
		}

		private void frm_Personal_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadDataDefault ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;

			this._hilo.Start();

			this.LoadMessages();
		}

		private void tileMaterial_Click( object sender, EventArgs e )
		{
			Control_Material.frm_Material mate = new Control_Material.frm_Material( this._data );
			mate.Owner = this;
			mate.ShowDialog( this );
		}

		private void tileIncome_Click( object sender, EventArgs e )
		{
			Control_Material.frm_Income inco = new Control_Material.frm_Income( this._data );
			inco.Owner = this;
			inco.ShowDialog( this );
		}

		private void tileAsignMaterials_Click( object sender, EventArgs e )
		{
			Control_Material.frm_AssignMaterials asm = new Control_Material.frm_AssignMaterials( this._data );
			asm.Owner = this;
			asm.ShowDialog( this );
		}

		private void pts_MenuItem_CloseApp_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void pts_MenuItem_ChangePassword_Click( object sender, EventArgs e )
		{
			mdl_ChangePassword cha = new mdl_ChangePassword();
			cha.Owner = this;
			cha.ShowDialog( this );
		}

		private void pts_MenuItem_ChangeImagePerfil_Click( object sender, EventArgs e )
		{
			mdl_ChangePicture pic = new mdl_ChangePicture();
			pic.Owner = this;
			pic.ShowDialog( this );
		}

		private void datosGeneralesToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Registers reg = new Layouts.regAlumno.frm_Registers( this._data );
			reg.Owner = this;
			reg.ShowDialog( this );
		}

		private void apoderadosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Parents par = new Layouts.regAlumno.frm_Parents( this._data );
			par.Owner = this;
			par.ShowDialog( this );
		}

		private void documentosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Documents docs = new Layouts.regAlumno.frm_Documents( this._data );
			docs.Owner = this;
			docs.ShowDialog( this );
		}

		private void buscarToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_FindAlumno find = new Layouts.regAlumno.frm_FindAlumno( this._data );
			find.Owner = this;
			find.ShowDialog( this );
		}
	}
}
