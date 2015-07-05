using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class Periodos
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }
		public string Description { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public bool IsActive { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class PeriodosParam
	{
		public int Codigo { get; set; }
		public int CodigoPeriodo { get; set; }
		public int TypePeriodo { get; set; }
		public string WorkDays { get; set; }
		public string BreakTimes { get; set; }
		public string AcademyHour { get; set; }
		public string MaxMonth { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class TypeFases
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class Fases
	{
		public int Codigo { get; set; }
		public int CodigoPeriodo { get; set; }
		public int CodigoTypeFase { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class FasesDivisiones
	{
		public int Codigo { get; set; }
		public int CodigoFase { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public bool IsActive { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class Niveles
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class Grados
	{
		public int Codigo { get; set; }
		public int CodigoNivel { get; set; }
		public string Name { get; set; }
		public int Preview { get; set; }
		public int Next { get; set; }
		public string Description { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class Secciones
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public char Character { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class Turnos
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class NivelesTurnos
	{
		public int Codigo { get; set; }
		public int CodigoTurno { get; set; }
		public int CodigoNivel { get; set; }
		public string EntryDate { get; set; }
		public string DepartDate { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class HorasClases
	{
		public int Codigo { get; set; }
		public int CodigoNivelturno { get; set; }
		public string HourStart { get; set; }
		public string HourEnd { get; set; }
		public string Type { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class Salones
	{
		public int Codigo { get; set; }
		public int MaxCapacity { get; set; }
		public string Observation { get; set; }
	}
}
