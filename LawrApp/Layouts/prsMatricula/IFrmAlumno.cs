using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objects.Processes;

namespace LawrApp.Layouts.prsMatricula
{
	public interface IFrmAlumno
	{
		void AddDocuments( Document Odocument, string NameDoc );

		void AddParent( Parent OParent, string NameParent, string NameDocument );

		void AddSchool( string nameSchool, int idSchool, string type );
	}
}
