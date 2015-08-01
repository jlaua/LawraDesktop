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
using Options;

namespace LawrApp.Layouts.regAlumno
{
	public partial class frm_Documents : MetroForm, IAlumno
	{
		private DataGeneral _data;
		private Documents _documents = new Documents();
		private tDocumentoAlumno _objDocuments = new tDocumentoAlumno();
		private Thread _hilo;

		private int _idAlumno		= 0;
		private int _idDocument		= 0;
		private string _srcImage	= "";

		private int _lengthAllowed;
		private bool _isNumeric, _isExactLength, _gotoModify = false;

		public frm_Documents( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

#region THREAD'S

		public void LoadDocumentsOfStudent()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lDocumentos> lista = this._documents.List( this._idAlumno );

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

					this.dgListDocumentos.Rows.Add( obj );
				}

				this.pgshowDocumentos.Visible = false;

			}
			else
			{
				this.pgshowDocumentos.Visible = false;
				MetroMessageBox.Show( this, "No hay datos Registrados", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}

			this.tabcontrolDocumentos.Enabled = true;
			this.PregistroDocumento.Enabled = false;
			this.pbuscarDocumentos.Enabled = true;
			this.btnNuevo.Enabled = true;

			this._hilo.Abort();
		}

		private void FindDocumentSelected()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._objDocuments = this._documents.Find( this._idAlumno, this._idDocument );

			if ( this._objDocuments != null )
			{
				this.cbotipoDocument.SelectedValue = this._objDocuments.CodigoTipoDocumento;
				this.cboDocumentotipoDocument_SelectionChangeCommitted( this.cbotipoDocument, null );

				this.txtNrodocumento.Text = this._objDocuments.DocumentNumber;

				if ( this._objDocuments.ExpirationDate != null )
				{
					this.chboExpira.CheckState = CheckState.Unchecked;
					this.dtFechaExpiracion.Enabled = true;
					this.dtFechaExpiracion.Text = this._objDocuments.ExpirationDate;
				}

				if ( !string.IsNullOrEmpty( this._objDocuments.ImageSrc ) )
				{
					this.pbImageDocument.ImageLocation = this._documents.ConfigBaseUrl + this._objDocuments.ImageSrc;
					this._objDocuments.ImageSrc = string.Empty;
					this._objDocuments.ImageKey = string.Empty;
				}
				
				this.gbDatosDocument.Enabled			= true;
				this.pgshowDocumentos.Visible			= false;
				this.btnagregardocumentos.Enabled		= true;
				this.lvDocumentoNumeroDocumento.Visible = false;

				this.PregistroDocumento.Enabled			= true;
				this.btnSearchImage.Enabled				= true;
				this.pbImageDocument.Enabled			= true;
			}
			else
			{
				this._objDocuments = new tDocumentoAlumno();
			}

			this._hilo.Abort();
		}

#endregion

#region METODOS DE INTERFAZ

		public void ChooseStudent( string nameAlumno, int idAlumno )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadDocumentsOfStudent ) );

			this.txtNameSelectedStudent.Text		= nameAlumno;
			this._idAlumno							= idAlumno;

			this.dgListDocumentos.Rows.Clear();

			this.tabcontrolDocumentos.SelectedTab	= this.tabListaDocument;
			this.ResetControls();
			this._hilo.Start();
		}

		public void AddSchool( string Name, int Codigo, string Type ){}

#endregion

