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
	public partial class frm_VisionMision : MetroForm
	{
		public TVisionMision _tvimi		= new TVisionMision();
		public TVisionMision _tvimi_old = new TVisionMision();
		public VisionMision _cvimi		= new VisionMision();
		public Thread _hilo;

		public bool _isChange = false;
		public bool _inAction = false;
		public bool _isNewData = false;

		private delegate void ReturnFocusToInput( MetroTextBox txt );

		public frm_VisionMision()
		{
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			this._tvimi = this._cvimi.Find();

			if ( this._tvimi == null )
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cvimi.ExceptionHistory, "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this._tvimi = new TVisionMision();
				this.ReturnFocus( this.txtVision );

				if ( string.IsNullOrEmpty( this._tvimi.Mision ) && string.IsNullOrEmpty( this._tvimi.Vision ) )
					this._isNewData = true;
				else
					this._isNewData = false;
			}
			else
			{
				if ( string.IsNullOrEmpty( this._tvimi.Mision ) && string.IsNullOrEmpty( this._tvimi.Vision ) )
					this._isNewData = true;
				else
					this._isNewData = false;

				this._tvimi_old = this._tvimi;
				this.txtVision.Text = this._tvimi.Vision;
				this.lblVision_Validate.Visible = ( string.IsNullOrEmpty( this._tvimi.Vision ) ) ? true : false;

				this.txtMision.Text = this._tvimi.Mision;
				this.lblMision_Validate.Visible = ( string.IsNullOrEmpty( this._tvimi.Mision ) ) ? true : false;

				this.panelMain.Enabled = true;
				this.pgsLoading.Visible = false;
				this.ReturnFocus( this.txtVision );
			}

			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;
			
			this._inAction = true;

			if ( this._cvimi.Insert() )
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, "SE REGISTRARON LOS DATOS CORRECTAMENTE", "TODO CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.panelMain.Enabled = true;
				this._isChange = false;
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cvimi.ExceptionHistory, "ERROR EN LA CONSTULTA", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this._isChange = true;
			}

			this.ReturnFocus( this.txtVision );
			this._inAction = false;
			this._hilo.Abort();
		}

		void SubmitUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._cvimi.Update() )
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, "SE MODIFICARON LOS DATOS CORRECTAMENTE", "TODO CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.panelMain.Enabled = true;
				this._isChange = false;
			}
			else
			{
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cvimi.ExceptionHistory, "ERROR EN LA CONSTULTA", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this._isChange = true;
			}

			this.ReturnFocus( this.txtVision );
			this._inAction = false;
			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ReturnFocus( MetroTextBox txt )
		{
			if ( ! this.InvokeRequired )
			{
				txt.Focus();
			}
			else
			{
				ReturnFocusToInput inp = new ReturnFocusToInput( ReturnFocus );
				this.Invoke( inp, new object[] { txt } );
			}
		}

		#endregion

		private void AsignAndValidate_MetroTextBox_Leave( object sender, EventArgs e )
		{
			MetroTextBox txt = ( MetroTextBox ) sender;

			switch( txt.Name )
			{
				case "txtVision":
					this._tvimi.Vision = txt.Text.Trim();
					this.lblVision_Validate.Visible = ( string.IsNullOrEmpty( this._tvimi.Vision ) ) ? true : false;
				break;
				case "txtMision":
					this._tvimi.Mision = txt.Text.Trim();
					this.lblMision_Validate.Visible = ( string.IsNullOrEmpty( this._tvimi.Mision ) ) ? true : false;
				break;
			}
		}

		private void frm_VisionMision_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );
			
			this._inAction = true;

			this._hilo.Start();
		}

		private void btnHecho_Click( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtMision.Text ) || string.IsNullOrWhiteSpace( this.txtVision.Text ) ) return;

			if ( this._isNewData )
				this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );
			else
				this._hilo = new Thread( new ThreadStart( this.SubmitUpdate ) );

			this.panelMain.Enabled = false;
			this.pgsLoading.Visible = true;
			this._inAction = true;

			this._cvimi.Data = this._tvimi;

			this._hilo.Start();
		}

		private void frm_VisionMision_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
			{
				e.Cancel = true;
			}
		}

		private void btnSalir_Click( object sender, EventArgs e )
		{
			this.Close();
		}
	}
}
