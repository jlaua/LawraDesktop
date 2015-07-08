namespace LawrApp.Layouts.prsMatricula
{
	partial class frmDocumentos
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
			this.btnSearchImageDocument = new MetroFramework.Controls.MetroButton();
			this.btnAddDocumentToAlumno = new MetroFramework.Controls.MetroButton();
			this.pbImageDocument = new System.Windows.Forms.PictureBox();
			this.gbDatosDocument = new System.Windows.Forms.GroupBox();
			this.lblDateExpire = new System.Windows.Forms.Label();
			this.lbVNumeroDocumento = new System.Windows.Forms.Label();
			this.lbVtipoDocumento = new System.Windows.Forms.Label();
			this.chboExpira = new MetroFramework.Controls.MetroCheckBox();
			this.txtNumberDocument = new MetroFramework.Controls.MetroTextBox();
			this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
			this.cboTypeDocument = new System.Windows.Forms.ComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.openImageDocument = new System.Windows.Forms.OpenFileDialog();
			this.ttValidatorMessage = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbImageDocument)).BeginInit();
			this.gbDatosDocument.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearchImageDocument
			// 
			this.btnSearchImageDocument.Location = new System.Drawing.Point(371, 70);
			this.btnSearchImageDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSearchImageDocument.Name = "btnSearchImageDocument";
			this.btnSearchImageDocument.Size = new System.Drawing.Size(199, 30);
			this.btnSearchImageDocument.TabIndex = 12;
			this.btnSearchImageDocument.Text = "Imagen";
			this.btnSearchImageDocument.UseSelectable = true;
			this.btnSearchImageDocument.Click += new System.EventHandler(this.btnSearchImageDocument_Click);
			// 
			// btnAddDocumentToAlumno
			// 
			this.btnAddDocumentToAlumno.Location = new System.Drawing.Point(467, 335);
			this.btnAddDocumentToAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddDocumentToAlumno.Name = "btnAddDocumentToAlumno";
			this.btnAddDocumentToAlumno.Size = new System.Drawing.Size(103, 30);
			this.btnAddDocumentToAlumno.TabIndex = 14;
			this.btnAddDocumentToAlumno.Text = "Agregar";
			this.btnAddDocumentToAlumno.UseSelectable = true;
			this.btnAddDocumentToAlumno.Click += new System.EventHandler(this.btnAddDocumentToAlumno_Click);
			// 
			// pbImageDocument
			// 
			this.pbImageDocument.BackColor = System.Drawing.SystemColors.Control;
			this.pbImageDocument.Location = new System.Drawing.Point(371, 108);
			this.pbImageDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbImageDocument.Name = "pbImageDocument";
			this.pbImageDocument.Size = new System.Drawing.Size(199, 219);
			this.pbImageDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImageDocument.TabIndex = 11;
			this.pbImageDocument.TabStop = false;
			// 
			// gbDatosDocument
			// 
			this.gbDatosDocument.Controls.Add(this.lblDateExpire);
			this.gbDatosDocument.Controls.Add(this.lbVNumeroDocumento);
			this.gbDatosDocument.Controls.Add(this.lbVtipoDocumento);
			this.gbDatosDocument.Controls.Add(this.chboExpira);
			this.gbDatosDocument.Controls.Add(this.txtNumberDocument);
			this.gbDatosDocument.Controls.Add(this.dtpExpiryDate);
			this.gbDatosDocument.Controls.Add(this.cboTypeDocument);
			this.gbDatosDocument.Controls.Add(this.metroLabel3);
			this.gbDatosDocument.Controls.Add(this.metroLabel2);
			this.gbDatosDocument.Controls.Add(this.metroLabel1);
			this.gbDatosDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDatosDocument.Location = new System.Drawing.Point(22, 64);
			this.gbDatosDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gbDatosDocument.Name = "gbDatosDocument";
			this.gbDatosDocument.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gbDatosDocument.Size = new System.Drawing.Size(343, 263);
			this.gbDatosDocument.TabIndex = 10;
			this.gbDatosDocument.TabStop = false;
			this.gbDatosDocument.Text = "Datos";
			// 
			// lblDateExpire
			// 
			this.lblDateExpire.BackColor = System.Drawing.Color.Transparent;
			this.lblDateExpire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateExpire.ForeColor = System.Drawing.Color.Red;
			this.lblDateExpire.Location = new System.Drawing.Point(111, 179);
			this.lblDateExpire.Name = "lblDateExpire";
			this.lblDateExpire.Size = new System.Drawing.Size(13, 16);
			this.lblDateExpire.TabIndex = 25;
			this.lblDateExpire.Text = "*";
			this.ttValidatorMessage.SetToolTip(this.lblDateExpire, "Su ducomento Ha Expirado");
			this.lblDateExpire.Visible = false;
			// 
			// lbVNumeroDocumento
			// 
			this.lbVNumeroDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lbVNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbVNumeroDocumento.ForeColor = System.Drawing.Color.Red;
			this.lbVNumeroDocumento.Location = new System.Drawing.Point(155, 111);
			this.lbVNumeroDocumento.Name = "lbVNumeroDocumento";
			this.lbVNumeroDocumento.Size = new System.Drawing.Size(13, 16);
			this.lbVNumeroDocumento.TabIndex = 24;
			this.lbVNumeroDocumento.Text = "*";
			this.ttValidatorMessage.SetToolTip(this.lbVNumeroDocumento, "Numero de documento es Obligatorio");
			// 
			// lbVtipoDocumento
			// 
			this.lbVtipoDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lbVtipoDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbVtipoDocumento.ForeColor = System.Drawing.Color.Red;
			this.lbVtipoDocumento.Location = new System.Drawing.Point(133, 49);
			this.lbVtipoDocumento.Name = "lbVtipoDocumento";
			this.lbVtipoDocumento.Size = new System.Drawing.Size(13, 16);
			this.lbVtipoDocumento.TabIndex = 23;
			this.lbVtipoDocumento.Text = "*";
			this.ttValidatorMessage.SetToolTip(this.lbVtipoDocumento, "Tipo de Documento Obligatorio");
			// 
			// chboExpira
			// 
			this.chboExpira.AutoSize = true;
			this.chboExpira.Checked = true;
			this.chboExpira.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chboExpira.Location = new System.Drawing.Point(261, 180);
			this.chboExpira.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chboExpira.Name = "chboExpira";
			this.chboExpira.Size = new System.Drawing.Size(76, 15);
			this.chboExpira.TabIndex = 5;
			this.chboExpira.Text = "No Expira.";
			this.chboExpira.UseSelectable = true;
			this.chboExpira.Click += new System.EventHandler(this.chboExpira_CheckedChanged);
			// 
			// txtNumberDocument
			// 
			this.txtNumberDocument.Enabled = false;
			this.txtNumberDocument.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNumberDocument.Lines = new string[0];
			this.txtNumberDocument.Location = new System.Drawing.Point(7, 131);
			this.txtNumberDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNumberDocument.MaxLength = 32767;
			this.txtNumberDocument.Name = "txtNumberDocument";
			this.txtNumberDocument.PasswordChar = '\0';
			this.txtNumberDocument.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNumberDocument.SelectedText = "";
			this.txtNumberDocument.Size = new System.Drawing.Size(330, 29);
			this.txtNumberDocument.TabIndex = 4;
			this.txtNumberDocument.UseSelectable = true;
			this.txtNumberDocument.TextChanged += new System.EventHandler(this.txtNumberDocument_TextChanged);
			this.txtNumberDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumberDocument_KeyDown);
			this.txtNumberDocument.Leave += new System.EventHandler(this.txtNumberDocument_Leave);
			// 
			// dtpExpiryDate
			// 
			this.dtpExpiryDate.CustomFormat = "yyyy-MM-dd";
			this.dtpExpiryDate.Enabled = false;
			this.dtpExpiryDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpExpiryDate.Location = new System.Drawing.Point(7, 198);
			this.dtpExpiryDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpExpiryDate.Name = "dtpExpiryDate";
			this.dtpExpiryDate.Size = new System.Drawing.Size(330, 29);
			this.dtpExpiryDate.TabIndex = 6;
			this.dtpExpiryDate.Leave += new System.EventHandler(this.dtpExpiryDate_Leave);
			// 
			// cboTypeDocument
			// 
			this.cboTypeDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboTypeDocument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboTypeDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTypeDocument.FormattingEnabled = true;
			this.cboTypeDocument.Location = new System.Drawing.Point(7, 69);
			this.cboTypeDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboTypeDocument.Name = "cboTypeDocument";
			this.cboTypeDocument.Size = new System.Drawing.Size(330, 29);
			this.cboTypeDocument.TabIndex = 3;
			this.cboTypeDocument.SelectedIndexChanged += new System.EventHandler(this.cboTypeDocument_SelectedIndexChanged);
			this.cboTypeDocument.SelectionChangeCommitted += new System.EventHandler(this.cboTypeDocument_SelectionChangeCommitted);
			this.cboTypeDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTypeDocument_KeyDown);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(7, 176);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(107, 19);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "Fecha Expiración";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(7, 108);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(152, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Numero de Documento:";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(7, 46);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(129, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Tipo de Documento:";
			// 
			// openImageDocument
			// 
			this.openImageDocument.Filter = "Images | *.jpg; *.png; *.jpeg;";
			// 
			// ttValidatorMessage
			// 
			this.ttValidatorMessage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttValidatorMessage.ToolTipTitle = "Info:";
			// 
			// frmDocumentos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.btnSearchImageDocument);
			this.Controls.Add(this.btnAddDocumentToAlumno);
			this.Controls.Add(this.pbImageDocument);
			this.Controls.Add(this.gbDatosDocument);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDocumentos";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Documentos";
			this.Load += new System.EventHandler(this.frmDocumentos_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbImageDocument)).EndInit();
			this.gbDatosDocument.ResumeLayout(false);
			this.gbDatosDocument.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnSearchImageDocument;
		private MetroFramework.Controls.MetroButton btnAddDocumentToAlumno;
		private System.Windows.Forms.GroupBox gbDatosDocument;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.OpenFileDialog openImageDocument;
		public MetroFramework.Controls.MetroTextBox txtNumberDocument;
		public System.Windows.Forms.DateTimePicker dtpExpiryDate;
		public System.Windows.Forms.ComboBox cboTypeDocument;
		public System.Windows.Forms.PictureBox pbImageDocument;
		public MetroFramework.Controls.MetroCheckBox chboExpira;
		private System.Windows.Forms.Label lbVNumeroDocumento;
		private System.Windows.Forms.Label lbVtipoDocumento;
		private System.Windows.Forms.Label lblDateExpire;
		private System.Windows.Forms.ToolTip ttValidatorMessage;
	}
}