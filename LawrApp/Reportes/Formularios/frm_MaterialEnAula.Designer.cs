namespace LawrApp.Reportes.Formularios
{
	partial class frm_MaterialEnAula
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.tAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.rpvMateriales = new Microsoft.Reporting.WinForms.ReportViewer();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			((System.ComponentModel.ISupportInitialize)(this.tAlumnoBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tAlumnoBindingSource
			// 
			this.tAlumnoBindingSource.DataSource = typeof(Objects.Tables.tAlumno);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rpvMateriales);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 488);
			this.panel1.TabIndex = 0;
			// 
			// rpvMateriales
			// 
			this.rpvMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rpvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rpvMateriales.DocumentMapCollapsed = true;
			reportDataSource2.Name = "t_alumno";
			reportDataSource2.Value = this.tAlumnoBindingSource;
			this.rpvMateriales.LocalReport.DataSources.Add(reportDataSource2);
			this.rpvMateriales.LocalReport.ReportEmbeddedResource = "LawrApp.Reportes.Disenio.inf_PerfilStudents.rdlc";
			this.rpvMateriales.Location = new System.Drawing.Point(0, 0);
			this.rpvMateriales.Name = "rpvMateriales";
			this.rpvMateriales.Size = new System.Drawing.Size(800, 488);
			this.rpvMateriales.TabIndex = 0;
			this.rpvMateriales.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
			this.rpvMateriales.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// pgsLoading
			// 
			this.pgsLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pgsLoading.Location = new System.Drawing.Point(4, 574);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// frm_MaterialEnAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_MaterialEnAula";
			this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 32);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Perfil de Alumno";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frm_MaterialEnAula_Load);
			((System.ComponentModel.ISupportInitialize)(this.tAlumnoBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private Microsoft.Reporting.WinForms.ReportViewer rpvMateriales;
		private System.Windows.Forms.BindingSource tAlumnoBindingSource;
	}
}