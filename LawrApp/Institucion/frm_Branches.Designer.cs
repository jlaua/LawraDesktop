namespace LawrApp.Institucion
{
	partial class frm_Branches
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl = new MetroFramework.Controls.MetroTabControl();
			this.tabPageListado = new MetroFramework.Controls.MetroTabPage();
			this.panelListado = new System.Windows.Forms.Panel();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.btnNuevo = new MetroFramework.Controls.MetroButton();
			this.btnBuscar = new MetroFramework.Controls.MetroButton();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.tabPageRegistro = new MetroFramework.Controls.MetroTabPage();
			this.panelRegistro = new System.Windows.Forms.Panel();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPreview = new MetroFramework.Controls.MetroButton();
			this.nudZoom = new System.Windows.Forms.NumericUpDown();
			this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
			this.txtLongitud = new System.Windows.Forms.TextBox();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.txtLatitud = new System.Windows.Forms.TextBox();
			this.cboDistrito = new System.Windows.Forms.ComboBox();
			this.cboProvincia = new System.Windows.Forms.ComboBox();
			this.cboDepartamento = new System.Windows.Forms.ComboBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.chboPrincipal = new MetroFramework.Controls.MetroCheckBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtCodigoLocal = new System.Windows.Forms.TextBox();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.panel1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageListado.SuspendLayout();
			this.panelListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.tabPageRegistro.SuspendLayout();
			this.panelRegistro.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(25, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 441);
			this.panel1.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageListado);
			this.tabControl.Controls.Add(this.tabPageRegistro);
			this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.tabControl.ItemSize = new System.Drawing.Size(105, 34);
			this.tabControl.Location = new System.Drawing.Point(3, 3);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(544, 435);
			this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl.Style = MetroFramework.MetroColorStyle.Green;
			this.tabControl.TabIndex = 0;
			this.tabControl.UseSelectable = true;
			// 
			// tabPageListado
			// 
			this.tabPageListado.Controls.Add(this.panelListado);
			this.tabPageListado.HorizontalScrollbarBarColor = true;
			this.tabPageListado.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageListado.HorizontalScrollbarSize = 6;
			this.tabPageListado.Location = new System.Drawing.Point(4, 38);
			this.tabPageListado.Name = "tabPageListado";
			this.tabPageListado.Size = new System.Drawing.Size(536, 393);
			this.tabPageListado.TabIndex = 0;
			this.tabPageListado.Text = "Sucursales";
			this.tabPageListado.VerticalScrollbarBarColor = true;
			this.tabPageListado.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageListado.VerticalScrollbarSize = 7;
			// 
			// panelListado
			// 
			this.panelListado.BackColor = System.Drawing.Color.White;
			this.panelListado.Controls.Add(this.dgvListado);
			this.panelListado.Controls.Add(this.btnSalir);
			this.panelListado.Controls.Add(this.btnEliminar);
			this.panelListado.Controls.Add(this.btnModificar);
			this.panelListado.Controls.Add(this.btnNuevo);
			this.panelListado.Controls.Add(this.btnBuscar);
			this.panelListado.Controls.Add(this.txtBuscar);
			this.panelListado.Controls.Add(this.metroLabel1);
			this.panelListado.Location = new System.Drawing.Point(0, 0);
			this.panelListado.Name = "panelListado";
			this.panelListado.Size = new System.Drawing.Size(536, 393);
			this.panelListado.TabIndex = 2;
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
            this.colTitle,
            this.colModifiedDate});
			this.dgvListado.Location = new System.Drawing.Point(3, 38);
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
			this.dgvListado.Size = new System.Drawing.Size(530, 304);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 10;
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colTitle
			// 
			this.colTitle.HeaderText = "Titulo";
			this.colTitle.Name = "colTitle";
			this.colTitle.ReadOnly = true;
			// 
			// colModifiedDate
			// 
			this.colModifiedDate.FillWeight = 60F;
			this.colModifiedDate.HeaderText = "Ult. Modificación";
			this.colModifiedDate.Name = "colModifiedDate";
			this.colModifiedDate.ReadOnly = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 357);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(60, 33);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(297, 357);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(71, 33);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(374, 357);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(71, 33);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(462, 357);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(71, 33);
			this.btnNuevo.TabIndex = 2;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseSelectable = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(462, 3);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(71, 29);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseSelectable = true;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(78, 3);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(377, 29);
			this.txtBuscar.TabIndex = 1;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 7);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(69, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Busqueda:";
			// 
			// tabPageRegistro
			// 
			this.tabPageRegistro.Controls.Add(this.panelRegistro);
			this.tabPageRegistro.HorizontalScrollbarBarColor = true;
			this.tabPageRegistro.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageRegistro.HorizontalScrollbarSize = 6;
			this.tabPageRegistro.Location = new System.Drawing.Point(4, 38);
			this.tabPageRegistro.Name = "tabPageRegistro";
			this.tabPageRegistro.Size = new System.Drawing.Size(536, 393);
			this.tabPageRegistro.TabIndex = 1;
			this.tabPageRegistro.Text = "Registro";
			this.tabPageRegistro.VerticalScrollbarBarColor = true;
			this.tabPageRegistro.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageRegistro.VerticalScrollbarSize = 7;
			// 
			// panelRegistro
			// 
			this.panelRegistro.BackColor = System.Drawing.Color.White;
			this.panelRegistro.Controls.Add(this.btnGuardar);
			this.panelRegistro.Controls.Add(this.btnCancelar);
			this.panelRegistro.Controls.Add(this.groupBox1);
			this.panelRegistro.Controls.Add(this.cboDistrito);
			this.panelRegistro.Controls.Add(this.cboProvincia);
			this.panelRegistro.Controls.Add(this.cboDepartamento);
			this.panelRegistro.Controls.Add(this.metroLabel5);
			this.panelRegistro.Controls.Add(this.metroLabel4);
			this.panelRegistro.Controls.Add(this.metroLabel3);
			this.panelRegistro.Controls.Add(this.chboPrincipal);
			this.panelRegistro.Controls.Add(this.txtTelefono);
			this.panelRegistro.Controls.Add(this.txtEmail);
			this.panelRegistro.Controls.Add(this.txtCodigoLocal);
			this.panelRegistro.Controls.Add(this.metroLabel8);
			this.panelRegistro.Controls.Add(this.metroLabel7);
			this.panelRegistro.Controls.Add(this.metroLabel6);
			this.panelRegistro.Controls.Add(this.txtDireccion);
			this.panelRegistro.Controls.Add(this.metroLabel2);
			this.panelRegistro.Enabled = false;
			this.panelRegistro.Location = new System.Drawing.Point(0, 0);
			this.panelRegistro.Name = "panelRegistro";
			this.panelRegistro.Size = new System.Drawing.Size(536, 393);
			this.panelRegistro.TabIndex = 2;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(450, 355);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(83, 35);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Hecho";
			this.btnGuardar.UseSelectable = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(376, 355);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(68, 35);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnPreview);
			this.groupBox1.Controls.Add(this.nudZoom);
			this.groupBox1.Controls.Add(this.metroLabel11);
			this.groupBox1.Controls.Add(this.metroLabel10);
			this.groupBox1.Controls.Add(this.txtLongitud);
			this.groupBox1.Controls.Add(this.metroLabel9);
			this.groupBox1.Controls.Add(this.txtLatitud);
			this.groupBox1.Location = new System.Drawing.Point(3, 213);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(530, 105);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Geo Localización";
			// 
			// btnPreview
			// 
			this.btnPreview.Location = new System.Drawing.Point(447, 56);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(77, 29);
			this.btnPreview.TabIndex = 3;
			this.btnPreview.Text = "vista Previa";
			this.btnPreview.UseSelectable = true;
			// 
			// nudZoom
			// 
			this.nudZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudZoom.Location = new System.Drawing.Point(358, 56);
			this.nudZoom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudZoom.Name = "nudZoom";
			this.nudZoom.Size = new System.Drawing.Size(49, 29);
			this.nudZoom.TabIndex = 2;
			this.nudZoom.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
			// 
			// metroLabel11
			// 
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new System.Drawing.Point(358, 34);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new System.Drawing.Size(45, 19);
			this.metroLabel11.TabIndex = 0;
			this.metroLabel11.Text = "Zoom";
			// 
			// metroLabel10
			// 
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new System.Drawing.Point(176, 34);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new System.Drawing.Size(60, 19);
			this.metroLabel10.TabIndex = 0;
			this.metroLabel10.Text = "Longitud";
			// 
			// txtLongitud
			// 
			this.txtLongitud.Location = new System.Drawing.Point(176, 56);
			this.txtLongitud.Name = "txtLongitud";
			this.txtLongitud.Size = new System.Drawing.Size(176, 29);
			this.txtLongitud.TabIndex = 1;
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(6, 34);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(48, 19);
			this.metroLabel9.TabIndex = 0;
			this.metroLabel9.Text = "Latitud";
			// 
			// txtLatitud
			// 
			this.txtLatitud.Location = new System.Drawing.Point(6, 56);
			this.txtLatitud.Name = "txtLatitud";
			this.txtLatitud.Size = new System.Drawing.Size(164, 29);
			this.txtLatitud.TabIndex = 1;
			// 
			// cboDistrito
			// 
			this.cboDistrito.FormattingEnabled = true;
			this.cboDistrito.Location = new System.Drawing.Point(361, 103);
			this.cboDistrito.Name = "cboDistrito";
			this.cboDistrito.Size = new System.Drawing.Size(172, 29);
			this.cboDistrito.TabIndex = 4;
			this.cboDistrito.Text = "Seleccione...";
			// 
			// cboProvincia
			// 
			this.cboProvincia.FormattingEnabled = true;
			this.cboProvincia.Location = new System.Drawing.Point(179, 102);
			this.cboProvincia.Name = "cboProvincia";
			this.cboProvincia.Size = new System.Drawing.Size(176, 29);
			this.cboProvincia.TabIndex = 4;
			this.cboProvincia.Text = "Seleccione...";
			// 
			// cboDepartamento
			// 
			this.cboDepartamento.FormattingEnabled = true;
			this.cboDepartamento.Location = new System.Drawing.Point(3, 102);
			this.cboDepartamento.Name = "cboDepartamento";
			this.cboDepartamento.Size = new System.Drawing.Size(170, 29);
			this.cboDepartamento.TabIndex = 4;
			this.cboDepartamento.Text = "Seleccione...";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(179, 80);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(62, 19);
			this.metroLabel5.TabIndex = 3;
			this.metroLabel5.Text = "Provincia";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(361, 80);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(50, 19);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "Distrito";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(3, 80);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(95, 19);
			this.metroLabel3.TabIndex = 3;
			this.metroLabel3.Text = "Departamento";
			// 
			// chboPrincipal
			// 
			this.chboPrincipal.Location = new System.Drawing.Point(462, 37);
			this.chboPrincipal.Name = "chboPrincipal";
			this.chboPrincipal.Size = new System.Drawing.Size(71, 29);
			this.chboPrincipal.Style = MetroFramework.MetroColorStyle.Green;
			this.chboPrincipal.TabIndex = 2;
			this.chboPrincipal.Text = "Principal";
			this.chboPrincipal.UseSelectable = true;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(179, 167);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(176, 29);
			this.txtTelefono.TabIndex = 1;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(361, 167);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(172, 29);
			this.txtEmail.TabIndex = 1;
			// 
			// txtCodigoLocal
			// 
			this.txtCodigoLocal.Location = new System.Drawing.Point(3, 167);
			this.txtCodigoLocal.Name = "txtCodigoLocal";
			this.txtCodigoLocal.Size = new System.Drawing.Size(170, 29);
			this.txtCodigoLocal.TabIndex = 1;
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(361, 145);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(48, 19);
			this.metroLabel8.TabIndex = 0;
			this.metroLabel8.Text = "Email\'s";
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(179, 145);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(63, 19);
			this.metroLabel7.TabIndex = 0;
			this.metroLabel7.Text = "Telefonos";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(3, 145);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(71, 19);
			this.metroLabel6.TabIndex = 0;
			this.metroLabel6.Text = "Cod. Local";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(3, 37);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(453, 29);
			this.txtDireccion.TabIndex = 1;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 15);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(63, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Dirección";
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(25, 520);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// frm_Branches
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Branches";
			this.Padding = new System.Windows.Forms.Padding(25, 77, 25, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Sucursales de la Institución";
			this.panel1.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPageListado.ResumeLayout(false);
			this.panelListado.ResumeLayout(false);
			this.panelListado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.tabPageRegistro.ResumeLayout(false);
			this.panelRegistro.ResumeLayout(false);
			this.panelRegistro.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroTabControl tabControl;
		private MetroFramework.Controls.MetroTabPage tabPageListado;
		private MetroFramework.Controls.MetroTabPage tabPageRegistro;
		private System.Windows.Forms.Panel panelListado;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvListado;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroButton btnNuevo;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private System.Windows.Forms.Panel panelRegistro;
		private System.Windows.Forms.ComboBox cboDistrito;
		private System.Windows.Forms.ComboBox cboProvincia;
		private System.Windows.Forms.ComboBox cboDepartamento;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroCheckBox chboPrincipal;
		private System.Windows.Forms.TextBox txtDireccion;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtCodigoLocal;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private System.Windows.Forms.GroupBox groupBox1;
		private MetroFramework.Controls.MetroButton btnPreview;
		private System.Windows.Forms.NumericUpDown nudZoom;
		private MetroFramework.Controls.MetroLabel metroLabel11;
		private MetroFramework.Controls.MetroLabel metroLabel10;
		private System.Windows.Forms.TextBox txtLongitud;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private System.Windows.Forms.TextBox txtLatitud;
	}
}