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
using Objects.Processes;
using System.Threading;
using Objects.Tables;

namespace LawrApp.Layouts.Fichas.Students

{
	public partial class frmStudents : MetroForm
	{
		private int _codigo;
		private Thread _hilo;
		private DataGeneral _data;

		private tAlumno _student = new tAlumno();
		private Parents _cParents = new Parents();
		private Alumnos _cStudents = new Alumnos();
		private Documents _cDocuments = new Documents();

		public frmStudents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region PROPIEDADES

		public int Codigo
		{
			get { return this._codigo; }
			set { this._codigo = value; }
		}

		#endregion

		#region THREAD'S

		public void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			//
			// LISTANDO LOS DATOS DEL ALUMNO
			//
			this._student = this._cStudents.FindStudents( this._codigo );

			this.lblNames.Text = this._student.Names;
			this.ttpData.SetToolTip( this.lblNames, this._student.Names );
			
			this.lblLastNames.Text = this._student.LastNames;
			this.ttpData.SetToolTip( this.lblLastNames, this._student.LastNames );

			this.lblGenero.Text = ( this._student.Gender ) ? "Femenino" : "Masculino";
			this.ttpData.SetToolTip( this.lblGenero, ( this._student.Gender ) ? "Femenino" : "Masculino" );

			this.lblBrindthey.Text = this._student.Birthday;
			this.ttpData.SetToolTip( this.lblBrindthey, this._student.Birthday );

			string age = Convert.ToInt32( ( ( ( DateTime.Now - Convert.ToDateTime( this._student.Birthday ) ).TotalDays ) / 365 ) ).ToString() + "  " + "Años";
			this.lblAge.Text = age;
			this.ttpData.SetToolTip( this.lblAge, age );

			this.lblColegio_Procedencia.Text = this._student.NameLastSchool;
			this.ttpData.SetToolTip( this.lblColegio_Procedencia, this._student.NameLastSchool );

			this.lblType.Text = ( this._student.TypeLastSchool ) ? "Estatal" : "Privada";
			this.ttpData.SetToolTip( this.lblType, ( this._student.TypeLastSchool ) ? "Estatal" : "Privada" );

			this.lblAdress.Text = this._student.Address;
			this.ttpData.SetToolTip( this.lblAdress, this._student.Address );

			string[] ubigeo = new string[3] 
			{ 
                this._student.Ubigeo.Substring(0, 2), 
                this._student.Ubigeo.Substring(2, 2), 
                this._student.Ubigeo.Substring(4, 2),
            };

			object[] dep = this._data.Tables["Departamentos"].Select( "CodDepartamento=" + ubigeo[0] )[0].ItemArray;
			this.lblDepartament.Text = ( string ) dep[1];
			this.ttpData.SetToolTip( this.lblDepartament, ( string ) dep[1] );

			object[] Provincia = this._data.Tables["Provincias"].Select( "ClaveUbigeo=" + Convert.ToInt32( ubigeo[1] ) + " AND Cod_Departamento=" + ubigeo[0] )[0].ItemArray;
			this.lblProvince.Text = ( string ) Provincia[3];
			this.ttpData.SetToolTip( this.lblProvince, ( string ) Provincia[3] );

			object[] Distrito = this._data.Tables["Distritos"].Select( "ClaveUbigeo=" + Convert.ToInt32( ubigeo[2] ) + " AND Cod_Provincia=" + Provincia[0] )[0].ItemArray;
			this.lblDistrict.Text = ( string ) Distrito[3];
			this.ttpData.SetToolTip( this.lblDistrict, ( string ) Distrito[3] );

			if ( this.pbfoto != null )
			{
				this.pbfoto.ImageLocation = this._cStudents.ConfigBaseUrl + this._student.ImageSrc;
				this.ttpData.SetToolTip( this.pbfoto, this._cStudents.ConfigBaseUrl + this._student.ImageSrc );
			}

			this.PanelMain.Enabled = true;
			this.pgsLoading.Visible = false;

			//
			// LISTANDO DOCUMENTOS DEL ALUMNO
			//
			List<lDocumentos> lista = this._cDocuments.List( this._codigo );

			if ( lista != null && lista.Any() )
			{
				foreach ( lDocumentos item in lista )
				{
					object[] obj = new object[5] 
					{
						item.Codigo,
						item.Names,
						item.Number,
						item.Expiration,
						item.ModifiedDate
					};

					this.dgvDocumentos.Rows.Add( obj );
				}

				this.pgsLoadingDocument.Visible = false;
			}
			else
			{
				this.dgvDocumentos.Enabled = false;
				this.pgsLoadingDocument.Visible = false;
			}

			//
			// LISTANDO LOS APODERADOS DEL ALUMNO
			//
			List<lApoderados> list = this._cParents.List( this._codigo );

			if ( list.Any() )
			{
				foreach ( lApoderados item in list )
				{
					object[] objTemp = new object[3] 
					{
						item.Codigo,
						item.Names,
						item.TipoApoderado
					};

					this.dgvParientes.Rows.Add( objTemp );
				}

				this.pgsLoadingparientes.Visible = false;
			}
			else
			{
				this.dgvParientes.Enabled = false;
				this.pgsLoadingparientes.Visible = false;
			}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		public void OpenModalDocuments()
		{
			mdlDocuments Document = new mdlDocuments( this._data.Tables["TipoDocumento"] );
			Document.CodigoAlumno = this._codigo;
			Document.Codigo = Convert.ToInt32( this.dgvDocumentos.CurrentRow.Cells[0].Value );
			Document.Owner = this;
			Document.ShowDialog( this );
		}

		public void OpenModalParents()
		{
			mdlParents parientes = new mdlParents( this._data );
			parientes.CodigoAlumno = this._codigo;
			parientes.Codigo = Convert.ToInt32( this.dgvParientes.CurrentRow.Cells[0].Value );
			parientes.Owner = this;
			parientes.ShowDialog( this );
		}

		#endregion

		#region EVENTOS

		private void frmStudents_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.pgsLoadingDocument.Visible = true;
			this.pgsLoadingparientes.Visible = true;

			this._hilo.Start();
			this.ttpData.SetToolTip( this.pbfoto, "Hola!!" );
		}

		private void dgvParientes_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
				this.OpenModalParents();
		}

		private void dgvDocumentos_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
				this.OpenModalDocuments();
		}

		private void dgvDocumentos_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( this.dgvDocumentos.Rows.Count <= 0 )
				return;
			else
				this.OpenModalDocuments();
		}

		private void dgvParientes_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( this.dgvDocumentos.Rows.Count <= 0 )
				return;
			else
				this.OpenModalParents();
		}

		#endregion

		private void frmStudents_FormClosing( object sender, FormClosingEventArgs e )
		{
			frmSearchStudents search = new frmSearchStudents( this._data );
			search.Show();
		}
		
	}
}
