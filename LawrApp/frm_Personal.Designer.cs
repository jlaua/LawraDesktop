namespace LawrApp
{
	partial class frm_Personal
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
			this.panel_Right_Body = new System.Windows.Forms.Panel();
			this.flpanel_Mensajes = new System.Windows.Forms.FlowLayoutPanel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.panel_Left_Body = new System.Windows.Forms.Panel();
			this.tileMaterial = new MetroFramework.Controls.MetroTile();
			this.panelHeading = new System.Windows.Forms.Panel();
			this.panel_Right_InstitutionData = new System.Windows.Forms.Panel();
			this.cboYearPeriod = new MetroFramework.Controls.MetroComboBox();
			this.lblAddressInstitucion = new MetroFramework.Controls.MetroLabel();
			this.lblNameInstitucion = new MetroFramework.Controls.MetroLabel();
			this.ptbLogoInstitucion = new System.Windows.Forms.PictureBox();
			this.panel_Left_UserData = new System.Windows.Forms.Panel();
			this.lblLogOut = new MetroFramework.Controls.MetroLink();
			this.lblCargo = new MetroFramework.Controls.MetroLabel();
			this.lblFullName = new MetroFramework.Controls.MetroLabel();
			this.ptbImagePorfile = new System.Windows.Forms.PictureBox();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pts_MenuItem_ChangeImagePerfil = new System.Windows.Forms.ToolStripMenuItem();
			this.pts_MenuItem_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
			this.pts_MenuItem_MyProfile = new System.Windows.Forms.ToolStripMenuItem();
			this.pts_MenuItem_LogOut = new System.Windows.Forms.ToolStripMenuItem();
			this.pts_MenuItem_CloseApp = new System.Windows.Forms.ToolStripMenuItem();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.lblLoadInfo = new MetroFramework.Controls.MetroLabel();
			this.panelMain.SuspendLayout();
			this.panel_Right_Body.SuspendLayout();
			this.panel_Left_Body.SuspendLayout();
			this.panelHeading.SuspendLayout();
			this.panel_Right_InstitutionData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogoInstitucion)).BeginInit();
			this.panel_Left_UserData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagePorfile)).BeginInit();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.panel_Right_Body);
			this.panelMain.Controls.Add(this.panel_Left_Body);
			this.panelMain.Controls.Add(this.panelHeading);
			this.panelMain.Controls.Add(this.MainMenu);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Enabled = false;
			this.panelMain.Location = new System.Drawing.Point(20, 30);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(860, 540);
			this.panelMain.TabIndex = 0;
			// 
			// panel_Right_Body
			// 
			this.panel_Right_Body.Controls.Add(this.flpanel_Mensajes);
			this.panel_Right_Body.Controls.Add(this.metroLabel5);
			this.panel_Right_Body.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_Right_Body.Location = new System.Drawing.Point(607, 109);
			this.panel_Right_Body.Name = "panel_Right_Body";
			this.panel_Right_Body.Size = new System.Drawing.Size(253, 431);
			this.panel_Right_Body.TabIndex = 5;
			// 
			// flpanel_Mensajes
			// 
			this.flpanel_Mensajes.AutoScroll = true;
			this.flpanel_Mensajes.Location = new System.Drawing.Point(3, 33);
			this.flpanel_Mensajes.Name = "flpanel_Mensajes";
			this.flpanel_Mensajes.Size = new System.Drawing.Size(247, 395);
			this.flpanel_Mensajes.TabIndex = 12;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(3, 11);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(65, 19);
			this.metroLabel5.TabIndex = 11;
			this.metroLabel5.Text = "Mensajes:";
			// 
			// panel_Left_Body
			// 
			this.panel_Left_Body.Controls.Add(this.tileMaterial);
			this.panel_Left_Body.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_Left_Body.Location = new System.Drawing.Point(0, 109);
			this.panel_Left_Body.Name = "panel_Left_Body";
			this.panel_Left_Body.Size = new System.Drawing.Size(601, 431);
			this.panel_Left_Body.TabIndex = 3;
			// 
			// tileMaterial
			// 
			this.tileMaterial.ActiveControl = null;
			this.tileMaterial.Location = new System.Drawing.Point(19, 21);
			this.tileMaterial.Name = "tileMaterial";
			this.tileMaterial.Size = new System.Drawing.Size(103, 125);
			this.tileMaterial.Style = MetroFramework.MetroColorStyle.Lime;
			this.tileMaterial.TabIndex = 12;
			this.tileMaterial.Text = "Registrar \r\nMaterial";
			this.tileMaterial.UseSelectable = true;
			this.tileMaterial.Click += new System.EventHandler(this.tileMaterial_Click);
			// 
			// panelHeading
			// 
			this.panelHeading.Controls.Add(this.panel_Right_InstitutionData);
			this.panelHeading.Controls.Add(this.panel_Left_UserData);
			this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeading.Location = new System.Drawing.Point(0, 25);
			this.panelHeading.Name = "panelHeading";
			this.panelHeading.Size = new System.Drawing.Size(860, 84);
			this.panelHeading.TabIndex = 2;
			// 
			// panel_Right_InstitutionData
			// 
			this.panel_Right_InstitutionData.Controls.Add(this.cboYearPeriod);
			this.panel_Right_InstitutionData.Controls.Add(this.lblAddressInstitucion);
			this.panel_Right_InstitutionData.Controls.Add(this.lblNameInstitucion);
			this.panel_Right_InstitutionData.Controls.Add(this.ptbLogoInstitucion);
			this.panel_Right_InstitutionData.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_Right_InstitutionData.Location = new System.Drawing.Point(391, 0);
			this.panel_Right_InstitutionData.Name = "panel_Right_InstitutionData";
			this.panel_Right_InstitutionData.Size = new System.Drawing.Size(469, 84);
			this.panel_Right_InstitutionData.TabIndex = 1;
			// 
			// cboYearPeriod
			// 
			this.cboYearPeriod.DisplayFocus = true;
			this.cboYearPeriod.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cboYearPeriod.FormattingEnabled = true;
			this.cboYearPeriod.ItemHeight = 19;
			this.cboYearPeriod.Location = new System.Drawing.Point(267, 53);
			this.cboYearPeriod.Name = "cboYearPeriod";
			this.cboYearPeriod.PromptText = "Periodos";
			this.cboYearPeriod.Size = new System.Drawing.Size(121, 25);
			this.cboYearPeriod.TabIndex = 6;
			this.cboYearPeriod.UseSelectable = true;
			// 
			// lblAddressInstitucion
			// 
			this.lblAddressInstitucion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblAddressInstitucion.Location = new System.Drawing.Point(45, 33);
			this.lblAddressInstitucion.Name = "lblAddressInstitucion";
			this.lblAddressInstitucion.Size = new System.Drawing.Size(343, 18);
			this.lblAddressInstitucion.TabIndex = 5;
			this.lblAddressInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblNameInstitucion
			// 
			this.lblNameInstitucion.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblNameInstitucion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblNameInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.lblNameInstitucion.Location = new System.Drawing.Point(45, 4);
			this.lblNameInstitucion.Name = "lblNameInstitucion";
			this.lblNameInstitucion.Size = new System.Drawing.Size(343, 31);
			this.lblNameInstitucion.TabIndex = 4;
			this.lblNameInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblNameInstitucion.UseCustomForeColor = true;
			// 
			// ptbLogoInstitucion
			// 
			this.ptbLogoInstitucion.ErrorImage = global::LawrApp.Properties.Resources.image_broken;
			this.ptbLogoInstitucion.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.ptbLogoInstitucion.Location = new System.Drawing.Point(394, 4);
			this.ptbLogoInstitucion.Name = "ptbLogoInstitucion";
			this.ptbLogoInstitucion.Size = new System.Drawing.Size(72, 77);
			this.ptbLogoInstitucion.TabIndex = 0;
			this.ptbLogoInstitucion.TabStop = false;
			// 
			// panel_Left_UserData
			// 
			this.panel_Left_UserData.Controls.Add(this.lblLogOut);
			this.panel_Left_UserData.Controls.Add(this.lblCargo);
			this.panel_Left_UserData.Controls.Add(this.lblFullName);
			this.panel_Left_UserData.Controls.Add(this.ptbImagePorfile);
			this.panel_Left_UserData.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_Left_UserData.Location = new System.Drawing.Point(0, 0);
			this.panel_Left_UserData.Name = "panel_Left_UserData";
			this.panel_Left_UserData.Size = new System.Drawing.Size(385, 84);
			this.panel_Left_UserData.TabIndex = 0;
			// 
			// lblLogOut
			// 
			this.lblLogOut.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.lblLogOut.Location = new System.Drawing.Point(76, 64);
			this.lblLogOut.Name = "lblLogOut";
			this.lblLogOut.Size = new System.Drawing.Size(117, 15);
			this.lblLogOut.TabIndex = 3;
			this.lblLogOut.Text = "Cerrar Sesión";
			this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblLogOut.UseCustomForeColor = true;
			this.lblLogOut.UseSelectable = true;
			// 
			// lblCargo
			// 
			this.lblCargo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblCargo.Location = new System.Drawing.Point(76, 36);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(304, 18);
			this.lblCargo.TabIndex = 2;
			// 
			// lblFullName
			// 
			this.lblFullName.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblFullName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.lblFullName.Location = new System.Drawing.Point(76, 9);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(304, 31);
			this.lblFullName.TabIndex = 1;
			this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFullName.UseCustomForeColor = true;
			// 
			// ptbImagePorfile
			// 
			this.ptbImagePorfile.ErrorImage = global::LawrApp.Properties.Resources.image_broken;
			this.ptbImagePorfile.InitialImage = global::LawrApp.Properties.Resources.loader;
			this.ptbImagePorfile.Location = new System.Drawing.Point(3, 3);
			this.ptbImagePorfile.Name = "ptbImagePorfile";
			this.ptbImagePorfile.Size = new System.Drawing.Size(67, 76);
			this.ptbImagePorfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagePorfile.TabIndex = 0;
			this.ptbImagePorfile.TabStop = false;
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.Color.White;
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(860, 25);
			this.MainMenu.TabIndex = 1;
			this.MainMenu.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pts_MenuItem_ChangeImagePerfil,
            this.pts_MenuItem_ChangePassword,
            this.pts_MenuItem_MyProfile,
            this.pts_MenuItem_LogOut,
            this.pts_MenuItem_CloseApp});
			this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.archivoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.archivoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// pts_MenuItem_ChangeImagePerfil
			// 
			this.pts_MenuItem_ChangeImagePerfil.BackColor = System.Drawing.Color.White;
			this.pts_MenuItem_ChangeImagePerfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.pts_MenuItem_ChangeImagePerfil.ImageTransparentColor = System.Drawing.Color.White;
			this.pts_MenuItem_ChangeImagePerfil.Name = "pts_MenuItem_ChangeImagePerfil";
			this.pts_MenuItem_ChangeImagePerfil.Padding = new System.Windows.Forms.Padding(2);
			this.pts_MenuItem_ChangeImagePerfil.Size = new System.Drawing.Size(228, 24);
			this.pts_MenuItem_ChangeImagePerfil.Text = "Cambiar Imagen de Perfil";
			// 
			// pts_MenuItem_ChangePassword
			// 
			this.pts_MenuItem_ChangePassword.BackColor = System.Drawing.Color.White;
			this.pts_MenuItem_ChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.pts_MenuItem_ChangePassword.ImageTransparentColor = System.Drawing.Color.White;
			this.pts_MenuItem_ChangePassword.Name = "pts_MenuItem_ChangePassword";
			this.pts_MenuItem_ChangePassword.Size = new System.Drawing.Size(224, 22);
			this.pts_MenuItem_ChangePassword.Text = "Cambiar Contraseña";
			// 
			// pts_MenuItem_MyProfile
			// 
			this.pts_MenuItem_MyProfile.BackColor = System.Drawing.Color.White;
			this.pts_MenuItem_MyProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.pts_MenuItem_MyProfile.ImageTransparentColor = System.Drawing.Color.White;
			this.pts_MenuItem_MyProfile.Name = "pts_MenuItem_MyProfile";
			this.pts_MenuItem_MyProfile.Size = new System.Drawing.Size(224, 22);
			this.pts_MenuItem_MyProfile.Text = "Mi Perfil";
			// 
			// pts_MenuItem_LogOut
			// 
			this.pts_MenuItem_LogOut.BackColor = System.Drawing.Color.White;
			this.pts_MenuItem_LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.pts_MenuItem_LogOut.ImageTransparentColor = System.Drawing.Color.White;
			this.pts_MenuItem_LogOut.Name = "pts_MenuItem_LogOut";
			this.pts_MenuItem_LogOut.Size = new System.Drawing.Size(224, 22);
			this.pts_MenuItem_LogOut.Text = "Cerrar Sesión";
			// 
			// pts_MenuItem_CloseApp
			// 
			this.pts_MenuItem_CloseApp.BackColor = System.Drawing.Color.White;
			this.pts_MenuItem_CloseApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.pts_MenuItem_CloseApp.ImageTransparentColor = System.Drawing.Color.White;
			this.pts_MenuItem_CloseApp.Name = "pts_MenuItem_CloseApp";
			this.pts_MenuItem_CloseApp.Size = new System.Drawing.Size(224, 22);
			this.pts_MenuItem_CloseApp.Text = "Salir";
			// 
			// metroLabel1
			// 
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel1.Location = new System.Drawing.Point(23, 8);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(160, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Menu Principal - Secretari(a/o)";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(20, 573);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 4;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// lblLoadInfo
			// 
			this.lblLoadInfo.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblLoadInfo.Location = new System.Drawing.Point(42, 573);
			this.lblLoadInfo.Name = "lblLoadInfo";
			this.lblLoadInfo.Size = new System.Drawing.Size(579, 16);
			this.lblLoadInfo.TabIndex = 5;
			// 
			// frm_Personal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 600);
			this.Controls.Add(this.lblLoadInfo);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.panelMain);
			this.DisplayHeader = false;
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Personal";
			this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 30);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Text = "Menu Principal";
			this.Load += new System.EventHandler(this.frm_Personal_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.panel_Right_Body.ResumeLayout(false);
			this.panel_Right_Body.PerformLayout();
			this.panel_Left_Body.ResumeLayout(false);
			this.panelHeading.ResumeLayout(false);
			this.panel_Right_InstitutionData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbLogoInstitucion)).EndInit();
			this.panel_Left_UserData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbImagePorfile)).EndInit();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pts_MenuItem_ChangeImagePerfil;
		private System.Windows.Forms.ToolStripMenuItem pts_MenuItem_ChangePassword;
		private System.Windows.Forms.ToolStripMenuItem pts_MenuItem_MyProfile;
		private System.Windows.Forms.ToolStripMenuItem pts_MenuItem_LogOut;
		private System.Windows.Forms.ToolStripMenuItem pts_MenuItem_CloseApp;
		private System.Windows.Forms.Panel panelHeading;
		private System.Windows.Forms.Panel panel_Right_InstitutionData;
		private System.Windows.Forms.Panel panel_Left_UserData;
		private MetroFramework.Controls.MetroLink lblLogOut;
		private MetroFramework.Controls.MetroLabel lblCargo;
		private MetroFramework.Controls.MetroLabel lblFullName;
		private System.Windows.Forms.PictureBox ptbImagePorfile;
		private System.Windows.Forms.Panel panel_Left_Body;
		private System.Windows.Forms.Panel panel_Right_Body;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private System.Windows.Forms.PictureBox ptbLogoInstitucion;
		private MetroFramework.Controls.MetroLabel lblAddressInstitucion;
		private MetroFramework.Controls.MetroLabel lblNameInstitucion;
		private MetroFramework.Controls.MetroComboBox cboYearPeriod;
		private System.Windows.Forms.FlowLayoutPanel flpanel_Mensajes;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTile tileMaterial;
		private MetroFramework.Controls.MetroLabel lblLoadInfo;
	}
}