using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tPersonal
	{
		public int Codigo { get; set; }
		public string Key { get; set; }
		public int CodigoImagen { get; set; }
		public string ImageSrc { get; set; }
		public string ImageKey { get; set; }
		public int CodigoTipoPersonal { get; set; }
		public int CodigoUsuario { get; set; }
		public string Names { get; set; }
		public string LastNames { get; set; }
		public string Birthday { get; set; }
		public bool Gender { get; set; }
		public int CodigoTipoDocumento { get; set; }
		public string DocumentNumber { get; set; }
		public tProfesiones Profesion { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string ModifiedDate { get; set; }
	}


}
