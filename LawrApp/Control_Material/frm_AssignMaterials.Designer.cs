namespace LawrApp.Control_Material
{
	partial class frm_AssignMaterials
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelMain = new System.Windows.Forms.Panel();
			this.scParent = new System.Windows.Forms.SplitContainer();
			this.panelDatos = new System.Windows.Forms.Panel();
			this.cboSalones = new MetroFramework.Controls.MetroComboBox();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnAgregar = new MetroFramework.Controls.MetroButton();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.btnBuscar = new MetroFramework.Controls.MetroButton();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.panelRegistros = new System.Windows.Forms.Panel();
			this.dgvListado = new MetroFramework.Controls.MetroGrid();
			this.btnElimar = new MetroFramework.Controls.MetroButton();
			this.btnFilters = new MetroFramework.Controls.MetroButton();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.txtFilters = new System.Windows.Forms.TextBox();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scParent)).BeginInit();
			this.scParent.Panel1.SuspendLayout();
			this.scParent.Panel2.SuspendLayout();
			this.scParent.SuspendLayout();
			this.panelDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.panelRegistros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.scParent);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(20, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(760, 498);
			this.panelMain.TabIndex = 0;
			// 
			// scParent
			// 
			this.scParent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scParent.Location = new System.Drawing.Point(0, 0);
			this.scParent.Name = "scParent";
			// 
			// scParent.Panel1
			// 
			this.scParent.Panel1.Controls.Add(this.panelDatos);
			// 
			// scParent.Panel2
			// 
			this.scParent.Panel2.Controls.Add(this.panelRegistros);
			this.scParent.Size = new System.Drawing.Size(760, 498);
			this.scParent.SplitterDistance = 253;
			this.scParent.TabIndex = 0;
			// 
			// panelDatos
			// 
			this.panelDatos.Controls.Add(this.cboSalones);
			this.panelDatos.Controls.Add(this.btnCancelar);
			this.panelDatos.Controls.Add(this.btnSalir);
			this.panelDatos.Controls.Add(this.btnAgregar);
			this.panelDatos.Controls.Add(this.nudCantidad);
			this.panelDatos.Controls.Add(this.metroLabel6);
			this.panelDatos.Controls.Add(this.btnBuscar);
			this.panelDatos.Controls.Add(this.txtModelo);
			this.panelDatos.Controls.Add(this.txtMarca);
			this.panelDatos.Controls.Add(this.txtCategoria);
			this.panelDatos.Controls.Add(this.txtDescription);
			this.panelDatos.Controls.Add(this.metroLabel5);
			this.panelDatos.Controls.Add(this.metroLabel4);
			this.panelDatos.Controls.Add(this.metroLabel3);
			this.panelDatos.Controls.Add(this.metroLabel2);
			this.panelDatos.Controls.Add(this.metroLabel1);
			this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDatos.Location = new System.Drawing.Point(0, 0);
			this.panelDatos.Name = "panelDatos";
			this.panelDatos.Padding = new System.Windows.Forms.Padding(5);
			this.panelDatos.Size = new System.Drawing.Size(253, 498);
			this.panelDatos.TabIndex = 0;
			// 
			// cboSalones
			// 
			this.cboSalones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cboSalones.FormattingEnabled = true;
			this.cboSalones.ItemHeight = 23;
			this.cboSalones.Location = new System.Drawing.Point(8, 37);
			this.cboSalones.Name = "cboSalones";
			this.cboSalones.PromptText = "Seleccione...";
			this.cboSalones.Size = new System.Drawing.Size(237, 29);
			this.cboSalones.TabIndex = 10;
			this.cboSalones.UseSelectable = true;
			this.cboSalones.SelectionChangeCommitted += new System.EventHandler(this.cboSalones_SelectionChangeCommitted);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Location = new System.Drawing.Point(179, 461);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(66, 29);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnSalir.Location = new System.Drawing.Point(8, 461);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(57, 29);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Location = new System.Drawing.Point(179, 364);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(66, 29);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseSelectable = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// nudCantidad
			// 
			this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudCantidad.Enabled = false;
			this.nudCantidad.Location = new System.Drawing.Point(8, 364);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(148, 29);
			this.nudCantidad.TabIndex = 6;
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(8, 342);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(62, 19);
			this.metroLabel6.TabIndex = 5;
			this.metroLabel6.Text = "Cantidad";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnBuscar.Enabled = false;
			this.btnBuscar.Location = new System.Drawing.Point(210, 101);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(35, 29);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "...";
			this.btnBuscar.UseSelectable = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtModelo
			// 
			this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModelo.BackColor = System.Drawing.Color.White;
			this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtModelo.Enabled = false;
			this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.txtModelo.Location = new System.Drawing.Point(8, 298);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.ReadOnly = true;
			this.txtModelo.Size = new System.Drawing.Size(237, 22);
			this.txtModelo.TabIndex = 3;
			this.txtModelo.TabStop = false;
			// 
			// txtMarca
			// 
			this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarca.BackColor = System.Drawing.Color.White;
			this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMarca.Enabled = false;
			this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.txtMarca.Location = new System.Drawing.Point(8, 232);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.ReadOnly = true;
			this.txtMarca.Size = new System.Drawing.Size(237, 22);
			this.txtMarca.TabIndex = 3;
			this.txtMarca.TabStop = false;
			// 
			// txtCategoria
			// 
			this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCategoria.BackColor = System.Drawing.Color.White;
			this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCategoria.Enabled = false;
			this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.txtCategoria.Location = new System.Drawing.Point(8, 166);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.ReadOnly = true;
			this.txtCategoria.Size = new System.Drawing.Size(237, 22);
			this.txtCategoria.TabIndex = 3;
			this.txtCategoria.TabStop = false;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.BackColor = System.Drawing.Color.White;
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.txtDescription.Location = new System.Drawing.Point(8, 101);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.Size = new System.Drawing.Size(196, 29);
			this.txtDescription.TabIndex = 3;
			this.txtDescription.TabStop = false;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(8, 276);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(55, 19);
			this.metroLabel5.TabIndex = 2;
			this.metroLabel5.Text = "Modelo";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(8, 210);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(46, 19);
			this.metroLabel4.TabIndex = 2;
			this.metroLabel4.Text = "Marca";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(8, 144);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(67, 19);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "Categoria";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(8, 79);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(57, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Material";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(8, 15);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(53, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Salones";
			// 
			// panelRegistros
			// 
			this.panelRegistros.Controls.Add(this.dgvListado);
			this.panelRegistros.Controls.Add(this.btnElimar);
			this.panelRegistros.Controls.Add(this.btnFilters);
			this.panelRegistros.Controls.Add(this.metroLabel7);
			this.panelRegistros.Controls.Add(this.txtFilters);
			this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRegistros.Enabled = false;
			this.panelRegistros.Location = new System.Drawing.Point(0, 0);
			this.panelRegistros.Name = "panelRegistros";
			this.panelRegistros.Padding = new System.Windows.Forms.Padding(5);
			this.panelRegistros.Size = new System.Drawing.Size(503, 498);
			this.panelRegistros.TabIndex = 0;
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AllowUserToOrderColumns = true;
			this.dgvListado.AllowUserToResizeColumns = false;
			this.dgvListado.AllowUserToResizeRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CausesValidation = false;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListado.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListado.EnableHeadersVisualStyles = false;
			this.dgvListado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListado.Location = new System.Drawing.Point(8, 43);
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListado.RowTemplate.Height = 31;
			this.dgvListado.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.Size = new System.Drawing.Size(487, 404);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 164;
			this.dgvListado.UseCustomBackColor = true;
			this.dgvListado.UseCustomForeColor = true;
			this.dgvListado.UseStyleColors = true;
			// 
			// btnElimar
			// 
			this.btnElimar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnElimar.Location = new System.Drawing.Point(407, 461);
			this.btnElimar.Name = "btnElimar";
			this.btnElimar.Size = new System.Drawing.Size(88, 29);
			this.btnElimar.TabIndex = 162;
			this.btnElimar.Text = "Eliminar Fila(s)";
			this.btnElimar.UseSelectable = true;
			this.btnElimar.Click += new System.EventHandler(this.btnElimar_Click);
			// 
			// btnFilters
			// 
			this.btnFilters.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnFilters.Location = new System.Drawing.Point(433, 8);
			this.btnFilters.Name = "btnFilters";
			this.btnFilters.Size = new System.Drawing.Size(62, 29);
			this.btnFilters.TabIndex = 2;
			this.btnFilters.Text = "Buscar";
			this.btnFilters.UseSelectable = true;
			// 
			// metroLabel7
			// 
			this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(8, 15);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(47, 19);
			this.metroLabel7.TabIndex = 1;
			this.metroLabel7.Text = "Filtrar:";
			// 
			// txtFilters
			// 
			this.txtFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilters.Location = new System.Drawing.Point(61, 8);
			this.txtFilters.Name = "txtFilters";
			this.txtFilters.Size = new System.Drawing.Size(366, 29);
			this.txtFilters.TabIndex = 0;
			this.txtFilters.TextChanged += new System.EventHandler(this.txtFilters_TextChanged);
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(756, 571);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.TabStop = false;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// frm_AssignMaterials
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_AssignMaterials";
			this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Asignar Materiales a Aulas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_AssignMaterials_FormClosing);
			this.Load += new System.EventHandler(this.frm_AssignMaterials_Load);
			this.panelMain.ResumeLayout(false);
			this.scParent.Panel1.ResumeLayout(false);
			this.scParent.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scParent)).EndInit();
			this.scParent.ResumeLayout(false);
			this.panelDatos.ResumeLayout(false);
			this.panelDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.panelRegistros.ResumeLayout(false);
			this.panelRegistros.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.SplitContainer scParent;
		private System.Windows.Forms.Panel panelDatos;
		private System.Windows.Forms.Panel panelRegistros;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnBuscar;
		private System.Windows.Forms.TextBox txtDescription;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtCategoria;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnAgregar;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroButton btnFilters;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private System.Windows.Forms.TextBox txtFilters;
		private MetroFramework.Controls.MetroButton btnElimar;
		private MetroFramework.Controls.MetroComboBox cboSalones;
		private MetroFramework.Controls.MetroGrid dgvListado;
	}
}