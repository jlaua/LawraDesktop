namespace LawrApp.Layouts.regPersonal
{
	partial class frm_Registers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panelMain = new MetroFramework.Controls.MetroPanel();
			this.tabControl = new MetroFramework.Controls.MetroTabControl();
			this.tabPageListado = new MetroFramework.Controls.MetroTabPage();
			this.panelListado = new System.Windows.Forms.Panel();
			this.btnDesactivar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnSearch = new MetroFramework.Controls.MetroButton();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTipoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colLasModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.btnNuevo = new MetroFramework.Controls.MetroButton();
			this.tabPageRegistro = new MetroFramework.Controls.MetroTabPage();
			this.panelRegistros = new System.Windows.Forms.Panel();
			this.lblLastModified = new MetroFramework.Controls.MetroLabel();
			this.gbDatos = new System.Windows.Forms.GroupBox();
			this.lblDireccion_Validator = new System.Windows.Forms.Label();
			this.lblTipoPersonal_Validator = new System.Windows.Forms.Label();
			this.lblDocumento_Validator = new System.Windows.Forms.Label();
			this.lblTipoDocumento_Validator = new System.Windows.Forms.Label();
			this.lblGenero_Validator = new System.Windows.Forms.Label();
			this.lblApellidos_Validator = new System.Windows.Forms.Label();
			this.lblNombres_Validator = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.cboTipoPersonal = new System.Windows.Forms.ComboBox();
			this.txtN_Documento = new System.Windows.Forms.TextBox();
			this.cboDocumento = new System.Windows.Forms.ComboBox();
			this.cboProfesion = new System.Windows.Forms.ComboBox();
			this.CboGenero = new System.Windows.Forms.ComboBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblSrcImage = new MetroFramework.Controls.MetroLabel();
			this.btnSearchImage = new MetroFramework.Controls.MetroButton();
			this.ptbImage = new System.Windows.Forms.PictureBox();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.openPerfilPicture = new System.Windows.Forms.OpenFileDialog();
			this.toltipMore = new System.Windows.Forms.ToolTip(this.components);
			this.lblSucursal = new MetroFramework.Controls.MetroLabel();
			this.panelMain.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageListado.SuspendLayout();
			this.panelListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.tabPageRegistro.SuspendLayout();
			this.panelRegistros.SuspendLayout();
			this.gbDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.tabControl);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Enabled = false;
			this.panelMain.HorizontalScrollbarBarColor = true;
			this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
			this.panelMain.HorizontalScrollbarSize = 10;
			this.panelMain.Location = new System.Drawing.Point(30, 90);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 478);
			this.panelMain.TabIndex = 0;
			this.panelMain.VerticalScrollbarBarColor = true;
			this.panelMain.VerticalScrollbarHighlightOnWheel = false;
			this.panelMain.VerticalScrollbarSize = 10;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageListado);
			this.tabControl.Controls.Add(this.tabPageRegistro);
			this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.tabControl.HotTrack = true;
			this.tabControl.ItemSize = new System.Drawing.Size(120, 40);
			this.tabControl.Location = new System.Drawing.Point(3, 3);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(734, 472);
			this.tabControl.Style = MetroFramework.MetroColorStyle.Green;
			this.tabControl.TabIndex = 4;
			this.tabControl.UseSelectable = true;
			// 
			// tabPageListado
			// 
			this.tabPageListado.Controls.Add(this.panelListado);
			this.tabPageListado.HorizontalScrollbarBarColor = true;
			this.tabPageListado.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageListado.HorizontalScrollbarSize = 1;
			this.tabPageListado.Location = new System.Drawing.Point(4, 44);
			this.tabPageListado.Name = "tabPageListado";
			this.tabPageListado.Size = new System.Drawing.Size(726, 424);
			this.tabPageListado.TabIndex = 0;
			this.tabPageListado.Text = "Apoderados";
			this.tabPageListado.VerticalScrollbarBarColor = true;
			this.tabPageListado.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageListado.VerticalScrollbarSize = 1;
			// 
			// panelListado
			// 
			this.panelListado.BackColor = System.Drawing.Color.Transparent;
			this.panelListado.Controls.Add(this.btnDesactivar);
			this.panelListado.Controls.Add(this.metroLabel1);
			this.panelListado.Controls.Add(this.btnSearch);
			this.panelListado.Controls.Add(this.txtSearch);
			this.panelListado.Controls.Add(this.dgvListado);
			this.panelListado.Controls.Add(this.btnSalir);
			this.panelListado.Controls.Add(this.btnEliminar);
			this.panelListado.Controls.Add(this.btnModificar);
			this.panelListado.Controls.Add(this.btnNuevo);
			this.panelListado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelListado.Location = new System.Drawing.Point(0, 0);
			this.panelListado.Name = "panelListado";
			this.panelListado.Size = new System.Drawing.Size(726, 424);
			this.panelListado.TabIndex = 2;
			// 
			// btnDesactivar
			// 
			this.btnDesactivar.Location = new System.Drawing.Point(373, 388);
			this.btnDesactivar.Name = "btnDesactivar";
			this.btnDesactivar.Size = new System.Drawing.Size(107, 33);
			this.btnDesactivar.TabIndex = 12;
			this.btnDesactivar.Text = "Desactivar Cuenta";
			this.btnDesactivar.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 19);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(51, 19);
			this.metroLabel1.TabIndex = 11;
			this.metroLabel1.Text = "Buscar:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(655, 14);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(68, 29);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.UseSelectable = true;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(60, 14);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(589, 29);
			this.txtSearch.TabIndex = 9;
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AllowUserToResizeColumns = false;
			this.dgvListado.AllowUserToResizeRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colKey,
            this.colDescripcion,
            this.colTipoPersonal,
            this.colActive,
            this.colLasModified});
			this.dgvListado.Location = new System.Drawing.Point(3, 49);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.ReadOnly = true;
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.Height = 28;
			this.dgvListado.RowTemplate.ReadOnly = true;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.ShowCellErrors = false;
			this.dgvListado.ShowCellToolTips = false;
			this.dgvListado.ShowEditingIcon = false;
			this.dgvListado.ShowRowErrors = false;
			this.dgvListado.Size = new System.Drawing.Size(718, 311);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 8;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colKey
			// 
			this.colKey.FillWeight = 50F;
			this.colKey.HeaderText = "Clave";
			this.colKey.Name = "colKey";
			this.colKey.ReadOnly = true;
			// 
			// colDescripcion
			// 
			this.colDescripcion.HeaderText = "Descripcion";
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.ReadOnly = true;
			// 
			// colTipoPersonal
			// 
			this.colTipoPersonal.FillWeight = 70F;
			this.colTipoPersonal.HeaderText = "Tipo";
			this.colTipoPersonal.Name = "colTipoPersonal";
			this.colTipoPersonal.ReadOnly = true;
			// 
			// colActive
			// 
			this.colActive.FillWeight = 30F;
			this.colActive.HeaderText = "Activo";
			this.colActive.Name = "colActive";
			this.colActive.ReadOnly = true;
			this.colActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colLasModified
			// 
			this.colLasModified.FillWeight = 80F;
			this.colLasModified.HeaderText = "Ult. Modificación";
			this.colLasModified.Name = "colLasModified";
			this.colLasModified.ReadOnly = true;
			this.colLasModified.Visible = false;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(5, 388);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(68, 33);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(486, 388);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(68, 33);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(560, 388);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(68, 33);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(655, 388);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(68, 33);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseSelectable = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// tabPageRegistro
			// 
			this.tabPageRegistro.Controls.Add(this.panelRegistros);
			this.tabPageRegistro.HorizontalScrollbarBarColor = true;
			this.tabPageRegistro.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageRegistro.HorizontalScrollbarSize = 1;
			this.tabPageRegistro.Location = new System.Drawing.Point(4, 44);
			this.tabPageRegistro.Name = "tabPageRegistro";
			this.tabPageRegistro.Size = new System.Drawing.Size(726, 424);
			this.tabPageRegistro.TabIndex = 1;
			this.tabPageRegistro.Text = "Registros";
			this.tabPageRegistro.VerticalScrollbarBarColor = true;
			this.tabPageRegistro.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageRegistro.VerticalScrollbarSize = 1;
			// 
			// panelRegistros
			// 
			this.panelRegistros.BackColor = System.Drawing.Color.Transparent;
			this.panelRegistros.Controls.Add(this.lblLastModified);
			this.panelRegistros.Controls.Add(this.gbDatos);
			this.panelRegistros.Controls.Add(this.btnCancelar);
			this.panelRegistros.Controls.Add(this.btnGuardar);
			this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRegistros.Enabled = false;
			this.panelRegistros.Location = new System.Drawing.Point(0, 0);
			this.panelRegistros.Name = "panelRegistros";
			this.panelRegistros.Size = new System.Drawing.Size(726, 424);
			this.panelRegistros.TabIndex = 2;
			// 
			// lblLastModified
			// 
			this.lblLastModified.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblLastModified.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblLastModified.Location = new System.Drawing.Point(11, 402);
			this.lblLastModified.Name = "lblLastModified";
			this.lblLastModified.Size = new System.Drawing.Size(275, 19);
			this.lblLastModified.TabIndex = 4;
			this.lblLastModified.Text = "metroLabel13";
			this.lblLastModified.UseCustomForeColor = true;
			// 
			// gbDatos
			// 
			this.gbDatos.Controls.Add(this.lblDireccion_Validator);
			this.gbDatos.Controls.Add(this.lblTipoPersonal_Validator);
			this.gbDatos.Controls.Add(this.lblDocumento_Validator);
			this.gbDatos.Controls.Add(this.lblTipoDocumento_Validator);
			this.gbDatos.Controls.Add(this.lblGenero_Validator);
			this.gbDatos.Controls.Add(this.lblApellidos_Validator);
			this.gbDatos.Controls.Add(this.lblNombres_Validator);
			this.gbDatos.Controls.Add(this.txtDireccion);
			this.gbDatos.Controls.Add(this.txtTelefono);
			this.gbDatos.Controls.Add(this.txtEmail);
			this.gbDatos.Controls.Add(this.cboTipoPersonal);
			this.gbDatos.Controls.Add(this.txtN_Documento);
			this.gbDatos.Controls.Add(this.cboDocumento);
			this.gbDatos.Controls.Add(this.cboProfesion);
			this.gbDatos.Controls.Add(this.CboGenero);
			this.gbDatos.Controls.Add(this.dtpBirthday);
			this.gbDatos.Controls.Add(this.txtApellidos);
			this.gbDatos.Controls.Add(this.txtNombres);
			this.gbDatos.Controls.Add(this.metroLabel6);
			this.gbDatos.Controls.Add(this.metroLabel5);
			this.gbDatos.Controls.Add(this.metroLabel9);
			this.gbDatos.Controls.Add(this.metroLabel8);
			this.gbDatos.Controls.Add(this.metroLabel11);
			this.gbDatos.Controls.Add(this.metroLabel12);
			this.gbDatos.Controls.Add(this.metroLabel10);
			this.gbDatos.Controls.Add(this.metroLabel7);
			this.gbDatos.Controls.Add(this.metroLabel4);
			this.gbDatos.Controls.Add(this.metroLabel3);
			this.gbDatos.Controls.Add(this.metroLabel2);
			this.gbDatos.Controls.Add(this.lblSrcImage);
			this.gbDatos.Controls.Add(this.btnSearchImage);
			this.gbDatos.Controls.Add(this.ptbImage);
			this.gbDatos.Location = new System.Drawing.Point(3, 3);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Size = new System.Drawing.Size(720, 359);
			this.gbDatos.TabIndex = 3;
			this.gbDatos.TabStop = false;
			this.gbDatos.Text = "Datos del Personal";
			// 
			// lblDireccion_Validator
			// 
			this.lblDireccion_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblDireccion_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDireccion_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblDireccion_Validator.Location = new System.Drawing.Point(67, 289);
			this.lblDireccion_Validator.Name = "lblDireccion_Validator";
			this.lblDireccion_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblDireccion_Validator.TabIndex = 62;
			this.lblDireccion_Validator.Text = "*";
			// 
			// lblTipoPersonal_Validator
			// 
			this.lblTipoPersonal_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblTipoPersonal_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoPersonal_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblTipoPersonal_Validator.Location = new System.Drawing.Point(471, 161);
			this.lblTipoPersonal_Validator.Name = "lblTipoPersonal_Validator";
			this.lblTipoPersonal_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblTipoPersonal_Validator.TabIndex = 61;
			this.lblTipoPersonal_Validator.Text = "*";
			// 
			// lblDocumento_Validator
			// 
			this.lblDocumento_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblDocumento_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumento_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblDocumento_Validator.Location = new System.Drawing.Point(278, 161);
			this.lblDocumento_Validator.Name = "lblDocumento_Validator";
			this.lblDocumento_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblDocumento_Validator.TabIndex = 60;
			this.lblDocumento_Validator.Text = "*";
			// 
			// lblTipoDocumento_Validator
			// 
			this.lblTipoDocumento_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblTipoDocumento_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoDocumento_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblTipoDocumento_Validator.Location = new System.Drawing.Point(82, 161);
			this.lblTipoDocumento_Validator.Name = "lblTipoDocumento_Validator";
			this.lblTipoDocumento_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblTipoDocumento_Validator.TabIndex = 59;
			this.lblTipoDocumento_Validator.Text = "*";
			// 
			// lblGenero_Validator
			// 
			this.lblGenero_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblGenero_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenero_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblGenero_Validator.Location = new System.Drawing.Point(234, 95);
			this.lblGenero_Validator.Name = "lblGenero_Validator";
			this.lblGenero_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblGenero_Validator.TabIndex = 58;
			this.lblGenero_Validator.Text = "*";
			// 
			// lblApellidos_Validator
			// 
			this.lblApellidos_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblApellidos_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApellidos_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblApellidos_Validator.Location = new System.Drawing.Point(351, 31);
			this.lblApellidos_Validator.Name = "lblApellidos_Validator";
			this.lblApellidos_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblApellidos_Validator.TabIndex = 56;
			this.lblApellidos_Validator.Text = "*";
			// 
			// lblNombres_Validator
			// 
			this.lblNombres_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblNombres_Validator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombres_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblNombres_Validator.Location = new System.Drawing.Point(65, 31);
			this.lblNombres_Validator.Name = "lblNombres_Validator";
			this.lblNombres_Validator.Size = new System.Drawing.Size(24, 16);
			this.lblNombres_Validator.TabIndex = 55;
			this.lblNombres_Validator.Text = "*";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(8, 310);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(557, 29);
			this.txtDireccion.TabIndex = 15;
			this.txtDireccion.Leave += new System.EventHandler(this.AsignDataAndValidate_TextBox_Leave);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(267, 244);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(298, 29);
			this.txtTelefono.TabIndex = 13;
			this.txtTelefono.Leave += new System.EventHandler(this.AsignDataAndValidate_TextBox_Leave);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(8, 244);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(253, 29);
			this.txtEmail.TabIndex = 12;
			this.txtEmail.Leave += new System.EventHandler(this.AsignDataAndValidate_TextBox_Leave);
			// 
			// cboTipoPersonal
			// 
			this.cboTipoPersonal.FormattingEnabled = true;
			this.cboTipoPersonal.Location = new System.Drawing.Point(367, 180);
			this.cboTipoPersonal.Name = "cboTipoPersonal";
			this.cboTipoPersonal.Size = new System.Drawing.Size(198, 29);
			this.cboTipoPersonal.TabIndex = 11;
			this.cboTipoPersonal.Text = "Seleccione...";
			this.cboTipoPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboOnlyUpDown_KeyDown);
			this.cboTipoPersonal.Leave += new System.EventHandler(this.AsignDataAndValidate_ComboBox_Leave);
			// 
			// txtN_Documento
			// 
			this.txtN_Documento.Location = new System.Drawing.Point(185, 180);
			this.txtN_Documento.Name = "txtN_Documento";
			this.txtN_Documento.Size = new System.Drawing.Size(176, 29);
			this.txtN_Documento.TabIndex = 10;
			this.txtN_Documento.Leave += new System.EventHandler(this.AsignDataAndValidate_TextBox_Leave);
			// 
			// cboDocumento
			// 
			this.cboDocumento.FormattingEnabled = true;
			this.cboDocumento.Location = new System.Drawing.Point(8, 180);
			this.cboDocumento.Name = "cboDocumento";
			this.cboDocumento.Size = new System.Drawing.Size(171, 29);
			this.cboDocumento.TabIndex = 9;
			this.cboDocumento.Text = "Seleccione...";
			this.cboDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboOnlyUpDown_KeyDown);
			this.cboDocumento.Leave += new System.EventHandler(this.AsignDataAndValidate_ComboBox_Leave);
			// 
			// cboProfesion
			// 
			this.cboProfesion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboProfesion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboProfesion.FormattingEnabled = true;
			this.cboProfesion.Location = new System.Drawing.Point(367, 115);
			this.cboProfesion.Name = "cboProfesion";
			this.cboProfesion.Size = new System.Drawing.Size(198, 29);
			this.cboProfesion.TabIndex = 8;
			this.cboProfesion.SelectionChangeCommitted += new System.EventHandler(this.cboProfesion_SelectionChangeCommitted);
			this.cboProfesion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboProfesion_KeyDown);
			this.cboProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter_TextBox_KeyPress);
			this.cboProfesion.Leave += new System.EventHandler(this.AsignDataAndValidate_ComboBox_Leave);
			// 
			// CboGenero
			// 
			this.CboGenero.FormattingEnabled = true;
			this.CboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
			this.CboGenero.Location = new System.Drawing.Point(185, 115);
			this.CboGenero.Name = "CboGenero";
			this.CboGenero.Size = new System.Drawing.Size(176, 29);
			this.CboGenero.TabIndex = 7;
			this.CboGenero.Text = "Seleccione...";
			this.CboGenero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboOnlyUpDown_KeyDown);
			this.CboGenero.Leave += new System.EventHandler(this.AsignDataAndValidate_ComboBox_Leave);
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
			this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthday.Location = new System.Drawing.Point(8, 116);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(171, 29);
			this.dtpBirthday.TabIndex = 6;
			this.dtpBirthday.Leave += new System.EventHandler(this.dtpBirthday_Leave);
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(291, 51);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(274, 29);
			this.txtApellidos.TabIndex = 5;
			this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter_TextBox_KeyPress);
			this.txtApellidos.Leave += new System.EventHandler(this.AsignDataAndValidate_TextBox_Leave);
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(8, 51);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(277, 29);
			this.txtNombres.TabIndex = 4;
			this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter_TextBox_KeyPress);
			this.txtNombres.Leave += new System.EventHandler(this.AsignDataAndValidate_TextBox_Leave);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(367, 93);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(64, 19);
			this.metroLabel6.TabIndex = 3;
			this.metroLabel6.Text = "Profesión";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(185, 93);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(52, 19);
			this.metroLabel5.TabIndex = 3;
			this.metroLabel5.Text = "Genero";
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(367, 158);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(107, 19);
			this.metroLabel9.TabIndex = 3;
			this.metroLabel9.Text = "Tipo de Personal";
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(185, 158);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(96, 19);
			this.metroLabel8.TabIndex = 3;
			this.metroLabel8.Text = "N° Documento";
			// 
			// metroLabel11
			// 
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new System.Drawing.Point(267, 222);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new System.Drawing.Size(63, 19);
			this.metroLabel11.TabIndex = 3;
			this.metroLabel11.Text = "Telefonos";
			// 
			// metroLabel12
			// 
			this.metroLabel12.AutoSize = true;
			this.metroLabel12.Location = new System.Drawing.Point(6, 287);
			this.metroLabel12.Name = "metroLabel12";
			this.metroLabel12.Size = new System.Drawing.Size(63, 19);
			this.metroLabel12.TabIndex = 3;
			this.metroLabel12.Text = "Dirección";
			// 
			// metroLabel10
			// 
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new System.Drawing.Point(7, 222);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new System.Drawing.Size(41, 19);
			this.metroLabel10.TabIndex = 3;
			this.metroLabel10.Text = "Email";
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(8, 158);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(77, 19);
			this.metroLabel7.TabIndex = 3;
			this.metroLabel7.Text = "Documento";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(8, 93);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(88, 19);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "F. Nacimiento";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(291, 28);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(63, 19);
			this.metroLabel3.TabIndex = 3;
			this.metroLabel3.Text = "Apellidos";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(8, 28);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(59, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Nombre";
			// 
			// lblSrcImage
			// 
			this.lblSrcImage.Location = new System.Drawing.Point(584, 245);
			this.lblSrcImage.Name = "lblSrcImage";
			this.lblSrcImage.Size = new System.Drawing.Size(123, 23);
			this.lblSrcImage.TabIndex = 2;
			this.lblSrcImage.Text = "...";
			// 
			// btnSearchImage
			// 
			this.btnSearchImage.Location = new System.Drawing.Point(584, 209);
			this.btnSearchImage.Name = "btnSearchImage";
			this.btnSearchImage.Size = new System.Drawing.Size(123, 33);
			this.btnSearchImage.TabIndex = 1;
			this.btnSearchImage.Text = "Buscar Imagen";
			this.btnSearchImage.UseSelectable = true;
			this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
			// 
			// ptbImage
			// 
			this.ptbImage.BackColor = System.Drawing.Color.Gainsboro;
			this.ptbImage.Location = new System.Drawing.Point(584, 51);
			this.ptbImage.Name = "ptbImage";
			this.ptbImage.Size = new System.Drawing.Size(123, 152);
			this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImage.TabIndex = 0;
			this.ptbImage.TabStop = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(567, 388);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 33);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(648, 388);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 33);
			this.btnGuardar.TabIndex = 1;
			this.btnGuardar.Text = "Hecho";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(40, 571);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// toltipMore
			// 
			this.toltipMore.BackColor = System.Drawing.SystemColors.Window;
			this.toltipMore.ForeColor = System.Drawing.SystemColors.GrayText;
			this.toltipMore.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipMore.ToolTipTitle = "Info:";
			// 
			// lblSucursal
			// 
			this.lblSucursal.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblSucursal.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblSucursal.Location = new System.Drawing.Point(22, 54);
			this.lblSucursal.Name = "lblSucursal";
			this.lblSucursal.Size = new System.Drawing.Size(748, 19);
			this.lblSucursal.TabIndex = 2;
			this.lblSucursal.Text = "metroLabel13";
			this.lblSucursal.UseCustomForeColor = true;
			// 
			// frm_Registers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.lblSucursal);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Registers";
			this.Padding = new System.Windows.Forms.Padding(30, 90, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Personal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Registers_FormClosing);
			this.Load += new System.EventHandler(this.frm_Registers_Load);
			this.panelMain.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPageListado.ResumeLayout(false);
			this.panelListado.ResumeLayout(false);
			this.panelListado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.tabPageRegistro.ResumeLayout(false);
			this.panelRegistros.ResumeLayout(false);
			this.gbDatos.ResumeLayout(false);
			this.gbDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel panelMain;
		private MetroFramework.Controls.MetroTabControl tabControl;
		private MetroFramework.Controls.MetroTabPage tabPageListado;
		private System.Windows.Forms.Panel panelListado;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dgvListado;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroButton btnNuevo;
		private MetroFramework.Controls.MetroTabPage tabPageRegistro;
		private System.Windows.Forms.Panel panelRegistros;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroButton btnDesactivar;
		private System.Windows.Forms.GroupBox gbDatos;
		private MetroFramework.Controls.MetroLabel lblSrcImage;
		private MetroFramework.Controls.MetroButton btnSearchImage;
		private System.Windows.Forms.PictureBox ptbImage;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.TextBox txtNombres;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.ComboBox cboProfesion;
		private System.Windows.Forms.ComboBox CboGenero;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.ComboBox cboDocumento;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private System.Windows.Forms.ComboBox cboTipoPersonal;
		private System.Windows.Forms.TextBox txtN_Documento;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtEmail;
		private MetroFramework.Controls.MetroLabel metroLabel11;
		private MetroFramework.Controls.MetroLabel metroLabel10;
		private System.Windows.Forms.TextBox txtDireccion;
		private MetroFramework.Controls.MetroLabel metroLabel12;
		private System.Windows.Forms.OpenFileDialog openPerfilPicture;
		private System.Windows.Forms.ToolTip toltipMore;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPersonal;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLasModified;
		private MetroFramework.Controls.MetroLabel lblSucursal;
		private System.Windows.Forms.Label lblTipoPersonal_Validator;
		private System.Windows.Forms.Label lblDocumento_Validator;
		private System.Windows.Forms.Label lblTipoDocumento_Validator;
		private System.Windows.Forms.Label lblGenero_Validator;
		private System.Windows.Forms.Label lblApellidos_Validator;
		private System.Windows.Forms.Label lblNombres_Validator;
		private System.Windows.Forms.Label lblDireccion_Validator;
		private MetroFramework.Controls.MetroLabel lblLastModified;

	}
}