namespace LawrApp
{
	partial class frm_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
			this.panelMain = new System.Windows.Forms.Panel();
			this.spcPaneles = new System.Windows.Forms.SplitContainer();
			this.panelLogin = new System.Windows.Forms.Panel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.tgRemenber1 = new MetroFramework.Controls.MetroToggle();
			this.btnLimpiar = new MetroFramework.Controls.MetroButton();
			this.panelInputPassword1 = new MetroFramework.Controls.MetroPanel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txtPassword1 = new System.Windows.Forms.TextBox();
			this.btnIngresar = new MetroFramework.Controls.MetroButton();
			this.ptbUserBlank = new System.Windows.Forms.PictureBox();
			this.panelInputUser1 = new MetroFramework.Controls.MetroPanel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtUser1 = new System.Windows.Forms.TextBox();
			this.panelAcceder = new System.Windows.Forms.Panel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.tgRemenber2 = new MetroFramework.Controls.MetroToggle();
			this.panelInputPassword2 = new MetroFramework.Controls.MetroPanel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.txtPassword2 = new System.Windows.Forms.TextBox();
			this.btnCambiar = new MetroFramework.Controls.MetroButton();
			this.btnContinuar = new MetroFramework.Controls.MetroButton();
			this.lblCargo = new MetroFramework.Controls.MetroLabel();
			this.lblFullName = new MetroFramework.Controls.MetroLabel();
			this.ptbImagePorfile = new System.Windows.Forms.PictureBox();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.btnChange = new MetroFramework.Controls.MetroButton();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcPaneles)).BeginInit();
			this.spcPaneles.Panel1.SuspendLayout();
			this.spcPaneles.Panel2.SuspendLayout();
			this.spcPaneles.SuspendLayout();
			this.panelLogin.SuspendLayout();
			this.panelInputPassword1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbUserBlank)).BeginInit();
			this.panelInputUser1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelAcceder.SuspendLayout();
			this.panelInputPassword2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagePorfile)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.spcPaneles);
			this.panelMain.Enabled = false;
			this.panelMain.Location = new System.Drawing.Point(23, 59);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(554, 406);
			this.panelMain.TabIndex = 0;
			// 
			// spcPaneles
			// 
			this.spcPaneles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcPaneles.Location = new System.Drawing.Point(0, 0);
			this.spcPaneles.Name = "spcPaneles";
			// 
			// spcPaneles.Panel1
			// 
			this.spcPaneles.Panel1.Controls.Add(this.panelLogin);
			this.spcPaneles.Panel1Collapsed = true;
			this.spcPaneles.Panel1MinSize = 0;
			// 
			// spcPaneles.Panel2
			// 
			this.spcPaneles.Panel2.Controls.Add(this.panelAcceder);
			this.spcPaneles.Panel2MinSize = 0;
			this.spcPaneles.Size = new System.Drawing.Size(554, 406);
			this.spcPaneles.SplitterDistance = 184;
			this.spcPaneles.TabIndex = 0;
			this.spcPaneles.TabStop = false;
			// 
			// panelLogin
			// 
			this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.panelLogin.Controls.Add(this.metroLabel1);
			this.panelLogin.Controls.Add(this.tgRemenber1);
			this.panelLogin.Controls.Add(this.btnLimpiar);
			this.panelLogin.Controls.Add(this.panelInputPassword1);
			this.panelLogin.Controls.Add(this.btnIngresar);
			this.panelLogin.Controls.Add(this.ptbUserBlank);
			this.panelLogin.Controls.Add(this.panelInputUser1);
			this.panelLogin.Location = new System.Drawing.Point(88, 11);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(377, 392);
			this.panelLogin.TabIndex = 5;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel1.Location = new System.Drawing.Point(193, 262);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(70, 15);
			this.metroLabel1.TabIndex = 12;
			this.metroLabel1.Text = "Recuérdame";
			this.metroLabel1.UseCustomBackColor = true;
			// 
			// tgRemenber1
			// 
			this.tgRemenber1.Checked = true;
			this.tgRemenber1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tgRemenber1.DisplayStatus = false;
			this.tgRemenber1.Location = new System.Drawing.Point(269, 258);
			this.tgRemenber1.Name = "tgRemenber1";
			this.tgRemenber1.Size = new System.Drawing.Size(35, 19);
			this.tgRemenber1.Style = MetroFramework.MetroColorStyle.Teal;
			this.tgRemenber1.TabIndex = 2;
			this.tgRemenber1.Text = "On";
			this.tgRemenber1.UseSelectable = true;
			this.tgRemenber1.UseStyleColors = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(72, 315);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(82, 39);
			this.btnLimpiar.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseCustomBackColor = true;
			this.btnLimpiar.UseCustomForeColor = true;
			this.btnLimpiar.UseSelectable = true;
			this.btnLimpiar.UseStyleColors = true;
			// 
			// panelInputPassword1
			// 
			this.panelInputPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelInputPassword1.Controls.Add(this.pictureBox3);
			this.panelInputPassword1.Controls.Add(this.txtPassword1);
			this.panelInputPassword1.HorizontalScrollbarBarColor = true;
			this.panelInputPassword1.HorizontalScrollbarHighlightOnWheel = false;
			this.panelInputPassword1.HorizontalScrollbarSize = 10;
			this.panelInputPassword1.Location = new System.Drawing.Point(72, 222);
			this.panelInputPassword1.Name = "panelInputPassword1";
			this.panelInputPassword1.Size = new System.Drawing.Size(232, 30);
			this.panelInputPassword1.TabIndex = 9;
			this.panelInputPassword1.VerticalScrollbarBarColor = true;
			this.panelInputPassword1.VerticalScrollbarHighlightOnWheel = false;
			this.panelInputPassword1.VerticalScrollbarSize = 10;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.pictureBox3.Location = new System.Drawing.Point(209, 5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(18, 18);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// txtPassword1
			// 
			this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword1.Location = new System.Drawing.Point(7, 3);
			this.txtPassword1.MaxLength = 60;
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.Size = new System.Drawing.Size(189, 22);
			this.txtPassword1.TabIndex = 1;
			this.txtPassword1.UseSystemPasswordChar = true;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(160, 315);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(144, 39);
			this.btnIngresar.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnIngresar.TabIndex = 3;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseCustomBackColor = true;
			this.btnIngresar.UseCustomForeColor = true;
			this.btnIngresar.UseSelectable = true;
			this.btnIngresar.UseStyleColors = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// ptbUserBlank
			// 
			this.ptbUserBlank.Image = global::LawrApp.Properties.Resources.user_tie_grey;
			this.ptbUserBlank.ImageLocation = "";
			this.ptbUserBlank.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.ptbUserBlank.Location = new System.Drawing.Point(123, 25);
			this.ptbUserBlank.Name = "ptbUserBlank";
			this.ptbUserBlank.Size = new System.Drawing.Size(129, 131);
			this.ptbUserBlank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbUserBlank.TabIndex = 0;
			this.ptbUserBlank.TabStop = false;
			// 
			// panelInputUser1
			// 
			this.panelInputUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelInputUser1.Controls.Add(this.pictureBox2);
			this.panelInputUser1.Controls.Add(this.txtUser1);
			this.panelInputUser1.HorizontalScrollbarBarColor = true;
			this.panelInputUser1.HorizontalScrollbarHighlightOnWheel = false;
			this.panelInputUser1.HorizontalScrollbarSize = 10;
			this.panelInputUser1.Location = new System.Drawing.Point(72, 182);
			this.panelInputUser1.Name = "panelInputUser1";
			this.panelInputUser1.Size = new System.Drawing.Size(232, 30);
			this.panelInputUser1.TabIndex = 8;
			this.panelInputUser1.VerticalScrollbarBarColor = true;
			this.panelInputUser1.VerticalScrollbarHighlightOnWheel = false;
			this.panelInputUser1.VerticalScrollbarSize = 10;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.pictureBox2.Location = new System.Drawing.Point(209, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(18, 18);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// txtUser1
			// 
			this.txtUser1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUser1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser1.Location = new System.Drawing.Point(7, 3);
			this.txtUser1.MaxLength = 60;
			this.txtUser1.Name = "txtUser1";
			this.txtUser1.Size = new System.Drawing.Size(196, 22);
			this.txtUser1.TabIndex = 0;
			// 
			// panelAcceder
			// 
			this.panelAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.panelAcceder.Controls.Add(this.metroLabel2);
			this.panelAcceder.Controls.Add(this.tgRemenber2);
			this.panelAcceder.Controls.Add(this.panelInputPassword2);
			this.panelAcceder.Controls.Add(this.btnCambiar);
			this.panelAcceder.Controls.Add(this.btnContinuar);
			this.panelAcceder.Controls.Add(this.lblCargo);
			this.panelAcceder.Controls.Add(this.lblFullName);
			this.panelAcceder.Controls.Add(this.ptbImagePorfile);
			this.panelAcceder.Location = new System.Drawing.Point(87, 3);
			this.panelAcceder.Name = "panelAcceder";
			this.panelAcceder.Size = new System.Drawing.Size(377, 400);
			this.panelAcceder.TabIndex = 0;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel2.Location = new System.Drawing.Point(178, 284);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(83, 19);
			this.metroLabel2.TabIndex = 14;
			this.metroLabel2.Text = "Recuérdame";
			this.metroLabel2.UseCustomBackColor = true;
			// 
			// tgRemenber2
			// 
			this.tgRemenber2.Checked = true;
			this.tgRemenber2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tgRemenber2.DisplayStatus = false;
			this.tgRemenber2.Location = new System.Drawing.Point(267, 282);
			this.tgRemenber2.Name = "tgRemenber2";
			this.tgRemenber2.Size = new System.Drawing.Size(37, 21);
			this.tgRemenber2.Style = MetroFramework.MetroColorStyle.Teal;
			this.tgRemenber2.TabIndex = 1;
			this.tgRemenber2.Text = "On";
			this.tgRemenber2.UseSelectable = true;
			this.tgRemenber2.UseStyleColors = true;
			// 
			// panelInputPassword2
			// 
			this.panelInputPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelInputPassword2.Controls.Add(this.pictureBox4);
			this.panelInputPassword2.Controls.Add(this.txtPassword2);
			this.panelInputPassword2.HorizontalScrollbarBarColor = true;
			this.panelInputPassword2.HorizontalScrollbarHighlightOnWheel = false;
			this.panelInputPassword2.HorizontalScrollbarSize = 10;
			this.panelInputPassword2.Location = new System.Drawing.Point(72, 246);
			this.panelInputPassword2.Name = "panelInputPassword2";
			this.panelInputPassword2.Size = new System.Drawing.Size(232, 30);
			this.panelInputPassword2.TabIndex = 9;
			this.panelInputPassword2.VerticalScrollbarBarColor = true;
			this.panelInputPassword2.VerticalScrollbarHighlightOnWheel = false;
			this.panelInputPassword2.VerticalScrollbarSize = 10;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox4.Image = global::LawrApp.Properties.Resources.key_grey;
			this.pictureBox4.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.pictureBox4.Location = new System.Drawing.Point(209, 6);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(18, 18);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// txtPassword2
			// 
			this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword2.Location = new System.Drawing.Point(3, 3);
			this.txtPassword2.MaxLength = 60;
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.Size = new System.Drawing.Size(200, 22);
			this.txtPassword2.TabIndex = 0;
			this.txtPassword2.UseSystemPasswordChar = true;
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(68, 339);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(67, 37);
			this.btnCambiar.TabIndex = 3;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseSelectable = true;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// btnContinuar
			// 
			this.btnContinuar.Location = new System.Drawing.Point(141, 339);
			this.btnContinuar.Name = "btnContinuar";
			this.btnContinuar.Size = new System.Drawing.Size(159, 37);
			this.btnContinuar.TabIndex = 2;
			this.btnContinuar.Text = "Continuar";
			this.btnContinuar.UseSelectable = true;
			this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
			// 
			// lblCargo
			// 
			this.lblCargo.BackColor = System.Drawing.Color.Transparent;
			this.lblCargo.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblCargo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblCargo.Location = new System.Drawing.Point(3, 206);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(371, 18);
			this.lblCargo.TabIndex = 2;
			this.lblCargo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblCargo.UseCustomBackColor = true;
			// 
			// lblFullName
			// 
			this.lblFullName.BackColor = System.Drawing.Color.Transparent;
			this.lblFullName.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblFullName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.lblFullName.Location = new System.Drawing.Point(47, 178);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(292, 28);
			this.lblFullName.TabIndex = 1;
			this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFullName.UseCustomBackColor = true;
			this.lblFullName.UseCustomForeColor = true;
			// 
			// ptbImagePorfile
			// 
			this.ptbImagePorfile.ErrorImage = global::LawrApp.Properties.Resources.image_broken;
			this.ptbImagePorfile.ImageLocation = "";
			this.ptbImagePorfile.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.ptbImagePorfile.Location = new System.Drawing.Point(126, 27);
			this.ptbImagePorfile.Name = "ptbImagePorfile";
			this.ptbImagePorfile.Size = new System.Drawing.Size(132, 148);
			this.ptbImagePorfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagePorfile.TabIndex = 0;
			this.ptbImagePorfile.TabStop = false;
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(25, 468);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Teal;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.TabStop = false;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// btnChange
			// 
			this.btnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChange.BackgroundImage")));
			this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChange.DisplayFocus = true;
			this.btnChange.Highlight = true;
			this.btnChange.Location = new System.Drawing.Point(561, 468);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(16, 16);
			this.btnChange.Style = MetroFramework.MetroColorStyle.White;
			this.btnChange.TabIndex = 2;
			this.btnChange.TabStop = false;
			this.btnChange.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnChange.UseCustomBackColor = true;
			this.btnChange.UseCustomForeColor = true;
			this.btnChange.UseSelectable = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// frm_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 500);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Login";
			this.Padding = new System.Windows.Forms.Padding(20, 67, 20, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Teal;
			this.Text = "Login";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Login_FormClosing);
			this.Load += new System.EventHandler(this.frm_Login_Load);
			this.panelMain.ResumeLayout(false);
			this.spcPaneles.Panel1.ResumeLayout(false);
			this.spcPaneles.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcPaneles)).EndInit();
			this.spcPaneles.ResumeLayout(false);
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.panelInputPassword1.ResumeLayout(false);
			this.panelInputPassword1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbUserBlank)).EndInit();
			this.panelInputUser1.ResumeLayout(false);
			this.panelInputUser1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelAcceder.ResumeLayout(false);
			this.panelAcceder.PerformLayout();
			this.panelInputPassword2.ResumeLayout(false);
			this.panelInputPassword2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagePorfile)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private System.Windows.Forms.Panel panelAcceder;
		private MetroFramework.Controls.MetroLabel lblFullName;
		private System.Windows.Forms.PictureBox ptbImagePorfile;
		private MetroFramework.Controls.MetroLabel lblCargo;
		private MetroFramework.Controls.MetroButton btnCambiar;
		private MetroFramework.Controls.MetroButton btnContinuar;
		private System.Windows.Forms.Panel panelLogin;
		private MetroFramework.Controls.MetroButton btnIngresar;
		private System.Windows.Forms.PictureBox ptbUserBlank;
		private System.Windows.Forms.TextBox txtPassword1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private MetroFramework.Controls.MetroPanel panelInputUser1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtUser1;
		private MetroFramework.Controls.MetroPanel panelInputPassword1;
		private MetroFramework.Controls.MetroToggle tgRemenber1;
		private MetroFramework.Controls.MetroButton btnLimpiar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.SplitContainer spcPaneles;
		private MetroFramework.Controls.MetroPanel panelInputPassword2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox txtPassword2;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroToggle tgRemenber2;
		private MetroFramework.Controls.MetroButton btnChange;
	}
}