using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tPeriodoParametro
	{
		public int Codigo { get; set; }
		public int CodigoPeriodo { get; set; }
		public int TypePeriod { get; set; }
		public string WorkDays { get; set; }
		public string BreakTime { get; set; }
		public string AcademyHours { get; set; }
		public int maxMonth { get; set; }
		public string ModifiedDate { get; set; }
	}
}
