using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Custom's
using Newtonsoft.Json;
using Objects.Tables;
using System.Net;
using Options;

namespace Institution
{
	public class History
	{
		private string _exceptionHistory;
		private tInstitucion _data = new tInstitucion();

		public string ExceptionHistory
		{
			get { return this._exceptionHistory; }
			internal set { this._exceptionHistory = value; }
		}

		public tInstitucion Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public tInstitucion Find()
		{
			Query oQuery = new Query( "api/institution/history" );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
				{
					throw new ArgumentNullException( "No se Encontro un El registro de la Institución", "No se Encontró Institución" );
				}
				else if ( oQuery.ResponseStatusCode != HttpStatusCode.Found )
				{
					throw new ArgumentNullException( "Error en el Servidor la consulta a sido detenida" );
				}

				return JsonConvert.DeserializeObject<tInstitucion>( oQuery.ResponseContent );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return null;
			}
		}

		public bool Insert()
		{
			Query oQuery = new Query( "api/institution/history" );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotModified )
				{
					throw new ArgumentNullException( oQuery.ResponseContent, "NO SE REALIZÓ EL REGISTRO" );
				}
				else if ( oQuery.ResponseStatusCode != HttpStatusCode.Accepted )
				{
					throw new ArgumentNullException( "Error en el Servidor la consulta a sido detenida" );
				}

				return Convert.ToBoolean( oQuery.ResponseContent.Trim() );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return false;
			}
		}

		public bool Update()
		{
			Query oQuery = new Query( "api/institution/history/" + this._data.Codigo );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPUT( "put" );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotModified )
				{
					throw new ArgumentNullException( oQuery.ResponseContent, "NO SE ACTUALIZÓ EL REGISTRO" );
				}
				else if ( oQuery.ResponseStatusCode != HttpStatusCode.Accepted )
				{
					throw new ArgumentNullException( "Error en el Servidor la consulta a sido detenida" );
				}

				return Convert.ToBoolean( oQuery.ResponseContent.Trim() );
			}
			catch ( Exception e )
			{
				this.ExceptionHistory = e.Message;
				return false;
			}
		}
	}
}
