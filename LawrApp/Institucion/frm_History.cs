using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Custom's
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Objects.Tables;
using Institution;

namespace LawrApp.Institucion
{
	public partial class frm_History : MetroForm
	{
		private History _cHistory = new History();
		public tInstitucion _tHistory = new tInstitucion();
		public Thread _hilo;
		private bool _noChanges = true;
		private bool _isNewData = true;

		private delegate void _forceFocusControl( RichTextBox ctr );

		public frm_History()
		{
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._tHistory = this._cHistory.Find();

			if( this._tHistory == null )
			{
				pgsLoading.Visible = false;
				this._tHistory = new tInstitucion();
				MetroMessageBox.Show( this, "MIENTRAS NO TENGAS UN INSTITUCIÓN REGISTRADA, NO PODRAS AGREGAR UNA HISTORIA. \n VE AL FORMULARIO DE REGISTRO DE INSTITUCIÓN", "NO SE ENCONTRO INSTITUCIÓN REGISTRADA", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
			else if( string.IsNullOrWhiteSpace( this._tHistory.History ) )
			{
				this._noChanges = true;
				this._isNewData = true;
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
			}
			else
			{
				this.rtxDetalle.Text = this._tHistory.History;
				this.lblCharacterCounter.Text = ( this.rtxDetalle.Text.Trim() ).Length + " Caracteres de 3000";
				this._noChanges = true;
				this._isNewData = false;
				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
			}

			this.ForceFocus( this.rtxDetalle );

			this._hilo.Abort();
		}

		void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;

			bool result = this._cHistory.Insert();

			if ( result )
			{
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._noChanges = true;
				this._isNewData = false;
				MetroMessageBox.Show( this, "Muy Bien, Acabas de Registrar tu Historia.", "Registro Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Question );
			}
			else
			{

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._noChanges = false;
				this._isNewData = true;
				MetroMessageBox.Show( this, this._cHistory.ExceptionHistory, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._hilo.Abort();
		}

		void SubmitUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			bool result = this._cHistory.Update();

			if ( result )
			{
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._noChanges = true;
				this._isNewData = false;
				MetroMessageBox.Show( this, "Muy Bien, Se Modifico tu historia.", "Modificación Satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Question );
			}
			else
			{
				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this._noChanges = false;
				this._isNewData = false;
				MetroMessageBox.Show( this, this._cHistory.ExceptionHistory, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this._hilo.Abort();
		}

		void ForceFocus( RichTextBox input )
		{
			if ( !this.InvokeRequired )
			{
				input.Focus();
				input.Select( input.Text.Length, 0);
			}
			else
			{
				_forceFocusControl fc = new _forceFocusControl( this.ForceFocus );
				this.Invoke( fc, new object[] { input } );
			}
		}

		#endregion

		private void frm_History_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this._hilo.Start();
		}

		private void rtxDetalle_KeyDown( object sender, KeyEventArgs e )
		{
			this._noChanges = false;
			RichTextBox rtx = ( ( RichTextBox ) sender );
			lblCharacterCounter.Text = ( ( rtx.Text.Trim() ).Length ) + " Caracteres de 3000";
			
			if( rtx.Text.Length > 255 )
			{
				lblCharacterCounter.ForeColor = MetroColors.Green;
			}
			else
			{
				lblCharacterCounter.ForeColor = MetroColors.Red;
			}
		}

		private void btnHecho_Click( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.rtxDetalle.Text.Trim() ) ) return;

			if ( ( this.rtxDetalle.Text.Trim() ).Length < 255 )
			{
				MetroMessageBox.Show( this, "LA CANTIDAD MINIMA ACEPTADA ES DE 255 CARACTERES", "EL TEXTO ES MUY CORTO", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			if ( ! this._noChanges && this._isNewData )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );
				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;

				this._tHistory.History = this.rtxDetalle.Text;

				this._cHistory.Data = this._tHistory;

				this._hilo.Start();
			}
			else if( ! this._noChanges && ! this._isNewData )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitUpdate ) );
				
				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;

				this._tHistory.History = this.rtxDetalle.Text;

				this._cHistory.Data = this._tHistory;

				this._hilo.Start();
			}
		}

		private void rtxDetalle_TextChanged( object sender, EventArgs e )
		{
			this._noChanges = false;

			RichTextBox rtx = ( ( RichTextBox ) sender );

			lblCharacterCounter.Text = rtx.Text.Length + " Caracteres de 3000";

			if ( rtx.Text.Length > 255 )
			{
				lblCharacterCounter.ForeColor = MetroColors.Green;
			}
			else
			{
				lblCharacterCounter.ForeColor = MetroColors.Red;
			}
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			if ( this._hilo.ThreadState == ThreadState.Running )
				this._hilo.Abort();

			this.Close();
		}
	}
}
