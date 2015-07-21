using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawrApp.Layouts.regAlumno
{
	public interface IAlumno
	{
		void AddSchool( string Name, int Codigo, string Type );

		void ChooseStudent( string nameAlum, int idAlum );
	}
}
