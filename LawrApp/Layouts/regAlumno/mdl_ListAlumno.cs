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
using Objects.Processes;
using System.Threading;

namespace LawrApp.Layouts.regAlumno
{
	public partial class mdl_ListAlumno : MetroForm
	{
		private DataGeneral _data;
		
		private Alumnos _alumno		= new Alumnos();

		private Thread _hilo;

		public mdl_ListAlumno( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		private void LoadStudents()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._alumno.ListStudents( this._data );

			this.dgvSearchAlumnos.DataSource = this._data.Tables["ListaAlumnos"];

			this.dgvSearchAlumnos.Columns[1].HeaderText = "Codigo";
			this.dgvSearchAlumnos.Columns[2].HeaderText = "Nombres";
			this.dgvSearchAlumnos.Columns[3].HeaderText = "Ultima Modificación";

			this.dgvSearchAlumnos.Columns[0].Visible = false;
			this.dgvSearchAlumnos.Columns[1].FillWeight = 50;
			this.dgvSearchAlumnos.Columns[3].FillWeight = 70;

			this.pgAlumnosLoad.Visible = false;

			this._hilo.Abort();
		}

		private void sendDataToParent()
		{
			IAlumno iterfazAlumno = this.Owner as IAlumno;

			int index = this.dgvSearchAlumnos.CurrentCell.RowIndex;

			int Codigo				= Convert.ToInt32( this.dgvSearchAlumnos.Rows[index].Cells[0].Value );
			string nameStudent		= this.dgvSearchAlumnos.Rows[index].Cells[2].Value.ToString();

			if ( iterfazAlumno != null )
			{
				iterfazAlumno.ChooseStudent( nameStudent, Codigo );
				this.Close();
			}
		}

		#region EVENTOS

		private void mdl_ListAlumno_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadStudents ) );

			this.txtSearch.Focus();

			this.pgAlumnosLoad.Visible = true;

			this._hilo.Start();
		}

		private void txtSearch_TextChanged( object sender, EventArgs e )
		{
			this._data.Tables["ListaAlumnos"].DefaultView.RowFilter = ( "Names Like '%" + this.txtSearch.Text + "%' " );
			this.dgvSearchAlumnos.DataSource = this._data.Tables["ListaAlumnos"].DefaultView;
		}

		private void dgvSearchAlumnos_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			this.sendDataToParent();
			//if ( this.lbnameform.Text == "frmregDocumento" )
			//{
			//	this.enviarAlumno();
			//}

			//if ( this.lbnameform.Text == "frmregParent" )
			//{
			//	this.enviarAlumno();
			//}
		}

		private void dgvSearchAlumnos_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
			{
				this.sendDataToParent();
				//if ( this.lbnameform.Text == "frmregDocumento" )
				//	this.enviarAlumno();
				//if ( this.lbnameform.Text == "frmregParent" )
				//	this.enviarAlumno();
			}
		}

		#endregion
	}
}
