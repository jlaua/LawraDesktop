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

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmSearchSchool : MetroForm
	{
		private DataTable _data;
		private bool _isRegisteredStudent = false;

		public bool isRegisteredAlumno
		{
			get { return this._isRegisteredStudent; }
			set { this._isRegisteredStudent = value; }
		}

		public frmSearchSchool( DataTable table )
		{
			this._data = table;
			InitializeComponent();
		}

		private void sendDataToParent()
		{
			IFrmAlumno Ialumno = this.Owner as IFrmAlumno;

			int index = this.dgvListSchool.CurrentCell.RowIndex;

			int Codigo = Convert.ToInt32( this.dgvListSchool.Rows[index].Cells[0].Value );
			string nombreColegio    = this.dgvListSchool.Rows[index].Cells[1].Value.ToString();
			string tipoColegio      = this.dgvListSchool.Rows[index].Cells[2].Value.ToString();

			if ( Ialumno != null )
			{
				Ialumno.AddSchool( nombreColegio, Codigo, tipoColegio );
				this.Close();
			}
		}

		private void frmFindSchool_Load( object sender, EventArgs e )
		{
			this.dgvListSchool.DataSource = this._data;
			this.dgvListSchool.Columns[0].Width = 50;
			this.dgvListSchool.Columns[2].Width = 150;
			lblMessage.Text = this.Owner.Text;
			this.txtSearchSchool.Focus();
		}

		private void txtSearchSchool_TextChanged( object sender, EventArgs e )
		{
			MetroTextBox txt = ( MetroTextBox ) sender;
			this._data.DefaultView.RowFilter = ( "Name Like '%" + txt.Text + "%'" );
			this.dgvListSchool.DataSource = this._data.DefaultView;
		}

		private void dgvListSchool_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			this.sendDataToParent();
		}

		private void btnadd_Click( object sender, EventArgs e )
		{
			this.sendDataToParent();
		}

	}
}
