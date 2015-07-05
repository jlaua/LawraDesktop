using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Processes.Response
{
	public class ResponseParent
	{
		public string Names { get; set; }
		public string LastName { get; set; }
		public int TypeParent { get; set; }
		public string GenderParent { get; set; }
		public int TypeDocument { get; set; }
		public string DocumentNumber { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
	}

	public class ResponseDocument
	{
		public int TypeDocument { get; set; }
		public string DocumentNumber { get; set; }
		public string Expire { get; set; }
	}

	public class ResponseAlumno
	{
		public int Id { get; set; }
		public string Names { get; set; }
		public string LastName { get; set; }
		public string Sexo { get; set; }
		public string Birthday { get; set; }
		public int IdLastSchool { get; set; }
		public string Imagesrc { get; set; }
		public string Address { get; set; }
		public string Usuario { get; set; }
		public List<ResponseParent> Parents { get; set; }
		public List<ResponseDocument> Documents { get; set; }
	}

	public class ListAlumnos
	{
		public string Id { get; set; }
		public string Key { get; set; }
		public string Name { get; set; }
		public string type { get; set; }
	}
}
