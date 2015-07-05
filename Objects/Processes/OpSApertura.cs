using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Processes
{
	public class Periodo
	{
		public string Name { get; set; }
		public int Year { get; set; }
		public string Description { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public bool Active { get; set; }
		public ParamPeriodo Parameters { get; set; }
		public List<fases> Fases { get; set; }
		public List<Niveles> Niveles { get; set; }
		public List<Turnos> Turnos { get; set; }
		public List<Grados> Grados { get; set; }
		public List<Secciones> Secciones { get; set; }
		public List<Salones> Salones { get; set; }
	}

	public class ParamPeriodo
	{
		public int TypePeriod { get; set; }
		public string WorkDays { get; set; }
		public string BreakTime { get; set; }
		public string AcademicHour { get; set; }
		public int MaxMonth { get; set; }
	}

	public class Divfases
	{
		public string Name { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public bool IsActive { get; set; }
	}

	public class fases
	{
		public int typePhase { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public bool IsActive { get; set; }
		public List<Divfases> DivPhases { get; set; }
	}

	public class ParamNiveles
	{
		public int MaxAge { get; set; }
		public int MinAge { get; set; }
		public int MonthChange { get; set; }
	}

	public class Niveles
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ParamNiveles Parameters { get; set; }
	}

	public class Turnos
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}

	public class Grados
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}

	public class Secciones
	{
		public string Name { get; set; }
		public string Character { get; set; }
	}

	public class Salones
	{
		public string Name { get; set; }
		public int MaxCapacity { get; set; }
		public string Observation { get; set; }
	}
}
