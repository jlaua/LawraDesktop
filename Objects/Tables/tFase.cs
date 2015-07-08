using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tFase
	{
		public int Codigo { get; set; }
		public int CodigoPeriodo { get; set; }
		public int CodigoTipoFase { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public bool Active { get; set; }
		public string ModifiedDate { get; set; }
	}
}
