namespace LawrApp.Layouts.regAlumno
{
	partial class mdl_LastSchools
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
			this.pbuscarColegiosProcedencias = new System.Windows.Forms.Panel();
			this.pgDataEscuelaLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.dgvListSchool = new MetroFramework.Controls.MetroGrid();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.txtSearchSchool = new MetroFramework.Controls.MetroTextBox();
			this.pbuscarColegiosProcedencias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListSchool)).BeginInit();
			this.SuspendLayout();
			// 
			// pbuscarColegiosProcedencias
			// 
			this.pbuscarColegiosProcedencias.Controls.Add(this.pgDataEscuelaLoad);
			this.pbuscarColegiosProcedencias.Controls.Add(this.dgvListSchool);
			this.pbuscarColegiosProcedencias.Controls.Add(this.btnbuscar);
			this.pbuscarColegiosProcedencias.Controls.Add(this.txtSearchSchool);
			this.pbuscarColegiosProcedencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbuscarColegiosProcedencias.Location = new System.Drawing.Point(30, 97);
			this.pbuscarColegiosProcedencias.Name = "pbuscarColegiosProcedencias";
			this.pbuscarColegiosProcedencias.Size = new System.Drawing.Size(540, 271);
			this.pbuscarColegiosProcedencias.TabIndex = 0;
			// 
			// pgDataEscuelaLoad
			// 
			this.pgDataEscuelaLoad.Location = new System.Drawing.Point(17, 433);
			this.pgDataEscuelaLoad.Maximum = 100;
			this.pgDataEscuelaLoad.Name = "pgDataEscuelaLoad";
			this.pgDataEscuelaLoad.Size = new System.Drawing.Size(21, 19);
			this.pgDataEscuelaLoad.Speed = 2F;
			this.pgDataEscuelaLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgDataEscuelaLoad.TabIndex = 152;
			this.pgDataEscuelaLoad.UseSelectable = true;
			this.pgDataEscuelaLoad.Value = 50;
			this.pgDataEscuelaLoad.Visible = false;
			// 
			// dgvListSchool
			// 
			this.dgvListSchool.AllowUserToAddRows = false;
			this.dgvListSchool.AllowUserToDeleteRows = false;
			this.dgvListSchool.AllowUserToResizeColumns = false;
			this.dgvListSchool.AllowUserToResizeRows = false;
			this.dgvListSchool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListSchool.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvListSchool.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListSchool.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvListSchool.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListSchool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListSchool.ColumnHeadersHeight = 30;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListSchool.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListSchool.EnableHeadersVisualStyles = false;
			this.dgvListSchool.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvListSchool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListSchool.Location = new System.Drawing.Point(3, 38);
			this.dgvListSchool.Name = "dgvListSchool";
			this.dgvListSchool.ReadOnly = true;
			this.dgvListSchool.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListSchool.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListSchool.RowHeadersVisible = false;
			this.dgvListSchool.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.dgvListSchool.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListSchool.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListSchool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListSchool.Size = new System.Drawing.Size(534, 230);
			this.dgvListSchool.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvListSchool.TabIndex = 11;
			this.dgvListSchool.UseStyleColors = true;
			this.dgvListSchool.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSchool_CellDoubleClick);
			this.dgvListSchool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListSchool_KeyDown);
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(462, 3);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(75, 29);
			this.btnbuscar.TabIndex = 10;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseSelectable = true;
			// 
			// txtSearchSchool
			// 
			this.txtSearchSchool.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtSearchSchool.Lines = new string[0];
			this.txtSearchSchool.Location = new System.Drawing.Point(3, 3);
			this.txtSearchSchool.MaxLength = 250;
			this.txtSearchSchool.Name = "txtSearchSchool";
			this.txtSearchSchool.PasswordChar = '\0';
			this.txtSearchSchool.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSearchSchool.SelectedText = "";
			this.txtSearchSchool.Size = new System.Drawing.Size(453, 29);
			this.txtSearchSchool.TabIndex = 8;
			this.txtSearchSchool.UseSelectable = true;
			this.txtSearchSchool.TextChanged += new System.EventHandler(this.txtSearchSchool_TextChanged);
			// 
			// mdl_LastSchools
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.pbuscarColegiosProcedencias);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mdl_LastSchools";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Buscar Colegios";
			this.Load += new System.EventHandler(this.mdl_LastSchools_Load);
			this.pbuscarColegiosProcedencias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListSchool)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pbuscarColegiosProcedencias;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private MetroFramework.Controls.MetroTextBox txtSearchSchool;
		private MetroFramework.Controls.MetroGrid dgvListSchool;
		private MetroFramework.Controls.MetroProgressSpinner pgDataEscuelaLoad;
	}
}