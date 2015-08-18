using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tInstitucion
	{
		public string Codigo { get; set; }
		public string Name { get; set; }
		public string FullAcronym { get; set; }
		public string ShortAcronym { get; set; }
		public string Creation { get; set; }
		public int Forma { get; set; }
		public int Gestion { get; set; }
		public int Gender { get; set; }
		public int Type { get; set; }
		public string ModularCode { get; set; }
		public string Resolution { get; set; }
		public string DRE { get; set; }
		public string UGEL { get; set; }
		public string Director { get; set; }
		public string WebPage { get; set; }
		public string History { get; set; }
		public string Vision { get; set; }
		public string Mision { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class tWelcome
	{
		public int Codigo { get; set; }
		public int CodigoInstitucion { get; set; }
		public string Description { get; set; }
		public string WhoSpeaks { get; set; }
		public string Office { get; set; }
		public int CodigoImagen { get; set; }
		public string ImageKey { get; set; }
		public string ImageSrc { get; set; }
		public string ModifiedDate { get; set; }
	}

}
