using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objects.Tables;

namespace Objects.Processes
{
	public class GradoSeccion
	{
		public List<tGrado> Grados { get; set; }
		public List<tSeccion> Secciones { get; set; }
		public List<tNivel> Niveles { get; set; }
	}

	public class AsignBranches
	{
		public string Codigo { get; set; }
		public string Name { get; set; }
		public string Logo { get; set; }
		public int CodigoSucursal { get; set; }
		public string BranchAddress { get; set; }
	}
}
