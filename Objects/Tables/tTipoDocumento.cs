using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tTipoDocumento
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public int Length { get; set; }
		public bool Numeric { get; set; }
		public bool ExactLength { get; set; }
		public string Description { get; set; }
		public string ModifiedDate { get; set; }
	}
}
