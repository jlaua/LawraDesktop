namespace LawrApp.Control_Material
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
			this.toltipValid = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain = new System.Windows.Forms.Panel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.tabpageMain = new MetroFramework.Controls.MetroTabControl();
			this.tabpagMaterial = new MetroFramework.Controls.MetroTabPage();
			this.tabpagRegistro = new MetroFramework.Controls.MetroTabPage();
			this.panelSearch = new MetroFramework.Controls.MetroPanel();
			this.panelRegister = new MetroFramework.Controls.MetroPanel();
			this.txtFiltrar = new System.Windows.Forms.TextBox();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.btnNuevo = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.MetroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.cboCategoria = new System.Windows.Forms.ComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.cboMarca = new System.Windows.Forms.ComboBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtCostoReparacion = new System.Windows.Forms.TextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.lblValidateDescripcion = new MetroFramework.Controls.MetroLabel();
			this.lblValidateCategoria = new MetroFramework.Controls.MetroLabel();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.panelMain.SuspendLayout();
			this.tabpageMain.SuspendLayout();
			this.tabpagMaterial.SuspendLayout();
			this.tabpagRegistro.SuspendLayout();
			this.panelSearch.SuspendLayout();
			this.panelRegister.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// toltipValid
			// 
			this.toltipValid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipValid.ToolTipTitle = "Requerido";
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.tabpageMain);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(590, 398);
			this.panelMain.TabIndex = 0;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(601, 471);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(16, 16);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.TabIndex = 1;
			this.pgsLoad.TabStop = false;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			// 
			// tabpageMain
			// 
			this.tabpageMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabpageMain.CausesValidation = false;
			this.tabpageMain.Controls.Add(this.tabpagMaterial);
			this.tabpageMain.Controls.Add(this.tabpagRegistro);
			this.tabpageMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabpageMain.HotTrack = true;
			this.tabpageMain.Location = new System.Drawing.Point(3, 3);
			this.tabpageMain.Name = "tabpageMain";
			this.tabpageMain.SelectedIndex = 1;
			this.tabpageMain.Size = new System.Drawing.Size(584, 392);
			this.tabpageMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabpageMain.Style = MetroFramework.MetroColorStyle.Blue;
			this.tabpageMain.TabIndex = 1;
			this.tabpageMain.TabStop = false;
			this.tabpageMain.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tabpageMain.UseSelectable = true;
			// 
			// tabpagMaterial
			// 
			this.tabpagMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabpagMaterial.Controls.Add(this.panelSearch);
			this.tabpagMaterial.HorizontalScrollbarBarColor = true;
			this.tabpagMaterial.HorizontalScrollbarHighlightOnWheel = true;
			this.tabpagMaterial.HorizontalScrollbarSize = 20;
			this.tabpagMaterial.Location = new System.Drawing.Point(4, 41);
			this.tabpagMaterial.Name = "tabpagMaterial";
			this.tabpagMaterial.Size = new System.Drawing.Size(576, 347);
			this.tabpagMaterial.Style = MetroFramework.MetroColorStyle.Blue;
			this.tabpagMaterial.TabIndex = 0;
			this.tabpagMaterial.Text = "Listados";
			this.tabpagMaterial.VerticalScrollbarBarColor = false;
			this.tabpagMaterial.VerticalScrollbarHighlightOnWheel = false;
			this.tabpagMaterial.VerticalScrollbarSize = 10;
			// 
			// tabpagRegistro
			// 
			this.tabpagRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabpagRegistro.Controls.Add(this.panelRegister);
			this.tabpagRegistro.HorizontalScrollbarBarColor = true;
			this.tabpagRegistro.HorizontalScrollbarHighlightOnWheel = true;
			this.tabpagRegistro.HorizontalScrollbarSize = 20;
			this.tabpagRegistro.Location = new System.Drawing.Point(4, 41);
			this.tabpagRegistro.Name = "tabpagRegistro";
			this.tabpagRegistro.Size = new System.Drawing.Size(576, 347);
			this.tabpagRegistro.TabIndex = 1;
			this.tabpagRegistro.Text = "Registros";
			this.tabpagRegistro.VerticalScrollbarBarColor = true;
			this.tabpagRegistro.VerticalScrollbarHighlightOnWheel = false;
			this.tabpagRegistro.VerticalScrollbarSize = 10;
			// 
			// panelSearch
			// 
			this.panelSearch.AutoSize = true;
			this.panelSearch.Controls.Add(this.dgvListado);
			this.panelSearch.Controls.Add(this.btnSalir);
			this.panelSearch.Controls.Add(this.btnEliminar);
			this.panelSearch.Controls.Add(this.btnModificar);
			this.panelSearch.Controls.Add(this.btnNuevo);
			this.panelSearch.Controls.Add(this.btnbuscar);
			this.panelSearch.Controls.Add(this.txtFiltrar);
			this.panelSearch.HorizontalScrollbarBarColor = true;
			this.panelSearch.HorizontalScrollbarHighlightOnWheel = false;
			this.panelSearch.HorizontalScrollbarSize = 10;
			this.panelSearch.Location = new System.Drawing.Point(3, 3);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(576, 348);
			this.panelSearch.TabIndex = 2;
			this.panelSearch.VerticalScrollbarBarColor = true;
			this.panelSearch.VerticalScrollbarHighlightOnWheel = false;
			this.panelSearch.VerticalScrollbarSize = 10;
			// 
			// panelRegister
			// 
			this.panelRegister.AutoSize = true;
			this.panelRegister.Controls.Add(this.lblValidateCategoria);
			this.panelRegister.Controls.Add(this.lblValidateDescripcion);
			this.panelRegister.Controls.Add(this.btnCancelar);
			this.panelRegister.Controls.Add(this.btnGuardar);
			this.panelRegister.Controls.Add(this.txtObservaciones);
			this.panelRegister.Controls.Add(this.metroLabel6);
			this.panelRegister.Controls.Add(this.txtCostoReparacion);
			this.panelRegister.Controls.Add(this.metroLabel5);
			this.panelRegister.Controls.Add(this.txtModelo);
			this.panelRegister.Controls.Add(this.metroLabel4);
			this.panelRegister.Controls.Add(this.cboMarca);
			this.panelRegister.Controls.Add(this.metroLabel3);
			this.panelRegister.Controls.Add(this.cboCategoria);
			this.panelRegister.Controls.Add(this.metroLabel2);
			this.panelRegister.Controls.Add(this.txtDescripcion);
			this.panelRegister.Controls.Add(this.MetroLabel1);
			this.panelRegister.Enabled = false;
			this.panelRegister.HorizontalScrollbarBarColor = true;
			this.panelRegister.HorizontalScrollbarHighlightOnWheel = false;
			this.panelRegister.HorizontalScrollbarSize = 10;
			this.panelRegister.Location = new System.Drawing.Point(3, 3);
			this.panelRegister.Name = "panelRegister";
			this.panelRegister.Size = new System.Drawing.Size(568, 339);
			this.panelRegister.TabIndex = 2;
			this.panelRegister.VerticalScrollbarBarColor = true;
			this.panelRegister.VerticalScrollbarHighlightOnWheel = false;
			this.panelRegister.VerticalScrollbarSize = 10;
			// 
			// txtFiltrar
			// 
			this.txtFiltrar.Location = new System.Drawing.Point(3, 3);
			this.txtFiltrar.Name = "txtFiltrar";
			this.txtFiltrar.Size = new System.Drawing.Size(489, 29);
			this.txtFiltrar.TabIndex = 2;
			this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(511, 3);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(62, 29);
			this.btnbuscar.TabIndex = 3;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseSelectable = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(498, 312);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 29);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseSelectable = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(399, 312);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 29);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(318, 312);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 29);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 312);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 29);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// MetroLabel1
			// 
			this.MetroLabel1.AutoSize = true;
			this.MetroLabel1.Location = new System.Drawing.Point(14, 12);
			this.MetroLabel1.Name = "MetroLabel1";
			this.MetroLabel1.Size = new System.Drawing.Size(76, 19);
			this.MetroLabel1.TabIndex = 2;
			this.MetroLabel1.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.Location = new System.Drawing.Point(14, 34);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(543, 29);
			this.txtDescripcion.TabIndex = 3;
			this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(14, 73);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(67, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Categoria";
			// 
			// cboCategoria
			// 
			this.cboCategoria.FormattingEnabled = true;
			this.cboCategoria.Location = new System.Drawing.Point(14, 95);
			this.cboCategoria.Name = "cboCategoria";
			this.cboCategoria.Size = new System.Drawing.Size(244, 29);
			this.cboCategoria.TabIndex = 5;
			this.cboCategoria.SelectionChangeCommitted += new System.EventHandler(this.cboCategoria_SelectionChangeCommitted);
			this.cboCategoria.TextChanged += new System.EventHandler(this.cboCategoria_TextChanged);
			this.cboCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCategoria_KeyDown);
			this.cboCategoria.Leave += new System.EventHandler(this.cboCategoria_Leave);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(277, 73);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(46, 19);
			this.metroLabel3.TabIndex = 6;
			this.metroLabel3.Text = "Marca";
			// 
			// cboMarca
			// 
			this.cboMarca.FormattingEnabled = true;
			this.cboMarca.Location = new System.Drawing.Point(277, 95);
			this.cboMarca.Name = "cboMarca";
			this.cboMarca.Size = new System.Drawing.Size(280, 29);
			this.cboMarca.TabIndex = 7;
			this.cboMarca.SelectionChangeCommitted += new System.EventHandler(this.cboMarca_SelectionChangeCommitted);
			this.cboMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMarca_KeyDown);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(14, 134);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(55, 19);
			this.metroLabel4.TabIndex = 8;
			this.metroLabel4.Text = "Modelo";
			// 
			// txtModelo
			// 
			this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModelo.Location = new System.Drawing.Point(14, 156);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(244, 29);
			this.txtModelo.TabIndex = 9;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(277, 134);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(198, 19);
			this.metroLabel5.TabIndex = 10;
			this.metroLabel5.Text = "Costo de Reparación (Estimado)";
			// 
			// txtCostoReparacion
			// 
			this.txtCostoReparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCostoReparacion.Location = new System.Drawing.Point(277, 156);
			this.txtCostoReparacion.Name = "txtCostoReparacion";
			this.txtCostoReparacion.Size = new System.Drawing.Size(280, 29);
			this.txtCostoReparacion.TabIndex = 11;
			this.txtCostoReparacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoReparacion_KeyPress);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(14, 195);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(95, 19);
			this.metroLabel6.TabIndex = 12;
			this.metroLabel6.Text = "Observaciones";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservaciones.Location = new System.Drawing.Point(14, 217);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(543, 71);
			this.txtObservaciones.TabIndex = 13;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(490, 307);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 29);
			this.btnGuardar.TabIndex = 14;
			this.btnGuardar.Text = "Hecho";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(409, 307);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 29);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblValidateDescripcion
			// 
			this.lblValidateDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblValidateDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblValidateDescripcion.ForeColor = System.Drawing.Color.Red;
			this.lblValidateDescripcion.Location = new System.Drawing.Point(88, 13);
			this.lblValidateDescripcion.Name = "lblValidateDescripcion";
			this.lblValidateDescripcion.Size = new System.Drawing.Size(16, 16);
			this.lblValidateDescripcion.TabIndex = 16;
			this.lblValidateDescripcion.Text = "*";
			this.lblValidateDescripcion.UseCustomBackColor = true;
			this.lblValidateDescripcion.UseCustomForeColor = true;
			// 
			// lblValidateCategoria
			// 
			this.lblValidateCategoria.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCategoria.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblValidateCategoria.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblValidateCategoria.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCategoria.Location = new System.Drawing.Point(78, 74);
			this.lblValidateCategoria.Name = "lblValidateCategoria";
			this.lblValidateCategoria.Size = new System.Drawing.Size(16, 16);
			this.lblValidateCategoria.TabIndex = 17;
			this.lblValidateCategoria.Text = "*";
			this.lblValidateCategoria.UseCustomBackColor = true;
			this.lblValidateCategoria.UseCustomForeColor = true;
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
			this.dgvListado.Location = new System.Drawing.Point(3, 38);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
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
			this.dgvListado.Size = new System.Drawing.Size(570, 256);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 9;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
			// 
			// frm_Material
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(650, 500);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Material";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Text = "Registro Material";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Material_FormClosing);
			this.Load += new System.EventHandler(this.frm_Material_Load);
			this.panelMain.ResumeLayout(false);
			this.tabpageMain.ResumeLayout(false);
			this.tabpagMaterial.ResumeLayout(false);
			this.tabpagMaterial.PerformLayout();
			this.tabpagRegistro.ResumeLayout(false);
			this.tabpagRegistro.PerformLayout();
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.panelRegister.ResumeLayout(false);
			this.panelRegister.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}
		
		private System.Windows.Forms.ToolTip toltipValid;

		#endregion
		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private MetroFramework.Controls.MetroTabControl tabpageMain;
		private MetroFramework.Controls.MetroTabPage tabpagMaterial;
		private MetroFramework.Controls.MetroTabPage tabpagRegistro;
		private MetroFramework.Controls.MetroPanel panelSearch;
		private MetroFramework.Controls.MetroPanel panelRegister;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private System.Windows.Forms.TextBox txtFiltrar;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroButton btnNuevo;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel MetroLabel1;
		private System.Windows.Forms.ComboBox cboMarca;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.ComboBox cboCategoria;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtCostoReparacion;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.TextBox txtModelo;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.TextBox txtObservaciones;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroLabel lblValidateDescripcion;
		private MetroFramework.Controls.MetroLabel lblValidateCategoria;
		private System.Windows.Forms.DataGridView dgvListado;


	}
}