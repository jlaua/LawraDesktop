namespace LawrApp.Layouts.Fichas.Students
{
	partial class frmSearchStudents
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
			this.dgvalumnos = new System.Windows.Forms.DataGridView();
			this.btnData = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.txtsearch = new MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.dgvalumnos);
			this.panelMain.Controls.Add(this.btnData);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.txtsearch);
			this.panelMain.Controls.Add(this.metroButton1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 471);
			this.panelMain.TabIndex = 1;
			// 
			// dgvalumnos
			// 
			this.dgvalumnos.AllowUserToAddRows = false;
			this.dgvalumnos.AllowUserToDeleteRows = false;
			this.dgvalumnos.AllowUserToResizeColumns = false;
			this.dgvalumnos.AllowUserToResizeRows = false;
			this.dgvalumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvalumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvalumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvalumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvalumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvalumnos.Location = new System.Drawing.Point(3, 39);
			this.dgvalumnos.MultiSelect = false;
			this.dgvalumnos.Name = "dgvalumnos";
			this.dgvalumnos.ReadOnly = true;
			this.dgvalumnos.RowHeadersVisible = false;
			this.dgvalumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvalumnos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvalumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvalumnos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvalumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvalumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvalumnos.RowTemplate.Height = 28;
			this.dgvalumnos.RowTemplate.ReadOnly = true;
			this.dgvalumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvalumnos.ShowCellErrors = false;
			this.dgvalumnos.ShowCellToolTips = false;
			this.dgvalumnos.ShowEditingIcon = false;
			this.dgvalumnos.ShowRowErrors = false;
			this.dgvalumnos.Size = new System.Drawing.Size(734, 388);
			this.dgvalumnos.StandardTab = true;
			this.dgvalumnos.TabIndex = 153;
			this.dgvalumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalumnos_CellDoubleClick);
			this.dgvalumnos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvalumnos_KeyDown);
			// 
			// btnData
			// 
			this.btnData.Location = new System.Drawing.Point(652, 433);
			this.btnData.Name = "btnData";
			this.btnData.Size = new System.Drawing.Size(85, 35);
			this.btnData.TabIndex = 17;
			this.btnData.Text = "Abrir";
			this.btnData.UseSelectable = true;
			this.btnData.Click += new System.EventHandler(this.btnData_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(562, 433);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(85, 35);
			this.btnSalir.TabIndex = 16;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtsearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.txtsearch.Lines = new string[0];
			this.txtsearch.Location = new System.Drawing.Point(3, 3);
			this.txtsearch.MaxLength = 32767;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.PasswordChar = '\0';
			this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtsearch.SelectedText = "";
			this.txtsearch.Size = new System.Drawing.Size(642, 30);
			this.txtsearch.TabIndex = 15;
			this.txtsearch.UseSelectable = true;
			this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(667, 3);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(70, 30);
			this.metroButton1.TabIndex = 13;
			this.metroButton1.Text = "Buscar";
			this.metroButton1.UseSelectable = true;
			// 
			// frmSearchStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmSearchStudents";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Buscar Alumno";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchStudents_FormClosing);
			this.Load += new System.EventHandler(this.frmSearchAlumno_Load);
			this.panelMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroButton btnData;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroTextBox txtsearch;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.DataGridView dgvalumnos;
	}
}