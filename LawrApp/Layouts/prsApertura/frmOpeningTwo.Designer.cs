namespace LawrApp.Layouts.prsApertura
{
	partial class frmOpeningTwo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnImport = new MetroFramework.Controls.MetroButton();
			this.dgvSalon = new System.Windows.Forms.DataGridView();
			this.colsalonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colsalonMaxCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvNivel = new System.Windows.Forms.DataGridView();
			this.colnivelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colnivelMinAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colnivelMaxage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvTurno = new System.Windows.Forms.DataGridView();
			this.colturnoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvSeccion = new System.Windows.Forms.DataGridView();
			this.colseccionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvGrado = new System.Windows.Forms.DataGridView();
			this.colgradoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colseccionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPreview = new MetroFramework.Controls.MetroButton();
			this.btnNext = new MetroFramework.Controls.MetroButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
			this.ttError = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSalon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrado)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnImport);
			this.panelMain.Controls.Add(this.dgvSalon);
			this.panelMain.Controls.Add(this.dgvNivel);
			this.panelMain.Controls.Add(this.dgvTurno);
			this.panelMain.Controls.Add(this.dgvSeccion);
			this.panelMain.Controls.Add(this.dgvGrado);
			this.panelMain.Controls.Add(this.btnPreview);
			this.panelMain.Controls.Add(this.btnNext);
			this.panelMain.Controls.Add(this.label5);
			this.panelMain.Controls.Add(this.label4);
			this.panelMain.Controls.Add(this.label3);
			this.panelMain.Controls.Add(this.label2);
			this.panelMain.Controls.Add(this.label1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(27, 92);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(646, 427);
			this.panelMain.TabIndex = 0;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(3, 389);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(96, 35);
			this.btnImport.TabIndex = 16;
			this.btnImport.Text = "Importar";
			this.btnImport.UseSelectable = true;
			// 
			// dgvSalon
			// 
			this.dgvSalon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSalon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSalon.BackgroundColor = System.Drawing.Color.White;
			this.dgvSalon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSalon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSalon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSalon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSalon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsalonId,
            this.dataGridViewTextBoxColumn4,
            this.colsalonMaxCapacity});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSalon.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSalon.EnableHeadersVisualStyles = false;
			this.dgvSalon.Location = new System.Drawing.Point(375, 254);
			this.dgvSalon.MultiSelect = false;
			this.dgvSalon.Name = "dgvSalon";
			this.dgvSalon.RowHeadersVisible = false;
			this.dgvSalon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSalon.Size = new System.Drawing.Size(268, 114);
			this.dgvSalon.StandardTab = true;
			this.dgvSalon.TabIndex = 5;
			// 
			// colsalonId
			// 
			this.colsalonId.HeaderText = "Id";
			this.colsalonId.Name = "colsalonId";
			this.colsalonId.ReadOnly = true;
			this.colsalonId.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// colsalonMaxCapacity
			// 
			this.colsalonMaxCapacity.FillWeight = 70F;
			this.colsalonMaxCapacity.HeaderText = "Max. Cap.";
			this.colsalonMaxCapacity.Name = "colsalonMaxCapacity";
			// 
			// dgvNivel
			// 
			this.dgvNivel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNivel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvNivel.BackgroundColor = System.Drawing.Color.White;
			this.dgvNivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvNivel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvNivel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvNivel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNivel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnivelId,
            this.dataGridViewTextBoxColumn3,
            this.colnivelMinAge,
            this.colnivelMaxage});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvNivel.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvNivel.EnableHeadersVisualStyles = false;
			this.dgvNivel.Location = new System.Drawing.Point(12, 254);
			this.dgvNivel.MultiSelect = false;
			this.dgvNivel.Name = "dgvNivel";
			this.dgvNivel.RowHeadersVisible = false;
			this.dgvNivel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNivel.Size = new System.Drawing.Size(357, 114);
			this.dgvNivel.StandardTab = true;
			this.dgvNivel.TabIndex = 4;
			// 
			// colnivelId
			// 
			this.colnivelId.HeaderText = "Id";
			this.colnivelId.Name = "colnivelId";
			this.colnivelId.ReadOnly = true;
			this.colnivelId.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// colnivelMinAge
			// 
			this.colnivelMinAge.FillWeight = 70F;
			this.colnivelMinAge.HeaderText = "Edad Min.";
			this.colnivelMinAge.MaxInputLength = 2;
			this.colnivelMinAge.Name = "colnivelMinAge";
			// 
			// colnivelMaxage
			// 
			this.colnivelMaxage.FillWeight = 70F;
			this.colnivelMaxage.HeaderText = "Edad Max.";
			this.colnivelMaxage.MaxInputLength = 2;
			this.colnivelMaxage.Name = "colnivelMaxage";
			// 
			// dgvTurno
			// 
			this.dgvTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTurno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvTurno.BackgroundColor = System.Drawing.Color.White;
			this.dgvTurno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTurno.ColumnHeadersVisible = false;
			this.dgvTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colturnoId,
            this.dataGridViewTextBoxColumn2});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTurno.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvTurno.EnableHeadersVisualStyles = false;
			this.dgvTurno.Location = new System.Drawing.Point(414, 47);
			this.dgvTurno.MultiSelect = false;
			this.dgvTurno.Name = "dgvTurno";
			this.dgvTurno.RowHeadersVisible = false;
			this.dgvTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTurno.Size = new System.Drawing.Size(229, 172);
			this.dgvTurno.StandardTab = true;
			this.dgvTurno.TabIndex = 3;
			// 
			// colturnoId
			// 
			this.colturnoId.HeaderText = "Id";
			this.colturnoId.Name = "colturnoId";
			this.colturnoId.ReadOnly = true;
			this.colturnoId.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dgvSeccion
			// 
			this.dgvSeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSeccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSeccion.BackgroundColor = System.Drawing.Color.White;
			this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSeccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSeccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSeccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeccion.ColumnHeadersVisible = false;
			this.dgvSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colseccionId,
            this.dataGridViewTextBoxColumn1});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSeccion.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvSeccion.EnableHeadersVisualStyles = false;
			this.dgvSeccion.Location = new System.Drawing.Point(184, 47);
			this.dgvSeccion.MultiSelect = false;
			this.dgvSeccion.Name = "dgvSeccion";
			this.dgvSeccion.RowHeadersVisible = false;
			this.dgvSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSeccion.Size = new System.Drawing.Size(224, 172);
			this.dgvSeccion.StandardTab = true;
			this.dgvSeccion.TabIndex = 2;
			// 
			// colseccionId
			// 
			this.colseccionId.HeaderText = "Id";
			this.colseccionId.Name = "colseccionId";
			this.colseccionId.ReadOnly = true;
			this.colseccionId.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dgvGrado
			// 
			this.dgvGrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGrado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvGrado.BackgroundColor = System.Drawing.Color.White;
			this.dgvGrado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvGrado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvGrado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvGrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGrado.ColumnHeadersVisible = false;
			this.dgvGrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colgradoId,
            this.colseccionName});
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGrado.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgvGrado.EnableHeadersVisualStyles = false;
			this.dgvGrado.Location = new System.Drawing.Point(3, 47);
			this.dgvGrado.MultiSelect = false;
			this.dgvGrado.Name = "dgvGrado";
			this.dgvGrado.RowHeadersVisible = false;
			this.dgvGrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGrado.Size = new System.Drawing.Size(175, 172);
			this.dgvGrado.StandardTab = true;
			this.dgvGrado.TabIndex = 1;
			// 
			// colgradoId
			// 
			this.colgradoId.HeaderText = "Id";
			this.colgradoId.Name = "colgradoId";
			this.colgradoId.ReadOnly = true;
			this.colgradoId.Visible = false;
			// 
			// colseccionName
			// 
			this.colseccionName.HeaderText = "Nombre";
			this.colseccionName.Name = "colseccionName";
			// 
			// btnPreview
			// 
			this.btnPreview.Location = new System.Drawing.Point(445, 389);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(96, 35);
			this.btnPreview.TabIndex = 15;
			this.btnPreview.Text = "< Anterior";
			this.btnPreview.UseSelectable = true;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(547, 389);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(96, 35);
			this.btnNext.TabIndex = 14;
			this.btnNext.Text = "Siguiente >";
			this.btnNext.UseSelectable = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Niveles:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(415, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "turnos:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(184, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Secciones:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Grados:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(375, 231);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Salones:";
			// 
			// ttInfo
			// 
			this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttInfo.ToolTipTitle = "Info:";
			// 
			// ttError
			// 
			this.ttError.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
			this.ttError.ToolTipTitle = "Error:";
			// 
			// frmOpeningTwo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 550);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 550);
			this.Name = "frmOpeningTwo";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Configuraciones del Plantel";
			this.Load += new System.EventHandler(this.frmOpeningTwo_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSalon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroButton btnPreview;
		private MetroFramework.Controls.MetroButton btnNext;
		private System.Windows.Forms.DataGridView dgvGrado;
		private System.Windows.Forms.DataGridView dgvNivel;
		private System.Windows.Forms.DataGridView dgvTurno;
		private System.Windows.Forms.DataGridView dgvSeccion;
		private System.Windows.Forms.DataGridView dgvSalon;
		private System.Windows.Forms.DataGridViewTextBoxColumn colsalonId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn colsalonMaxCapacity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colnivelId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colnivelMinAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colnivelMaxage;
		private System.Windows.Forms.DataGridViewTextBoxColumn colturnoId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colseccionId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colgradoId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colseccionName;
		private MetroFramework.Controls.MetroButton btnImport;
		private System.Windows.Forms.ToolTip ttInfo;
		private System.Windows.Forms.ToolTip ttError;
	}
}