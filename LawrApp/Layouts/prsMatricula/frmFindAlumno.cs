using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmFindAlumno : MetroForm
	{
		private DataGeneral _data;
		private bool _closeInProcesses = false;
		private bool _isNewStudent = false;

		public bool IsNewStudent
		{
			get { return this._isNewStudent; }
			set { this._isNewStudent = value; }
		}

		public frmFindAlumno( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region METODOS

		#endregion

		private void frmFindAlumno_Load( object sender, EventArgs e )
		{
			dgvalumnos.DataSource = this._data.Tables["ListaAlumnos"];

			dgvalumnos.Columns[0].Visible = false;
			dgvalumnos.Columns[1].HeaderText = "Clave";
			dgvalumnos.Columns[2].HeaderText = "Nombres Completos";
			dgvalumnos.Columns[3].HeaderText = "Ult. Modificación";

		}

		private void txtsearch_TextChanged( object sender, EventArgs e )
		{
			( this.dgvalumnos.DataSource as DataTable ).DefaultView.RowFilter = string.Format( "Nombres del Alumno = '{0}'", this.txtsearch.Text );
		}

		private void btnpreview_Click( object sender, EventArgs e )
		{
			frmInitialMessage msg = new frmInitialMessage( this._data );
			msg.IsNewStudent = false;
			this._closeInProcesses = true;
			msg.Show();
			this.Close();
		}

		private void frmFindAlumno_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( ! this._closeInProcesses )
			{
				frmMain main = new frmMain( this._data );
				main.Show();
			}
		}

	}
}
