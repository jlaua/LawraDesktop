namespace LawrApp
{
	partial class mdl_ChangePicture
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
			this.btnBuscar = new MetroFramework.Controls.MetroButton();
			this.lblSource = new MetroFramework.Controls.MetroLabel();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnCambiar = new MetroFramework.Controls.MetroButton();
			this.ptbPicture = new System.Windows.Forms.PictureBox();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnBuscar);
			this.panelMain.Controls.Add(this.lblSource);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnCambiar);
			this.panelMain.Controls.Add(this.ptbPicture);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 60);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(291, 258);
			this.panelMain.TabIndex = 0;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(207, 3);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(81, 30);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseSelectable = true;
			this.btnBuscar.Click += new System.EventHandler(this.ptbPicture_Click);
			// 
			// lblSource
			// 
			this.lblSource.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblSource.Location = new System.Drawing.Point(3, 231);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(285, 23);
			this.lblSource.TabIndex = 3;
			this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(207, 198);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(81, 30);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseCustomBackColor = true;
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnCambiar
			// 
			this.btnCambiar.Enabled = false;
			this.btnCambiar.Location = new System.Drawing.Point(207, 162);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(81, 30);
			this.btnCambiar.TabIndex = 1;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseSelectable = true;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// ptbPicture
			// 
			this.ptbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.ptbPicture.ErrorImage = global::LawrApp.Properties.Resources.image_broken;
			this.ptbPicture.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.ptbPicture.Location = new System.Drawing.Point(3, 3);
			this.ptbPicture.Name = "ptbPicture";
			this.ptbPicture.Size = new System.Drawing.Size(198, 225);
			this.ptbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbPicture.TabIndex = 0;
			this.ptbPicture.TabStop = false;
			this.ptbPicture.Click += new System.EventHandler(this.ptbPicture_Click);
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(303, 321);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// OpenFile
			// 
			this.OpenFile.FileName = "openFileDialog1";
			// 
			// mdl_ChangePicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(351, 350);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "mdl_ChangePicture";
			this.Padding = new System.Windows.Forms.Padding(30, 60, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cambiar Imagen de perfil";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdl_ChangePicture_FormClosing);
			this.Load += new System.EventHandler(this.mdl_ChangePicture_Load);
			this.panelMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroButton btnBuscar;
		private MetroFramework.Controls.MetroLabel lblSource;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnCambiar;
		private System.Windows.Forms.PictureBox ptbPicture;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private System.Windows.Forms.OpenFileDialog OpenFile;
	}
}