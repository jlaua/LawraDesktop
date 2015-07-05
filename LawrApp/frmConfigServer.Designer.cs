namespace LawrApp
{
	partial class frmConfigServer
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
			this.lblmensaje = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.btnAplicar = new MetroFramework.Controls.MetroButton();
			this.psLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.psLoad);
			this.panelMain.Controls.Add(this.btnAplicar);
			this.panelMain.Controls.Add(this.lblmensaje);
			this.panelMain.Controls.Add(this.label1);
			this.panelMain.Controls.Add(this.txtURL);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(446, 95);
			this.panelMain.TabIndex = 0;
			// 
			// lblmensaje
			// 
			this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmensaje.Location = new System.Drawing.Point(4, 68);
			this.lblmensaje.Name = "lblmensaje";
			this.lblmensaje.Size = new System.Drawing.Size(286, 24);
			this.lblmensaje.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Servidor:";
			// 
			// txtURL
			// 
			this.txtURL.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtURL.Location = new System.Drawing.Point(7, 24);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(436, 29);
			this.txtURL.TabIndex = 0;
			// 
			// btnAplicar
			// 
			this.btnAplicar.Location = new System.Drawing.Point(355, 60);
			this.btnAplicar.Name = "btnAplicar";
			this.btnAplicar.Size = new System.Drawing.Size(88, 32);
			this.btnAplicar.TabIndex = 3;
			this.btnAplicar.Text = "Aplicar";
			this.btnAplicar.UseSelectable = true;
			this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
			// 
			// psLoad
			// 
			this.psLoad.Location = new System.Drawing.Point(333, 68);
			this.psLoad.Maximum = 100;
			this.psLoad.Name = "psLoad";
			this.psLoad.Size = new System.Drawing.Size(16, 16);
			this.psLoad.Speed = 3F;
			this.psLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.psLoad.TabIndex = 4;
			this.psLoad.UseSelectable = true;
			this.psLoad.Value = 50;
			this.psLoad.Visible = false;
			// 
			// frmConfigServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 225);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConfigServer";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 33);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Cambiar Servidor";
			this.Load += new System.EventHandler(this.server_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label lblmensaje;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtURL;
		private MetroFramework.Controls.MetroButton btnAplicar;
		private MetroFramework.Controls.MetroProgressSpinner psLoad;
	}
}