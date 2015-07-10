using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tDistritos
	{
		public int Id { get; set; }
		public string Distrito { get; set; }
	}

	public class tProvincias
	{
		public int Id { get; set; }
		public string Provincia { get; set; }
		public List<tDistritos> Distritos { get; set; }
	}

	public class tDepartamentos
	{
		public int Id { get; set; }
		public string Departamento { get; set; }
		public List<tProvincias> Provincias { get; set; }
	}
}
