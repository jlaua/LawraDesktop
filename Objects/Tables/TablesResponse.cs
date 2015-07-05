using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
    public class Distritos
    {
        public int Id { get; set; }
        public string Distrito { get; set; }
    }

    public class Provincias
    {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public List<Distritos> Distritos { get; set; }
    }

    public class Departamentos
    {
        public int Id { get; set; }
        public string Departamento { get; set; }
        public List<Provincias> Provincias { get; set; }
    }

    public class TipoDocumento
    {
        public int Id { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public int Length { get; set; }
        public bool IsNumeric { get; set; }
        public bool IsExactLength { get; set; }
    }

    public class LastSchool
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
    }

    public class TypeParent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int type { get; set; }
    }
    
	public class ListStudents
	{
		public int Codigo { get; set; }
		public string Key { get; set; }
		public string Names { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class GradoSeccion
	{
		public List<Grados> Grados { get; set; }
		public List<Secciones> Secciones { get; set; }
		public List<Niveles> Niveles { get; set; }
	}

	public class FillClases
	{
		public int Codigo { get; set; }
		public string Grado { get; set; }
		public string Seccion { get; set; }
		public string Nivel { get; set; }
		public string Turno { get; set; }
	}

	public class ListCursos
	{
		public int Codigo { get; set; }
		public string Name { get; set; }
		public string ModifiedDate { get; set; }
	}
}
