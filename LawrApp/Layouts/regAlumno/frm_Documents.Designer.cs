namespace LawrApp.Layouts.regAlumno
{
	partial class frm_Documents
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabcontrolDocumentos = new MetroFramework.Controls.MetroTabControl();
			this.tabListaDocument = new MetroFramework.Controls.MetroTabPage();
			this.pbuscarDocumentos = new MetroFramework.Controls.MetroPanel();
			this.btnNuevo = new MetroFramework.Controls.MetroTile();
			this.btncancelar = new MetroFramework.Controls.MetroButton();
			this.dgListDocumentos = new MetroFramework.Controls.MetroGrid();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExpiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.tabregistrardocumentos = new MetroFramework.Controls.MetroTabPage();
			this.PregistroDocumento = new MetroFramework.Controls.MetroPanel();
			this.gbDatosDocument = new System.Windows.Forms.GroupBox();
			this.lvDocuementolDateExpire = new System.Windows.Forms.Label();
			this.lvDocumentoNumeroDocumento = new System.Windows.Forms.Label();
			this.lvDocuementoTipoDocumento = new System.Windows.Forms.Label();
			this.chboExpira = new MetroFramework.Controls.MetroCheckBox();
			this.txtNrodocumento = new MetroFramework.Controls.MetroTextBox();
			this.dtFechaExpiracion = new System.Windows.Forms.DateTimePicker();
			this.cbotipoDocument = new System.Windows.Forms.ComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.lbrutaimagen = new MetroFramework.Controls.MetroLabel();
			this.Cancelar = new MetroFramework.Controls.MetroButton();
			this.btnagregardocumentos = new MetroFramework.Controls.MetroButton();
			this.btnSearchImage = new MetroFramework.Controls.MetroButton();
			this.pbImageDocument = new System.Windows.Forms.PictureBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtNameSelectedStudent = new MetroFramework.Controls.MetroTextBox();
			this.btnbuscaralumno = new MetroFramework.Controls.MetroButton();
			this.openImageDocument = new System.Windows.Forms.OpenFileDialog();
			this.ttValidatorMessage = new System.Windows.Forms.ToolTip(this.components);
			this.pgshowDocumentos = new MetroFramework.Controls.MetroProgressSpinner();
			this.panel1.SuspendLayout();
			this.tabcontrolDocumentos.SuspendLayout();
			this.tabListaDocument.SuspendLayout();
			this.pbuscarDocumentos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgListDocumentos)).BeginInit();
			this.tabregistrardocumentos.SuspendLayout();
			this.PregistroDocumento.SuspendLayout();
			this.gbDatosDocument.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImageDocument)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabcontrolDocumentos);
			this.panel1.Controls.Add(this.metroLabel5);
			this.panel1.Controls.Add(this.txtNameSelectedStudent);
			this.panel1.Controls.Add(this.btnbuscaralumno);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(740, 471);
			this.panel1.TabIndex = 0;
			// 
			// tabcontrolDocumentos
			// 
			this.tabcontrolDocumentos.Controls.Add(this.tabListaDocument);
			this.tabcontrolDocumentos.Controls.Add(this.tabregistrardocumentos);
			this.tabcontrolDocumentos.Enabled = false;
			this.tabcontrolDocumentos.Location = new System.Drawing.Point(3, 39);
			this.tabcontrolDocumentos.Name = "tabcontrolDocumentos";
			this.tabcontrolDocumentos.SelectedIndex = 1;
			this.tabcontrolDocumentos.Size = new System.Drawing.Size(734, 429);
			this.tabcontrolDocumentos.Style = MetroFramework.MetroColorStyle.Green;
			this.tabcontrolDocumentos.TabIndex = 32;
			this.tabcontrolDocumentos.UseSelectable = true;
			// 
			// tabListaDocument
			// 
			this.tabListaDocument.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabListaDocument.Controls.Add(this.pbuscarDocumentos);
			this.tabListaDocument.HorizontalScrollbarBarColor = true;
			this.tabListaDocument.HorizontalScrollbarHighlightOnWheel = false;
			this.tabListaDocument.HorizontalScrollbarSize = 1;
			this.tabListaDocument.Location = new System.Drawing.Point(4, 38);
			this.tabListaDocument.Name = "tabListaDocument";
			this.tabListaDocument.Size = new System.Drawing.Size(726, 387);
			this.tabListaDocument.TabIndex = 0;
			this.tabListaDocument.Text = "Listar Documentos";
			this.tabListaDocument.VerticalScrollbarBarColor = true;
			this.tabListaDocument.VerticalScrollbarHighlightOnWheel = false;
			this.tabListaDocument.VerticalScrollbarSize = 1;
			// 
			// pbuscarDocumentos
			// 
			this.pbuscarDocumentos.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbuscarDocumentos.Controls.Add(this.btnNuevo);
			this.pbuscarDocumentos.Controls.Add(this.btncancelar);
			this.pbuscarDocumentos.Controls.Add(this.dgListDocumentos);
			this.pbuscarDocumentos.Controls.Add(this.btnEliminar);
			this.pbuscarDocumentos.Controls.Add(this.btnModificar);
			this.pbuscarDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbuscarDocumentos.HorizontalScrollbarBarColor = true;
			this.pbuscarDocumentos.HorizontalScrollbarHighlightOnWheel = false;
			this.pbuscarDocumentos.HorizontalScrollbarSize = 1;
			this.pbuscarDocumentos.Location = new System.Drawing.Point(0, 0);
			this.pbuscarDocumentos.Name = "pbuscarDocumentos";
			this.pbuscarDocumentos.Size = new System.Drawing.Size(726, 387);
			this.pbuscarDocumentos.TabIndex = 37;
			this.pbuscarDocumentos.VerticalScrollbarBarColor = true;
			this.pbuscarDocumentos.VerticalScrollbarHighlightOnWheel = false;
			this.pbuscarDocumentos.VerticalScrollbarSize = 1;
			// 
			// btnNuevo
			// 
			this.btnNuevo.ActiveControl = null;
			this.btnNuevo.Enabled = false;
			this.btnNuevo.Location = new System.Drawing.Point(678, 3);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(42, 29);
			this.btnNuevo.Style = MetroFramework.MetroColorStyle.Green;
			this.btnNuevo.TabIndex = 154;
			this.btnNuevo.Text = "+";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNuevo.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnNuevo.UseSelectable = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(501, 336);
			this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(69, 34);
			this.btncancelar.TabIndex = 154;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseSelectable = true;
			this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
			// 
			// dgListDocumentos
			// 
			this.dgListDocumentos.AllowUserToAddRows = false;
			this.dgListDocumentos.AllowUserToDeleteRows = false;
			this.dgListDocumentos.AllowUserToResizeRows = false;
			this.dgListDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgListDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgListDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgListDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgListDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgListDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgListDocumentos.ColumnHeadersHeight = 33;
			this.dgListDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgListDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDocumento,
            this.colNumero,
            this.colExpiration,
            this.colModifiedDate});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgListDocumentos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgListDocumentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgListDocumentos.EnableHeadersVisualStyles = false;
			this.dgListDocumentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgListDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgListDocumentos.Location = new System.Drawing.Point(3, 38);
			this.dgListDocumentos.MultiSelect = false;
			this.dgListDocumentos.Name = "dgListDocumentos";
			this.dgListDocumentos.ReadOnly = true;
			this.dgListDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgListDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgListDocumentos.RowHeadersVisible = false;
			this.dgListDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgListDocumentos.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgListDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListDocumentos.Size = new System.Drawing.Size(717, 291);
			this.dgListDocumentos.Style = MetroFramework.MetroColorStyle.Green;
			this.dgListDocumentos.TabIndex = 35;
			this.dgListDocumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsearchDocumentos_CellDoubleClick);
			this.dgListDocumentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgsearchDocumentos_KeyDown);
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colDocumento
			// 
			this.colDocumento.HeaderText = "Documento";
			this.colDocumento.Name = "colDocumento";
			this.colDocumento.ReadOnly = true;
			// 
			// colNumero
			// 
			this.colNumero.HeaderText = "Numero";
			this.colNumero.Name = "colNumero";
			this.colNumero.ReadOnly = true;
			// 
			// colExpiration
			// 
			this.colExpiration.HeaderText = "F. Expiración";
			this.colExpiration.Name = "colExpiration";
			this.colExpiration.ReadOnly = true;
			// 
			// colModifiedDate
			// 
			this.colModifiedDate.HeaderText = "Ultima Modificación";
			this.colModifiedDate.Name = "colModifiedDate";
			this.colModifiedDate.ReadOnly = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(576, 336);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(69, 34);
			this.btnEliminar.TabIndex = 36;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(651, 336);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(69, 34);
			this.btnModificar.TabIndex = 35;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// tabregistrardocumentos
			// 
			this.tabregistrardocumentos.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabregistrardocumentos.Controls.Add(this.PregistroDocumento);
			this.tabregistrardocumentos.HorizontalScrollbarBarColor = true;
			this.tabregistrardocumentos.HorizontalScrollbarHighlightOnWheel = false;
			this.tabregistrardocumentos.HorizontalScrollbarSize = 1;
			this.tabregistrardocumentos.Location = new System.Drawing.Point(4, 38);
			this.tabregistrardocumentos.Name = "tabregistrardocumentos";
			this.tabregistrardocumentos.Size = new System.Drawing.Size(726, 387);
			this.tabregistrardocumentos.TabIndex = 1;
			this.tabregistrardocumentos.Text = "Registrar Documentos";
			this.tabregistrardocumentos.VerticalScrollbarBarColor = true;
			this.tabregistrardocumentos.VerticalScrollbarHighlightOnWheel = false;
			this.tabregistrardocumentos.VerticalScrollbarSize = 1;
			// 
			// PregistroDocumento
			// 
			this.PregistroDocumento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PregistroDocumento.Controls.Add(this.gbDatosDocument);
			this.PregistroDocumento.Controls.Add(this.lbrutaimagen);
			this.PregistroDocumento.Controls.Add(this.Cancelar);
			this.PregistroDocumento.Controls.Add(this.btnagregardocumentos);
			this.PregistroDocumento.Controls.Add(this.btnSearchImage);
			this.PregistroDocumento.Controls.Add(this.pbImageDocument);
			this.PregistroDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PregistroDocumento.HorizontalScrollbarBarColor = true;
			this.PregistroDocumento.HorizontalScrollbarHighlightOnWheel = false;
			this.PregistroDocumento.HorizontalScrollbarSize = 1;
			this.PregistroDocumento.Location = new System.Drawing.Point(0, 0);
			this.PregistroDocumento.Name = "PregistroDocumento";
			this.PregistroDocumento.Size = new System.Drawing.Size(726, 387);
			this.PregistroDocumento.TabIndex = 2;
			this.PregistroDocumento.VerticalScrollbarBarColor = true;
			this.PregistroDocumento.VerticalScrollbarHighlightOnWheel = false;
			this.PregistroDocumento.VerticalScrollbarSize = 1;
			// 
			// gbDatosDocument
			// 
			this.gbDatosDocument.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.gbDatosDocument.Controls.Add(this.lvDocuementolDateExpire);
			this.gbDatosDocument.Controls.Add(this.lvDocumentoNumeroDocumento);
			this.gbDatosDocument.Controls.Add(this.lvDocuementoTipoDocumento);
			this.gbDatosDocument.Controls.Add(this.chboExpira);
			this.gbDatosDocument.Controls.Add(this.txtNrodocumento);
			this.gbDatosDocument.Controls.Add(this.dtFechaExpiracion);
			this.gbDatosDocument.Controls.Add(this.cbotipoDocument);
			this.gbDatosDocument.Controls.Add(this.metroLabel3);
			this.gbDatosDocument.Controls.Add(this.metroLabel2);
			this.gbDatosDocument.Controls.Add(this.metroLabel1);
			this.gbDatosDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDatosDocument.Location = new System.Drawing.Point(57, 38);
			this.gbDatosDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gbDatosDocument.Name = "gbDatosDocument";
			this.gbDatosDocument.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gbDatosDocument.Size = new System.Drawing.Size(384, 224);
			this.gbDatosDocument.TabIndex = 30;
			this.gbDatosDocument.TabStop = false;
			this.gbDatosDocument.Text = "Datos";
			// 
			// lvDocuementolDateExpire
			// 
			this.lvDocuementolDateExpire.BackColor = System.Drawing.Color.Transparent;
			this.lvDocuementolDateExpire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvDocuementolDateExpire.ForeColor = System.Drawing.Color.Red;
			this.lvDocuementolDateExpire.Location = new System.Drawing.Point(132, 153);
			this.lvDocuementolDateExpire.Name = "lvDocuementolDateExpire";
			this.lvDocuementolDateExpire.Size = new System.Drawing.Size(13, 16);
			this.lvDocuementolDateExpire.TabIndex = 25;
			this.lvDocuementolDateExpire.Text = "*";
			this.lvDocuementolDateExpire.Visible = false;
			// 
			// lvDocumentoNumeroDocumento
			// 
			this.lvDocumentoNumeroDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lvDocumentoNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvDocumentoNumeroDocumento.ForeColor = System.Drawing.Color.Red;
			this.lvDocumentoNumeroDocumento.Location = new System.Drawing.Point(177, 86);
			this.lvDocumentoNumeroDocumento.Name = "lvDocumentoNumeroDocumento";
			this.lvDocumentoNumeroDocumento.Size = new System.Drawing.Size(13, 16);
			this.lvDocumentoNumeroDocumento.TabIndex = 24;
			this.lvDocumentoNumeroDocumento.Text = "*";
			// 
			// lvDocuementoTipoDocumento
			// 
			this.lvDocuementoTipoDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lvDocuementoTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvDocuementoTipoDocumento.ForeColor = System.Drawing.Color.Red;
			this.lvDocuementoTipoDocumento.Location = new System.Drawing.Point(163, 25);
			this.lvDocuementoTipoDocumento.Name = "lvDocuementoTipoDocumento";
			this.lvDocuementoTipoDocumento.Size = new System.Drawing.Size(13, 16);
			this.lvDocuementoTipoDocumento.TabIndex = 23;
			this.lvDocuementoTipoDocumento.Text = "*";
			// 
			// chboExpira
			// 
			this.chboExpira.AutoSize = true;
			this.chboExpira.Checked = true;
			this.chboExpira.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chboExpira.Location = new System.Drawing.Point(280, 150);
			this.chboExpira.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chboExpira.Name = "chboExpira";
			this.chboExpira.Size = new System.Drawing.Size(76, 15);
			this.chboExpira.TabIndex = 5;
			this.chboExpira.Text = "No Expira.";
			this.chboExpira.UseSelectable = true;
			this.chboExpira.CheckedChanged += new System.EventHandler(this.chboExpira_CheckedChanged);
			// 
			// txtNrodocumento
			// 
			this.txtNrodocumento.Enabled = false;
			this.txtNrodocumento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNrodocumento.Lines = new string[0];
			this.txtNrodocumento.Location = new System.Drawing.Point(28, 106);
			this.txtNrodocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNrodocumento.MaxLength = 250;
			this.txtNrodocumento.Name = "txtNrodocumento";
			this.txtNrodocumento.PasswordChar = '\0';
			this.txtNrodocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNrodocumento.SelectedText = "";
			this.txtNrodocumento.Size = new System.Drawing.Size(330, 29);
			this.txtNrodocumento.TabIndex = 4;
			this.txtNrodocumento.UseSelectable = true;
			this.txtNrodocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumentoNrodocumento_KeyDown);
			this.txtNrodocumento.Leave += new System.EventHandler(this.txtDocumentoNrodocumento_Leave);
			// 
			// dtFechaExpiracion
			// 
			this.dtFechaExpiracion.CustomFormat = "yyyy-MM-dd";
			this.dtFechaExpiracion.Enabled = false;
			this.dtFechaExpiracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFechaExpiracion.Location = new System.Drawing.Point(28, 172);
			this.dtFechaExpiracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtFechaExpiracion.Name = "dtFechaExpiracion";
			this.dtFechaExpiracion.Size = new System.Drawing.Size(330, 29);
			this.dtFechaExpiracion.TabIndex = 6;
			// 
			// cbotipoDocument
			// 
			this.cbotipoDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cbotipoDocument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbotipoDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbotipoDocument.FormattingEnabled = true;
			this.cbotipoDocument.Location = new System.Drawing.Point(28, 45);
			this.cbotipoDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbotipoDocument.MaxLength = 250;
			this.cbotipoDocument.Name = "cbotipoDocument";
			this.cbotipoDocument.Size = new System.Drawing.Size(330, 29);
			this.cbotipoDocument.TabIndex = 3;
			this.cbotipoDocument.SelectionChangeCommitted += new System.EventHandler(this.cboDocumentotipoDocument_SelectionChangeCommitted);
			this.cbotipoDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDocumentotipoDocument_KeyDown);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(28, 150);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(107, 19);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "Fecha Expiración";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(28, 83);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(152, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Numero de Documento:";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(28, 22);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(129, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Tipo de Documento:";
			// 
			// lbrutaimagen
			// 
			this.lbrutaimagen.Location = new System.Drawing.Point(521, 266);
			this.lbrutaimagen.Name = "lbrutaimagen";
			this.lbrutaimagen.Size = new System.Drawing.Size(158, 22);
			this.lbrutaimagen.TabIndex = 158;
			// 
			// Cancelar
			// 
			this.Cancelar.Location = new System.Drawing.Point(491, 331);
			this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(87, 35);
			this.Cancelar.TabIndex = 157;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.UseSelectable = true;
			this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
			// 
			// btnagregardocumentos
			// 
			this.btnagregardocumentos.Location = new System.Drawing.Point(584, 331);
			this.btnagregardocumentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnagregardocumentos.Name = "btnagregardocumentos";
			this.btnagregardocumentos.Size = new System.Drawing.Size(95, 35);
			this.btnagregardocumentos.TabIndex = 34;
			this.btnagregardocumentos.Text = "Agregar";
			this.btnagregardocumentos.UseSelectable = true;
			this.btnagregardocumentos.Click += new System.EventHandler(this.btnagregardocumentos_Click);
			// 
			// btnSearchImage
			// 
			this.btnSearchImage.Enabled = false;
			this.btnSearchImage.Location = new System.Drawing.Point(521, 38);
			this.btnSearchImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSearchImage.Name = "btnSearchImage";
			this.btnSearchImage.Size = new System.Drawing.Size(158, 30);
			this.btnSearchImage.TabIndex = 32;
			this.btnSearchImage.Text = "Imagen";
			this.btnSearchImage.UseSelectable = true;
			this.btnSearchImage.Click += new System.EventHandler(this.btnDocuementoSearchImageDocument_Click);
			// 
			// pbImageDocument
			// 
			this.pbImageDocument.BackColor = System.Drawing.SystemColors.Control;
			this.pbImageDocument.Enabled = false;
			this.pbImageDocument.Location = new System.Drawing.Point(521, 76);
			this.pbImageDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbImageDocument.Name = "pbImageDocument";
			this.pbImageDocument.Size = new System.Drawing.Size(158, 186);
			this.pbImageDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImageDocument.TabIndex = 31;
			this.pbImageDocument.TabStop = false;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(3, 8);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(58, 19);
			this.metroLabel5.TabIndex = 34;
			this.metroLabel5.Text = "Alumno:";
			// 
			// txtNameSelectedStudent
			// 
			this.txtNameSelectedStudent.Enabled = false;
			this.txtNameSelectedStudent.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNameSelectedStudent.Lines = new string[0];
			this.txtNameSelectedStudent.Location = new System.Drawing.Point(67, 4);
			this.txtNameSelectedStudent.MaxLength = 250;
			this.txtNameSelectedStudent.Name = "txtNameSelectedStudent";
			this.txtNameSelectedStudent.PasswordChar = '\0';
			this.txtNameSelectedStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNameSelectedStudent.SelectedText = "";
			this.txtNameSelectedStudent.Size = new System.Drawing.Size(634, 28);
			this.txtNameSelectedStudent.TabIndex = 33;
			this.txtNameSelectedStudent.UseSelectable = true;
			// 
			// btnbuscaralumno
			// 
			this.btnbuscaralumno.Location = new System.Drawing.Point(707, 4);
			this.btnbuscaralumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnbuscaralumno.Name = "btnbuscaralumno";
			this.btnbuscaralumno.Size = new System.Drawing.Size(30, 28);
			this.btnbuscaralumno.TabIndex = 35;
			this.btnbuscaralumno.Text = "....";
			this.btnbuscaralumno.UseSelectable = true;
			this.btnbuscaralumno.Click += new System.EventHandler(this.btnbuscaralumno_Click);
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
			// pgshowDocumentos
			// 
			this.pgshowDocumentos.Location = new System.Drawing.Point(30, 574);
			this.pgshowDocumentos.Maximum = 100;
			this.pgshowDocumentos.Name = "pgshowDocumentos";
			this.pgshowDocumentos.Size = new System.Drawing.Size(17, 19);
			this.pgshowDocumentos.Speed = 2F;
			this.pgshowDocumentos.Style = MetroFramework.MetroColorStyle.Green;
			this.pgshowDocumentos.TabIndex = 161;
			this.pgshowDocumentos.UseSelectable = true;
			this.pgshowDocumentos.Value = 50;
			this.pgshowDocumentos.Visible = false;
			// 
			// frm_Documents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pgshowDocumentos);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Documents";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Registro de Documentos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmregDocumento_FormClosing);
			this.Load += new System.EventHandler(this.frmregDocumento_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabcontrolDocumentos.ResumeLayout(false);
			this.tabListaDocument.ResumeLayout(false);
			this.pbuscarDocumentos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgListDocumentos)).EndInit();
			this.tabregistrardocumentos.ResumeLayout(false);
			this.PregistroDocumento.ResumeLayout(false);
			this.gbDatosDocument.ResumeLayout(false);
			this.gbDatosDocument.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImageDocument)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroTabControl tabcontrolDocumentos;
		private MetroFramework.Controls.MetroTabPage tabListaDocument;
		private MetroFramework.Controls.MetroPanel pbuscarDocumentos;
		private MetroFramework.Controls.MetroGrid dgListDocumentos;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroTabPage tabregistrardocumentos;
		private MetroFramework.Controls.MetroPanel PregistroDocumento;
		private MetroFramework.Controls.MetroButton btnSearchImage;
		public System.Windows.Forms.PictureBox pbImageDocument;
		private System.Windows.Forms.GroupBox gbDatosDocument;
		private System.Windows.Forms.Label lvDocuementolDateExpire;
		private System.Windows.Forms.Label lvDocumentoNumeroDocumento;
		private System.Windows.Forms.Label lvDocuementoTipoDocumento;
		public MetroFramework.Controls.MetroCheckBox chboExpira;
		public MetroFramework.Controls.MetroTextBox txtNrodocumento;
		public System.Windows.Forms.DateTimePicker dtFechaExpiracion;
		public System.Windows.Forms.ComboBox cbotipoDocument;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox txtNameSelectedStudent;
		private MetroFramework.Controls.MetroButton btnbuscaralumno;
		private MetroFramework.Controls.MetroTile btnNuevo;
		private System.Windows.Forms.OpenFileDialog openImageDocument;
		private System.Windows.Forms.ToolTip ttValidatorMessage;
		private MetroFramework.Controls.MetroButton btnagregardocumentos;
		private MetroFramework.Controls.MetroButton Cancelar;
		private MetroFramework.Controls.MetroButton btncancelar;
		private MetroFramework.Controls.MetroLabel lbrutaimagen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExpiration;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
		private MetroFramework.Controls.MetroProgressSpinner pgshowDocumentos;

	}
}