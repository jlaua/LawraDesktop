namespace LawrApp.Institucion
{
	partial class frm_History
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
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnHecho = new MetroFramework.Controls.MetroButton();
			this.rtxDetalle = new System.Windows.Forms.RichTextBox();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnHecho);
			this.panelMain.Controls.Add(this.rtxDetalle);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(540, 421);
			this.panelMain.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(381, 387);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnHecho
			// 
			this.btnHecho.Location = new System.Drawing.Point(462, 387);
			this.btnHecho.Name = "btnHecho";
			this.btnHecho.Size = new System.Drawing.Size(75, 31);
			this.btnHecho.TabIndex = 1;
			this.btnHecho.Text = "Hecho";
			this.btnHecho.UseSelectable = true;
			// 
			// rtxDetalle
			// 
			this.rtxDetalle.AcceptsTab = true;
			this.rtxDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtxDetalle.Location = new System.Drawing.Point(3, 3);
			this.rtxDetalle.Name = "rtxDetalle";
			this.rtxDetalle.Size = new System.Drawing.Size(534, 363);
			this.rtxDetalle.TabIndex = 0;
			this.rtxDetalle.Text = "";
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(30, 521);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// frm_History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_History";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Historia de la Institución";
			this.panelMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnHecho;
		private System.Windows.Forms.RichTextBox rtxDetalle;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
	}
}