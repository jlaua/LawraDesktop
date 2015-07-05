namespace LawrApp.Layouts.prsMatricula
{
	partial class frmMatricula
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnguardarMatricula = new MetroFramework.Controls.MetroButton();
			this.txtMatriculaTotal = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.txtMatriculaIgv = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.txtMatriculaSubtotal = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.cbotipocolegio = new System.Windows.Forms.ComboBox();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.txtIdalumno = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.txtMatriculaNivel = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtMatriculaTurno = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtMatriculaGradoSeccion = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtMatriculaAlumno = new MetroFramework.Controls.MetroTextBox();
			this.metroPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize ) ( this.metroGrid1 ) ).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add( this.groupBox2 );
			this.metroPanel1.Controls.Add( this.groupBox1 );
			this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point( 27, 92 );
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size( 746, 477 );
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add( this.btnguardarMatricula );
			this.groupBox2.Controls.Add( this.txtMatriculaTotal );
			this.groupBox2.Controls.Add( this.metroLabel7 );
			this.groupBox2.Controls.Add( this.txtMatriculaIgv );
			this.groupBox2.Controls.Add( this.metroLabel6 );
			this.groupBox2.Controls.Add( this.txtMatriculaSubtotal );
			this.groupBox2.Controls.Add( this.metroLabel5 );
			this.groupBox2.Controls.Add( this.metroButton1 );
			this.groupBox2.Controls.Add( this.cbotipocolegio );
			this.groupBox2.Controls.Add( this.metroGrid1 );
			this.groupBox2.Location = new System.Drawing.Point( 34, 172 );
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size( 678, 287 );
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Conceptos de Pagos";
			// 
			// btnguardarMatricula
			// 
			this.btnguardarMatricula.Location = new System.Drawing.Point( 533, 214 );
			this.btnguardarMatricula.Name = "btnguardarMatricula";
			this.btnguardarMatricula.Size = new System.Drawing.Size( 123, 28 );
			this.btnguardarMatricula.TabIndex = 41;
			this.btnguardarMatricula.Text = "Guardar Matricula";
			this.btnguardarMatricula.UseSelectable = true;
			// 
			// txtMatriculaTotal
			// 
			this.txtMatriculaTotal.Lines = new string[0];
			this.txtMatriculaTotal.Location = new System.Drawing.Point( 533, 138 );
			this.txtMatriculaTotal.MaxLength = 32767;
			this.txtMatriculaTotal.Name = "txtMatriculaTotal";
			this.txtMatriculaTotal.PasswordChar = '\0';
			this.txtMatriculaTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaTotal.SelectedText = "";
			this.txtMatriculaTotal.Size = new System.Drawing.Size( 123, 28 );
			this.txtMatriculaTotal.TabIndex = 39;
			this.txtMatriculaTotal.UseSelectable = true;
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point( 495, 138 );
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size( 36, 19 );
			this.metroLabel7.TabIndex = 40;
			this.metroLabel7.Text = "Total";
			// 
			// txtMatriculaIgv
			// 
			this.txtMatriculaIgv.Lines = new string[0];
			this.txtMatriculaIgv.Location = new System.Drawing.Point( 533, 104 );
			this.txtMatriculaIgv.MaxLength = 32767;
			this.txtMatriculaIgv.Name = "txtMatriculaIgv";
			this.txtMatriculaIgv.PasswordChar = '\0';
			this.txtMatriculaIgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaIgv.SelectedText = "";
			this.txtMatriculaIgv.Size = new System.Drawing.Size( 123, 28 );
			this.txtMatriculaIgv.TabIndex = 37;
			this.txtMatriculaIgv.UseSelectable = true;
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point( 501, 104 );
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size( 26, 19 );
			this.metroLabel6.TabIndex = 38;
			this.metroLabel6.Text = "Igv";
			// 
			// txtMatriculaSubtotal
			// 
			this.txtMatriculaSubtotal.Lines = new string[0];
			this.txtMatriculaSubtotal.Location = new System.Drawing.Point( 533, 70 );
			this.txtMatriculaSubtotal.MaxLength = 32767;
			this.txtMatriculaSubtotal.Name = "txtMatriculaSubtotal";
			this.txtMatriculaSubtotal.PasswordChar = '\0';
			this.txtMatriculaSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaSubtotal.SelectedText = "";
			this.txtMatriculaSubtotal.Size = new System.Drawing.Size( 123, 28 );
			this.txtMatriculaSubtotal.TabIndex = 8;
			this.txtMatriculaSubtotal.UseSelectable = true;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point( 474, 70 );
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size( 57, 19 );
			this.metroLabel5.TabIndex = 36;
			this.metroLabel5.Text = "Subtotal";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point( 366, 36 );
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size( 33, 28 );
			this.metroButton1.TabIndex = 35;
			this.metroButton1.Text = "+";
			this.metroButton1.UseSelectable = true;
			// 
			// cbotipocolegio
			// 
			this.cbotipocolegio.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.cbotipocolegio.FormattingEnabled = true;
			this.cbotipocolegio.Items.AddRange( new object[] {
            "Matriculas"} );
			this.cbotipocolegio.Location = new System.Drawing.Point( 108, 36 );
			this.cbotipocolegio.Name = "cbotipocolegio";
			this.cbotipocolegio.Size = new System.Drawing.Size( 252, 28 );
			this.cbotipocolegio.TabIndex = 34;
			this.cbotipocolegio.Text = "Seleccione...";
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToAddRows = false;
			this.metroGrid1.AllowUserToDeleteRows = false;
			this.metroGrid1.AllowUserToResizeRows = false;
			this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 177 ) ) ) ), ( ( int ) ( ( ( byte ) ( 89 ) ) ) ) );
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel );
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 177 ) ) ) ), ( ( int ) ( ( ( byte ) ( 89 ) ) ) ) );
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.metroGrid1.ColumnHeadersHeight = 25;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.metroGrid1.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3} );
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel );
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 136 ) ) ) ), ( ( int ) ( ( ( byte ) ( 136 ) ) ) ), ( ( int ) ( ( ( byte ) ( 136 ) ) ) ) );
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 177 ) ) ) ), ( ( int ) ( ( ( byte ) ( 89 ) ) ) ) );
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
			this.metroGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font( "Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel );
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			this.metroGrid1.Location = new System.Drawing.Point( 26, 70 );
			this.metroGrid1.MultiSelect = false;
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.ReadOnly = true;
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 177 ) ) ) ), ( ( int ) ( ( ( byte ) ( 89 ) ) ) ) );
			dataGridViewCellStyle3.Font = new System.Drawing.Font( "Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel );
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 177 ) ) ) ), ( ( int ) ( ( ( byte ) ( 89 ) ) ) ) );
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ) );
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.metroGrid1.RowHeadersVisible = false;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 64 ) ) ) ), ( ( int ) ( ( ( byte ) ( 64 ) ) ) ), ( ( int ) ( ( ( byte ) ( 64 ) ) ) ) );
			this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size( 442, 113 );
			this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
			this.metroGrid1.TabIndex = 33;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Concepto";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Descuento";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add( this.metroLabel8 );
			this.groupBox1.Controls.Add( this.txtIdalumno );
			this.groupBox1.Controls.Add( this.metroLabel4 );
			this.groupBox1.Controls.Add( this.txtMatriculaNivel );
			this.groupBox1.Controls.Add( this.metroLabel3 );
			this.groupBox1.Controls.Add( this.txtMatriculaTurno );
			this.groupBox1.Controls.Add( this.metroLabel2 );
			this.groupBox1.Controls.Add( this.txtMatriculaGradoSeccion );
			this.groupBox1.Controls.Add( this.metroLabel1 );
			this.groupBox1.Controls.Add( this.txtMatriculaAlumno );
			this.groupBox1.Location = new System.Drawing.Point( 34, 17 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size( 678, 149 );
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informacion especifica";
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point( 236, 23 );
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size( 23, 19 );
			this.metroLabel8.TabIndex = 9;
			this.metroLabel8.Text = "Id:";
			this.metroLabel8.Visible = false;
			// 
			// txtIdalumno
			// 
			this.txtIdalumno.Lines = new string[0];
			this.txtIdalumno.Location = new System.Drawing.Point( 265, 17 );
			this.txtIdalumno.MaxLength = 32767;
			this.txtIdalumno.Name = "txtIdalumno";
			this.txtIdalumno.PasswordChar = '\0';
			this.txtIdalumno.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtIdalumno.SelectedText = "";
			this.txtIdalumno.Size = new System.Drawing.Size( 72, 28 );
			this.txtIdalumno.TabIndex = 8;
			this.txtIdalumno.UseSelectable = true;
			this.txtIdalumno.Visible = false;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point( 28, 76 );
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size( 41, 19 );
			this.metroLabel4.TabIndex = 7;
			this.metroLabel4.Text = "Nivel:";
			// 
			// txtMatriculaNivel
			// 
			this.txtMatriculaNivel.Lines = new string[0];
			this.txtMatriculaNivel.Location = new System.Drawing.Point( 28, 98 );
			this.txtMatriculaNivel.MaxLength = 32767;
			this.txtMatriculaNivel.Name = "txtMatriculaNivel";
			this.txtMatriculaNivel.PasswordChar = '\0';
			this.txtMatriculaNivel.ReadOnly = true;
			this.txtMatriculaNivel.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaNivel.SelectedText = "";
			this.txtMatriculaNivel.Size = new System.Drawing.Size( 309, 28 );
			this.txtMatriculaNivel.TabIndex = 6;
			this.txtMatriculaNivel.UseSelectable = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point( 343, 76 );
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size( 44, 19 );
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Turno:";
			// 
			// txtMatriculaTurno
			// 
			this.txtMatriculaTurno.Lines = new string[0];
			this.txtMatriculaTurno.Location = new System.Drawing.Point( 343, 98 );
			this.txtMatriculaTurno.MaxLength = 32767;
			this.txtMatriculaTurno.Name = "txtMatriculaTurno";
			this.txtMatriculaTurno.PasswordChar = '\0';
			this.txtMatriculaTurno.ReadOnly = true;
			this.txtMatriculaTurno.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaTurno.SelectedText = "";
			this.txtMatriculaTurno.Size = new System.Drawing.Size( 317, 28 );
			this.txtMatriculaTurno.TabIndex = 4;
			this.txtMatriculaTurno.UseSelectable = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point( 343, 26 );
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size( 117, 19 );
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Grado Y Seccion : ";
			// 
			// txtMatriculaGradoSeccion
			// 
			this.txtMatriculaGradoSeccion.Lines = new string[0];
			this.txtMatriculaGradoSeccion.Location = new System.Drawing.Point( 343, 48 );
			this.txtMatriculaGradoSeccion.MaxLength = 32767;
			this.txtMatriculaGradoSeccion.Name = "txtMatriculaGradoSeccion";
			this.txtMatriculaGradoSeccion.PasswordChar = '\0';
			this.txtMatriculaGradoSeccion.ReadOnly = true;
			this.txtMatriculaGradoSeccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaGradoSeccion.SelectedText = "";
			this.txtMatriculaGradoSeccion.Size = new System.Drawing.Size( 317, 28 );
			this.txtMatriculaGradoSeccion.TabIndex = 2;
			this.txtMatriculaGradoSeccion.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point( 28, 26 );
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size( 58, 19 );
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Alumno:";
			// 
			// txtMatriculaAlumno
			// 
			this.txtMatriculaAlumno.Lines = new string[0];
			this.txtMatriculaAlumno.Location = new System.Drawing.Point( 28, 48 );
			this.txtMatriculaAlumno.MaxLength = 32767;
			this.txtMatriculaAlumno.Name = "txtMatriculaAlumno";
			this.txtMatriculaAlumno.PasswordChar = '\0';
			this.txtMatriculaAlumno.ReadOnly = true;
			this.txtMatriculaAlumno.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMatriculaAlumno.SelectedText = "";
			this.txtMatriculaAlumno.Size = new System.Drawing.Size( 309, 28 );
			this.txtMatriculaAlumno.TabIndex = 0;
			this.txtMatriculaAlumno.UseSelectable = true;
			// 
			// frmMatricula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 20F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 800, 600 );
			this.Controls.Add( this.metroPanel1 );
			this.Font = new System.Drawing.Font( "Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			this.Name = "frmMatricula";
			this.Padding = new System.Windows.Forms.Padding( 27, 92, 27, 31 );
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Boleta de Pagos";
			this.metroPanel1.ResumeLayout( false );
			this.groupBox2.ResumeLayout( false );
			this.groupBox2.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize ) ( this.metroGrid1 ) ).EndInit();
			this.groupBox1.ResumeLayout( false );
			this.groupBox1.PerformLayout();
			this.ResumeLayout( false );

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox txtMatriculaNivel;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txtMatriculaTurno;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtMatriculaGradoSeccion;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtMatriculaAlumno;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn3;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.ComboBox cbotipocolegio;
		private MetroFramework.Controls.MetroTextBox txtMatriculaTotal;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroTextBox txtMatriculaIgv;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroTextBox txtMatriculaSubtotal;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroTextBox txtIdalumno;
		private MetroFramework.Controls.MetroButton btnguardarMatricula;
	}
}