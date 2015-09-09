namespace LawrApp.Institucion
{
	partial class frm_Lounge
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnNuevo = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new MetroFramework.Controls.MetroGrid();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbGestion = new System.Windows.Forms.GroupBox();
			this.lblCapacidad_Validator = new MetroFramework.Controls.MetroLabel();
			this.lblNombre_Validator = new MetroFramework.Controls.MetroLabel();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.btnDone = new MetroFramework.Controls.MetroButton();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.gbGestion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnEliminar);
			this.panelMain.Controls.Add(this.btnNuevo);
			this.panelMain.Controls.Add(this.btnModificar);
			this.panelMain.Controls.Add(this.dgvListado);
			this.panelMain.Controls.Add(this.gbGestion);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 65);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(540, 403);
			this.panelMain.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 371);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(52, 29);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(311, 371);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(68, 29);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(474, 371);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(63, 29);
			this.btnNuevo.TabIndex = 2;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseSelectable = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(385, 371);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(68, 29);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AllowUserToResizeRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCapacity,
            this.colModifiedDate});
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListado.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvListado.EnableHeadersVisualStyles = false;
			this.dgvListado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListado.Location = new System.Drawing.Point(3, 147);
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle20;
			this.dgvListado.RowTemplate.Height = 31;
			this.dgvListado.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.Size = new System.Drawing.Size(534, 212);
			this.dgvListado.StandardTab = true;
			this.dgvListado.Style = MetroFramework.MetroColorStyle.Green;
			this.dgvListado.TabIndex = 1;
			this.dgvListado.UseCustomBackColor = true;
			this.dgvListado.UseCustomForeColor = true;
			this.dgvListado.UseStyleColors = true;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
			// 
			// colCodigo
			// 
			this.colCodigo.FillWeight = 60F;
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colNombre
			// 
			this.colNombre.HeaderText = "Nombre";
			this.colNombre.Name = "colNombre";
			this.colNombre.ReadOnly = true;
			// 
			// colCapacity
			// 
			this.colCapacity.FillWeight = 60F;
			this.colCapacity.HeaderText = "Cap. Maxima";
			this.colCapacity.Name = "colCapacity";
			this.colCapacity.ReadOnly = true;
			// 
			// colModifiedDate
			// 
			this.colModifiedDate.FillWeight = 70F;
			this.colModifiedDate.HeaderText = "F. Modificación";
			this.colModifiedDate.Name = "colModifiedDate";
			this.colModifiedDate.ReadOnly = true;
			// 
			// gbGestion
			// 
			this.gbGestion.Controls.Add(this.lblCapacidad_Validator);
			this.gbGestion.Controls.Add(this.lblNombre_Validator);
			this.gbGestion.Controls.Add(this.btnCancelar);
			this.gbGestion.Controls.Add(this.btnDone);
			this.gbGestion.Controls.Add(this.txtObservacion);
			this.gbGestion.Controls.Add(this.metroLabel3);
			this.gbGestion.Controls.Add(this.nudCapacidad);
			this.gbGestion.Controls.Add(this.metroLabel2);
			this.gbGestion.Controls.Add(this.txtNombre);
			this.gbGestion.Controls.Add(this.metroLabel1);
			this.gbGestion.Enabled = false;
			this.gbGestion.Location = new System.Drawing.Point(3, 3);
			this.gbGestion.Name = "gbGestion";
			this.gbGestion.Size = new System.Drawing.Size(534, 138);
			this.gbGestion.TabIndex = 0;
			this.gbGestion.TabStop = false;
			this.gbGestion.Text = "Gestionar";
			// 
			// lblCapacidad_Validator
			// 
			this.lblCapacidad_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblCapacidad_Validator.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblCapacidad_Validator.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblCapacidad_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblCapacidad_Validator.Location = new System.Drawing.Point(483, 31);
			this.lblCapacidad_Validator.Name = "lblCapacidad_Validator";
			this.lblCapacidad_Validator.Size = new System.Drawing.Size(14, 10);
			this.lblCapacidad_Validator.TabIndex = 8;
			this.lblCapacidad_Validator.Text = "*";
			this.lblCapacidad_Validator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCapacidad_Validator.UseCustomForeColor = true;
			// 
			// lblNombre_Validator
			// 
			this.lblNombre_Validator.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre_Validator.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblNombre_Validator.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblNombre_Validator.ForeColor = System.Drawing.Color.Red;
			this.lblNombre_Validator.Location = new System.Drawing.Point(65, 31);
			this.lblNombre_Validator.Name = "lblNombre_Validator";
			this.lblNombre_Validator.Size = new System.Drawing.Size(14, 10);
			this.lblNombre_Validator.TabIndex = 7;
			this.lblNombre_Validator.Text = "*";
			this.lblNombre_Validator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNombre_Validator.UseCustomForeColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(380, 101);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(71, 29);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnDone
			// 
			this.btnDone.Location = new System.Drawing.Point(457, 101);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(71, 29);
			this.btnDone.TabIndex = 6;
			this.btnDone.Text = "Hecho";
			this.btnDone.UseSelectable = true;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(6, 101);
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(368, 29);
			this.txtObservacion.TabIndex = 5;
			this.txtObservacion.Leave += new System.EventHandler(this.AsignAndValidate_Leave);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(6, 79);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(95, 19);
			this.metroLabel3.TabIndex = 4;
			this.metroLabel3.Text = "Observaciones";
			// 
			// nudCapacidad
			// 
			this.nudCapacidad.Location = new System.Drawing.Point(382, 47);
			this.nudCapacidad.Name = "nudCapacidad";
			this.nudCapacidad.Size = new System.Drawing.Size(146, 29);
			this.nudCapacidad.TabIndex = 3;
			this.nudCapacidad.Leave += new System.EventHandler(this.nudCapacidad_Leave);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(382, 25);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(104, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Capacidad Max.";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(6, 47);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(370, 29);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.Leave += new System.EventHandler(this.AsignAndValidate_Leave);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(6, 25);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(62, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Nombre:";
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(551, 471);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 1;
			this.pgsLoading.TabStop = false;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			// 
			// frm_Lounge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(600, 500);
			this.Controls.Add(this.pgsLoading);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Lounge";
			this.Padding = new System.Windows.Forms.Padding(30, 65, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Salones";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Lounge_FormClosing);
			this.Load += new System.EventHandler(this.frm_Lounge_Load);
			this.panelMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.gbGestion.ResumeLayout(false);
			this.gbGestion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.GroupBox gbGestion;
		private MetroFramework.Controls.MetroButton btnDone;
		private System.Windows.Forms.TextBox txtObservacion;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.NumericUpDown nudCapacidad;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtNombre;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroGrid dgvListado;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
		private MetroFramework.Controls.MetroButton btnNuevo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroLabel lblNombre_Validator;
		private MetroFramework.Controls.MetroLabel lblCapacidad_Validator;
	}
}