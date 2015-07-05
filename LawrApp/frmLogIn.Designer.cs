namespace LawrApp
{
    partial class frmLogIn
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
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtuser_nick = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.pgsload = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnacceder = new MetroFramework.Controls.MetroButton();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.metroLabel3);
            this.panelDatos.Controls.Add(this.metroToggle1);
            this.panelDatos.Controls.Add(this.metroLabel1);
            this.panelDatos.Controls.Add(this.txtuser_nick);
            this.panelDatos.Controls.Add(this.metroLabel2);
            this.panelDatos.Controls.Add(this.txtpassword);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(303, 76);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(267, 194);
            this.panelDatos.TabIndex = 4;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(128, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Recuérdame";
            // 
            // metroToggle1
            // 
            this.metroToggle1.Appearance = System.Windows.Forms.Appearance.Button;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(218, 155);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(42, 19);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToggle1.TabIndex = 7;
            this.metroToggle1.Text = "On";
            this.metroToggle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToggle1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuario";
            // 
            // txtuser_nick
            // 
            this.txtuser_nick.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtuser_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuser_nick.Lines = new string[0];
            this.txtuser_nick.Location = new System.Drawing.Point(3, 32);
            this.txtuser_nick.MaxLength = 32767;
            this.txtuser_nick.Name = "txtuser_nick";
            this.txtuser_nick.PasswordChar = '\0';
            this.txtuser_nick.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtuser_nick.SelectedText = "";
            this.txtuser_nick.Size = new System.Drawing.Size(257, 30);
            this.txtuser_nick.TabIndex = 2;
            this.txtuser_nick.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Contraseña";
            // 
            // txtpassword
            // 
            this.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(3, 97);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(257, 30);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // pgsload
            // 
            this.pgsload.Location = new System.Drawing.Point(427, 338);
            this.pgsload.Maximum = 100;
            this.pgsload.Name = "pgsload";
            this.pgsload.Size = new System.Drawing.Size(24, 24);
            this.pgsload.Speed = 2F;
            this.pgsload.TabIndex = 7;
            this.pgsload.TabStop = false;
            this.pgsload.UseSelectable = true;
            this.pgsload.Value = 50;
            this.pgsload.Visible = false;
            // 
            // btnacceder
            // 
            this.btnacceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnacceder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnacceder.Location = new System.Drawing.Point(464, 336);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(106, 30);
            this.btnacceder.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnacceder.TabIndex = 5;
            this.btnacceder.Text = "Acceder";
            this.btnacceder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnacceder.UseSelectable = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnacceder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.pgsload);
            this.Controls.Add(this.btnacceder);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDatos;
        private MetroFramework.Controls.MetroProgressSpinner pgsload;
        private MetroFramework.Controls.MetroButton btnacceder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtuser_nick;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel3;

    }
}