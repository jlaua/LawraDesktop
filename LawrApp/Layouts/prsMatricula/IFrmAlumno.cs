using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objects.Tables;

namespace LawrApp.Layouts.prsMatricula
{
	public interface IFrmAlumno
	{
		void AddDocuments( tDocumentoAlumno Odocument, string NameDoc );

		void AddParent( tApoderado OParent, string NameParent, string NameDocument );

		void AddSchool( string nameSchool, int idSchool, string type );
	}
}
