using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Custom's
using Objects.Processes;
using Newtonsoft.Json;
using Objects.Tables;
using System.Net;
using RestSharp;
using Options;

namespace ControlMaterial
{
	public class Income_Expenses
	{
		private string _msgExptionInEx;
		private tKardex _data = new tKardex();

		public string EXception
		{
			get { return this._msgExptionInEx; }
			internal set { this._msgExptionInEx = value; }
		}

		public tKardex Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public bool Insert()
		{
			Query oQuery = new Query( "api/control/material/" + this._data.CodigoMaterial + "/income" );

			oQuery.RequestParameters = this._data;

			try
			{
				oQuery.SendRequestPOST();

				if ( oQuery.ResponseStatusCode == HttpStatusCode.InternalServerError )
					throw new ArgumentNullException( "Existe un error en el servidor:\n", "Error en el Servidor" );
				else if ( oQuery.ResponseStatusCode == HttpStatusCode.NotFound )
					throw new ArgumentNullException( "No se encontro recurso al cual acceder", "Recurso no encontrado" );

				msgResponse resp = JsonConvert.DeserializeObject<msgResponse>( oQuery.ResponseContent );

				if ( oQuery.ResponseStatusCode == HttpStatusCode.BadRequest )
					throw new InvalidOperationException( resp.message );

				return Convert.ToBoolean( resp.data );
			}
			catch ( Exception e )
			{
				this.EXception = e.Message;
				return false;
			}
		}
	}
}
