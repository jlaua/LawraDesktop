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
	public class Documents : Connection
	{
		private string _msgExceptionDocument;

		private tDocumentoAlumno _data = new tDocumentoAlumno();

		#region Propiedades

		public string MsgDocumentException
		{
			get { return this._msgExceptionDocument; }
		}

		public tDocumentoAlumno Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		#endregion

		#region Metodos

		public List<lDocumentos> List( int codAlumno )
		{
			Query query = new Query( "api/students/" + codAlumno + "/documents" );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "No se encontraron datos", "Documentos" );

				return JsonConvert.DeserializeObject<List<lDocumentos>>( query.ResponseContent );
			}
			catch ( Exception ex )
			{
				this._msgExceptionDocument = ex.Message;
				return null;
			}
		}

		public tDocumentoAlumno Find( int CodigoAlumno, int CodPariente )
		{
			Query query = new Query( "api/students/" + CodigoAlumno + "/documents/" + CodPariente );

			try
			{
				query.SendRequestGET();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( "Docoumentos no encontrados", "NO SE ENCONTRO NIUNGUN DOCUMENTO" );

				tDocumentoAlumno result = JsonConvert.DeserializeObject<tDocumentoAlumno>( query.ResponseContent );
				return result;
			}
			catch ( Exception ex )
			{
				this._msgExceptionDocument = ex.Message;
				return null;
			}
		}

		public int Create()
		{
			Query query = new Query( "api/students/" + this.Data.CodigoAlumno + "/documents" );

			if ( ! string.IsNullOrEmpty( this._data.ImageSrc ) && ! string.IsNullOrEmpty( this._data.ImageKey ) )
			{
				Dictionary<string, string> file = new Dictionary<string, string>();
				file.Add( this._data.ImageKey, this._data.ImageSrc );

				query.AddRequestFiles( file );
				this.Data.ImageSrc = string.Empty;
			}

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPOST();

				if ( query.ResponseStatusCode != HttpStatusCode.Created )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL REGISTRO EL DOCUMENTO" );

				return Convert.ToInt32( query.ResponseContent );
			}
			catch ( Exception e )
			{
				this._msgExceptionDocument = e.Message;
				return 0;
			}
		}

		public bool Modify()
		{
			Query query = new Query( "api/students/" + this.Data.CodigoAlumno + "/documents/" + this.Data.Codigo );

			string srcImage = this._data.ImageSrc;
			this.Data.ImageSrc = string.Empty;

			query.RequestParameters = this._data;

			if ( !string.IsNullOrEmpty( srcImage ) && !string.IsNullOrEmpty( this._data.ImageKey ) )
			{
				Dictionary<string, string> file = new Dictionary<string, string>();
				file.Add( this._data.ImageKey, srcImage );

				query.AddRequestFiles( file );
			}

			try
			{
				query.SendRequestPUT();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentNullException( query.MsgExceptionQuery, "ERROR AL REGISTRO EL DOCUMENTO" );

				return true;
			}
			catch ( Exception e )
			{
				this._msgExceptionDocument = e.Message;
				return false;
			}
		}

		public bool Delete( int codalumno, int codDocumento )
		{
			Query query = new Query( "api/students/" + codalumno + "/documents/" + codDocumento );

			try
			{
				query.SendRequestDELETE();

				if ( query.ResponseStatusCode != HttpStatusCode.OK )
					throw new ArgumentException( query.MsgExceptionQuery, "ERROR AL ELIMINARR UN DOCUMENTO" );

				return true;
			}
			catch ( Exception e )
			{
				this._msgExceptionDocument = e.Message;
				return false;
			}
		}

		#endregion 
	}
}
