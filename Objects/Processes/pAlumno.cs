using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Tables;

namespace Objects.Processes
{
    public class pAlumno
    {
		public tAlumno Alumno { get; set; }
		public List<tApoderado> Apoderado { get; set; }
		public List<tDocumentoAlumno> Documentos { get; set; }
		public List<tCursoExonerado> CursosExonerados { get; set; }
    }

	public class lAlumnos
	{
		public int Codigo { get; set; }
		public string Key { get; set; }
		public string Names { get; set; }
		public string ModifiedDate { get; set; }
	}
}
