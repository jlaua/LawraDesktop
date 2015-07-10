using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using Options;
using Objects.Tables;

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmDocumentos : MetroForm
	{
		private DataTable _data;
		private int _lengthAllowed;
		private bool _isNumeric, _isExactLength;

		public frmDocumentos( DataTable table )
		{
			this._data = table;
			InitializeComponent();
		}

		#region METODOS

		private void SendObjectToDatagrid()
		{
			IFrmAlumno IUAlumno		= this.Owner as IFrmAlumno;

			if ( IUAlumno != null )
			{
				tDocumentoAlumno ObjDocument	= new tDocumentoAlumno();

				ObjDocument.CodigoTipoDocumento = Convert.ToInt32( cboTypeDocument.SelectedValue );
				ObjDocument.DocumentNumber = txtNumberDocument.Text;

				if ( this.pbImageDocument.ImageLocation != null && this.pbImageDocument.Image != null )
				{
					ObjDocument.ImageSrc = this.pbImageDocument.ImageLocation;
					ObjDocument.ImageKey = Helper.NameImageRandom( 10 );
				}

				ObjDocument.ExpirationDate = ( this.chboExpira.CheckState == CheckState.Checked ) ? null : dtpExpiryDate.Value.ToString( "yyyy-MM-dd" );

				IUAlumno.AddDocuments( ObjDocument, this.cboTypeDocument.Text );
			}
		}

		#endregion

		#region EVENTOS

		private void frmDocumentos_Load( object sender, EventArgs e )
		{
			this.cboTypeDocument.ValueMember = "Codigo";
			this.cboTypeDocument.DisplayMember = "Name";
			this.cboTypeDocument.DataSource = this._data;

			this.cboTypeDocument.SelectedIndex = -1;
			this.cboTypeDocument.Text = "Seleccione...";
			
			this.lbVtipoDocumento.Visible = true;

			this.txtNumberDocument.Enabled = true;
		}

		private void chboExpira_CheckedChanged( object sender, EventArgs e )
		{
			CheckState chb = ( ( CheckBox ) sender ).CheckState;

			if ( chb == CheckState.Unchecked )
			{
				this.dtpExpiryDate.Enabled = true;
				this.lblDateExpire.Visible = true;
				this.dtpExpiryDate.Focus();
			}
			else
				this.dtpExpiryDate.Enabled = false;
		}

		private void btnSearchImageDocument_Click( object sender, EventArgs e )
		{
			DialogResult result = this.openImageDocument.ShowDialog();

			if ( result == DialogResult.OK )
			{
				string src = this.openImageDocument.FileName;
				pbImageDocument.Image = Image.FromFile( src );
				pbImageDocument.Load( src );
			}
		}

		private void btnAddDocumentToAlumno_Click( object sender, EventArgs e )
		{
			bool AddContinue = cboTypeDocument.Text != "Seleccione..." && !string.IsNullOrWhiteSpace( txtNumberDocument.Text );

			if ( ! AddContinue ) return;

			if ( chboExpira.CheckState == CheckState.Unchecked )
			{
				if ( ! Helper.ValidarFechaDeExpiracion( dtpExpiryDate.Value, 2 ) )
				{
					this.lblDateExpire.Visible = true;
					ttValidatorMessage.Show( "Maximo 2 dias antes de su fecha de vencimiento", this.lblDateExpire, 3000 );
					return;
				}
			}

			SendObjectToDatagrid();

			this.Close();
		}

		private void txtNumberDocument_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( txtNumberDocument.Text ) )
			{ this.lbVNumeroDocumento.Visible = true; }
			else { this.lbVNumeroDocumento.Visible = false; }

		}

		private void dtpExpiryDate_Leave( object sender, EventArgs e )
		{
			if ( chboExpira.CheckState != CheckState.Checked )
			{
				if ( !Helper.ValidarFechaDeExpiracion( dtpExpiryDate.Value, 2 ) )
				{
					this.lblDateExpire.Visible = true;
					ttValidatorMessage.Show( "Maximo 2 dias antes de su fecha de vencimiento", this.lblDateExpire, 3000 );

				}
				else
					this.lblDateExpire.Visible = false;
			}
		}

		private void txtNumberDocument_Leave( object sender, EventArgs e )
		{
			if ( !string.IsNullOrWhiteSpace( txtNumberDocument.Text.Trim() ) )
			{
				if ( this._isExactLength && txtNumberDocument.Text.Trim().Length != this._lengthAllowed )
				{
					ttValidatorMessage.Show( "La Cantidad de Digitos debe ser exacta a " + this._lengthAllowed, this.lbVNumeroDocumento, 3000 );
					this.lbVNumeroDocumento.Visible = true;
				}
			}
		}

		private void cboTypeDocument_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			if ( cbo.Text == "Seleccione..." )
				this.lbVtipoDocumento.Visible = true;
			else
				this.lbVtipoDocumento.Visible = false;

			if ( cbo.Text != "Seleccione" )
			{
				txtNumberDocument.Enabled = true;

				Object[] docs = this._data.Select( "Codigo=" + cbo.SelectedValue )[0].ItemArray;

				this._lengthAllowed = ( int ) docs[3];
				this._isNumeric = ( bool ) docs[4];
				this._isExactLength = ( bool ) docs[5];

				this.txtNumberDocument.Clear();
			}
		}

		private void txtNumberDocument_KeyDown( object sender, KeyEventArgs e )
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

		private void cboTypeDocument_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

		private void cboTypeDocument_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( cboTypeDocument.Text == "Seleccione..." )
			{
				lbVtipoDocumento.Visible = true;
			}
			else
				lbVtipoDocumento.Visible = false;
		}

		#endregion

	}
}
