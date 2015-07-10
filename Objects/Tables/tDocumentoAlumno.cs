using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Tables
{
	public class tDocumentoAlumno
	{
		public int Codigo { get; set; }
		public int CodigoAlumno { get; set; }
		public int CodigoTipoDocumento { get; set; }
		public string ImageSrc { get; set; }
		public string ImageKey { get; set; }
		public string DocumentNumber { get; set; }
		public string ExpirationDate { get; set; }
		public string ModifiedDate { get; set; }
	}
}
