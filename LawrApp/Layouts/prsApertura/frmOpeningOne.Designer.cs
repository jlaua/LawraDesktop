namespace LawrApp.Layouts.prsApertura
{
	partial class frmOpeningOne
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
			this.label14 = new System.Windows.Forms.Label();
			this.btnImport = new MetroFramework.Controls.MetroButton();
			this.btnNext = new MetroFramework.Controls.MetroButton();
			this.gbparameters = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAddFreeTime = new MetroFramework.Controls.MetroButton();
			this.btnAddHoursAcademy = new MetroFramework.Controls.MetroButton();
			this.nudFreeTime = new System.Windows.Forms.NumericUpDown();
			this.nudHoursAcademy = new System.Windows.Forms.NumericUpDown();
			this.listFreeTime = new System.Windows.Forms.ListBox();
			this.listHoursAcademy = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.chklDaysAcademy = new System.Windows.Forms.CheckedListBox();
			this.gbyear = new System.Windows.Forms.GroupBox();
			this.dtpEndPeriod = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpStartPeriod = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.cbotypeYear = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtnameYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboyear = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
			this.ttError = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain.SuspendLayout();
			this.gbparameters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFreeTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHoursAcademy)).BeginInit();
			this.gbyear.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.label14);
			this.panelMain.Controls.Add(this.btnImport);
			this.panelMain.Controls.Add(this.btnNext);
			this.panelMain.Controls.Add(this.gbparameters);
			this.panelMain.Controls.Add(this.gbyear);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(27, 92);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(646, 427);
			this.panelMain.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Cursor = System.Windows.Forms.Cursors.Help;
			this.label14.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Silver;
			this.label14.Location = new System.Drawing.Point(95, 403);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(17, 21);
			this.label14.TabIndex = 4;
			this.label14.Text = "?";
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(3, 390);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(89, 34);
			this.btnImport.TabIndex = 3;
			this.btnImport.Text = "Importar";
			this.btnImport.UseSelectable = true;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(554, 390);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(89, 34);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Siguiente";
			this.btnNext.UseSelectable = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// gbparameters
			// 
			this.gbparameters.Controls.Add(this.label9);
			this.gbparameters.Controls.Add(this.label10);
			this.gbparameters.Controls.Add(this.label8);
			this.gbparameters.Controls.Add(this.btnAddFreeTime);
			this.gbparameters.Controls.Add(this.btnAddHoursAcademy);
			this.gbparameters.Controls.Add(this.nudFreeTime);
			this.gbparameters.Controls.Add(this.nudHoursAcademy);
			this.gbparameters.Controls.Add(this.listFreeTime);
			this.gbparameters.Controls.Add(this.listHoursAcademy);
			this.gbparameters.Controls.Add(this.label7);
			this.gbparameters.Controls.Add(this.label6);
			this.gbparameters.Controls.Add(this.chklDaysAcademy);
			this.gbparameters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbparameters.Location = new System.Drawing.Point(3, 178);
			this.gbparameters.Name = "gbparameters";
			this.gbparameters.Size = new System.Drawing.Size(640, 206);
			this.gbparameters.TabIndex = 1;
			this.gbparameters.TabStop = false;
			this.gbparameters.Text = "Parametros";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(298, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 17);
			this.label9.TabIndex = 9;
			this.label9.Text = "Tiempo Libre:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(364, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 17);
			this.label10.TabIndex = 8;
			this.label10.Text = "Min.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(210, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 17);
			this.label8.TabIndex = 8;
			this.label8.Text = "Min.";
			// 
			// btnAddFreeTime
			// 
			this.btnAddFreeTime.Location = new System.Drawing.Point(407, 45);
			this.btnAddFreeTime.Name = "btnAddFreeTime";
			this.btnAddFreeTime.Size = new System.Drawing.Size(34, 27);
			this.btnAddFreeTime.TabIndex = 7;
			this.btnAddFreeTime.Text = "+";
			this.btnAddFreeTime.UseSelectable = true;
			this.btnAddFreeTime.Click += new System.EventHandler(this.btnAddFreeTime_Click);
			// 
			// btnAddHoursAcademy
			// 
			this.btnAddHoursAcademy.Location = new System.Drawing.Point(262, 48);
			this.btnAddHoursAcademy.Name = "btnAddHoursAcademy";
			this.btnAddHoursAcademy.Size = new System.Drawing.Size(24, 24);
			this.btnAddHoursAcademy.TabIndex = 7;
			this.btnAddHoursAcademy.Text = "+";
			this.btnAddHoursAcademy.UseSelectable = true;
			this.btnAddHoursAcademy.Click += new System.EventHandler(this.btnAddHoursAcademy_Click);
			// 
			// nudFreeTime
			// 
			this.nudFreeTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudFreeTime.Location = new System.Drawing.Point(300, 48);
			this.nudFreeTime.Name = "nudFreeTime";
			this.nudFreeTime.ReadOnly = true;
			this.nudFreeTime.Size = new System.Drawing.Size(62, 25);
			this.nudFreeTime.TabIndex = 6;
			this.nudFreeTime.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// nudHoursAcademy
			// 
			this.nudHoursAcademy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudHoursAcademy.Location = new System.Drawing.Point(146, 46);
			this.nudHoursAcademy.Name = "nudHoursAcademy";
			this.nudHoursAcademy.ReadOnly = true;
			this.nudHoursAcademy.Size = new System.Drawing.Size(62, 25);
			this.nudHoursAcademy.TabIndex = 6;
			this.nudHoursAcademy.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// listFreeTime
			// 
			this.listFreeTime.FormattingEnabled = true;
			this.listFreeTime.ItemHeight = 17;
			this.listFreeTime.Location = new System.Drawing.Point(301, 79);
			this.listFreeTime.Name = "listFreeTime";
			this.listFreeTime.Size = new System.Drawing.Size(140, 106);
			this.listFreeTime.TabIndex = 3;
			this.listFreeTime.UseTabStops = false;
			// 
			// listHoursAcademy
			// 
			this.listHoursAcademy.FormattingEnabled = true;
			this.listHoursAcademy.ItemHeight = 17;
			this.listHoursAcademy.Location = new System.Drawing.Point(146, 79);
			this.listHoursAcademy.Name = "listHoursAcademy";
			this.listHoursAcademy.Size = new System.Drawing.Size(140, 106);
			this.listHoursAcademy.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(142, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Hora Academica:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(6, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Dias Academicos:";
			// 
			// chklDaysAcademy
			// 
			this.chklDaysAcademy.CheckOnClick = true;
			this.chklDaysAcademy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chklDaysAcademy.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
			this.chklDaysAcademy.Location = new System.Drawing.Point(8, 48);
			this.chklDaysAcademy.Name = "chklDaysAcademy";
			this.chklDaysAcademy.Size = new System.Drawing.Size(122, 144);
			this.chklDaysAcademy.TabIndex = 0;
			this.chklDaysAcademy.ThreeDCheckBoxes = true;
			// 
			// gbyear
			// 
			this.gbyear.Controls.Add(this.dtpEndPeriod);
			this.gbyear.Controls.Add(this.label5);
			this.gbyear.Controls.Add(this.dtpStartPeriod);
			this.gbyear.Controls.Add(this.label4);
			this.gbyear.Controls.Add(this.cbotypeYear);
			this.gbyear.Controls.Add(this.label3);
			this.gbyear.Controls.Add(this.txtnameYear);
			this.gbyear.Controls.Add(this.label2);
			this.gbyear.Controls.Add(this.cboyear);
			this.gbyear.Controls.Add(this.label1);
			this.gbyear.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbyear.Location = new System.Drawing.Point(3, 3);
			this.gbyear.Name = "gbyear";
			this.gbyear.Size = new System.Drawing.Size(640, 169);
			this.gbyear.TabIndex = 0;
			this.gbyear.TabStop = false;
			this.gbyear.Text = "Año Academico";
			// 
			// dtpEndPeriod
			// 
			this.dtpEndPeriod.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEndPeriod.CustomFormat = "yyyy-MM-dd";
			this.dtpEndPeriod.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEndPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndPeriod.Location = new System.Drawing.Point(416, 116);
			this.dtpEndPeriod.Name = "dtpEndPeriod";
			this.dtpEndPeriod.Size = new System.Drawing.Size(218, 29);
			this.dtpEndPeriod.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(412, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fin del Periodo:";
			// 
			// dtpStartPeriod
			// 
			this.dtpStartPeriod.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpStartPeriod.CustomFormat = "yyyy-MM-dd";
			this.dtpStartPeriod.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpStartPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartPeriod.Location = new System.Drawing.Point(192, 116);
			this.dtpStartPeriod.Name = "dtpStartPeriod";
			this.dtpStartPeriod.Size = new System.Drawing.Size(218, 29);
			this.dtpStartPeriod.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(192, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Inicio del Periodo:";
			// 
			// cbotypeYear
			// 
			this.cbotypeYear.FormattingEnabled = true;
			this.cbotypeYear.Items.AddRange(new object[] {
            "Bimestral",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual"});
			this.cbotypeYear.Location = new System.Drawing.Point(8, 117);
			this.cbotypeYear.Name = "cbotypeYear";
			this.cbotypeYear.Size = new System.Drawing.Size(178, 28);
			this.cbotypeYear.TabIndex = 5;
			this.cbotypeYear.Text = "Seleccione...";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tipo:";
			// 
			// txtnameYear
			// 
			this.txtnameYear.Location = new System.Drawing.Point(192, 58);
			this.txtnameYear.Name = "txtnameYear";
			this.txtnameYear.Size = new System.Drawing.Size(442, 27);
			this.txtnameYear.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(188, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre:";
			// 
			// cboyear
			// 
			this.cboyear.FormattingEnabled = true;
			this.cboyear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
			this.cboyear.Location = new System.Drawing.Point(8, 58);
			this.cboyear.Name = "cboyear";
			this.cboyear.Size = new System.Drawing.Size(178, 28);
			this.cboyear.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Año:";
			// 
			// ttInfo
			// 
			this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttInfo.ToolTipTitle = "Info:";
			// 
			// ttError
			// 
			this.ttError.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
			this.ttError.ToolTipTitle = "Error:";
			// 
			// frmOpeningOne
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 550);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 550);
			this.Name = "frmOpeningOne";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Configuraciones de Apertura";
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.gbparameters.ResumeLayout(false);
			this.gbparameters.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFreeTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHoursAcademy)).EndInit();
			this.gbyear.ResumeLayout(false);
			this.gbyear.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label label14;
		private MetroFramework.Controls.MetroButton btnImport;
		private MetroFramework.Controls.MetroButton btnNext;
		private System.Windows.Forms.GroupBox gbparameters;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private MetroFramework.Controls.MetroButton btnAddFreeTime;
		private MetroFramework.Controls.MetroButton btnAddHoursAcademy;
		private System.Windows.Forms.NumericUpDown nudFreeTime;
		private System.Windows.Forms.NumericUpDown nudHoursAcademy;
		private System.Windows.Forms.ListBox listFreeTime;
		private System.Windows.Forms.ListBox listHoursAcademy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckedListBox chklDaysAcademy;
		private System.Windows.Forms.GroupBox gbyear;
		private System.Windows.Forms.DateTimePicker dtpEndPeriod;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpStartPeriod;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbotypeYear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtnameYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboyear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip ttInfo;
		private System.Windows.Forms.ToolTip ttError;
	}
}