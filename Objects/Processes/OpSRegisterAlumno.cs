using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Processes
{
    public class OpSRegisterAlumno
    {
        public string Names             { get; set; }
        public string LastName          { get; set; }
        public bool Sexo                { get; set; }
        public string Birthday          { get; set; }
        public string NameLastSchool    { get; set; }
        public int IdLastSchool			{ get; set; }
        public bool TypeLastSchool		{ get; set; }
        public string Address           { get; set; }
        public string Ubigeo            { get; set; }
        public string Imagesrc          { get; set; }
        public string ImageKey          { get; set; }
        public List<Parent> Parents     { get; set; }
        public List<Document> Documents { get; set; }
		public List<ExoneratedCours> ExoneratedCourses { get; set; }
    }

    public class Parent
    {
        public string Names             { get; set; }
        public string LastName          { get; set; }
        public bool GenderParent        { get; set; }
        public string Birthday          { get; set; }
        public int TypeParent           { get; set; }
        public int TypeDocument         { get; set; }
        public string DocumentNumber    { get; set; }
        public string Address           { get; set; }
        public string Phone             { get; set; }
        public string Email             { get; set; }
    }

    public class Document
    {
        public int tDocument { get; set; }
        public string Imagesrc { get; set; }
        public string ImageKey { get; set; }
        public string DocumentNumber { get; set; }
        public string Expire { get; set; }
    }

	public class ExoneratedCours
	{
		public int idCursesExonerate { get; set; }
		public string Oservation { get; set; }
	}
}
