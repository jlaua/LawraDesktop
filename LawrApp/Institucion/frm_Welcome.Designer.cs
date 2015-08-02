namespace LawrApp.Institucion
{
	partial class frm_Welcome
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.rtxBienvenida = new System.Windows.Forms.RichTextBox();
			this.ptbFoto = new System.Windows.Forms.PictureBox();
			this.btnSearchImage = new MetroFramework.Controls.MetroButton();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.lblSource = new MetroFramework.Controls.MetroLabel();
			this.btnHecho = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnHecho);
			this.panelMain.Controls.Add(this.lblSource);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.btnSearchImage);
			this.panelMain.Controls.Add(this.ptbFoto);
			this.panelMain.Controls.Add(this.rtxBienvenida);
			this.panelMain.Controls.Add(this.txtDirector);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(540, 421);
			this.panelMain.TabIndex = 0;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(138, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Director o Propietario";
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(3, 22);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(363, 29);
			this.txtDirector.TabIndex = 1;
			// 
			// rtxBienvenida
			// 
			this.rtxBienvenida.Location = new System.Drawing.Point(3, 57);
			this.rtxBienvenida.Name = "rtxBienvenida";
			this.rtxBienvenida.Size = new System.Drawing.Size(363, 361);
			this.rtxBienvenida.TabIndex = 2;
			this.rtxBienvenida.Text = "";
			// 
			// ptbFoto
			// 
			this.ptbFoto.Location = new System.Drawing.Point(383, 22);
			this.ptbFoto.Name = "ptbFoto";
			this.ptbFoto.Size = new System.Drawing.Size(154, 178);
			this.ptbFoto.TabIndex = 4;
			this.ptbFoto.TabStop = false;
			// 
			// btnSearchImage
			// 
			this.btnSearchImage.Location = new System.Drawing.Point(383, 206);
			this.btnSearchImage.Name = "btnSearchImage";
			this.btnSearchImage.Size = new System.Drawing.Size(154, 30);
			this.btnSearchImage.TabIndex = 5;
			this.btnSearchImage.Text = "Buscar Imagen";
			this.btnSearchImage.UseSelectable = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(383, 0);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(36, 19);
			this.metroLabel3.TabIndex = 6;
			this.metroLabel3.Text = "Foto";
			// 
			// lblSource
			// 
			this.lblSource.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblSource.Location = new System.Drawing.Point(383, 239);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(154, 15);
			this.lblSource.TabIndex = 7;
			this.lblSource.Text = "Source";
			// 
			// btnHecho
			// 
			this.btnHecho.Location = new System.Drawing.Point(458, 383);
			this.btnHecho.Name = "btnHecho";
			this.btnHecho.Size = new System.Drawing.Size(79, 35);
			this.btnHecho.TabIndex = 8;
			this.btnHecho.Text = "Hecho";
			this.btnHecho.UseSelectable = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(383, 383);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(69, 35);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// metroProgressSpinner1
			// 
			this.metroProgressSpinner1.Location = new System.Drawing.Point(30, 520);
			this.metroProgressSpinner1.Maximum = 100;
			this.metroProgressSpinner1.Name = "metroProgressSpinner1";
			this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
			this.metroProgressSpinner1.Speed = 2F;
			this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
			this.metroProgressSpinner1.TabIndex = 1;
			this.metroProgressSpinner1.UseSelectable = true;
			this.metroProgressSpinner1.Value = 50;
			// 
			// frm_Welcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.metroProgressSpinner1);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Welcome";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Bienvenida";
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnHecho;
		private MetroFramework.Controls.MetroLabel lblSource;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnSearchImage;
		private System.Windows.Forms.PictureBox ptbFoto;
		private System.Windows.Forms.RichTextBox rtxBienvenida;
		private System.Windows.Forms.TextBox txtDirector;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
	}
}