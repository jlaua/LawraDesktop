namespace LawrApp.Institucion
{
	partial class frm_VisionMision
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
			this.lblMision_Validate = new MetroFramework.Controls.MetroLabel();
			this.lblVision_Validate = new MetroFramework.Controls.MetroLabel();
			this.txtMision = new MetroFramework.Controls.MetroTextBox();
			this.txtVision = new MetroFramework.Controls.MetroTextBox();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnHecho = new MetroFramework.Controls.MetroButton();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Controls.Add(this.lblMision_Validate);
			this.panelMain.Controls.Add(this.lblVision_Validate);
			this.panelMain.Controls.Add(this.txtMision);
			this.panelMain.Controls.Add(this.txtVision);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnHecho);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Enabled = false;
			this.panelMain.Location = new System.Drawing.Point(30, 87);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(540, 431);
			this.panelMain.TabIndex = 0;
			// 
			// lblMision_Validate
			// 
			this.lblMision_Validate.AutoSize = true;
			this.lblMision_Validate.BackColor = System.Drawing.Color.Transparent;
			this.lblMision_Validate.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblMision_Validate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblMision_Validate.ForeColor = System.Drawing.Color.Red;
			this.lblMision_Validate.Location = new System.Drawing.Point(49, 196);
			this.lblMision_Validate.Name = "lblMision_Validate";
			this.lblMision_Validate.Size = new System.Drawing.Size(12, 15);
			this.lblMision_Validate.TabIndex = 6;
			this.lblMision_Validate.Text = "*";
			this.lblMision_Validate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMision_Validate.UseCustomBackColor = true;
			this.lblMision_Validate.UseCustomForeColor = true;
			// 
			// lblVision_Validate
			// 
			this.lblVision_Validate.AutoSize = true;
			this.lblVision_Validate.BackColor = System.Drawing.Color.Transparent;
			this.lblVision_Validate.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblVision_Validate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblVision_Validate.ForeColor = System.Drawing.Color.Red;
			this.lblVision_Validate.Location = new System.Drawing.Point(45, 4);
			this.lblVision_Validate.Name = "lblVision_Validate";
			this.lblVision_Validate.Size = new System.Drawing.Size(12, 15);
			this.lblVision_Validate.TabIndex = 5;
			this.lblVision_Validate.Text = "*";
			this.lblVision_Validate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblVision_Validate.UseCustomBackColor = true;
			this.lblVision_Validate.UseCustomForeColor = true;
			// 
			// txtMision
			// 
			this.txtMision.BackColor = System.Drawing.Color.White;
			this.txtMision.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtMision.Lines = new string[0];
			this.txtMision.Location = new System.Drawing.Point(3, 214);
			this.txtMision.MaxLength = 32767;
			this.txtMision.Multiline = true;
			this.txtMision.Name = "txtMision";
			this.txtMision.PasswordChar = '\0';
			this.txtMision.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMision.SelectedText = "";
			this.txtMision.Size = new System.Drawing.Size(534, 166);
			this.txtMision.Style = MetroFramework.MetroColorStyle.Silver;
			this.txtMision.TabIndex = 2;
			this.txtMision.UseCustomBackColor = true;
			this.txtMision.UseCustomForeColor = true;
			this.txtMision.UseSelectable = true;
			this.txtMision.UseStyleColors = true;
			this.txtMision.Leave += new System.EventHandler(this.AsignAndValidate_MetroTextBox_Leave);
			// 
			// txtVision
			// 
			this.txtVision.BackColor = System.Drawing.Color.White;
			this.txtVision.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtVision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.txtVision.Lines = new string[0];
			this.txtVision.Location = new System.Drawing.Point(3, 22);
			this.txtVision.MaxLength = 32767;
			this.txtVision.Multiline = true;
			this.txtVision.Name = "txtVision";
			this.txtVision.PasswordChar = '\0';
			this.txtVision.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtVision.SelectedText = "";
			this.txtVision.Size = new System.Drawing.Size(534, 167);
			this.txtVision.Style = MetroFramework.MetroColorStyle.Silver;
			this.txtVision.TabIndex = 1;
			this.txtVision.UseCustomBackColor = true;
			this.txtVision.UseCustomForeColor = true;
			this.txtVision.UseSelectable = true;
			this.txtVision.UseStyleColors = true;
			this.txtVision.Leave += new System.EventHandler(this.AsignAndValidate_MetroTextBox_Leave);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(381, 398);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 30);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnHecho
			// 
			this.btnHecho.Location = new System.Drawing.Point(462, 398);
			this.btnHecho.Name = "btnHecho";
			this.btnHecho.Size = new System.Drawing.Size(75, 30);
			this.btnHecho.TabIndex = 3;
			this.btnHecho.Text = "Hecho";
			this.btnHecho.UseSelectable = true;
			this.btnHecho.Click += new System.EventHandler(this.btnHecho_Click);
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
			this.pgsLoading.TabStop = false;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 2);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(43, 19);
			this.metroLabel1.TabIndex = 7;
			this.metroLabel1.Text = "Visión";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 193);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(47, 19);
			this.metroLabel2.TabIndex = 8;
			this.metroLabel2.Text = "Misión";
			// 
			// frm_VisionMision
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_VisionMision";
			this.Padding = new System.Windows.Forms.Padding(30, 87, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Visión/Misión";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_VisionMision_FormClosing);
			this.Load += new System.EventHandler(this.frm_VisionMision_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnHecho;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroTextBox txtVision;
		private MetroFramework.Controls.MetroTextBox txtMision;
		private MetroFramework.Controls.MetroLabel lblMision_Validate;
		private MetroFramework.Controls.MetroLabel lblVision_Validate;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}