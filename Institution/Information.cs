using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Objects.Tables;
using Options;
using System.Net;
using Objects.Tables;

namespace Institution
{
    public class Information : Connection
    {
		private string _exception;
		private tInstitucion _data =  new tInstitucion();

		public string ExceptionInfo
		{
			get { return this._exception; }
			internal set { this._exception = value; }
		}

		public tInstitucion Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public tInstitucion Find()
		{
			Query oQuery = new Query( "api/institution/information" );

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
			catch( Exception e )
			{
				this.ExceptionInfo = e.Message;
				return null;
			}
		}

		public string Insert()
		{
			Query oQuery = new Query( "api/institution/information" );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotModified )
				{
					throw new ArgumentNullException( "La Acción ha podido concluir, verifique sus datos y vuelva a intentarlo", "Regristro ó Modificación" );
				}
				else if ( oQuery.ResponseStatusCode != HttpStatusCode.Created )
				{
					throw new ArgumentNullException( "Error en el Servidor la consulta a sido detenida" );
				}

				return (oQuery.ResponseContent.Replace('"', ' ') ).Trim();
			}
			catch ( Exception e )
			{
				this.ExceptionInfo = e.Message;
				return null;
			}
		}

		public bool Update()
		{
			Query oQuery = new Query( "api/institution/information/" + this._data.Codigo );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPUT("put");

				if ( oQuery.ResponseStatusCode == HttpStatusCode.NotModified )
				{
					throw new ArgumentNullException( "La Acción ha podido concluir, verifique sus datos y vuelva a intentarlo", "Regristro ó Modificación" );
				}
				else if ( oQuery.ResponseStatusCode != HttpStatusCode.Accepted )
				{
					throw new ArgumentNullException( "Error en el Servidor la consulta a sido detenida" );
				}

				return Convert.ToBoolean( oQuery.ResponseContent );
			}
			catch ( Exception e )
			{
				this.ExceptionInfo = e.Message;
				return false;
			}
		}
		
    }
}
