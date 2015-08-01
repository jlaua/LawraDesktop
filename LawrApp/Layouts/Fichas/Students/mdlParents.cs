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
	public partial class mdlParents : MetroForm
	{
		Parents		_parent	   = new Parents();
		tApoderado _apoderados = new tApoderado();
		DataGeneral _data;

		private Thread _hilo;
		private int _codigoAlumno;
		private int _codigo;

		public mdlParents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region PROPIEDADES

		public int CodigoAlumno
		{
			get { return this._codigoAlumno; }
			set { this._codigoAlumno = value; }
		}

		public int Codigo
		{
			get { return this._codigo; }
			set { this._codigo = value; }
		}

		#endregion

		#region METODOS

		private void FindParents()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._apoderados = this._parent.Find( this._codigoAlumno, this._codigo );

			if ( this._apoderados != null )
			{
				this.lblNames.Text = this._apoderados.Names;
				this.lblLastNames.Text = this._apoderados.LastNames;
				this.lblGenero.Text = ( this._apoderados.Gender ) ? "Femenino" : "Masculino";
				this.lblBirthday.Text = this._apoderados.Birthday;
				this.lblAge.Text = Convert.ToInt32( ( ( ( DateTime.Now - Convert.ToDateTime( this._apoderados.Birthday ) ).TotalDays ) / 365 ) ).ToString();

				Object[] Parent = this._data.Tables["TipoApoderado"].Select( "Codigo=" + this._apoderados.CodigoTipoApoderado )[0].ItemArray;
				this.lblParent.Text = ( string ) Parent[1];

				Object[] Doc = this._data.Tables["TipoDocumento"].Select( "Codigo=" + this._apoderados.CodigoTipoDocumento )[0].ItemArray;
				this.lblType_Document.Text = ( string ) Doc[1];

				this.lblNumber_Document.Text = this._apoderados.DocumentNumber;
				this.lblAddress.Text = this._apoderados.Address;

				this.lblPhone.Text = ( string.IsNullOrEmpty(this._apoderados.Phone) ) ? " no registrado" : this._apoderados.Phone;
				this.lblEmail.Text = ( string.IsNullOrEmpty(this._apoderados.Email) ) ? " no registrado" : this._apoderados.Email;

				this.pgParent.Visible = false;
				this.panelmain.Enabled = true;
			}

			this._hilo.Abort();
		}

		#endregion

		private void frmData_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.FindParents ) );

			this.panelmain.Enabled = false;
			this.pgParent.Visible = true;

			this._hilo.Start();
		}
	}
}
