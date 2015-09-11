namespace LawrApp.ControlMaterial
{
	partial class frm_Material
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.tabpageMain = new MetroFramework.Controls.MetroTabControl();
			this.tabpagMaterial = new MetroFramework.Controls.MetroTabPage();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.txtFiltrar = new System.Windows.Forms.TextBox();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.btnNuevo = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.tabpagRegistro = new MetroFramework.Controls.MetroTabPage();
			this.panelRegister = new System.Windows.Forms.Panel();
			this.lblValidateCostoResparacion = new System.Windows.Forms.Label();
			this.lblValidateCategoria = new System.Windows.Forms.Label();
			this.lblValidateDescripcion = new System.Windows.Forms.Label();
			this.cboMarca = new System.Windows.Forms.ComboBox();
			this.cboCategoria = new System.Windows.Forms.ComboBox();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.txtCostoReparacion = new System.Windows.Forms.TextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.toltipValid = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain.SuspendLayout();
			this.tabpageMain.SuspendLayout();
			this.tabpagMaterial.SuspendLayout();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.tabpagRegistro.SuspendLayout();
			this.panelRegister.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.tabpageMain);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(607, 385);
			this.panelMain.TabIndex = 0;
			// 
			// tabpageMain
			// 
			this.tabpageMain.Controls.Add(this.tabpagMaterial);
			this.tabpageMain.Controls.Add(this.tabpagRegistro);
			this.tabpageMain.Location = new System.Drawing.Point(3, 5);
			this.tabpageMain.Name = "tabpageMain";
			this.tabpageMain.SelectedIndex = 1;
			this.tabpageMain.Size = new System.Drawing.Size(601, 377);
			this.tabpageMain.Style = MetroFramework.MetroColorStyle.Blue;
			this.tabpageMain.TabIndex = 0;
			this.tabpageMain.UseCustomForeColor = true;
			this.tabpageMain.UseSelectable = true;
			// 
			// tabpagMaterial
			// 
			this.tabpagMaterial.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabpagMaterial.Controls.Add(this.panelSearch);
			this.tabpagMaterial.HorizontalScrollbarBarColor = true;
			this.tabpagMaterial.HorizontalScrollbarHighlightOnWheel = false;
			this.tabpagMaterial.HorizontalScrollbarSize = 1;
			this.tabpagMaterial.Location = new System.Drawing.Point(4, 38);
			this.tabpagMaterial.Name = "tabpagMaterial";
			this.tabpagMaterial.Size = new System.Drawing.Size(593, 335);
			this.tabpagMaterial.TabIndex = 0;
			this.tabpagMaterial.Text = "Listado";
			this.tabpagMaterial.VerticalScrollbarBarColor = true;
			this.tabpagMaterial.VerticalScrollbarHighlightOnWheel = false;
			this.tabpagMaterial.VerticalScrollbarSize = 1;
			// 
			// panelSearch
			// 
			this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelSearch.Controls.Add(this.txtFiltrar);
			this.panelSearch.Controls.Add(this.btnSalir);
			this.panelSearch.Controls.Add(this.btnEliminar);
			this.panelSearch.Controls.Add(this.btnModificar);
			this.panelSearch.Controls.Add(this.btnNuevo);
			this.panelSearch.Controls.Add(this.dgvListado);
			this.panelSearch.Controls.Add(this.btnbuscar);
			this.panelSearch.Controls.Add(this.metroLabel1);
			this.panelSearch.Location = new System.Drawing.Point(3, 3);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(587, 331);
			this.panelSearch.TabIndex = 2;
			// 
			// txtFiltrar
			// 
			this.txtFiltrar.BackColor = System.Drawing.Color.White;
			this.txtFiltrar.Location = new System.Drawing.Point(59, 10);
			this.txtFiltrar.Name = "txtFiltrar";
			this.txtFiltrar.Size = new System.Drawing.Size(442, 29);
			this.txtFiltrar.TabIndex = 1;
			this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 298);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 30);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(325, 298);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 30);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(406, 298);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 30);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(507, 298);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 30);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseSelectable = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
			this.dgvListado.Location = new System.Drawing.Point(3, 45);
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
			this.dgvListado.Size = new System.Drawing.Size(581, 239);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 3;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(507, 10);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(77, 29);
			this.btnbuscar.TabIndex = 2;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 12);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Filtrado:";
			// 
			// tabpagRegistro
			// 
			this.tabpagRegistro.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabpagRegistro.Controls.Add(this.panelRegister);
			this.tabpagRegistro.HorizontalScrollbarBarColor = true;
			this.tabpagRegistro.HorizontalScrollbarHighlightOnWheel = false;
			this.tabpagRegistro.HorizontalScrollbarSize = 1;
			this.tabpagRegistro.Location = new System.Drawing.Point(4, 38);
			this.tabpagRegistro.Name = "tabpagRegistro";
			this.tabpagRegistro.Size = new System.Drawing.Size(593, 335);
			this.tabpagRegistro.TabIndex = 1;
			this.tabpagRegistro.Text = " Registro ";
			this.tabpagRegistro.VerticalScrollbarBarColor = true;
			this.tabpagRegistro.VerticalScrollbarHighlightOnWheel = false;
			this.tabpagRegistro.VerticalScrollbarSize = 1;
			// 
			// panelRegister
			// 
			this.panelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelRegister.Controls.Add(this.lblValidateCostoResparacion);
			this.panelRegister.Controls.Add(this.lblValidateCategoria);
			this.panelRegister.Controls.Add(this.lblValidateDescripcion);
			this.panelRegister.Controls.Add(this.cboMarca);
			this.panelRegister.Controls.Add(this.cboCategoria);
			this.panelRegister.Controls.Add(this.btnCancelar);
			this.panelRegister.Controls.Add(this.btnGuardar);
			this.panelRegister.Controls.Add(this.metroLabel7);
			this.panelRegister.Controls.Add(this.txtCostoReparacion);
			this.panelRegister.Controls.Add(this.metroLabel6);
			this.panelRegister.Controls.Add(this.txtObservaciones);
			this.panelRegister.Controls.Add(this.txtModelo);
			this.panelRegister.Controls.Add(this.txtDescripcion);
			this.panelRegister.Controls.Add(this.metroLabel5);
			this.panelRegister.Controls.Add(this.metroLabel4);
			this.panelRegister.Controls.Add(this.metroLabel3);
			this.panelRegister.Controls.Add(this.metroLabel2);
			this.panelRegister.Enabled = false;
			this.panelRegister.Location = new System.Drawing.Point(4, 3);
			this.panelRegister.Name = "panelRegister";
			this.panelRegister.Size = new System.Drawing.Size(576, 331);
			this.panelRegister.TabIndex = 3;
			// 
			// lblValidateCostoResparacion
			// 
			this.lblValidateCostoResparacion.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCostoResparacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateCostoResparacion.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCostoResparacion.Location = new System.Drawing.Point(423, 132);
			this.lblValidateCostoResparacion.Name = "lblValidateCostoResparacion";
			this.lblValidateCostoResparacion.Size = new System.Drawing.Size(24, 16);
			this.lblValidateCostoResparacion.TabIndex = 57;
			this.lblValidateCostoResparacion.Text = "*";
			// 
			// lblValidateCategoria
			// 
			this.lblValidateCategoria.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateCategoria.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCategoria.Location = new System.Drawing.Point(71, 73);
			this.lblValidateCategoria.Name = "lblValidateCategoria";
			this.lblValidateCategoria.Size = new System.Drawing.Size(24, 16);
			this.lblValidateCategoria.TabIndex = 56;
			this.lblValidateCategoria.Text = "*";
			// 
			// lblValidateDescripcion
			// 
			this.lblValidateDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateDescripcion.ForeColor = System.Drawing.Color.Red;
			this.lblValidateDescripcion.Location = new System.Drawing.Point(78, 18);
			this.lblValidateDescripcion.Name = "lblValidateDescripcion";
			this.lblValidateDescripcion.Size = new System.Drawing.Size(24, 16);
			this.lblValidateDescripcion.TabIndex = 55;
			this.lblValidateDescripcion.Text = "*";
			// 
			// cboMarca
			// 
			this.cboMarca.FormattingEnabled = true;
			this.cboMarca.Location = new System.Drawing.Point(313, 91);
			this.cboMarca.Name = "cboMarca";
			this.cboMarca.Size = new System.Drawing.Size(260, 29);
			this.cboMarca.TabIndex = 3;
			this.cboMarca.SelectionChangeCommitted += new System.EventHandler(this.cboMarca_SelectionChangeCommitted);
			this.cboMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMarca_KeyDown);
			this.cboMarca.Leave += new System.EventHandler(this.cboMarca_Leave);
			// 
			// cboCategoria
			// 
			this.cboCategoria.FormattingEnabled = true;
			this.cboCategoria.Location = new System.Drawing.Point(3, 92);
			this.cboCategoria.Name = "cboCategoria";
			this.cboCategoria.Size = new System.Drawing.Size(287, 29);
			this.cboCategoria.TabIndex = 2;
			this.cboCategoria.SelectionChangeCommitted += new System.EventHandler(this.cboCategoria_SelectionChangeCommitted);
			this.cboCategoria.TextChanged += new System.EventHandler(this.cboCategoria_TextChanged);
			this.cboCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCategoria_KeyDown);
			this.cboCategoria.Leave += new System.EventHandler(this.cboCategoria_Leave);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(417, 297);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 31);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(498, 297);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 31);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Hecho";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(309, 129);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(117, 19);
			this.metroLabel7.TabIndex = 16;
			this.metroLabel7.Text = "Costo Reparacion ";
			// 
			// txtCostoReparacion
			// 
			this.txtCostoReparacion.Location = new System.Drawing.Point(313, 151);
			this.txtCostoReparacion.Name = "txtCostoReparacion";
			this.txtCostoReparacion.Size = new System.Drawing.Size(260, 29);
			this.txtCostoReparacion.TabIndex = 5;
			this.txtCostoReparacion.TextChanged += new System.EventHandler(this.txtCostoReparacion_TextChanged);
			this.txtCostoReparacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoReparacion_KeyPress);
			this.txtCostoReparacion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(3, 129);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(59, 19);
			this.metroLabel6.TabIndex = 14;
			this.metroLabel6.Text = "Modelo ";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(3, 205);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(570, 76);
			this.txtObservaciones.TabIndex = 6;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(3, 151);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(287, 29);
			this.txtModelo.TabIndex = 4;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(3, 37);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(570, 29);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
			this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(309, 69);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(46, 19);
			this.metroLabel5.TabIndex = 8;
			this.metroLabel5.Text = "Marca";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(3, 69);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(71, 19);
			this.metroLabel4.TabIndex = 6;
			this.metroLabel4.Text = "Categoria ";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(3, 183);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(95, 19);
			this.metroLabel3.TabIndex = 4;
			this.metroLabel3.Text = "Observaciones";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 15);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(76, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Descripcion";
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(606, 483);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 152;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// toltipValid
			// 
			this.toltipValid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipValid.ToolTipTitle = "Requerido";
			// 
			// frm_Material
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(667, 514);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Material";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Text = "Registro Material";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistrarMaterial_FormClosing);
			this.Load += new System.EventHandler(this.frmRegistrarMaterial_Load_1);
			this.panelMain.ResumeLayout(false);
			this.tabpageMain.ResumeLayout(false);
			this.tabpagMaterial.ResumeLayout(false);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.tabpagRegistro.ResumeLayout(false);
			this.panelRegister.ResumeLayout(false);
			this.panelRegister.PerformLayout();
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroTabControl tabpageMain;
		private MetroFramework.Controls.MetroTabPage tabpagMaterial;
		private MetroFramework.Controls.MetroTabPage tabpagRegistro;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.Panel panelRegister;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroButton btnNuevo;
		private System.Windows.Forms.DataGridView dgvListado;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private System.Windows.Forms.TextBox txtCostoReparacion;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.TextBox txtFiltrar;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private System.Windows.Forms.ComboBox cboCategoria;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.ComboBox cboMarca;
		private System.Windows.Forms.ToolTip toltipValid;
		private System.Windows.Forms.Label lblValidateCategoria;
		private System.Windows.Forms.Label lblValidateDescripcion;
		private System.Windows.Forms.Label lblValidateCostoResparacion;

		#endregion
	}
}