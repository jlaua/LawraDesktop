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
using Access;

namespace LawrApp.Institucion
{
	public partial class mdl_Preview : MetroForm
	{
		private string _lat, _lng;
		private string _msgException;
		private int _zoom;
		private ConfigServer _conf = new ConfigServer();

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
			this.lblDetalle.Text = "Detalle: Latitud = " + this.Latitud + "; Longitud = " + this.Longitud + "; Zoom de Altura = " + this.Zoom;
			
			try
			{
				this.webBrowser.Navigate( this._conf.BaseUrl + "api/geolocation/lat/" + this.Latitud + "/lng/" + this.Longitud + "/zoom/" + this.Zoom );
			}catch( Exception ex )
			{
				this._msgException = ex.Message;
			}
		}
	}
}
