using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace LawrApp.Reportes.Formularios
{
	public partial class frm_prueba : MetroForm
	{
		public frm_prueba()
		{
			InitializeComponent();
		}

		DataTable tableOptions()
		{
			DataTable dt = new DataTable();
			
			dt.Columns.Add( "Codigo", typeof( int ) );
			dt.Columns.Add( "Nombre", typeof( string ) );

			dt.Rows.Add( new object[] { 1, "Buen Estado" } );
			dt.Rows.Add( new object[] { 2, "Req. Reparacion" } );
			dt.Rows.Add( new object[] { 3, "Pesimo Estado" } );

			return dt;
		}

		DataTable tableContenido()
		{
			DataTable dt = new DataTable();

			dt.Columns.Add( "Codigo", typeof( Int32 ) );
			dt.Columns.Add( "Descripcion", typeof( string ) );
			dt.Columns.Add( "Estados", typeof( Int32 ) );

			dt.Rows.Add( new object[] { 1, "Lampara", 2 } );
			dt.Rows.Add( new object[] { 2, "Alfañique", 3 } );
			dt.Rows.Add( new object[] { 3, "Sillas", 1 } );
			dt.Rows.Add( new object[] { 4, "Carpetas", 1 } );
			dt.Rows.Add( new object[] { 5, "Lampara", 2 } );
			dt.Rows.Add( new object[] { 6, "Alfañique", 3 } );
			dt.Rows.Add( new object[] { 7, "Sillas", 1 } );
			dt.Rows.Add( new object[] { 8, "Carpetas", 1 } );
			dt.Rows.Add( new object[] { 9, "Lampara", 1 } );
			dt.Rows.Add( new object[] { 10, "Alfañique", 1 } );
			dt.Rows.Add( new object[] { 11, "Sillas", 1 } );
			dt.Rows.Add( new object[] { 12, "Carpetas", 1 } );
			dt.Rows.Add( new object[] { 13, "Lampara", 1 } );
			dt.Rows.Add( new object[] { 14, "Alfañique", 1 } );
			dt.Rows.Add( new object[] { 15, "Sillas", 1 } );
			dt.Rows.Add( new object[] { 16, "Carpetas", 1 } );
			dt.Rows.Add( new object[] { 17, "Lampara", 2 } );
			dt.Rows.Add( new object[] { 18, "Alfañique", 3 } );
			dt.Rows.Add( new object[] { 19, "Sillas", 1 } );
			dt.Rows.Add( new object[] { 20, "Carpetas", 1 } );

			return dt;
		}

		private void frm_prueba_Load( object sender, EventArgs e )
		{
			DataGridViewComboBoxColumn colCbo = dgvListado.Columns[2] as DataGridViewComboBoxColumn;

			colCbo.DisplayMember = "Nombre";
			colCbo.ValueMember = "Codigo";
			colCbo.DataSource = this.tableOptions();

			this.dgvListado.AutoGenerateColumns = false;

			DataTable table = this.tableContenido();

			foreach( DataRow row in table.Rows ) dgvListado.Rows.Add( row.ItemArray );

		}

		private void btnRecorrer_Click( object sender, EventArgs e )
		{
			foreach( DataGridViewRow row in dgvListado.Rows ) MessageBox.Show( this, string.Format("Codigo={0}", row.Cells[2].Value) );
		}
	}
}
