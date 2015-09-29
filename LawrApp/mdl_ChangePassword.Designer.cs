namespace LawrApp
{
	partial class mdl_ChangePassword
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.lblConfirmPassword_Validator = new MetroFramework.Controls.MetroLabel();
			this.lblNewPassword_Validator = new MetroFramework.Controls.MetroLabel();
			this.lblOldPassword_validator = new MetroFramework.Controls.MetroLabel();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnCambiar = new MetroFramework.Controls.MetroButton();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtOldPassword = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.ttValidator = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.lblConfirmPassword_Validator);
			this.panelMain.Controls.Add(this.lblNewPassword_Validator);
			this.panelMain.Controls.Add(this.lblOldPassword_validator);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnCambiar);
			this.panelMain.Controls.Add(this.txtConfirmPassword);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.txtNewPassword);
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.txtOldPassword);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 60);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(340, 258);
			this.panelMain.TabIndex = 0;
			// 
			// lblConfirmPassword_Validator
			// 
			this.lblConfirmPassword_Validator.AutoSize = true;
			this.lblConfirmPassword_Validator.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblConfirmPassword_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblConfirmPassword_Validator.Location = new System.Drawing.Point(137, 142);
			this.lblConfirmPassword_Validator.Name = "lblConfirmPassword_Validator";
			this.lblConfirmPassword_Validator.Size = new System.Drawing.Size(15, 19);
			this.lblConfirmPassword_Validator.TabIndex = 3;
			this.lblConfirmPassword_Validator.Text = "*";
			this.lblConfirmPassword_Validator.UseCustomForeColor = true;
			// 
			// lblNewPassword_Validator
			// 
			this.lblNewPassword_Validator.AutoSize = true;
			this.lblNewPassword_Validator.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblNewPassword_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblNewPassword_Validator.Location = new System.Drawing.Point(115, 77);
			this.lblNewPassword_Validator.Name = "lblNewPassword_Validator";
			this.lblNewPassword_Validator.Size = new System.Drawing.Size(15, 19);
			this.lblNewPassword_Validator.TabIndex = 3;
			this.lblNewPassword_Validator.Text = "*";
			this.lblNewPassword_Validator.UseCustomForeColor = true;
			// 
			// lblOldPassword_validator
			// 
			this.lblOldPassword_validator.AutoSize = true;
			this.lblOldPassword_validator.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblOldPassword_validator.ForeColor = System.Drawing.Color.Red;
			this.lblOldPassword_validator.Location = new System.Drawing.Point(115, 13);
			this.lblOldPassword_validator.Name = "lblOldPassword_validator";
			this.lblOldPassword_validator.Size = new System.Drawing.Size(15, 19);
			this.lblOldPassword_validator.TabIndex = 3;
			this.lblOldPassword_validator.Text = "*";
			this.lblOldPassword_validator.UseCustomForeColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 223);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(67, 32);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(251, 223);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(86, 32);
			this.btnCambiar.TabIndex = 3;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseSelectable = true;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(3, 164);
			this.txtConfirmPassword.MaxLength = 100;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(334, 29);
			this.txtConfirmPassword.TabIndex = 2;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			this.txtConfirmPassword.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(3, 142);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(139, 19);
			this.metroLabel3.TabIndex = 0;
			this.metroLabel3.Text = "Confirmar Contraseña";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(3, 99);
			this.txtNewPassword.MaxLength = 100;
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Size = new System.Drawing.Size(334, 29);
			this.txtNewPassword.TabIndex = 1;
			this.txtNewPassword.UseSystemPasswordChar = true;
			this.txtNewPassword.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 77);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(116, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Nueva Contraseña";
			// 
			// txtOldPassword
			// 
			this.txtOldPassword.Location = new System.Drawing.Point(3, 35);
			this.txtOldPassword.MaxLength = 100;
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.Size = new System.Drawing.Size(334, 29);
			this.txtOldPassword.TabIndex = 0;
			this.txtOldPassword.UseSystemPasswordChar = true;
			this.txtOldPassword.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 13);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(115, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Contraseña Actual";
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(351, 321);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.TabStop = false;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// ttValidator
			// 
			this.ttValidator.BackColor = System.Drawing.Color.White;
			this.ttValidator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			// 
			// mdl_ChangePassword
			// 
			this.AcceptButton = this.btnCambiar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.CancelButton = this.btnSalir;
			this.ClientSize = new System.Drawing.Size(400, 350);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "mdl_ChangePassword";
			this.Padding = new System.Windows.Forms.Padding(30, 60, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cambiar Contraseña";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdl_ChangePassword_FormClosing);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnCambiar;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox txtNewPassword;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtOldPassword;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel lblConfirmPassword_Validator;
		private MetroFramework.Controls.MetroLabel lblNewPassword_Validator;
		private MetroFramework.Controls.MetroLabel lblOldPassword_validator;
		private System.Windows.Forms.ToolTip ttValidator;
	}
}