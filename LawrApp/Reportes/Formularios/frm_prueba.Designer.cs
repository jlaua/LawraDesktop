namespace LawrApp.Reportes.Formularios
{
	partial class frm_prueba
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvListado = new MetroFramework.Controls.MetroGrid();
			this.btnRecorrer = new MetroFramework.Controls.MetroButton();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeleccione = new System.Windows.Forms.DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AllowUserToResizeRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colSeleccione});
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListado.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvListado.EnableHeadersVisualStyles = false;
			this.dgvListado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvListado.Location = new System.Drawing.Point(28, 63);
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
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
			this.dgvListado.Size = new System.Drawing.Size(544, 267);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 0;
			this.dgvListado.UseCustomBackColor = true;
			this.dgvListado.UseCustomForeColor = true;
			this.dgvListado.UseStyleColors = true;
			// 
			// btnRecorrer
			// 
			this.btnRecorrer.Location = new System.Drawing.Point(497, 336);
			this.btnRecorrer.Name = "btnRecorrer";
			this.btnRecorrer.Size = new System.Drawing.Size(75, 29);
			this.btnRecorrer.TabIndex = 1;
			this.btnRecorrer.Text = "Recorrer";
			this.btnRecorrer.UseSelectable = true;
			this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
			// 
			// colCodigo
			// 
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colCodigo.DefaultCellStyle = dataGridViewCellStyle17;
			this.colCodigo.FillWeight = 20F;
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			// 
			// colDescripcion
			// 
			this.colDescripcion.HeaderText = "Descripción";
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.ReadOnly = true;
			// 
			// colSeleccione
			// 
			this.colSeleccione.DisplayStyleForCurrentCellOnly = true;
			this.colSeleccione.FillWeight = 45F;
			this.colSeleccione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colSeleccione.HeaderText = "Seleccione";
			this.colSeleccione.Name = "colSeleccione";
			this.colSeleccione.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colSeleccione.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// frm_prueba
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.btnRecorrer);
			this.Controls.Add(this.dgvListado);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_prueba";
			this.Padding = new System.Windows.Forms.Padding(25, 60, 25, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.ShowInTaskbar = false;
			this.Text = "Pruebas";
			this.Load += new System.EventHandler(this.frm_prueba_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid dgvListado;
		private MetroFramework.Controls.MetroButton btnRecorrer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewComboBoxColumn colSeleccione;



	}
}