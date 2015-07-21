namespace LawrApp.Layouts.prsMatricula
{
	partial class frmAsignaClase
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.BtnNext = new MetroFramework.Controls.MetroButton();
			this.btnPreview = new MetroFramework.Controls.MetroButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnsearch = new MetroFramework.Controls.MetroButton();
			this.cboniveles = new System.Windows.Forms.ComboBox();
			this.txtname = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
			this.cboseccion = new System.Windows.Forms.ComboBox();
			this.cbogrado = new System.Windows.Forms.ComboBox();
			this.dgClases = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelMain.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgClases)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.dgClases);
			this.panelMain.Controls.Add(this.pgsLoading);
			this.panelMain.Controls.Add(this.BtnNext);
			this.panelMain.Controls.Add(this.btnPreview);
			this.panelMain.Controls.Add(this.groupBox2);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(27, 92);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(746, 477);
			this.panelMain.TabIndex = 0;
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(9, 458);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 3F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 41;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// BtnNext
			// 
			this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnNext.Location = new System.Drawing.Point(650, 442);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.Size = new System.Drawing.Size(87, 32);
			this.BtnNext.TabIndex = 6;
			this.BtnNext.Text = "Siguiente";
			this.BtnNext.UseSelectable = true;
			// 
			// btnPreview
			// 
			this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPreview.Location = new System.Drawing.Point(559, 442);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(85, 32);
			this.btnPreview.TabIndex = 7;
			this.btnPreview.Text = "Anterior";
			this.btnPreview.UseSelectable = true;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.metroLabel3);
			this.groupBox2.Controls.Add(this.metroLabel2);
			this.groupBox2.Controls.Add(this.metroLabel1);
			this.groupBox2.Controls.Add(this.btnsearch);
			this.groupBox2.Controls.Add(this.cboniveles);
			this.groupBox2.Controls.Add(this.txtname);
			this.groupBox2.Controls.Add(this.metroLabel13);
			this.groupBox2.Controls.Add(this.cboseccion);
			this.groupBox2.Controls.Add(this.cbogrado);
			this.groupBox2.Location = new System.Drawing.Point(3, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(740, 172);
			this.groupBox2.TabIndex = 40;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Configurar";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel3.Location = new System.Drawing.Point(389, 99);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(57, 19);
			this.metroLabel3.TabIndex = 31;
			this.metroLabel3.Text = "Sección:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel2.Location = new System.Drawing.Point(190, 99);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(50, 19);
			this.metroLabel2.TabIndex = 30;
			this.metroLabel2.Text = "Grado:";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.Location = new System.Drawing.Point(6, 99);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(42, 19);
			this.metroLabel1.TabIndex = 29;
			this.metroLabel1.Text = "Nivel:";
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(651, 122);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(83, 29);
			this.btnsearch.TabIndex = 4;
			this.btnsearch.Text = "Buscar";
			this.btnsearch.UseSelectable = true;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// cboniveles
			// 
			this.cboniveles.FormattingEnabled = true;
			this.cboniveles.Location = new System.Drawing.Point(6, 122);
			this.cboniveles.Name = "cboniveles";
			this.cboniveles.Size = new System.Drawing.Size(178, 28);
			this.cboniveles.TabIndex = 1;
			this.cboniveles.SelectionChangeCommitted += new System.EventHandler(this.cboniveles_SelectionChangeCommitted);
			// 
			// txtname
			// 
			this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txtname.DisplayIcon = false;
			this.txtname.Enabled = false;
			this.txtname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtname.Lines = new string[0];
			this.txtname.Location = new System.Drawing.Point(6, 54);
			this.txtname.MaxLength = 32767;
			this.txtname.Multiline = true;
			this.txtname.Name = "txtname";
			this.txtname.PasswordChar = '\0';
			this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtname.SelectedText = "";
			this.txtname.Size = new System.Drawing.Size(728, 29);
			this.txtname.TabIndex = 27;
			this.txtname.UseSelectable = true;
			// 
			// metroLabel13
			// 
			this.metroLabel13.AutoSize = true;
			this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel13.Location = new System.Drawing.Point(6, 32);
			this.metroLabel13.Name = "metroLabel13";
			this.metroLabel13.Size = new System.Drawing.Size(60, 19);
			this.metroLabel13.TabIndex = 28;
			this.metroLabel13.Text = "Alumno:";
			// 
			// cboseccion
			// 
			this.cboseccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboseccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboseccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboseccion.FormattingEnabled = true;
			this.cboseccion.Location = new System.Drawing.Point(389, 122);
			this.cboseccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboseccion.Name = "cboseccion";
			this.cboseccion.Size = new System.Drawing.Size(192, 29);
			this.cboseccion.TabIndex = 3;
			this.cboseccion.Text = "Seleccione...";
			// 
			// cbogrado
			// 
			this.cbogrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cbogrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbogrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbogrado.FormattingEnabled = true;
			this.cbogrado.Location = new System.Drawing.Point(190, 122);
			this.cbogrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbogrado.Name = "cbogrado";
			this.cbogrado.Size = new System.Drawing.Size(193, 29);
			this.cbogrado.TabIndex = 2;
			this.cbogrado.Text = "Seleccione...";
			// 
			// dgClases
			// 
			this.dgClases.AllowUserToAddRows = false;
			this.dgClases.AllowUserToDeleteRows = false;
			this.dgClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgClases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgClases.BackgroundColor = System.Drawing.Color.White;
			this.dgClases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgClases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgClases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colGrado,
            this.colSeccion,
            this.colNivel,
            this.colTurno});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgClases.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgClases.EnableHeadersVisualStyles = false;
			this.dgClases.Location = new System.Drawing.Point(9, 188);
			this.dgClases.MultiSelect = false;
			this.dgClases.Name = "dgClases";
			this.dgClases.ReadOnly = true;
			this.dgClases.RowHeadersVisible = false;
			this.dgClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgClases.Size = new System.Drawing.Size(728, 248);
			this.dgClases.TabIndex = 42;
			this.dgClases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClases_CellDoubleClick);
			this.dgClases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgClases_KeyDown);
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colGrado
			// 
			this.colGrado.HeaderText = "Grado";
			this.colGrado.Name = "colGrado";
			this.colGrado.ReadOnly = true;
			// 
			// colSeccion
			// 
			this.colSeccion.HeaderText = "Sección";
			this.colSeccion.Name = "colSeccion";
			this.colSeccion.ReadOnly = true;
			// 
			// colNivel
			// 
			this.colNivel.HeaderText = "Nivel";
			this.colNivel.Name = "colNivel";
			this.colNivel.ReadOnly = true;
			// 
			// colTurno
			// 
			this.colTurno.HeaderText = "Turno";
			this.colTurno.Name = "colTurno";
			this.colTurno.ReadOnly = true;
			// 
			// frmAsignaClase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmAsignaClase";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Asignación de Clase";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsignaClase_FormClosing);
			this.Load += new System.EventHandler(this.frmAsignaClase_Load);
			this.panelMain.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgClases)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.GroupBox groupBox2;
		private MetroFramework.Controls.MetroTextBox txtname;
		private MetroFramework.Controls.MetroLabel metroLabel13;
		public System.Windows.Forms.ComboBox cboseccion;
		public System.Windows.Forms.ComboBox cbogrado;
		private MetroFramework.Controls.MetroButton BtnNext;
		private MetroFramework.Controls.MetroButton btnPreview;
		private System.Windows.Forms.ComboBox cboniveles;
		private MetroFramework.Controls.MetroButton btnsearch;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.DataGridView dgClases;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGrado;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNivel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
	}
}