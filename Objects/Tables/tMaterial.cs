using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tMaterial
	{
		public int Codigo { get; set; }
		public string Description { get; set; }
		public tMarca Marca { get; set; }
		public tCategoria Category { get; set; }
		public string Model { get; set; }
		public string Observation { get; set; }
		public string RestorationCost { get; set; }//Costo de restauración
		public string ModifiedDate { get; set; }
	}

	public class tMarca
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string Modifieddate { get; set; }
	}

	public class tCategoria
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string Modifieddate { get; set; }
	}
}
