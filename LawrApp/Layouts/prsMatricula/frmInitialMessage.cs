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
	public partial class frmInitialMessage : MetroForm
	{
		private bool _isNewStudent = false;
		private DataGeneral _data;

		public bool IsNewStudent
		{
			get { return this._isNewStudent; }
			set { this._isNewStudent = value; }
		}

		public frmInitialMessage( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		private void btnMessageContinue_Click( object sender, EventArgs e )
		{
			if ( rbnuevoAlumno.Checked )
			{

				frmAsignaClase confGredrees = new frmAsignaClase( this._data );
				confGredrees.IsNewStudent = true;
				confGredrees.Show();
				this.Close();
			}
			else
			{
				this._isNewStudent = false;
				frmFindAlumno buscarAlumno = new frmFindAlumno( this._data );
				buscarAlumno.Show();
				this.Close();
			}
		}

		private void rbnuevoAlumno_CheckedChanged( object sender, EventArgs e )
		{
			_isNewStudent = true;

		}

		private void rbalumnoRegistrado_CheckedChanged( object sender, EventArgs e )
		{
			_isNewStudent = false;
		}

		private void frmInitialMessage_Load( object sender, EventArgs e )
		{
			if ( this.IsNewStudent )
			{
				rbnuevoAlumno.Checked = true;
				rbalumnoRegistrado.Checked = false;
			}
			else
			{
				rbnuevoAlumno.Checked = false;
				rbalumnoRegistrado.Checked = true;
			}
		}
	}
}
