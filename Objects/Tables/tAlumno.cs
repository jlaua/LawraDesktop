using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tAlumno
	{
		public int Codigo { get; set; }
		public string Key { get; set; }
		public int CodigoImagen { get; set; }
		public string ImageSrc { get; set; }
		public string ImageKey { get; set; }
		public int CodigoUsuario { get; set; }
		public int CodigoUltimoColegio { get; set; }
		public string Names { get; set; }
		public string LastNames { get; set; }
		public string Birthday { get; set; }
		public bool Gender { get; set; }
		public string Address { get; set; }
		public string Ubigeo { get; set; }
		public string Observation { get; set; }
		public string ModifiedDate { get; set; }
	}
}
