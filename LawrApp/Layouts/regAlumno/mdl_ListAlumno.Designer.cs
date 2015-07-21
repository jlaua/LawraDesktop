namespace LawrApp.Layouts.regAlumno
{
	partial class mdl_ListAlumno
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pgAlumnosLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvSearchAlumnos = new System.Windows.Forms.DataGridView();
			this.lbnameform = new MetroFramework.Controls.MetroLabel();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearchAlumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.dgvSearchAlumnos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(540, 271);
			this.panel1.TabIndex = 0;
			// 
			// pgAlumnosLoad
			// 
			this.pgAlumnosLoad.Location = new System.Drawing.Point(549, 72);
			this.pgAlumnosLoad.Maximum = 100;
			this.pgAlumnosLoad.Name = "pgAlumnosLoad";
			this.pgAlumnosLoad.Size = new System.Drawing.Size(21, 19);
			this.pgAlumnosLoad.Speed = 2F;
			this.pgAlumnosLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgAlumnosLoad.TabIndex = 152;
			this.pgAlumnosLoad.UseSelectable = true;
			this.pgAlumnosLoad.Value = 50;
			this.pgAlumnosLoad.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Location = new System.Drawing.Point(13, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(511, 65);
			this.groupBox1.TabIndex = 157;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nombres Y Apellidos";
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.txtSearch.Location = new System.Drawing.Point(6, 28);
			this.txtSearch.MaxLength = 250;
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(499, 28);
			this.txtSearch.TabIndex = 156;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// dgvSearchAlumnos
			// 
			this.dgvSearchAlumnos.AllowUserToAddRows = false;
			this.dgvSearchAlumnos.AllowUserToDeleteRows = false;
			this.dgvSearchAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearchAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSearchAlumnos.BackgroundColor = System.Drawing.Color.White;
			this.dgvSearchAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSearchAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSearchAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearchAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvSearchAlumnos.ColumnHeadersHeight = 27;
			this.dgvSearchAlumnos.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSearchAlumnos.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgvSearchAlumnos.EnableHeadersVisualStyles = false;
			this.dgvSearchAlumnos.Location = new System.Drawing.Point(3, 74);
			this.dgvSearchAlumnos.MultiSelect = false;
			this.dgvSearchAlumnos.Name = "dgvSearchAlumnos";
			this.dgvSearchAlumnos.ReadOnly = true;
			this.dgvSearchAlumnos.RowHeadersVisible = false;
			this.dgvSearchAlumnos.RowHeadersWidth = 40;
			this.dgvSearchAlumnos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvSearchAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvSearchAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSearchAlumnos.Size = new System.Drawing.Size(534, 194);
			this.dgvSearchAlumnos.StandardTab = true;
			this.dgvSearchAlumnos.TabIndex = 154;
			this.dgvSearchAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchAlumnos_CellDoubleClick);
			this.dgvSearchAlumnos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSearchAlumnos_KeyDown);
			// 
			// lbnameform
			// 
			this.lbnameform.AutoSize = true;
			this.lbnameform.Location = new System.Drawing.Point(399, 19);
			this.lbnameform.Name = "lbnameform";
			this.lbnameform.Size = new System.Drawing.Size(0, 0);
			this.lbnameform.TabIndex = 1;
			// 
			// mdl_ListAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.pgAlumnosLoad);
			this.Controls.Add(this.lbnameform);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(600, 400);
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "mdl_ListAlumno";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Alumnos Registrados";
			this.Load += new System.EventHandler(this.mdl_ListAlumno_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearchAlumnos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSearch;
		private MetroFramework.Controls.MetroProgressSpinner pgAlumnosLoad;
		private MetroFramework.Controls.MetroLabel lbnameform;
		private System.Windows.Forms.DataGridView dgvSearchAlumnos;
	}
}