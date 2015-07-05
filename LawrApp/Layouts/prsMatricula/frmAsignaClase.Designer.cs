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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelMain = new System.Windows.Forms.Panel();
			this.BtnNext = new MetroFramework.Controls.MetroButton();
			this.btnPreview = new MetroFramework.Controls.MetroButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnsearch = new MetroFramework.Controls.MetroButton();
			this.cboniveles = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtname = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
			this.cboseccion = new System.Windows.Forms.ComboBox();
			this.cbogrado = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgClases = new MetroFramework.Controls.MetroGrid();
			this.columCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelMain.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgClases)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.BtnNext);
			this.panelMain.Controls.Add(this.btnPreview);
			this.panelMain.Controls.Add(this.groupBox2);
			this.panelMain.Controls.Add(this.groupBox4);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(27, 92);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(746, 477);
			this.panelMain.TabIndex = 0;
			// 
			// BtnNext
			// 
			this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnNext.Location = new System.Drawing.Point(656, 442);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.Size = new System.Drawing.Size(87, 32);
			this.BtnNext.TabIndex = 5;
			this.BtnNext.Text = "Siguiente";
			this.BtnNext.UseSelectable = true;
			// 
			// btnPreview
			// 
			this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPreview.Location = new System.Drawing.Point(565, 442);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(85, 32);
			this.btnPreview.TabIndex = 6;
			this.btnPreview.Text = "Anterior";
			this.btnPreview.UseSelectable = true;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnsearch);
			this.groupBox2.Controls.Add(this.cboniveles);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtname);
			this.groupBox2.Controls.Add(this.metroLabel13);
			this.groupBox2.Controls.Add(this.cboseccion);
			this.groupBox2.Controls.Add(this.cbogrado);
			this.groupBox2.Location = new System.Drawing.Point(19, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(709, 172);
			this.groupBox2.TabIndex = 40;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Configurar";
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(620, 122);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(83, 29);
			this.btnsearch.TabIndex = 37;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(385, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 36;
			this.label3.Text = "Secciones:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(186, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 20);
			this.label2.TabIndex = 35;
			this.label2.Text = "Grados:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(6, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 34;
			this.label1.Text = "Niveles:";
			// 
			// txtname
			// 
			this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txtname.DisplayIcon = false;
			this.txtname.Enabled = false;
			this.txtname.Lines = new string[0];
			this.txtname.Location = new System.Drawing.Point(6, 54);
			this.txtname.MaxLength = 32767;
			this.txtname.Multiline = true;
			this.txtname.Name = "txtname";
			this.txtname.PasswordChar = '\0';
			this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtname.SelectedText = "";
			this.txtname.Size = new System.Drawing.Size(697, 29);
			this.txtname.TabIndex = 27;
			this.txtname.UseSelectable = true;
			// 
			// metroLabel13
			// 
			this.metroLabel13.AutoSize = true;
			this.metroLabel13.Location = new System.Drawing.Point(6, 32);
			this.metroLabel13.Name = "metroLabel13";
			this.metroLabel13.Size = new System.Drawing.Size(58, 19);
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
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dgClases);
			this.groupBox4.Location = new System.Drawing.Point(3, 188);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(740, 225);
			this.groupBox4.TabIndex = 39;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Configurar ";
			// 
			// dgClases
			// 
			this.dgClases.AllowUserToAddRows = false;
			this.dgClases.AllowUserToDeleteRows = false;
			this.dgClases.AllowUserToResizeRows = false;
			this.dgClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgClases.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgClases.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgClases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgClases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columCodigo,
            this.colName,
            this.colDesde,
            this.Nivel,
            this.colHasta});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgClases.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgClases.EnableHeadersVisualStyles = false;
			this.dgClases.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgClases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgClases.Location = new System.Drawing.Point(6, 26);
			this.dgClases.MultiSelect = false;
			this.dgClases.Name = "dgClases";
			this.dgClases.ReadOnly = true;
			this.dgClases.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgClases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgClases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgClases.RowHeadersVisible = false;
			this.dgClases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgClases.Size = new System.Drawing.Size(728, 193);
			this.dgClases.Style = MetroFramework.MetroColorStyle.Green;
			this.dgClases.TabIndex = 4;
			this.dgClases.UseStyleColors = true;
			this.dgClases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClases_CellDoubleClick);
			// 
			// columCodigo
			// 
			this.columCodigo.HeaderText = "Codigo";
			this.columCodigo.Name = "columCodigo";
			this.columCodigo.ReadOnly = true;
			this.columCodigo.Visible = false;
			// 
			// colName
			// 
			this.colName.HeaderText = "Grado";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colDesde
			// 
			this.colDesde.HeaderText = "Seccion";
			this.colDesde.Name = "colDesde";
			this.colDesde.ReadOnly = true;
			this.colDesde.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// Nivel
			// 
			this.Nivel.HeaderText = "Nivel";
			this.Nivel.Name = "Nivel";
			this.Nivel.ReadOnly = true;
			// 
			// colHasta
			// 
			this.colHasta.HeaderText = "Turno";
			this.colHasta.Name = "colHasta";
			this.colHasta.ReadOnly = true;
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
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Asignación de Clase";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsignaClase_FormClosing);
			this.Load += new System.EventHandler(this.frmAsignaClase_Load);
			this.panelMain.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
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
		private System.Windows.Forms.GroupBox groupBox4;
		public MetroFramework.Controls.MetroGrid dgClases;
		private MetroFramework.Controls.MetroButton BtnNext;
		private MetroFramework.Controls.MetroButton btnPreview;
		private System.Windows.Forms.ComboBox cboniveles;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroButton btnsearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn columCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHasta;
	}
}