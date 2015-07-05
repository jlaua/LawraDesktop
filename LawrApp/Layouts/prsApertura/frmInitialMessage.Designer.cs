namespace LawrApp.Layouts.prsApertura
{
    partial class frmInitialMessage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitialMessage));
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnnext = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel1.Location = new System.Drawing.Point(27, 92);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(468, 266);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
			this.metroLabel1.WrapToLine = true;
			// 
			// btnnext
			// 
			this.btnnext.Location = new System.Drawing.Point(398, 389);
			this.btnnext.Name = "btnnext";
			this.btnnext.Size = new System.Drawing.Size(97, 36);
			this.btnnext.TabIndex = 1;
			this.btnnext.Text = "Siguiente";
			this.btnnext.UseSelectable = true;
			this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
			// 
			// frmInitialMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 459);
			this.Controls.Add(this.btnnext);
			this.Controls.Add(this.metroLabel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInitialMessage";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Asistente de Proceso";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInitialMessage_FormClosing);
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnnext;
    }
}