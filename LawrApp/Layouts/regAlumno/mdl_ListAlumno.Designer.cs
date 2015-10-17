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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pgAlumnosLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.lbnameform = new MetroFramework.Controls.MetroLabel();
			this.dgvSearchAlumnos = new MetroFramework.Controls.MetroGrid();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearchAlumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvSearchAlumnos);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(540, 308);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(534, 65);
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
			this.txtSearch.Size = new System.Drawing.Size(522, 28);
			this.txtSearch.TabIndex = 156;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pgAlumnosLoad
			// 
			this.pgAlumnosLoad.Location = new System.Drawing.Point(30, 371);
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
			// lbnameform
			// 
			this.lbnameform.AutoSize = true;
			this.lbnameform.Location = new System.Drawing.Point(399, -18);
			this.lbnameform.Name = "lbnameform";
			this.lbnameform.Size = new System.Drawing.Size(0, 0);
			this.lbnameform.TabIndex = 1;
			// 
			// dgvSearchAlumnos
			// 
			this.dgvSearchAlumnos.AllowUserToAddRows = false;
			this.dgvSearchAlumnos.AllowUserToDeleteRows = false;
			this.dgvSearchAlumnos.AllowUserToOrderColumns = true;
			this.dgvSearchAlumnos.AllowUserToResizeColumns = false;
			this.dgvSearchAlumnos.AllowUserToResizeRows = false;
			this.dgvSearchAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearchAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.dgvSearchAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSearchAlumnos.CausesValidation = false;
			this.dgvSearchAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSearchAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearchAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSearchAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSearchAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSearchAlumnos.EnableHeadersVisualStyles = false;
			this.dgvSearchAlumnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSearchAlumnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSearchAlumnos.Location = new System.Drawing.Point(3, 74);
			this.dgvSearchAlumnos.Name = "dgvSearchAlumnos";
			this.dgvSearchAlumnos.ReadOnly = true;
			this.dgvSearchAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearchAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSearchAlumnos.RowHeadersVisible = false;
			this.dgvSearchAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dgvSearchAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSearchAlumnos.RowTemplate.Height = 31;
			this.dgvSearchAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSearchAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSearchAlumnos.Size = new System.Drawing.Size(534, 231);
			this.dgvSearchAlumnos.StandardTab = true;
			this.dgvSearchAlumnos.TabIndex = 165;
			this.dgvSearchAlumnos.UseCustomBackColor = true;
			this.dgvSearchAlumnos.UseCustomForeColor = true;
			this.dgvSearchAlumnos.UseStyleColors = true;
			this.dgvSearchAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchAlumnos_CellDoubleClick);
			this.dgvSearchAlumnos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSearchAlumnos_KeyDown);
			// 
			// mdl_ListAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
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
			this.Padding = new System.Windows.Forms.Padding(30, 60, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
		private MetroFramework.Controls.MetroGrid dgvSearchAlumnos;
	}
}