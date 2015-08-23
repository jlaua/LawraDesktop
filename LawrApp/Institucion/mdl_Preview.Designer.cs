namespace LawrApp.Institucion
{
	partial class mdl_Preview
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
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblDetalle = new MetroFramework.Controls.MetroLabel();
			this.panelMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.webBrowser);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 65);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(450, 325);
			this.panelMain.TabIndex = 0;
			// 
			// webBrowser
			// 
			this.webBrowser.AllowNavigation = false;
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.webBrowser.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser.Location = new System.Drawing.Point(0, 34);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.ScrollBarsEnabled = false;
			this.webBrowser.Size = new System.Drawing.Size(450, 291);
			this.webBrowser.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblDetalle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 65);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 28);
			this.panel1.TabIndex = 1;
			// 
			// lblDetalle
			// 
			this.lblDetalle.AutoSize = true;
			this.lblDetalle.Location = new System.Drawing.Point(3, 4);
			this.lblDetalle.Name = "lblDetalle";
			this.lblDetalle.Size = new System.Drawing.Size(52, 19);
			this.lblDetalle.TabIndex = 0;
			this.lblDetalle.Text = "Detalle:";
			// 
			// mdl_Preview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 400);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mdl_Preview";
			this.Padding = new System.Windows.Forms.Padding(0, 65, 0, 10);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Vista previa de Local";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.Load += new System.EventHandler(this.mdl_Preview_Load);
			this.panelMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroLabel lblDetalle;
	}
}