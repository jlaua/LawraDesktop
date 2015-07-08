using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tApoderado
	{
		public int Codigo { get; set; }
		public int CodigoAlumno { get; set; }
		public string Names { get; set; }
		public string LastNames { get; set; }
		public string BirthDay { get; set; }
		public bool Gender { get; set; }
		public int CodigoTipoApoderado { get; set; }
		public int CodigoTipoDocumento { get; set; }
		public string DocumentNumber { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string ModifiedDate { get; set; }
	}
}
