using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tSucursal
	{
		public int Codigo { get; set; }
		public int CodigoInstitucion { get; set; }
		public string Address { get; set; }
		public bool IsMain { get; set; }
		public string Ubigeo { get; set; }
		public string LocalCode { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Latitud { get; set; }
		public string Longitud { get; set; }
		public int Zoom { get; set; }
		public string ModifiedDate { get; set; }
	}
}
