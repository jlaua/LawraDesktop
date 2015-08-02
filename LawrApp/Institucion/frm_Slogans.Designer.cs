namespace LawrApp.Institucion
{
	partial class frm_Slogans
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbRegistros = new System.Windows.Forms.GroupBox();
			this.gbListados = new System.Windows.Forms.GroupBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroButton5 = new MetroFramework.Controls.MetroButton();
			this.metroButton6 = new MetroFramework.Controls.MetroButton();
			this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
			this.panel1.SuspendLayout();
			this.gbRegistros.SuspendLayout();
			this.gbListados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbListados);
			this.panel1.Controls.Add(this.gbRegistros);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(540, 421);
			this.panel1.TabIndex = 0;
			// 
			// gbRegistros
			// 
			this.gbRegistros.Controls.Add(this.metroButton2);
			this.gbRegistros.Controls.Add(this.metroButton1);
			this.gbRegistros.Controls.Add(this.richTextBox1);
			this.gbRegistros.Controls.Add(this.metroLabel2);
			this.gbRegistros.Controls.Add(this.textBox1);
			this.gbRegistros.Controls.Add(this.metroLabel1);
			this.gbRegistros.Enabled = false;
			this.gbRegistros.Location = new System.Drawing.Point(3, 3);
			this.gbRegistros.Name = "gbRegistros";
			this.gbRegistros.Size = new System.Drawing.Size(534, 172);
			this.gbRegistros.TabIndex = 0;
			this.gbRegistros.TabStop = false;
			this.gbRegistros.Text = "Registros";
			// 
			// gbListados
			// 
			this.gbListados.Controls.Add(this.dgvListado);
			this.gbListados.Controls.Add(this.metroButton6);
			this.gbListados.Controls.Add(this.metroButton5);
			this.gbListados.Controls.Add(this.metroButton4);
			this.gbListados.Controls.Add(this.metroButton3);
			this.gbListados.Location = new System.Drawing.Point(3, 196);
			this.gbListados.Name = "gbListados";
			this.gbListados.Size = new System.Drawing.Size(534, 222);
			this.gbListados.TabIndex = 0;
			this.gbListados.TabStop = false;
			this.gbListados.Text = "Listados";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(6, 30);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(44, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Titulo:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(471, 29);
			this.textBox1.TabIndex = 1;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(6, 66);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(76, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Descripción";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(6, 88);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(424, 78);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(456, 137);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(72, 29);
			this.metroButton1.TabIndex = 4;
			this.metroButton1.Text = "Hecho";
			this.metroButton1.UseSelectable = true;
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(456, 101);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(72, 31);
			this.metroButton2.TabIndex = 4;
			this.metroButton2.Text = "Cancelar";
			this.metroButton2.UseSelectable = true;
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AllowUserToResizeColumns = false;
			this.dgvListado.AllowUserToResizeRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTitle,
            this.colModifiedDate});
			this.dgvListado.Location = new System.Drawing.Point(6, 28);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.ReadOnly = true;
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.Height = 28;
			this.dgvListado.RowTemplate.ReadOnly = true;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.ShowCellErrors = false;
			this.dgvListado.ShowCellToolTips = false;
			this.dgvListado.ShowEditingIcon = false;
			this.dgvListado.ShowRowErrors = false;
			this.dgvListado.Size = new System.Drawing.Size(521, 156);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 9;
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colTitle
			// 
			this.colTitle.HeaderText = "Titulo";
			this.colTitle.Name = "colTitle";
			this.colTitle.ReadOnly = true;
			// 
			// colModifiedDate
			// 
			this.colModifiedDate.FillWeight = 60F;
			this.colModifiedDate.HeaderText = "Ult. Modificación";
			this.colModifiedDate.Name = "colModifiedDate";
			this.colModifiedDate.ReadOnly = true;
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(455, 190);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(72, 29);
			this.metroButton3.TabIndex = 4;
			this.metroButton3.Text = "Nuevo";
			this.metroButton3.UseSelectable = true;
			// 
			// metroButton4
			// 
			this.metroButton4.Location = new System.Drawing.Point(358, 190);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(72, 29);
			this.metroButton4.TabIndex = 4;
			this.metroButton4.Text = "Modificar";
			this.metroButton4.UseSelectable = true;
			// 
			// metroButton5
			// 
			this.metroButton5.Location = new System.Drawing.Point(280, 190);
			this.metroButton5.Name = "metroButton5";
			this.metroButton5.Size = new System.Drawing.Size(72, 29);
			this.metroButton5.TabIndex = 4;
			this.metroButton5.Text = "Eliminar";
			this.metroButton5.UseSelectable = true;
			// 
			// metroButton6
			// 
			this.metroButton6.Location = new System.Drawing.Point(6, 190);
			this.metroButton6.Name = "metroButton6";
			this.metroButton6.Size = new System.Drawing.Size(72, 29);
			this.metroButton6.TabIndex = 4;
			this.metroButton6.Text = "Salir";
			this.metroButton6.UseSelectable = true;
			// 
			// metroProgressSpinner1
			// 
			this.metroProgressSpinner1.Location = new System.Drawing.Point(30, 522);
			this.metroProgressSpinner1.Maximum = 100;
			this.metroProgressSpinner1.Name = "metroProgressSpinner1";
			this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
			this.metroProgressSpinner1.Speed = 2F;
			this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
			this.metroProgressSpinner1.TabIndex = 1;
			this.metroProgressSpinner1.UseSelectable = true;
			this.metroProgressSpinner1.Value = 50;
			// 
			// frm_Slogans
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.metroProgressSpinner1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frm_Slogans";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Descripción de Lemas";
			this.panel1.ResumeLayout(false);
			this.gbRegistros.ResumeLayout(false);
			this.gbRegistros.PerformLayout();
			this.gbListados.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbListados;
		private System.Windows.Forms.GroupBox gbRegistros;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox textBox1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.DataGridView dgvListado;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
		private MetroFramework.Controls.MetroButton metroButton6;
		private MetroFramework.Controls.MetroButton metroButton5;
		private MetroFramework.Controls.MetroButton metroButton4;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
	}
}