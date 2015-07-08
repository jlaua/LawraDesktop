using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tConceptoPago
	{
		public int Codigo { get; set; }
		public int CodigoPeriodo { get; set; }
		public int CodigoNivel { get; set; } //Pago dependiendo del Nivel, Puede tomar valores nulos 0
		public string Details { get; set; }
		public decimal Amount { get; set; }
		public char type { get; set; }
		public string ModifiedDate { get; set; }
	}
}
