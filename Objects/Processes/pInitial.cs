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
}
