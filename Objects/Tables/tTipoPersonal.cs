using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tTipoPersonal
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool isUser { get; set; }
		public int TypeUserAsoc { get; set; }
		public string ModifiedDate { get; set; }
	}
}
