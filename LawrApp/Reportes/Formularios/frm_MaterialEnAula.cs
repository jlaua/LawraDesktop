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

namespace LawrApp.Reportes.Formularios
{
	public partial class frm_MaterialEnAula : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;

		private bool _inAction = true;
		private delegate void LoadDefaultForm();
 
		public frm_MaterialEnAula( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		void ChargeReporte()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;
			
			//Thread.Sleep(2000);

			this.LoadReport();

			this._inAction = false;
			this._hilo.Abort();
		}

		void LoadReport()
		{
			//if ( ! this.InvokeRequired )
			//{
				ReportDataSource repDist = new ReportDataSource( "Distritos", this._data.Tables["Distritos"] );
				ReportDataSource repProv = new ReportDataSource( "Provincias", this._data.Tables["Provincias"] );
				ReportDataSource repDepa = new ReportDataSource( "Departamentos", this._data.Tables["Departamentos"] );

				this.rpvMateriales.LocalReport.DataSources.Clear();

				this.rpvMateriales.PromptAreaCollapsed = true;
				this.rpvMateriales.SetDisplayMode( DisplayMode.PrintLayout );

				this.rpvMateriales.LocalReport.DataSources.Add( repDist );
				this.rpvMateriales.LocalReport.DataSources.Add( repProv );
				this.rpvMateriales.LocalReport.DataSources.Add( repDepa );

				this.rpvMateriales.RefreshReport();
				this.rpvMateriales.Refresh();

				this.panel1.Enabled = true;
				this.pgsLoading.Visible = false;
			//}
			//else
			//{
			//	LoadDefaultForm form = new LoadDefaultForm( LoadReport );
			//	this.Invoke( form, new object[] { } );
			//}
		}

		private void frm_MaterialEnAula_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadReport ) );

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
