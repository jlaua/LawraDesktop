namespace LawrApp.Layouts.Fichas.Students
{
	partial class mdlDocuments
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblFecha_Expiration = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblFecha_Expiracion = new MetroFramework.Controls.MetroLabel();
			this.lblNumbers = new MetroFramework.Controls.MetroLabel();
			this.lblnombres = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.pboImage = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblFecha_Expiration);
			this.panel1.Controls.Add(this.lblNumber);
			this.panel1.Controls.Add(this.lblName);
			this.panel1.Controls.Add(this.lblFecha_Expiracion);
			this.panel1.Controls.Add(this.lblNumbers);
			this.panel1.Controls.Add(this.lblnombres);
			this.panel1.Controls.Add(this.pboImage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 150);
			this.panel1.TabIndex = 1;
			// 
			// lblFecha_Expiration
			// 
			this.lblFecha_Expiration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha_Expiration.Location = new System.Drawing.Point(255, 95);
			this.lblFecha_Expiration.Name = "lblFecha_Expiration";
			this.lblFecha_Expiration.Size = new System.Drawing.Size(205, 15);
			this.lblFecha_Expiration.TabIndex = 55;
			// 
			// lblNumber
			// 
			this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber.Location = new System.Drawing.Point(255, 64);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(205, 15);
			this.lblNumber.TabIndex = 54;
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(255, 32);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(205, 15);
			this.lblName.TabIndex = 53;
			// 
			// lblFecha_Expiracion
			// 
			this.lblFecha_Expiracion.AutoSize = true;
			this.lblFecha_Expiracion.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblFecha_Expiracion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblFecha_Expiracion.Location = new System.Drawing.Point(174, 95);
			this.lblFecha_Expiracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFecha_Expiracion.Name = "lblFecha_Expiracion";
			this.lblFecha_Expiracion.Size = new System.Drawing.Size(75, 15);
			this.lblFecha_Expiracion.Style = MetroFramework.MetroColorStyle.Black;
			this.lblFecha_Expiracion.TabIndex = 49;
			this.lblFecha_Expiracion.Text = "F. Expiracion";
			this.lblFecha_Expiracion.UseCustomForeColor = true;
			// 
			// lblNumbers
			// 
			this.lblNumbers.AutoSize = true;
			this.lblNumbers.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblNumbers.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblNumbers.Location = new System.Drawing.Point(174, 64);
			this.lblNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNumbers.Name = "lblNumbers";
			this.lblNumbers.Size = new System.Drawing.Size(53, 15);
			this.lblNumbers.Style = MetroFramework.MetroColorStyle.Black;
			this.lblNumbers.TabIndex = 48;
			this.lblNumbers.Text = "Numero";
			this.lblNumbers.UseCustomForeColor = true;
			// 
			// lblnombres
			// 
			this.lblnombres.AutoSize = true;
			this.lblnombres.BackColor = System.Drawing.Color.White;
			this.lblnombres.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblnombres.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblnombres.Location = new System.Drawing.Point(174, 32);
			this.lblnombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblnombres.Name = "lblnombres";
			this.lblnombres.Size = new System.Drawing.Size(53, 15);
			this.lblnombres.Style = MetroFramework.MetroColorStyle.Black;
			this.lblnombres.TabIndex = 47;
			this.lblnombres.Text = "Nombre";
			this.lblnombres.UseCustomForeColor = true;
			this.lblnombres.UseStyleColors = true;
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(30, 249);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(15, 19);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 153;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// pboImage
			// 
			this.pboImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pboImage.Location = new System.Drawing.Point(3, 3);
			this.pboImage.Name = "pboImage";
			this.pboImage.Size = new System.Drawing.Size(158, 143);
			this.pboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pboImage.TabIndex = 0;
			this.pboImage.TabStop = false;
			// 
			// mdlDocuments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 280);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mdlDocuments";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 33);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Documentos";
			this.Load += new System.EventHandler(this.frmDocumentos_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblFecha_Expiration;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Label lblName;
		private MetroFramework.Controls.MetroLabel lblFecha_Expiracion;
		private MetroFramework.Controls.MetroLabel lblNumbers;
		private MetroFramework.Controls.MetroLabel lblnombres;
		private System.Windows.Forms.PictureBox pboImage;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
	}
}