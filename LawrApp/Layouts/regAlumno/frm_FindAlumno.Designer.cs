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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnnuevoAlumno = new MetroFramework.Controls.MetroButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pgAlumnosLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.lbnameFormPadre = new MetroFramework.Controls.MetroLabel();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new MetroFramework.Controls.MetroGrid();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.panelMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.dgvListado);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnEliminar);
			this.panelMain.Controls.Add(this.btnModificar);
			this.panelMain.Controls.Add(this.btnnuevoAlumno);
			this.panelMain.Controls.Add(this.groupBox1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 471);
			this.panelMain.TabIndex = 0;
			// 
			// btnnuevoAlumno
			// 
			this.btnnuevoAlumno.Location = new System.Drawing.Point(654, 427);
			this.btnnuevoAlumno.Name = "btnnuevoAlumno";
			this.btnnuevoAlumno.Size = new System.Drawing.Size(83, 41);
			this.btnnuevoAlumno.TabIndex = 3;
			this.btnnuevoAlumno.Text = "Nuevo";
			this.btnnuevoAlumno.UseSelectable = true;
			this.btnnuevoAlumno.Click += new System.EventHandler(this.btnnuevoAlumno_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(734, 67);
			this.groupBox1.TabIndex = 152;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.White;
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Location = new System.Drawing.Point(6, 28);
			this.txtSearch.MaxLength = 250;
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(722, 28);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pgAlumnosLoad
			// 
			this.pgAlumnosLoad.Location = new System.Drawing.Point(30, 570);
			this.pgAlumnosLoad.Maximum = 100;
			this.pgAlumnosLoad.Name = "pgAlumnosLoad";
			this.pgAlumnosLoad.Size = new System.Drawing.Size(16, 16);
			this.pgAlumnosLoad.Speed = 2F;
			this.pgAlumnosLoad.Style = MetroFramework.MetroColorStyle.Blue;
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
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(549, 427);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(83, 41);
			this.btnModificar.TabIndex = 154;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
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
			this.dgvListado.Location = new System.Drawing.Point(3, 76);
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.ReadOnly = true;
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
			this.dgvListado.Size = new System.Drawing.Size(734, 345);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 165;
			this.dgvListado.UseCustomBackColor = true;
			this.dgvListado.UseCustomForeColor = true;
			this.dgvListado.UseStyleColors = true;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellDoubleClick);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSearch_KeyDown);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(460, 427);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(83, 41);
			this.btnEliminar.TabIndex = 154;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 427);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(62, 41);
			this.btnSalir.TabIndex = 154;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// frm_FindAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
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
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Buscar Alumno";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FindAlumno_FormClosing);
			this.Load += new System.EventHandler(this.frm_FindAlumno_Load);
			this.panelMain.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSearch;
		private MetroFramework.Controls.MetroProgressSpinner pgAlumnosLoad;
		private MetroFramework.Controls.MetroButton btnnuevoAlumno;
		private MetroFramework.Controls.MetroLabel lbnameFormPadre;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroGrid dgvListado;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
	}
}