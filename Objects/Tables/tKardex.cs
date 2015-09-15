using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tKardex
	{
		public int Codigo { get; set; }
		public int CodigoMaterial { get; set; }
		public bool TypeReg { get; set; }//el tipo de kardex 0=Ingreso, 1=egreso
		public bool TypeIncome { get; set; } // el tipo de ingreso 0=Donación, 1=Compra
		public decimal PurchasePrice { get; set; }//precio de compra
		public int Quantity { get; set; }
		public string PurchaseDate { get; set; }
		public string SerialNumber { get; set; }//N° de Facturas, boletos u otros documentos
		public string ModifiedDate { get; set; }
	}
}
