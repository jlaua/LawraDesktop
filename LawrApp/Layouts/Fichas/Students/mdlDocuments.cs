using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using Registers.Students;
using System.Threading;
using Objects.Tables;

namespace LawrApp.Layouts.Fichas.Students
{
	public partial class mdlDocuments : MetroForm
	{
		private Documents _documentos = new Documents();
		private tDocumentoAlumno _document;
		private DataTable _data;
		private Thread _hilo;

		private int _codigoAlumno;
		private int _codigo;

		public mdlDocuments( DataTable table )
		{
			this._data = table;
			InitializeComponent();
		}

		#region PROPIEDADES

		public int Codigo
		{
			get { return this._codigo; }
			set { this._codigo = value; }
		}
		public int CodigoAlumno
		{
			get { return this._codigoAlumno; }
			set { this._codigoAlumno = value; }
		}

		#endregion

		#region HILOS

		private void FindDocumentSelected()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._document = this._documentos.Find( this._codigoAlumno, this._codigo );

			if ( this._document != null )
			{

				Object[] doc = this._data.Select( "Codigo=" + this._document.CodigoTipoDocumento )[0].ItemArray;

				this.lblName.Text = ( string ) doc[1];
				this.lblNumber.Text = this._document.DocumentNumber;
				this.lblFecha_Expiration.Text = ( this._document.ExpirationDate == null ) ? "Documento no expira" : this._document.ExpirationDate;

				if ( ! string.IsNullOrEmpty( this._document.ImageSrc ) )
				{
					this.pboImage.ImageLocation = this._documentos.ConfigBaseUrl + this._document.ImageSrc;
				}

				this.pgsLoading.Visible = false;
			}
			else
			{
				MetroMessageBox.Show( this, "No hay datos Registrados", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information );
				this.Close();
			}

			this._hilo.Abort();
		}

		#endregion

		private void frmDocumentos_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.FindDocumentSelected ) );
			this.pgsLoading.Visible = true;
			this._hilo.Start();
		}
	}
}
