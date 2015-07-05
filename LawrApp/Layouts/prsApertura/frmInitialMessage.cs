using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LawrApp.Layouts.prsApertura
{
    public partial class frmInitialMessage : MetroForm
    {
		private DataGeneral _data;
		private bool _isNext = false;

		public frmInitialMessage( DataGeneral dts )
        {
			this._data = dts;
            InitializeComponent();
        }

		private void btnnext_Click( object sender, EventArgs e )
		{
			frmOpeningOne open = new frmOpeningOne( this._data );
			this._isNext = true;
			open.Show();
			this.Close();
		}

		private void frmInitialMessage_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( ! this._isNext )
			{
				frmMain main = new frmMain( this._data );
				main.Show();
			}
		}

    }
}
