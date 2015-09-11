using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Tables;

namespace Objects.Processes
{
	public class pMaterialControl
	{
		public tMaterial Material { get; set; }
	}

	public class lKeys
	{
		public string Keys { get; set; }
	}

	public class Claves
	{
		public string CodigoMaterialSalon { get; set; }
		public string Keys { get; set; }
	}

	public class AsignMaterialRequest
	{
		public int CodigoMaterial { get; set; }
		public int Cantidad { get; set; }
		public int CodigoSalon { get; set; }
		public List<Claves> Keys { get; set; }
	}

	public class lMaterial
	{
		public int Codigo { get; set; }
		public string Description { get; set; }
		public string ModifiedDate { get; set; }
	}
	public class lMaterialOfAula
	{
		public int CodigoMaterialSalon { get; set; }
		public int Codigo { get; set; }
		public string Key { get; set; }
		public string Description { get; set; }
		public string Condicion { get; set; }
	}

	public class lSalon
	{
		public int Codigo { get; set; }
		public string Description { get; set; }
		public string ModifiedDate { get; set; }

	}

	public class lIngresos
	{
		public int Codigo { get; set; }
		public int CodigoMaterial { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		public int ActualQuantity { get; set; }
	}
	public class lDetalleIngresosOfMaterial
	{
		public int Codigo { get; set; }
		public int CodigoMaterial { get; set; }
		public string Type { get; set; }
		public string EntryDate { get; set; }
		public int Quantity { get; set; }
		public string DocumentNumber { get; set; }
		public int Price { get; set; }
	}

	public class lReportEspecifico
	{
		public int CodigoAula { get; set; }
		public string Aula { get; set; }
		public string UltInventario { get; set; }
		public List<lMaterialOfAula> Materiales { get; set; }
		public List<lConteroPorCondicion> Conteo { get; set; }
		public List<lGastos> Gastos { get; set; }
	}

	public class lReporteIndividualOfMaterial
	{
		public string CodigoMaterialSalon { get; set; }
		public string Key { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public string Responsible { get; set; }
		public string CreationDate { get; set; }
		public string Detail { get; set; }


	}
	public class lConteroPorCondicion
	{
		public string Condicion { get; set; }
		public int Cantidad { get; set; }
	}
	public class lGastos
	{
		public string Condicion { get; set; }
		public decimal Monto { get; set; }
	}

	public class lfechas
	{
		public int Codigo { get; set; }
		public string Date { get; set; }
	}
}
