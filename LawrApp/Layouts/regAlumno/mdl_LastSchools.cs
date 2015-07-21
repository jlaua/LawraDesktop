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

namespace LawrApp.Layouts.regAlumno
{
	public partial class mdl_LastSchools : MetroForm
	{
		DataTable _data;

		//public delegate void enviardataescuela( string nombreescuela, int idescuela, string type );
		//public event enviardataescuela envioescuela;

		public mdl_LastSchools( DataTable table )
		{
			this._data = table;
			InitializeComponent();
		}

		public string LabelChange
		{
			set { this.txtSearchSchool.Text = value; }
		}

		private void sendDataToParent()
		{
			IAlumno iterfazAlumno = this.Owner as IAlumno;

			int index = this.dgvListSchool.CurrentCell.RowIndex;

			int Codigo				= Convert.ToInt32( this.dgvListSchool.Rows[index].Cells[0].Value );
			string nombreColegio	= this.dgvListSchool.Rows[index].Cells[1].Value.ToString();
			string tipoColegio      = this.dgvListSchool.Rows[index].Cells[2].Value.ToString();

			if ( iterfazAlumno != null )
			{
				iterfazAlumno.AddSchool( nombreColegio, Codigo, tipoColegio );
				this.Close();
			}
		}

		private void mdl_LastSchools_Load( object sender, EventArgs e )
		{
			this.dgvListSchool.DataSource = this._data;

			this.dgvListSchool.Columns[0].Visible = false;
			this.dgvListSchool.Columns[2].FillWeight = 25;
			this.dgvListSchool.Columns[3].FillWeight = 30;

			this.txtSearchSchool.Focus();
		}

		private void dgvListSchool_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			this.sendDataToParent();
		}

		private void txtSearchSchool_TextChanged( object sender, EventArgs e )
		{
			this._data.DefaultView.RowFilter = ( "Name Like '%" + this.txtSearchSchool.Text + "%' " );
			this.dgvListSchool.DataSource = _data.DefaultView;
		}

		private void dgvListSchool_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
				sendDataToParent();
		}

	}
}