#region METODOS

		private void SubmitDataForDeletion()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( this._documents.Delete( this._idAlumno, this._idDocument ) )
			{
				this.dgListDocumentos.Rows.RemoveAt( this.dgListDocumentos.CurrentRow.Index );
				this.pgshowDocumentos.Visible = false;
				this.ResetControls();
			}

			this._hilo.Abort();
		}

		private void SubmitDataForCreationOrModification()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( ! this._gotoModify )
			{
				int NewCodDocument = this._documents.Create();
				
				if ( NewCodDocument > 0 )
				{
					this.pgshowDocumentos.Visible = false;

					MetroMessageBox.Show( this, "El Documento se ha Registrado satisfactoriamente", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );

					object[] obj = new object[5] 
					{
 						NewCodDocument,
						this._data.Tables["TipoDocumento"].Select( "Codigo=" + this.cbotipoDocument.SelectedValue )[0].ItemArray[1].ToString(),
						this.txtNrodocumento.Text,
						( this.chboExpira.CheckState == CheckState.Unchecked ) ? this.dtFechaExpiracion.Value.ToString("yyyy-MM-dd") : null,
						DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
					};

					this.dgListDocumentos.Rows.Add( obj );

					ResetControls();
				}
				else
				{
					this.pgshowDocumentos.Visible = false;
					MetroMessageBox.Show( this, this._documents.MsgDocumentException, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.PregistroDocumento.Enabled = true;
					this.btnagregardocumentos.Enabled = true;
					this.Cancelar.Enabled = true;
				}
			}
			else
			{
				if ( this._documents.Modify() )
				{
					this.pgshowDocumentos.Visible = false;
					MetroMessageBox.Show( this, "El Documento se ha Modificado satisfactoriamente", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.dgListDocumentos.CurrentRow.Cells[1].Value = this._data.Tables["TipoDocumento"].Select( 
																											"Codigo=" + this.cbotipoDocument.SelectedValue 
																										)[0].ItemArray[1].ToString();
					this.dgListDocumentos.CurrentRow.Cells[2].Value = this.txtNrodocumento.Text;
					this.dgListDocumentos.CurrentRow.Cells[3].Value = ( this.chboExpira.CheckState == CheckState.Unchecked ) ? this.dtFechaExpiracion.Value.ToString( "yyyy-MM-dd" ) : null;
					this.dgListDocumentos.CurrentRow.Cells[4].Value = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );

					ResetControls();
				}
				else
				{
					this.pgshowDocumentos.Visible = false;
					MetroMessageBox.Show( this, this._documents.MsgDocumentException, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.PregistroDocumento.Enabled = true;
					this.btnagregardocumentos.Enabled = true;
					this.Cancelar.Enabled = true;
				}
			}

			this._hilo.Abort();
		}

		private void ResetControls()
		{
			this.cbotipoDocument.SelectedIndex		= -1;
			this.cbotipoDocument.Text				= "Seleccione...";
			this.lvDocuementoTipoDocumento.Visible	= true;
			this.lvDocumentoNumeroDocumento.Visible = true;
			this.dtFechaExpiracion.Enabled			= false;
			this.dgListDocumentos.Enabled			= true;
			this.btnNuevo.Enabled					= true;
			this.btnbuscaralumno.Enabled			= true;
			this.pbuscarDocumentos.Enabled			= true;
			this.PregistroDocumento.Enabled			= false;
			this.txtNrodocumento.Enabled			= false;
			this.dtFechaExpiracion.Value			= DateTime.Now;
			this.chboExpira.CheckState				= CheckState.Checked;
			this.pbImageDocument.Image				= null;

			this._srcImage							= null;
			this.lbrutaimagen.Text					= null;

			this.txtNrodocumento.Clear();
		}

		private void JoinData()
		{
			this._objDocuments.CodigoAlumno = this._idAlumno;
			this._objDocuments.CodigoTipoDocumento = Convert.ToInt32( this.cbotipoDocument.SelectedValue );
			this._objDocuments.DocumentNumber = this.txtNrodocumento.Text;

			if ( ! string.IsNullOrEmpty(this._srcImage) )
			{
				this._objDocuments.ImageSrc = this.pbImageDocument.ImageLocation;
				this._objDocuments.ImageKey = Helper.NameImageRandom( 10 );
			}

			this._objDocuments.ExpirationDate = ( this.chboExpira.CheckState == CheckState.Checked ) ? null : this.dtFechaExpiracion.Value.ToString( "yyyy-MM-dd" );

			this._documents.Data = this._objDocuments;
		}

#endregion

#region EVENTOS

		private void frmregDocumento_Load( object sender, EventArgs e )
		{
			this.tabcontrolDocumentos.SelectedTab = this.tabListaDocument;

			this.cbotipoDocument.ValueMember	= "Codigo";
			this.cbotipoDocument.DisplayMember	= "ShortName";
			this.cbotipoDocument.DataSource		= this._data.Tables["TipoDocumento"];

			this.cbotipoDocument.SelectedIndex = -1;
			this.lvDocuementoTipoDocumento.Visible = true;

			this.txtNrodocumento.Enabled = true;
		}

		private void frmregDocumento_FormClosing( object sender, FormClosingEventArgs e )
		{
			frmMain main = new frmMain( this._data );
			main.Show();
		}

	#region KEYDOWN

		private void cboDocumentotipoDocument_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

		private void dgsearchDocumentos_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Delete )
			{
				DialogResult question = MetroMessageBox.Show(
					this,
					"Esta Seguro que desea eliminar El Documento del Alumno : " + this.txtNameSelectedStudent.Text,
					"Advertencia!",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if ( question == DialogResult.Yes )
				{
					this._hilo = new Thread( new ThreadStart( this.SubmitDataForDeletion ) );

					this._idDocument = (int) this.dgListDocumentos.CurrentRow.Cells[0].Value;

					this.pbuscarDocumentos.Enabled = false;
					this.PregistroDocumento.Enabled = false;
					this.btnbuscaralumno.Enabled = false;
					this.pgshowDocumentos.Visible = true;

					this._hilo.Start();
				}
			}
			else if( e.KeyData == Keys.Enter )
			{
				if ( dgListDocumentos.CurrentRow.Index < 0 ) return;

				this._hilo = new Thread( new ThreadStart( this.FindDocumentSelected ) );

				this.pgshowDocumentos.Visible = true;
				this.btnagregardocumentos.Enabled = false;

				int index = this.dgListDocumentos.CurrentRow.Index;

				this._idDocument = Convert.ToInt32( this.dgListDocumentos.Rows[index].Cells[0].Value );

				this._gotoModify = true;
				this.cbotipoDocument.Enabled = false;

				this._hilo.Start();

				this.tabcontrolDocumentos.SelectedTab = this.tabregistrardocumentos;
			}
		}

		private void txtDocumentoNrodocumento_KeyDown( object sender, KeyEventArgs e )
		{
			MetroTextBox txt = ( MetroTextBox ) sender;

			if ( e.KeyData != Keys.Back && e.KeyData != Keys.Delete )
			{
				if ( this._isNumeric )
				{
					if ( ( txt.Text.Trim() ).Length >= this._lengthAllowed || Helper.solonumeros( ( char ) e.KeyValue ) )
						e.SuppressKeyPress = true;
				}
				else
				{
					if ( ( txt.Text.Trim() ).Length >= this._lengthAllowed )
						e.SuppressKeyPress = true;
				}
			}
		}

	#endregion

	#region SELECTIONCHANGECOMITTED

		private void cboDocumentotipoDocument_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			this.lvDocuementoTipoDocumento.Visible = false;
			this.txtNrodocumento.Enabled = true;

			Object[] docs = this._data.Tables["TipoDocumento"].Select( "Codigo=" + cbo.SelectedValue )[0].ItemArray;

			this._lengthAllowed = ( int ) docs[3];
			this._isNumeric = ( bool ) docs[4];
			this._isExactLength = ( bool ) docs[5];

			this.txtNrodocumento.Clear();
		}

	#endregion

	#region LEAVE

		private void txtDocumentoNrodocumento_Leave( object sender, EventArgs e )
		{
			if ( !string.IsNullOrWhiteSpace( this.txtNrodocumento.Text.Trim() ) )
			{
				if ( this._isExactLength && this.txtNrodocumento.Text.Trim().Length != this._lengthAllowed )
				{
					ttValidatorMessage.Show( "La Cantidad de Digitos debe ser exacta a " + this._lengthAllowed,
					this.lvDocumentoNumeroDocumento, 3000 );
					this.lvDocumentoNumeroDocumento.Visible = true;
				}
			}
		}

	#endregion

	#region CLICK

		private void btnbuscaralumno_Click( object sender, EventArgs e )
		{
			mdl_ListAlumno search = new mdl_ListAlumno( _data );
			search.Owner = this;
			search.ShowDialog( this );
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			this._gotoModify = false;
			
			this.ResetControls();
			
			this.PregistroDocumento.Enabled = true;
			this.btnSearchImage.Enabled		= true;
			this.gbDatosDocument.Enabled	= true;
			this.cbotipoDocument.Enabled	= true;

			this.tabcontrolDocumentos.SelectedTab = this.tabregistrardocumentos;

			this.cbotipoDocument.Focus();
		}

		private void dgsearchDocumentos_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex < 0 ) return;

			this._hilo = new Thread( new ThreadStart( this.FindDocumentSelected ) );

			this.pgshowDocumentos.Visible = true;
			this.btnagregardocumentos.Enabled = false;

			this._idDocument	= Convert.ToInt32( this.dgListDocumentos.Rows[e.RowIndex].Cells[0].Value );
			
			this._gotoModify				= true;
			this.cbotipoDocument.Enabled	= false;
			
			this._hilo.Start();

			this.tabcontrolDocumentos.SelectedTab = this.tabregistrardocumentos;
		}

		private void Cancelar_Click( object sender, EventArgs e )
		{
			this.ResetControls();
			this.tabcontrolDocumentos.SelectedTab = this.tabListaDocument;
		}

		private void btncancelar_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btnModificar_Click( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.FindDocumentSelected ) );

			this.pgshowDocumentos.Visible = true;
			this.btnagregardocumentos.Enabled = false;

			this._idDocument = Convert.ToInt32( this.dgListDocumentos.CurrentRow.Cells[0].Value );
			
			this._gotoModify				= true;
			this.cbotipoDocument.Enabled	= false;

			this._hilo.Start();

			this.tabcontrolDocumentos.SelectedTab = this.tabregistrardocumentos;
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			DialogResult question = MetroMessageBox.Show(
					this,
					"Esta Seguro que desea eliminar El Documento del Alumno : " + this.txtNameSelectedStudent.Text,
					"Advertencia!",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
			);

			if ( question == DialogResult.Yes )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitDataForDeletion ) );

				this._idDocument = ( int ) this.dgListDocumentos.CurrentRow.Cells[0].Value;

				this.pbuscarDocumentos.Enabled = false;
				this.PregistroDocumento.Enabled = false;
				this.btnbuscaralumno.Enabled = false;
				this.pgshowDocumentos.Visible = true;

				this._hilo.Start();
			}
		}

		private void btnDocuementoSearchImageDocument_Click( object sender, EventArgs e )
		{
			this.openImageDocument.Filter = "Images | *.jpg; *.png; *.jpeg";
			DialogResult result = this.openImageDocument.ShowDialog();

			if ( result == DialogResult.OK )
			{
				var src = this.openImageDocument.FileName;
				this.pbImageDocument.Load( src );
				this.lbrutaimagen.Text = src;
				this._srcImage = src;

			}
		}

		private void btnagregardocumentos_Click( object sender, EventArgs e )
		{
			bool AddContinue = this.cbotipoDocument.Text != "Seleccione..." &&
						!string.IsNullOrWhiteSpace( this.txtNrodocumento.Text );

			if ( ! AddContinue ) return;

			if ( chboExpira.CheckState == CheckState.Unchecked )
			{
				if ( !Helper.ValidarFechaDeExpiracion( this.dtFechaExpiracion.Value, 2 ) )
				{
					this.lvDocuementolDateExpire.Visible = true;
					ttValidatorMessage.Show( "Maximo 2 dias antes de su fecha de vencimiento",
					this.lvDocuementolDateExpire, 3000 );
					return;
				}
			}

			if ( ! this._gotoModify )
			{
				Object[] docs = this._data.Tables["TipoDocumento"].Select( "Codigo=" + this.cbotipoDocument.SelectedValue )[0].ItemArray;

				foreach ( DataGridViewRow row in this.dgListDocumentos.Rows )
				{
					if ( row.Cells[1].Value.ToString() == docs[1].ToString() || row.Cells[1].Value.ToString() == docs[2].ToString() )
					{
						AddContinue = false;
						break;
					}
				}

				if ( !AddContinue )
				{
					MetroMessageBox.Show( this, "Este tipo de documento ya esta registrado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}
			}

			this._hilo = new Thread( new ThreadStart( this.SubmitDataForCreationOrModification ) );

			this.btnagregardocumentos.Enabled	= false;
			this.btnbuscaralumno.Enabled		= false;
			this.pgshowDocumentos.Visible		= true;
			this.pbuscarDocumentos.Enabled		= false;
			this.PregistroDocumento.Enabled		= false;
			
			this.JoinData();
			
			this._hilo.Start();
		}

	#endregion

		private void chboExpira_CheckedChanged( object sender, EventArgs e )
		{
			CheckState chb = ( ( CheckBox ) sender ).CheckState;

			if ( chb == CheckState.Unchecked )
			{
				this.dtFechaExpiracion.Enabled = true;
				this.lvDocuementolDateExpire.Visible = true;
				this.dtFechaExpiracion.Focus();
			}
			else
				this.dtFechaExpiracion.Enabled = false;
		}

#endregion

	}
}
