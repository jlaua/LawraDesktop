using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Options;
using Objects.Processes;
using Objects.Tables;
using Newtonsoft.Json;
using System.Net;
using System.Data;

namespace Registers.Students
{
	public class Parents : Connection
	{
		private string _msgException;

		tApoderado _data = new tApoderado();

		#region Propiedades

		public string MsgExceptionParents
		{
			get { return this._msgException; }
			internal set { this._msgException = value; }
		}

		public tApoderado Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		#endregion

		#region Metodos

		public List<lApoderados> List( int CodigoStudents = 0 )
		{
			Query query = new Query( "api/students/" + CodigoStudents + "/parents" );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "ERROR EN LA BUSQUEDA", "HUBO UN ERROR EN LA BUSQUEDA DE LOS APODERADOS"  );
				else if ( query.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "LISTA VACIA", "NO SE ENCONTRARON APODERADOS ASIGNADOS A ESTE ALUMNO" );

				return JsonConvert.DeserializeObject<List<lApoderados>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this.MsgExceptionParents = ex.Message;
				return (new List<lApoderados>());
			}
		}

		public tApoderado Find( int CodigoStudents, int CodigoParent )
		{
			Query query = new Query( "api/students/" + CodigoStudents + "/parents/" + CodigoParent );
			
			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "Docoumentos no encontrados", "NO SE ENCONTRO NIUNGUN PARIENTE" );

				return JsonConvert.DeserializeObject<tApoderado>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this.MsgExceptionParents = ex.Message;
				return null;
			}
		}

		public int Insert( int CodigoStudent )
		{
			Query query = new Query( "api/students/" + CodigoStudent + "/parents" );

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPOST();

				if ( query.ResponseStatusCode != HttpStatusCode.Created )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL REGISTRAR UN PARIENTE" );

				return Convert.ToInt32( query.ResponseContent ); ;
			}
			catch ( Exception e )
			{
				this.MsgExceptionParents = e.Message;
				return 0;
			}
		}

		public bool Update( int CodigoStudent, int CodigoParent )
		{
			Query query = new Query( "api/students/" + CodigoStudent + "/parents/" + CodigoParent );

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPUT();

				if ( query.ResponseStatusCode != HttpStatusCode.Created )
					throw new ArgumentNullException( query.MsgExceptionQuery, "HUBO UN ERROR AL INTENTAR MODIFICAR AL APODERADO" );

				return Convert.ToBoolean( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this.MsgExceptionParents = e.Message;
				return false;
			}
		}

		public bool Delete( int CodigoStudent, int CodigoParent )
		{
			Query query = new Query( "api/students/" + CodigoStudent + "/parents/" + CodigoParent );
			try
			{
				query.SendRequestDELETE();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentException( query.MsgExceptionQuery, "ERROR AL ELIMINAR EL PARIENTE DEL ALUMNO" );

				return Convert.ToBoolean( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this.MsgExceptionParents = e.Message;
				return false;
			}
		}

		#endregion 
	}
}
