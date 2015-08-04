using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace LawrApp.Institucion
{
	public partial class mdl_Preview : MetroForm
	{
		private string _lat, _lng;
		private int _zoom;

		public mdl_Preview()
		{
			InitializeComponent();
		}

		public string Latitud
		{
			get { return this._lat; }
			set { this._lat = value; }
		}

		public string Longitud
		{
			get { return this._lng; }
			set { this._lng = value; }
		}

		public int Zoom
		{
			get { return this._zoom; }
			set { this._zoom = value; }
		}

		private void mdl_Preview_Load( object sender, EventArgs e )
		{

		}
	}
}
