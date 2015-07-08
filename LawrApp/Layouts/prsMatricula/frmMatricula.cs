using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmMatricula : MetroForm
	{
		private DataGeneral _data;
		private bool _isNewStudent = false;
		private int _codClase;
		private int _idStudent = 0;

		public bool IsNewStudent
		{
			get { return this._isNewStudent; }
			set { this._isNewStudent = value; }
		}

		public int CodigoClase
		{
			get { return this._codClase; }
			set { this._codClase = value; }
		}

		public frmMatricula( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		private void btnguardarMatricula_Click( object sender, EventArgs e )
		{
			MetroMessageBox.Show( this, "Desea Imprimir Boleta de pagos", "Imprimir Boleta de Pagos", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
		}

		private void frmMatricula_Load( object sender, EventArgs e )
		{

		}
	}
}
