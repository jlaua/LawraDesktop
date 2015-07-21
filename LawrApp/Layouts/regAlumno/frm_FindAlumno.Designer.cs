namespace LawrApp.Layouts.regAlumno
{
	partial class frm_FindAlumno
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
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnnuevoAlumno = new MetroFramework.Controls.MetroButton();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pgAlumnosLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.lbnameFormPadre = new MetroFramework.Controls.MetroLabel();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnnuevoAlumno);
			this.panelMain.Controls.Add(this.dgvSearch);
			this.panelMain.Controls.Add(this.groupBox1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 471);
			this.panelMain.TabIndex = 0;
			// 
			// dgvSearch
			// 
			this.dgvSearch.AllowUserToAddRows = false;
			this.dgvSearch.AllowUserToDeleteRows = false;
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
			this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSearch.ColumnHeadersHeight = 27;
			this.dgvSearch.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSearch.Location = new System.Drawing.Point(9, 76);
			this.dgvSearch.MultiSelect = false;
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.ReadOnly = true;
			this.dgvSearch.RowHeadersVisible = false;
			this.dgvSearch.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSearch.Size = new System.Drawing.Size(728, 376);
			this.dgvSearch.StandardTab = true;
			this.dgvSearch.TabIndex = 153;
			this.dgvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellDoubleClick);
			this.dgvSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSearch_KeyDown);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(585, 67);
			this.groupBox1.TabIndex = 152;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// btnnuevoAlumno
			// 
			this.btnnuevoAlumno.Location = new System.Drawing.Point(684, 31);
			this.btnnuevoAlumno.Name = "btnnuevoAlumno";
			this.btnnuevoAlumno.Size = new System.Drawing.Size(53, 28);
			this.btnnuevoAlumno.TabIndex = 3;
			this.btnnuevoAlumno.Text = "Crear";
			this.btnnuevoAlumno.UseSelectable = true;
			this.btnnuevoAlumno.Click += new System.EventHandler(this.btnnuevoAlumno_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.txtSearch.Location = new System.Drawing.Point(6, 28);
			this.txtSearch.MaxLength = 250;
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(563, 28);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pgAlumnosLoad
			// 
			this.pgAlumnosLoad.Location = new System.Drawing.Point(30, 574);
			this.pgAlumnosLoad.Maximum = 100;
			this.pgAlumnosLoad.Name = "pgAlumnosLoad";
			this.pgAlumnosLoad.Size = new System.Drawing.Size(21, 19);
			this.pgAlumnosLoad.Speed = 2F;
			this.pgAlumnosLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgAlumnosLoad.TabIndex = 151;
			this.pgAlumnosLoad.UseSelectable = true;
			this.pgAlumnosLoad.Value = 50;
			this.pgAlumnosLoad.Visible = false;
			// 
			// lbnameFormPadre
			// 
			this.lbnameFormPadre.AutoSize = true;
			this.lbnameFormPadre.Location = new System.Drawing.Point(255, 30);
			this.lbnameFormPadre.Name = "lbnameFormPadre";
			this.lbnameFormPadre.Size = new System.Drawing.Size(0, 0);
			this.lbnameFormPadre.TabIndex = 1;
			// 
			// frm_FindAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.lbnameFormPadre);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.pgAlumnosLoad);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "frm_FindAlumno";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Buscar Alumno";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FindAlumno_FormClosing);
			this.Load += new System.EventHandler(this.frm_FindAlumno_Load);
			this.panelMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.DataGridView dgvSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSearch;
		private MetroFramework.Controls.MetroProgressSpinner pgAlumnosLoad;
		private MetroFramework.Controls.MetroButton btnnuevoAlumno;
		private MetroFramework.Controls.MetroLabel lbnameFormPadre;
	}
}