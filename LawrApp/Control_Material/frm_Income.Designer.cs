namespace LawrApp.Control_Material
{
	partial class frm_Income
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
			this.cboTipoIngreso = new MetroFramework.Controls.MetroComboBox();
			this.lblValidateCosto = new System.Windows.Forms.Label();
			this.lblValidateN_Documento = new System.Windows.Forms.Label();
			this.lblValidateCantidad = new System.Windows.Forms.Label();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.dtpFecha_Compra = new System.Windows.Forms.DateTimePicker();
			this.lblValidateTipoIngreso = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.btnsalir = new MetroFramework.Controls.MetroButton();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.txtNDocumento = new System.Windows.Forms.TextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.toltipValid = new System.Windows.Forms.ToolTip(this.components);
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.nudCantidad);
			this.panelMain.Controls.Add(this.cboTipoIngreso);
			this.panelMain.Controls.Add(this.lblValidateCosto);
			this.panelMain.Controls.Add(this.lblValidateN_Documento);
			this.panelMain.Controls.Add(this.lblValidateCantidad);
			this.panelMain.Controls.Add(this.metroLabel9);
			this.panelMain.Controls.Add(this.dtpFecha_Compra);
			this.panelMain.Controls.Add(this.lblValidateTipoIngreso);
			this.panelMain.Controls.Add(this.txtMarca);
			this.panelMain.Controls.Add(this.btnsalir);
			this.panelMain.Controls.Add(this.btnGuardar);
			this.panelMain.Controls.Add(this.metroLabel8);
			this.panelMain.Controls.Add(this.txtNDocumento);
			this.panelMain.Controls.Add(this.metroLabel7);
			this.panelMain.Controls.Add(this.txtCosto);
			this.panelMain.Controls.Add(this.metroLabel6);
			this.panelMain.Controls.Add(this.metroLabel5);
			this.panelMain.Controls.Add(this.txtModelo);
			this.panelMain.Controls.Add(this.metroLabel4);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.txtCategoria);
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.btnbuscar);
			this.panelMain.Controls.Add(this.txtDescripcion);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Enabled = false;
			this.panelMain.Location = new System.Drawing.Point(20, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(610, 298);
			this.panelMain.TabIndex = 0;
			// 
			// cboTipoIngreso
			// 
			this.cboTipoIngreso.DisplayFocus = true;
			this.cboTipoIngreso.ItemHeight = 23;
			this.cboTipoIngreso.Items.AddRange(new object[] {
            "Donación",
            "Compras"});
			this.cboTipoIngreso.Location = new System.Drawing.Point(14, 172);
			this.cboTipoIngreso.Name = "cboTipoIngreso";
			this.cboTipoIngreso.PromptText = "Seleccione...";
			this.cboTipoIngreso.Size = new System.Drawing.Size(195, 29);
			this.cboTipoIngreso.Style = MetroFramework.MetroColorStyle.Blue;
			this.cboTipoIngreso.TabIndex = 2;
			this.cboTipoIngreso.UseCustomBackColor = true;
			this.cboTipoIngreso.UseSelectable = true;
			this.cboTipoIngreso.UseStyleColors = true;
			this.cboTipoIngreso.SelectionChangeCommitted += new System.EventHandler(this.cboTipoIngreso_SelectionChangeCommitted);
			// 
			// lblValidateCosto
			// 
			this.lblValidateCosto.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateCosto.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCosto.Location = new System.Drawing.Point(463, 153);
			this.lblValidateCosto.Name = "lblValidateCosto";
			this.lblValidateCosto.Size = new System.Drawing.Size(15, 16);
			this.lblValidateCosto.TabIndex = 62;
			this.lblValidateCosto.Text = "*";
			this.lblValidateCosto.Visible = false;
			// 
			// lblValidateN_Documento
			// 
			this.lblValidateN_Documento.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateN_Documento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateN_Documento.ForeColor = System.Drawing.Color.Red;
			this.lblValidateN_Documento.Location = new System.Drawing.Point(225, 220);
			this.lblValidateN_Documento.Name = "lblValidateN_Documento";
			this.lblValidateN_Documento.Size = new System.Drawing.Size(15, 16);
			this.lblValidateN_Documento.TabIndex = 61;
			this.lblValidateN_Documento.Text = "*";
			this.lblValidateN_Documento.Visible = false;
			// 
			// lblValidateCantidad
			// 
			this.lblValidateCantidad.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateCantidad.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCantidad.Location = new System.Drawing.Point(73, 221);
			this.lblValidateCantidad.Name = "lblValidateCantidad";
			this.lblValidateCantidad.Size = new System.Drawing.Size(14, 16);
			this.lblValidateCantidad.TabIndex = 59;
			this.lblValidateCantidad.Text = "*";
			this.lblValidateCantidad.Visible = false;
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(215, 150);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(115, 19);
			this.metroLabel9.TabIndex = 58;
			this.metroLabel9.Text = "Fecha de Compra";
			// 
			// dtpFecha_Compra
			// 
			this.dtpFecha_Compra.CustomFormat = "yyyy-MM-dd";
			this.dtpFecha_Compra.Enabled = false;
			this.dtpFecha_Compra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha_Compra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFecha_Compra.Location = new System.Drawing.Point(215, 172);
			this.dtpFecha_Compra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpFecha_Compra.Name = "dtpFecha_Compra";
			this.dtpFecha_Compra.Size = new System.Drawing.Size(202, 29);
			this.dtpFecha_Compra.TabIndex = 3;
			// 
			// lblValidateTipoIngreso
			// 
			this.lblValidateTipoIngreso.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateTipoIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateTipoIngreso.ForeColor = System.Drawing.Color.Red;
			this.lblValidateTipoIngreso.Location = new System.Drawing.Point(92, 151);
			this.lblValidateTipoIngreso.Name = "lblValidateTipoIngreso";
			this.lblValidateTipoIngreso.Size = new System.Drawing.Size(14, 16);
			this.lblValidateTipoIngreso.TabIndex = 56;
			this.lblValidateTipoIngreso.Text = "*";
			// 
			// txtMarca
			// 
			this.txtMarca.Enabled = false;
			this.txtMarca.Location = new System.Drawing.Point(215, 106);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(202, 29);
			this.txtMarca.TabIndex = 0;
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(534, 241);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(64, 29);
			this.btnsalir.TabIndex = 8;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseSelectable = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.AllowDrop = true;
			this.btnGuardar.Location = new System.Drawing.Point(423, 241);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(105, 29);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(14, 219);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(62, 19);
			this.metroLabel8.TabIndex = 26;
			this.metroLabel8.Text = "Cantidad";
			// 
			// txtNDocumento
			// 
			this.txtNDocumento.Enabled = false;
			this.txtNDocumento.Location = new System.Drawing.Point(132, 241);
			this.txtNDocumento.Name = "txtNDocumento";
			this.txtNDocumento.Size = new System.Drawing.Size(285, 29);
			this.txtNDocumento.TabIndex = 6;
			this.txtNDocumento.Leave += new System.EventHandler(this.txtNDocumento_Leave);
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(132, 219);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(97, 19);
			this.metroLabel7.TabIndex = 24;
			this.metroLabel7.Text = "Nº Documento";
			// 
			// txtCosto
			// 
			this.txtCosto.Enabled = false;
			this.txtCosto.Location = new System.Drawing.Point(423, 172);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(175, 29);
			this.txtCosto.TabIndex = 4;
			this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
			this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(423, 150);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(43, 19);
			this.metroLabel6.TabIndex = 22;
			this.metroLabel6.Text = "Costo";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(14, 150);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(82, 19);
			this.metroLabel5.TabIndex = 20;
			this.metroLabel5.Text = "Tipo Ingreso";
			// 
			// txtModelo
			// 
			this.txtModelo.Enabled = false;
			this.txtModelo.Location = new System.Drawing.Point(423, 106);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(175, 29);
			this.txtModelo.TabIndex = 0;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(423, 84);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(55, 19);
			this.metroLabel4.TabIndex = 7;
			this.metroLabel4.Text = "Modelo";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(215, 84);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(46, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Marca";
			// 
			// txtCategoria
			// 
			this.txtCategoria.Enabled = false;
			this.txtCategoria.Location = new System.Drawing.Point(14, 106);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(195, 29);
			this.txtCategoria.TabIndex = 0;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(14, 84);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(67, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Categoria";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(523, 42);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(75, 29);
			this.btnbuscar.TabIndex = 1;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseSelectable = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Location = new System.Drawing.Point(14, 42);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(494, 29);
			this.txtDescripcion.TabIndex = 0;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(14, 20);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Material";
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(614, 374);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.TabIndex = 2;
			this.pgsLoading.TabStop = false;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// toltipValid
			// 
			this.toltipValid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipValid.ToolTipTitle = "Requerido";
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(14, 240);
			this.nudCantidad.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(112, 29);
			this.nudCantidad.TabIndex = 5;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.Leave += new System.EventHandler(this.nudCantidad_Leave);
			// 
			// frm_Income
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(650, 400);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Income";
			this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ingresos de Materiales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Income_FormClosing);
			this.Load += new System.EventHandler(this.frm_Income_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label lblValidateCosto;
		private System.Windows.Forms.Label lblValidateN_Documento;
		private System.Windows.Forms.Label lblValidateCantidad;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		public System.Windows.Forms.DateTimePicker dtpFecha_Compra;
		private System.Windows.Forms.Label lblValidateTipoIngreso;
		private System.Windows.Forms.TextBox txtMarca;
		private MetroFramework.Controls.MetroButton btnsalir;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private System.Windows.Forms.TextBox txtNDocumento;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private System.Windows.Forms.TextBox txtCosto;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.TextBox txtModelo;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox txtCategoria;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroComboBox cboTipoIngreso;
		private System.Windows.Forms.ToolTip toltipValid;
		private System.Windows.Forms.NumericUpDown nudCantidad;
	}
}