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

		private delegate void LoadDataToGridView();

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

			this.LoadToGrid();

			this.panelMain.Enabled = true;
			this.pgAlumnosLoad.Visible = false;
			this._hilo.Abort();
		}

		private void LoadToGrid()
		{
			if( ! this.InvokeRequired )
			{
				this.dgvListado.DataSource = this._data.Tables["ListaAlumnos"];

				this.dgvListado.Columns[0].Visible = false;
				this.dgvListado.Columns["Key"].FillWeight = 30;
				this.dgvListado.Columns["ModifiedDate"].FillWeight = 40;

				this.dgvListado.Columns["Key"].HeaderText = "Folder";
				this.dgvListado.Columns["Names"].HeaderText = "Nombre Completo";
				this.dgvListado.Columns["ModifiedDate"].HeaderText = "Ult. Modificación";
			}
			else
			{
				LoadDataToGridView gri = new LoadDataToGridView( LoadToGrid );
				this.Invoke( gri, new object[] { } );
			}
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

			regAlum.CodigoAlumno = Convert.ToInt32( this.dgvListado.CurrentRow.Cells[0].Value );
			regAlum.keyAlumno = this.dgvListado.CurrentRow.Cells[1].Value.ToString();

			regAlum.ToActualize = true;

			regAlum.Owner = this.ParentForm;
			regAlum.ShowDialog( this.ParentForm );

			this.Close();
		}

		#endregion

	#region TEXTCHANGED

		private void txtSearch_TextChanged( object sender, EventArgs e )
		{
			this._data.Tables["ListaAlumnos"].DefaultView.RowFilter = ( "Names Like '%" + this.txtSearch.Text + "%' " );
			this.dgvListado.DataSource = this._data.Tables["ListaAlumnos"].DefaultView;
		}

	#endregion

	#region KEYDOWN

		private void dgvSearch_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Delete )
			{
				int idAlumno		= Convert.ToInt32( dgvListado.CurrentRow.Cells[0].Value );
				string nombreAlumno = dgvListado.CurrentRow.Cells[2].Value.ToString();

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
						this.dgvListado.Rows.Remove( this.dgvListado.CurrentRow );
				}
			}
			else if ( e.KeyData == Keys.Enter )
			{
				frm_Registers regAlum = new frm_Registers( this._data );
				regAlum.CodigoAlumno = Convert.ToInt32( this.dgvListado.CurrentRow.Cells[0].Value );
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
