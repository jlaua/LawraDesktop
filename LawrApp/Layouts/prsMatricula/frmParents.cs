using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using Objects.Processes;
using Objects.Tables;
using Options;

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmParents : MetroForm
	{
		private DataGeneral _data;
		private int _lengthAllowed;
		private bool _isNumeric, _isExactLength;

		public string AddressOfSon
		{
			set { this.txtAddress.Text = value; }
		}

		public frmParents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region METODOS

		private DataTable TempDataTable( DataRow[] rows )
		{
			DataTable tempDt = new DataTable();

			tempDt.Columns.Add( new DataColumn( "Id", typeof( int ) ) );
			tempDt.Columns.Add( new DataColumn( "Name", typeof( string ) ) );
			tempDt.Columns.Add( new DataColumn( "Type", typeof( int ) ) );

			if ( rows.Length != 0 )
			{
				for ( int i = 0; i < rows.Length; i++ )
				{
					tempDt.Rows.Add( rows[i].ItemArray );
				}
			}

			return tempDt;
		}

		public void SendObjectToDatagrid()
		{
			Parent ObjParent = new Parent();

			IFrmAlumno IUAlumno = this.Owner as IFrmAlumno;

			if ( IUAlumno != null )
			{
				ObjParent.Names = txtNames.Text;
				ObjParent.LastName = TxtLasName.Text;
				ObjParent.GenderParent = ( cboSexo.SelectedIndex == 0 ) ? false : true;
				ObjParent.Birthday = dtpBirthday.Value.ToString( "yyyy-MM-dd" );
				ObjParent.TypeDocument = Convert.ToInt32( cboTypeDocument.SelectedValue );
				ObjParent.DocumentNumber = txtDocumentNumber.Text;
				ObjParent.TypeParent = Convert.ToInt32( cboparentesco.SelectedValue );
				ObjParent.Phone = txtPhones.Text;
				ObjParent.Email = txtEmail.Text;
				ObjParent.Address = txtAddress.Text;

				IUAlumno.AddParent( ObjParent, cboparentesco.Text, this.txtDocumentNumber.Text );

			}
		}

		public bool ValidarInformacionBasica()
		{
			//nombre del apoderado
			if ( string.IsNullOrWhiteSpace( this.txtNames.Text ) )
			{
				this.toltipValid.Show( "Nombre del Pariente es requerido", this.txtNames, 3000 );
				this.txtNames.Focus();
				return false;
			}

			//apellidos del apoderado
			if ( string.IsNullOrWhiteSpace( this.TxtLasName.Text ) )
			{
				this.toltipValid.Show( "Apellido del pariente es requerido", this.TxtLasName, 3000 );
				this.TxtLasName.Focus();
				return false;
			}

			//
			if ( this.cboSexo.Text == "Seleccione..." )
			{
				this.toltipValid.Show( "Sexo del pariente es requerido ", this.cboSexo, 3000 );
				this.cboSexo.Focus();
				return false;
			}

			if ( cboTypeDocument.Text == "Seleccione..." )
			{
				this.toltipValid.Show( "Minimo es un documento requerido  ", this.cboTypeDocument, 3000 );
				this.cboTypeDocument.Focus();
				return false;
			}

			if ( string.IsNullOrWhiteSpace( txtDocumentNumber.Text ) )
			{
				this.toltipValid.ShowAlways = true;
				this.toltipValid.Show( "Este campo es requerido", this.txtDocumentNumber, 3000 );
				this.txtDocumentNumber.Focus();
				return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtAddress.Text ) )
			{
				this.toltipValid.ShowAlways = true;
				this.toltipValid.Show( "Este campo es requerido", this.txtAddress, 3000 );
				this.txtAddress.Focus();
				return false;
			}

			if ( !string.IsNullOrWhiteSpace( txtEmail.Text ) && ( lbvcorreo.Visible == true ) )
			{
				return false;
			}

			if ( !Helper.ValidacionMayoriaDeEdad( this.dtpBirthday.Value ) )
			{
				this.toltipValid.Show( "El Apoderado debe ser mayor de edad", this.dtpBirthday, 3000 );
				this.dtpBirthday.Focus();
				return false;
			}

			return true;

		}

		public void ValidacionMayoriaDeEdad()
		{
			DateTime InputDate = new DateTime( this.dtpBirthday.Value.Year, this.dtpBirthday.Value.Month, this.dtpBirthday.Value.Day ).AddYears( 18 );
			DateTime InputDateMax = new DateTime( this.dtpBirthday.Value.Year, this.dtpBirthday.Value.Month, this.dtpBirthday.Value.Day ).AddYears( 85 );
			TimeSpan edadActual = DateTime.Now - InputDate;
			TimeSpan edadMax = DateTime.Now - InputDateMax;

			if ( edadActual.Days < 0 && edadMax.TotalDays < 0 )
			{
				this.lbValidationfechaNacimiento.Visible = true;
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Minimo 18 año de edad", dtpBirthday, 3000 );
			}
			else
				this.lbValidationfechaNacimiento.Visible = false;

		}

		public void LimpiarParent()
		{
			this.txtNames.Clear();
			this.TxtLasName.Clear();
			this.txtPhones.Clear();
			this.txtEmail.Clear();
			this.txtAddress.Clear();
			this.txtDocumentNumber.Clear();

			this.cboSexo.Text = "Seleccione...";
			this.cboparentesco.Text = "Seleccione...";
			this.cboTypeDocument.Text = "Seleccione...";

			this.txtDocumentNumber.Enabled = false;


			this.lbvalidacionname.Visible = true;
			this.lbvalidacionApellidos.Visible = true;
			this.lbValidacionsexo.Visible = true;
			this.lbValidacionTipoDocumento.Visible = true;
			this.lbValidactionParentesco.Visible = true;
			this.lbValidationfechaNacimiento.Visible = true;
			this.lbvalidacionDirection.Visible = true;

		}

		#endregion

		#region Eventos

		private void frmParents_Load( object sender, EventArgs e )
		{
			this.cboTypeDocument.ValueMember = "Id";
			this.cboTypeDocument.DisplayMember = "LongName";
			this.cboTypeDocument.DataSource = this._data.Tables["tipodocumento"];

			this.cboTypeDocument.SelectedIndex = -1;
			this.cboTypeDocument.Text = "Seleccione...";

		}

		private void txtNames_KeyPress( object sender, KeyPressEventArgs e )
		{
			e.Handled = Helper.solotexto( e.KeyChar );
		}

		private void txtNamesApoderados_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( txtNames.Text ) )
			{
				this.lbvalidacionname.Visible = true;
				toltipValid.ShowAlways = true;
				toltipValid.Show( "El Nombre del Pariente del alumno es rquerido", this.txtNames, 3000 );
			}
			else
				this.lbvalidacionname.Visible = false;

		}

		private void txtNamesApoderados_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( txtNames.Text ) )
			{
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Campo Nombre requerido", txtNames, 3000 );
			}
		}

		private void TxtLasName_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.TxtLasName.Text ) )
			{
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Campo Apellido requerido", this.txtNames, 3000 );
			}
		}

		private void TxtLasName_TextChanged_1( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this.TxtLasName.Text ) )
			{
				this.lbvalidacionApellidos.Visible = true;
				this.toltipValid.ShowAlways = true;
				this.toltipValid.Show( "El Apellido del Pariente del alumno es requerido", this.TxtLasName, 3000 );
			}
			else lbvalidacionApellidos.Visible = false;
		}

		private void TxtLasName_KeyPress( object sender, KeyPressEventArgs e )
		{
			e.Handled = Helper.solotexto( e.KeyChar );
		}

		//BOTON QUE ENVIA LOS DATOS
		private void btnAddParent_Click( object sender, EventArgs e )
		{
			if ( !ValidarInformacionBasica() ) return;

			SendObjectToDatagrid();
			this.Close();
		}

		private void dtpBirthday_Leave( object sender, EventArgs e )
		{
			ValidacionMayoriaDeEdad();
		}

		private void cboSexo_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

		private void cboSexo_Leave( object sender, EventArgs e )
		{
			if ( cboSexo.Text == "Seleccione..." )
			{
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Campo Sexo requerido", cboSexo, 3000 );
			}
		}

		private void cboSexo_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			this.cboparentesco.ValueMember = "Id";
			this.cboparentesco.DisplayMember = "Name";

			this.cboparentesco.DataSource = this._data.Tables["tipoapoderado"].Select( "Type=" + cbo.SelectedIndex ).CopyToDataTable();
			
			this.cboparentesco.SelectedIndex = -1;
			this.cboparentesco.Text = "Seleccione...";
		}

		private void txtAddress_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this.txtAddress.Text ) )
			{
				this.lbvalidacionDirection.Visible = true;
				this.toltipValid.ShowAlways = true;
				this.toltipValid.Show( "Direccion requerida", txtAddress, 3000 );
			}
			else
				this.lbvalidacionDirection.Visible = false;
		}

		private void txtAddress_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtAddress.Text ) )
			{
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Cammpo Ciudad requerido", this.txtAddress, 3000 );
			}
		}

		private void txtDocumentNumber_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( txtDocumentNumber.Text ) )
				this.lbvalidacionNumerDocumet.Visible = true; 
			else
				this.lbvalidacionNumerDocumet.Visible = false;
		}

		private void txtDocumentNumber_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( txtDocumentNumber.Text ) )
			{
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Cammpo Dni requerido", txtDocumentNumber, 3000 );
			}
		}

		private void txtDocumentNumber_KeyDown( object sender, KeyEventArgs e )
		{
			MetroTextBox txt = ( MetroTextBox ) sender;

			if ( e.KeyData != Keys.Back && e.KeyData != Keys.Delete )
			{
				if ( this._isNumeric )
				{
					if ( ( txt.Text.Trim() ).Length >= this._lengthAllowed || Helper.solonumeros( ( char ) e.KeyValue ) )
					{
						e.SuppressKeyPress = true;
					}
				}
				else
				{
					if ( ( txt.Text.Trim() ).Length >= this._lengthAllowed )
					{
						e.SuppressKeyPress = true;
					}
				}
			}
		}

		private void cboparentesco_Leave( object sender, EventArgs e )
		{
			if ( cboparentesco.Text == "Seleccione..." )
			{
				toltipValid.ShowAlways = true;
				toltipValid.Show( "Campo Parentesco requerido", cboparentesco, 3000 );
			}
		}

		private void cboparentesco_SelectionChangeCommitted( object sender, EventArgs e )
		{
			if ( cboparentesco.Text == "Seleccione..." )
				this.lbValidactionParentesco.Visible = true;
			else
				this.lbValidactionParentesco.Visible = false;
		}

		private void cboTypeDocument_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

		private void cboTypeDocument_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			this.txtDocumentNumber.Enabled = true;

			Object[] docs = this._data.Tables["tipodocumento"].Select( "Id=" + cbo.SelectedValue )[0].ItemArray;

			this._lengthAllowed		= ( int ) docs[3];
			this._isNumeric			= ( bool ) docs[4];
			this._isExactLength		= ( bool ) docs[5];

			this.lbValidacionTipoDocumento.Visible = false;
			this.txtDocumentNumber.Clear();
		}

		private void txtEmail_Leave( object sender, EventArgs e )
		{
			if ( !string.IsNullOrWhiteSpace( txtEmail.Text ) )
			{
				if ( Helper.CorreoElectronico( this.txtEmail.Text ) == false )
					this.lbvcorreo.Visible = true;
			}
		}

		private void txtEmail_TextChanged( object sender, EventArgs e )
		{
			if ( !string.IsNullOrWhiteSpace( txtEmail.Text ) )
			{
				if ( Helper.CorreoElectronico( this.txtEmail.Text ) == false )
					this.lbvcorreo.Visible = true;
				else
					this.lbvcorreo.Visible = false;
			}
			else
				this.lbvcorreo.Visible = false;
		}

		private void txtPhones_KeyPress( object sender, KeyPressEventArgs e )
		{
			Helper.IsPhone( sender, e, ',' );
		}

		#endregion

		private void dtpBirthday_ValueChanged( object sender, EventArgs e )
		{
			this.ValidacionMayoriaDeEdad();
		}
	}
}
