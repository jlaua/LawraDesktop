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
using MetroFramework.Controls;
using Registers.Students;
using System.Threading;

namespace LawrApp.Layouts.Fichas.Students
{
	public partial class frmSearchStudents : MetroForm
	{
		private DataGeneral _data;
		private Alumnos _cStudent = new Alumnos();
		private bool _openFicha = false;

		public frmSearchStudents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region METODOS

		private void OpenFichaStudent()
		{
			frmStudents frmestudiantes = new frmStudents( this._data );
			frmestudiantes.Codigo = Convert.ToInt32( this.dgvalumnos.CurrentRow.Cells[0].Value );
			this._openFicha = true;
			frmestudiantes.Show();
			this.Close();
		}

		#endregion

		private void frmSearchAlumno_Load( object sender, EventArgs e )
		{
			this.dgvalumnos.DataSource = this._data.Tables["ListaAlumnos"];
		}
		
		private void frmSearchStudents_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( ! this._openFicha )
			{
				frmMain main = new frmMain( this._data );
				main.Show();
			}
		}

		private void txtsearch_TextChanged( object sender, EventArgs e )
		{
			this._data.Tables["ListaAlumnos"].DefaultView.RowFilter = ( "Names Like '%" + this.txtsearch.Text + "%' " );
			this.dgvalumnos.DataSource = this._data.Tables["ListaAlumnos"].DefaultView;

		}

		private void dgvalumnos_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex > (-1) ) this.OpenFichaStudent();
		}

		private void btnData_Click( object sender, EventArgs e )
		{
			if ( this.dgvalumnos.Rows.Count > 0 ) this.OpenFichaStudent();
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void dgvalumnos_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
			{
				if ( this.dgvalumnos.Rows.Count <= 0 ) return;
				else
					this.OpenFichaStudent();
			}
		}

	}
}
