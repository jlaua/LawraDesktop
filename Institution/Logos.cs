using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Custom's
using Objects.Tables;
using Objects.Processes;
using Newtonsoft.Json;
using System.Net;
using Options;

namespace Institution
{
	public class Logos : Connection
	{
		private string _exceptionLogo, _resource = "api/institution/logos";
		private tMinLogos _data = new tMinLogos();
		private Dictionary<string, string> _file = new Dictionary<string, string>();

		public tMinLogos Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public string EXception
		{
			get { return this._exceptionLogo; }
			internal set { this._exceptionLogo = value; }
		}

		public List<tLogos> Listar()
		{
			Query oQuery = new Query( this._resource );

			try
			{
				oQuery.SendRequestGET();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<List<tLogos>>( resp.data );
			}
			catch( Exception ex )
			{
				this.EXception = ex.Message;
				return null;
			}
		}

		public tLogos Insert()
		{
			Query oQuery = new Query( this._resource );

			try
			{
				if ( this._file.Any() ) this._file.Clear();

				if ( !string.IsNullOrEmpty( this._data.Handle ) && !string.IsNullOrEmpty( this._data.Source ) )
				{
					this._file.Add( this._data.Handle, this._data.Source );
					this._data.Source = string.Empty;
				}

				oQuery.RequestParameters = this._data;

				if ( this._file.Any() )
					oQuery.AddRequestFiles( this._file );

				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tLogos>( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return null;
			}
		}

		public tLogos Update( int codigo )
		{
			Query oQuery = new Query( this._resource + "/" + codigo );

			try
			{
				if ( this._file.Any() ) this._file.Clear();

				if ( !string.IsNullOrEmpty( this._data.Handle ) && !string.IsNullOrEmpty( this._data.Source ) )
				{
					this._file.Add( this._data.Handle, this._data.Source );
					this._data.Source = string.Empty;
				}

				oQuery.RequestParameters = this._data;

				if ( this._file.Any() )
					oQuery.AddRequestFiles( this._file );

				oQuery.SendRequestPUT();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return JsonConvert.DeserializeObject<tLogos>( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return null;
			}
		}

		public bool Delete( int codigo )
		{
			Query oQuery = new Query( this._resource + "/" + codigo );

			try
			{
				oQuery.SendRequestDELETE();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n" + this.EXception, "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception ex )
			{
				this.EXception = ex.Message;
				return false;
			}
		}
	}
}
