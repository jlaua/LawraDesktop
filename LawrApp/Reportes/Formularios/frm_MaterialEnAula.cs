using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using LawrApp.Reportes;
using Microsoft.Reporting.WinForms;
using System.Threading;

using Registers.Students;
using Objects.Tables;
using Objects.Processes;

namespace LawrApp.Reportes.Formularios
{
	public partial class frm_MaterialEnAula : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;

		private Alumnos _alum = new Alumnos();
		private Parents _pare = new Parents();
		private Documents _docu = new Documents();

		private List<tAlumno> _talumno = new List<tAlumno>();
		private List<lApoderados> _tapoderado = new List<lApoderados>();
		private List<lDocumentos> _tdocumento = new List<lDocumentos>();

		private bool _inAction = true;
		private int _codigo = 0;
 
		public frm_MaterialEnAula( DataGeneral dts, int Codigo )
		{
			this._data = dts;
			this._codigo = Codigo;
			InitializeComponent();
		}

		void ChargeReporte()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			this._talumno.Add( this._alum.FindStudents( this._codigo ) );
			this._tapoderado = this._pare.List(this._codigo);
			this._tdocumento = this._docu.List( this._codigo );

			this._talumno[0].ImageSrc = this._alum.ConfigBaseUrl + this._talumno[0].ImageSrc;

			this.LoadReport();

			this._inAction = false;
			this._hilo.Abort();
		}

		void LoadReport()
		{
			ReportDataSource talum = new ReportDataSource( "t_alumno", this._talumno );
			ReportDataSource tapod = new ReportDataSource( "t_apoderado", this._tapoderado );
			ReportDataSource tdocu = new ReportDataSource( "t_documento", this._tdocumento );

			this.rpvMateriales.LocalReport.DataSources.Clear();

			this.rpvMateriales.PromptAreaCollapsed = true;
			this.rpvMateriales.SetDisplayMode( DisplayMode.PrintLayout );

			this.rpvMateriales.LocalReport.DataSources.Add( talum );
			this.rpvMateriales.LocalReport.DataSources.Add( tapod );
			this.rpvMateriales.LocalReport.DataSources.Add( tdocu );

			this.rpvMateriales.RefreshReport();
			this.rpvMateriales.Refresh();

			this.panel1.Enabled = true;
			this.pgsLoading.Visible = false;
		}

		private void frm_MaterialEnAula_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.ChargeReporte ) );

			this.panel1.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._hilo.Start();
		}

		private void reportViewer1_Load( object sender, EventArgs e )
		{

		}
	}
}
