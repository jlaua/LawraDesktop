namespace LawrApp.Layouts.prsMatricula
{
	partial class frmInitialMessage
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnMessageSiguiente = new MetroFramework.Controls.MetroButton();
			this.gbopciones = new System.Windows.Forms.GroupBox();
			this.rbnuevoAlumno = new MetroFramework.Controls.MetroRadioButton();
			this.rbalumnoRegistrado = new MetroFramework.Controls.MetroRadioButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.panelMain.SuspendLayout();
			this.gbopciones.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnMessageSiguiente);
			this.panelMain.Controls.Add(this.gbopciones);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(27, 92);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(471, 336);
			this.panelMain.TabIndex = 0;
			// 
			// btnMessageSiguiente
			// 
			this.btnMessageSiguiente.Location = new System.Drawing.Point(371, 297);
			this.btnMessageSiguiente.Name = "btnMessageSiguiente";
			this.btnMessageSiguiente.Size = new System.Drawing.Size(97, 36);
			this.btnMessageSiguiente.TabIndex = 6;
			this.btnMessageSiguiente.Text = "Siguiente";
			this.btnMessageSiguiente.UseSelectable = true;
			this.btnMessageSiguiente.Click += new System.EventHandler(this.btnMessageContinue_Click);
			// 
			// gbopciones
			// 
			this.gbopciones.Controls.Add(this.rbnuevoAlumno);
			this.gbopciones.Controls.Add(this.rbalumnoRegistrado);
			this.gbopciones.Location = new System.Drawing.Point(6, 208);
			this.gbopciones.Name = "gbopciones";
			this.gbopciones.Size = new System.Drawing.Size(462, 69);
			this.gbopciones.TabIndex = 5;
			this.gbopciones.TabStop = false;
			this.gbopciones.Text = "Opciones";
			// 
			// rbnuevoAlumno
			// 
			this.rbnuevoAlumno.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rbnuevoAlumno.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
			this.rbnuevoAlumno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.rbnuevoAlumno.Location = new System.Drawing.Point(15, 29);
			this.rbnuevoAlumno.Name = "rbnuevoAlumno";
			this.rbnuevoAlumno.Size = new System.Drawing.Size(134, 34);
			this.rbnuevoAlumno.Style = MetroFramework.MetroColorStyle.Green;
			this.rbnuevoAlumno.TabIndex = 6;
			this.rbnuevoAlumno.Text = "Nuevo Alumno";
			this.rbnuevoAlumno.UseCustomForeColor = true;
			this.rbnuevoAlumno.UseSelectable = true;
			this.rbnuevoAlumno.CheckedChanged += new System.EventHandler(this.rbnuevoAlumno_CheckedChanged);
			// 
			// rbalumnoRegistrado
			// 
			this.rbalumnoRegistrado.Checked = true;
			this.rbalumnoRegistrado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rbalumnoRegistrado.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
			this.rbalumnoRegistrado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.rbalumnoRegistrado.Location = new System.Drawing.Point(155, 29);
			this.rbalumnoRegistrado.Name = "rbalumnoRegistrado";
			this.rbalumnoRegistrado.Size = new System.Drawing.Size(156, 34);
			this.rbalumnoRegistrado.Style = MetroFramework.MetroColorStyle.Green;
			this.rbalumnoRegistrado.TabIndex = 5;
			this.rbalumnoRegistrado.TabStop = true;
			this.rbalumnoRegistrado.Text = "Alumno Registrado";
			this.rbalumnoRegistrado.UseCustomForeColor = true;
			this.rbalumnoRegistrado.UseSelectable = true;
			this.rbalumnoRegistrado.CheckedChanged += new System.EventHandler(this.rbalumnoRegistrado_CheckedChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.Location = new System.Drawing.Point(3, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(465, 205);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Mensaje ";
			this.metroLabel1.WrapToLine = true;
			// 
			// frmInitialMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 459);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmInitialMessage";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Asistente de Proceso";
			this.Load += new System.EventHandler(this.frmInitialMessage_Load);
			this.panelMain.ResumeLayout(false);
			this.gbopciones.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroButton btnMessageSiguiente;
		private System.Windows.Forms.GroupBox gbopciones;
		public MetroFramework.Controls.MetroRadioButton rbnuevoAlumno;
		public MetroFramework.Controls.MetroRadioButton rbalumnoRegistrado;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}