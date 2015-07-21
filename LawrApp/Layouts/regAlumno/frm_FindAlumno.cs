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
using System.Threading;
using Registers.Students;

namespace LawrApp.Layouts.regAlumno
{
	public partial class frm_FindAlumno : MetroForm
	{
		Alumnos alumnos = new Alumnos();
		DataGeneral _data;

		private Thread _hilo;
		private bool _getAlumno = false;
		private bool _openMain	= true;

		public frm_FindAlumno( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

#region PROPIEDADES

		public bool IsClose
		{
			get { return this._openMain; }
			set { this._openMain = value; }
		}

		public bool GetAlumno
		{
			get { return this._getAlumno; }
			set { this._getAlumno = value; }
		}

#endregion

#region METODOS

		private void LoadDataTableEstudent()
		{
			CheckForIllegalCrossThreadCalls = false;
			this.alumnos.ListStudents( this._data );

			this.dgvSearch.DataSource = this._data.Tables["ListaAlumnos"];

			this.dgvSearch.Columns[0].Visible = false;
			this.dgvSearch.Columns[1].FillWeight = 30;
			this.dgvSearch.Columns[3].FillWeight = 40;

			this.panelMain.Enabled = true;
			this.pgAlumnosLoad.Visible = false;
		}

#endregion

#region EVENTOS

		private void frm_FindAlumno_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadDataTableEstudent ) );
			
			this.panelMain.Enabled = false;
			this.pgAlumnosLoad.Visible = true;

			this._hilo.Start();
		}

		private void frm_FindAlumno_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._openMain )
			{
				frmMain main = new frmMain( _data );
				main.Show();
			}
		}

	#region CLICK

		private void btnnuevoAlumno_Click( object sender, EventArgs e )
		{
			frm_Registers regAlum = new frm_Registers( this._data );
			
			this._openMain = false;

			regAlum.Show();

			this.Close();
		}

		private void dgvSearch_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			frm_Registers regAlum = new frm_Registers( this._data );

			regAlum.CodigoAlumno = Convert.ToInt32( this.dgvSearch.Rows[e.RowIndex].Cells[0].Value );
			regAlum.keyAlumno = this.dgvSearch.CurrentRow.Cells[1].Value.ToString();

			regAlum.ToActualize = true;

			this._openMain = false;
			regAlum.Show();

			this.Close();
		}

		#endregion

	#region TEXTCHANGED

		private void txtSearch_TextChanged( object sender, EventArgs e )
		{
			this._data.Tables["ListaAlumnos"].DefaultView.RowFilter = ( "Names Like '%" + this.txtSearch.Text + "%' " );
			this.dgvSearch.DataSource = this._data.Tables["ListaAlumnos"].DefaultView;
		}

	#endregion

	#region KEYDOWN

		private void dgvSearch_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Delete )
			{
				int idAlumno		= Convert.ToInt32( dgvSearch.CurrentRow.Cells[0].Value );
				string nombreAlumno = dgvSearch.CurrentRow.Cells[2].Value.ToString();

				DialogResult question = MetroMessageBox.Show( 
							this, 
							"Realmente deseas eliminar Al Alumno: " + nombreAlumno + "?", 
							"Advertencia!",
							MessageBoxButtons.YesNo, 
							MessageBoxIcon.Question 
				);

				if ( question == DialogResult.Yes )
				{
					if ( alumnos.DeleteStudent( idAlumno ) )
						this.dgvSearch.Rows.Remove( this.dgvSearch.CurrentRow );
				}
			}
			else if ( e.KeyData == Keys.Enter )
			{
				frm_Registers regAlum = new frm_Registers( this._data );
				regAlum.CodigoAlumno = Convert.ToInt32( this.dgvSearch.CurrentRow.Cells[0].Value );
				regAlum.ToActualize = true;

				this._openMain = false;

				regAlum.Show();
				this.Close();
			}
		}

	#endregion

#endregion

	}
}
