using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//custom
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using Institution;
using Objects.Tables;

namespace LawrApp.Institucion
{
	public partial class frm_Information : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;

		private Information _cInfo		= new Information();
		private tInstitucion _tInst		= new tInstitucion();
		private tInstitucion _tInst_old	= new tInstitucion();
		private bool _submitInsert		= false;
		private string _institutionCode	= string.Empty;
		private bool _noChanges			= true;

		public frm_Information( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._tInst = this._cInfo.Find();

			if( this._tInst == null )
			{
				this._submitInsert = true;
				this.pgsLoading.Visible = false;
				MetroMessageBox.Show( this, this._cInfo.ExceptionInfo, "Error en la consulta", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.panelMain.Enabled = true;
				this._tInst = new tInstitucion();
				this.txtNombre.Select();
			}
			else
			{
				//Guardando el Backup de los datos
				this._tInst_old = this._tInst;

				this._submitInsert = false;

				this._institutionCode = this._tInst.Codigo;

				this.txtNombre.Text = this._tInst.Name;
				this.lblNombreValidate.Visible = false;
				
				this.txtAcronimoLong.Text = this._tInst.FullAcronym;
				this.lblAcronimoValidate.Visible = false;
				this.txtAcronimoShort.Text = this._tInst.ShortAcronym;
				
				this.dtpCreation.Value = Convert.ToDateTime( this._tInst.Creation );
				
				this.cboForma.SelectedValue = this._tInst.Forma;
				this.lblFormaValidate.Visible = false;
				
				this.cboGestion.SelectedValue = this._tInst.Gestion;
				this.lblGestionValidate.Visible = false;
				
				this.cboGenero.SelectedValue = this._tInst.Gender;
				this.lblGeneroValidate.Visible = false;
				
				this.cboTipo.SelectedValue = this._tInst.Type;
				this.lblTipoValidate.Visible = false;

				this.txtCodigoMudular.Text = this._tInst.ModularCode;

				this.txtResolucion.Text = this._tInst.Resolution;
				this.lblResolucionValidate.Visible = false;
				
				this.txtDRE.Text = this._tInst.DRE;
				this.lblDREValidate.Visible = false;
				
				this.txtUGEL.Text = this._tInst.UGEL;
				this.lblUGELValidate.Visible = false;
				
				this.txtDirector.Text = this._tInst.Director;
				this.lblDirectorValidate.Visible = false;

				this.txtPaginaWeb.Text = this._tInst.WebPage;

				this.lblLastModified.Text = "Ult. Modificación: " + ( Convert.ToDateTime( this._tInst.ModifiedDate ) ).ToString( "dddd d \\de MMMM \\del yyyy a la\\s hh:mm:ss tt" );
				this.lblLastModified.Visible = true;

				this.pgsLoading.Visible = false;
				this.panelMain.Enabled = true;
				this.txtNombre.Focus();
				this._noChanges = true;
			}

			this._hilo.Abort();
		}

		void SubmitInsert(  )
		{
			CheckForIllegalCrossThreadCalls = false;
			
			string code = this._cInfo.Insert();

			if( code != null && code.Length == 10 )
			{
				this._tInst.Codigo = code;
				this._submitInsert = false;
				this._noChanges = true;
				this.lblLastModified.Text = "Ult. Modificación: " + DateTime.Now.ToString("dddd d \\de MMMM \\del yyyy a la\\s hh:mm:ss tt");
				this.lblLastModified.Visible = true;
				this.pgsLoading.Visible = false;
				panelMain.Enabled = true;
				MetroMessageBox.Show( this, "Acabas de crear tu Institución", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.btnHecho.Enabled = true;
				this.btnSalir.Enabled = true;
				this.ControlBox = true;
			}
			else
			{
				this.pgsLoading.Visible = false;
				panelMain.Enabled = true;
				MetroMessageBox.Show( this, this._cInfo.ExceptionInfo, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.btnHecho.Enabled = true;
				this.btnSalir.Enabled = true;
				this.ControlBox = true;
			}

			this._hilo.Abort();
		}

		void SubmitUpdate( )
		{
			CheckForIllegalCrossThreadCalls = false;

			bool wasUpdated = this._cInfo.Update();

			if ( wasUpdated )
			{
				this._noChanges = true;
				this._submitInsert = false;
				this.lblLastModified.Text = "Ult. Modificación: " + DateTime.Now.ToString( "dddd d \\de MMMM \\del yyyy a la\\s hh:mm:ss tt" );
				this.lblLastModified.Visible = true;
				this.pgsLoading.Visible = false;
				panelMain.Enabled = true;
				MetroMessageBox.Show( this, "Los datos se modificaron con exito", "Muy Bien!", MessageBoxButtons.OK, MessageBoxIcon.Question );
				this.btnHecho.Enabled = true;
				this.btnSalir.Enabled = true;
				this.ControlBox = true;
			}
			else
			{
				this.pgsLoading.Visible = false;
				panelMain.Enabled = true;
				MetroMessageBox.Show( this, this._cInfo.ExceptionInfo, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.btnHecho.Enabled = true;
				this.btnSalir.Enabled = true;
				this.ControlBox = true;
			}

			this._hilo.Abort();
		}

		#endregion

		#region FUNCIONES
		
		private DataTable FormaData()
		{
			DataTable table = new DataTable();

			table.Columns.Add( "Codigo", typeof( int ) );
			table.Columns.Add( "Description", typeof( string ) );

			object[] datos = new object[2]{ "Escolarizado", "No Escolarizado" };

			for( int i = 0; i < datos.Length; i++ )
			{
				object[] row = new object[2] { (i + 1), datos[i] };
				
				table.Rows.Add( row );
			}

			return table;
		}

		private DataTable GestionData()
		{
			DataTable table = new DataTable();

			table.Columns.Add( "Codigo", typeof( int ) );
			table.Columns.Add( "Description", typeof( string ) );

			object[] datos = new object[2] { "Publica", "Particular" };

			for ( int i = 0; i < datos.Length; i++ )
			{
				object[] row = new object[2] { ( i + 1 ), datos[i] };

				table.Rows.Add( row );
			}

			return table;
		}

		private DataTable GeneroData()
		{
			DataTable table = new DataTable();

			table.Columns.Add( "Codigo", typeof( int ) );
			table.Columns.Add( "Description", typeof( string ) );

			object[] datos = new object[3] { "Mixto", "Mujeres", "Hombres" };

			for ( int i = 0; i < datos.Length; i++ )
			{
				object[] row = new object[2] { ( i + 1 ), datos[i] };

				table.Rows.Add( row );
			}

			return table;
		}

		private DataTable TipoData()
		{
			DataTable table = new DataTable();

			table.Columns.Add( "Codigo", typeof( int ) );
			table.Columns.Add( "Description", typeof( string ) );

			object[] datos = new object[3] { "Unidocente Multigrado", "Polidocente Multigrado", "Polidocente Completo" };

			for ( int i = 0; i < datos.Length; i++ )
			{
				object[] row = new object[2] { ( i + 1 ), datos[i] };

				table.Rows.Add( row );
			}

			return table;
		}

		private bool ValidateDataRequired()
		{
			string textRequired = "Este Campo es Requerido";
			string textNotSelection = "Se debe Seleccionar un Valor";

			//NOMBRE DE LA INSTITUCION
			if( string.IsNullOrWhiteSpace( this._tInst.Name ) )
			{
				this.ttpValidator.Show( textRequired, this.lblNombreValidate );
				this.txtNombre.Focus();
				return false;
			}

			// ACRONIMO LARGO
			if( string.IsNullOrWhiteSpace( this._tInst.FullAcronym ) )
			{
				this.ttpValidator.Show( textRequired, this.lblAcronimoValidate );
				this.txtAcronimoLong.Focus();
				return false;
			}

			// ACRONIMO CORTO
			if( string.IsNullOrWhiteSpace( this._tInst.ShortAcronym ) )
			{
				this.ttpValidator.Show( textRequired, this.txtAcronimoShort );
				this.txtAcronimoShort.Focus();
				return false;
			}

			// FORMA DE LA INSTITUCIÓN
			if( this._tInst.Forma <= 0 )
			{
				this.ttpValidator.Show( textNotSelection, this.lblFormaValidate );
				this.cboForma.Focus();
				return false;
			}

			// GESTION DE LA INSTITUCIÓN
			if ( this._tInst.Gestion <= 0 )
			{
				this.ttpValidator.Show( textNotSelection, this.lblGestionValidate );
				this.cboGestion.Focus();
				return false;
			}

			// GENERO DE LA INSTITUCIÓN
			if ( this._tInst.Gender <= 0 )
			{
				this.ttpValidator.Show( textNotSelection, this.lblGeneroValidate );
				this.cboGenero.Focus();
				return false;
			}

			// TIPO DE INSTITUCIÓN
			if ( this._tInst.Type <= 0 )
			{
				this.ttpValidator.Show( textNotSelection, this.lblTipoValidate );
				this.cboTipo.Focus();
				return false;
			}

			// RESOLUCION DE LA INSTITUCIÓN
			if ( string.IsNullOrWhiteSpace( this._tInst.Resolution ) )
			{
				this.ttpValidator.Show( textRequired, this.lblResolucionValidate );
				this.txtResolucion.Focus();
				return false;
			}

			// DIRECCIÓN REGIONAL DE EDUCACIÓN (DRE)
			if ( string.IsNullOrWhiteSpace( this._tInst.DRE ) )
			{
				this.ttpValidator.Show( textRequired, this.lblDREValidate );
				this.txtDRE.Focus();
				return false;
			}

			// UNIDAD DE GESTIÓN EDUCATICA LOCAL (UGEL)
			if ( string.IsNullOrWhiteSpace( this._tInst.UGEL ) )
			{
				this.ttpValidator.Show( textRequired, this.lblUGELValidate );
				this.txtUGEL.Focus();
				return false;
			}

			// DIRECTOR ACTUAL DE LA INSTITUCIÓN
			if ( string.IsNullOrWhiteSpace( this._tInst.Director ) )
			{
				this.ttpValidator.Show( textRequired, this.lblDirectorValidate );
				this.txtDirector.Focus();
				return false;
			}

			return true;
		}

		#endregion

		private void frm_Information_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.cboGenero.DisplayMember = "Description";
			this.cboGenero.ValueMember = "Codigo";
			this.cboGenero.DataSource = this.GeneroData();
			this.cboGenero.SelectedIndex = -1;
			this.cboGenero.Text = "Seleccione...";

			this.cboGestion.DisplayMember = "Description";
			this.cboGestion.ValueMember = "Codigo";
			this.cboGestion.DataSource = this.GestionData();
			this.cboGestion.SelectedIndex = -1;
			this.cboGestion.Text = "Seleccione...";

			this.cboTipo.DisplayMember = "Description";
			this.cboTipo.ValueMember = "Codigo";
			this.cboTipo.DataSource = this.TipoData();
			this.cboTipo.SelectedIndex = -1;
			this.cboTipo.Text = "Seleccione...";

			this.cboForma.DisplayMember = "Description";
			this.cboForma.ValueMember = "Codigo";
			this.cboForma.DataSource = this.FormaData();
			this.cboForma.SelectedIndex = -1;
			this.cboForma.Text = "Seleccione...";

			//VALIDANDO FECHA MAXIMA EN EL CONTROL DATETIMEPICKER
			this.dtpCreation.MaxDate = DateTime.Today.AddMonths(6);

			this._hilo.Start();
		}

		private void btnHecho_Click( object sender, EventArgs e )
		{
			if ( !this.ValidateDataRequired() ) return;

			if ( this._submitInsert )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitInsert ) );

				this.btnHecho.Enabled = false;
				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;
				this.btnSalir.Enabled = false;
				this.ControlBox = false;

				this._cInfo.Data = this._tInst;

				this._hilo.Start();
			}
			else if( ! this._noChanges && ! this._submitInsert )
			{
				this._hilo = new Thread( new ThreadStart( this.SubmitUpdate ) );

				this.btnHecho.Enabled = false;
				this.panelMain.Enabled = false;
				this.pgsLoading.Visible = true;
				this.btnSalir.Enabled = false;
				this.ControlBox = false;

				this._cInfo.Data = this._tInst;

				this._hilo.Start();
			}
		}

		private void txtAcronimoLong_KeyDown( object sender, KeyEventArgs e )
		{
			this.txtAcronimoShort.Clear();

			string[] text = ( ( TextBox ) sender ).Text.Split( (char)Keys.Space );
			int i = 0;

			while( i < text.Length )
			{
				if( text[i].Length > 3 )
				{
					this.txtAcronimoShort.Text += text[i].Substring(0, 1);
				}

				i++;
			}

			if ( !this._submitInsert ) this._noChanges = false;
		}

		private void CboOnlyUpDown_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyData != Keys.Up && e.KeyData != Keys.Down )
			{
				e.SuppressKeyPress = true;
			}
		}

		private void VerifyDataChanges_TextBox_KeyDown( object sender, KeyEventArgs e )
		{
			if ( !this._submitInsert ) this._noChanges = false;
		}

		private void AsignDataAndValidate_TextBox_Leave( object sender, EventArgs e )
		{
			TextBox txt = ( (TextBox) sender );

			switch( txt.Name )
			{
				case "txtNombre":
					this._tInst.Name = txt.Text.Trim();
					this.lblNombreValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtAcronimoLong":
					this._tInst.FullAcronym = txt.Text.Trim();
					this.lblAcronimoValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtAcronimoShort":
					this._tInst.ShortAcronym = txt.Text.Trim();
					this.lblAcronimoValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtCodigoMudular":
					this._tInst.ModularCode = txt.Text.Trim();
				break;
				case "txtResolucion":
					this._tInst.Resolution = txt.Text.Trim();
					this.lblResolucionValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtDRE":
					this._tInst.DRE = txt.Text.Trim();
					this.lblDREValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtUGEL":
					this._tInst.UGEL = txt.Text.Trim();
					this.lblUGELValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtDirector":
					this._tInst.Director = txt.Text.Trim();
					this.lblDirectorValidate.Visible = ( string.IsNullOrWhiteSpace( txt.Text ) ) ? true : false;
				break;
				case "txtPaginaWeb":
					this._tInst.WebPage = ( (txt.Text.Trim()).Length > 10 ) ? txt.Text.Trim() : null;
				break;
			}
		}

		private void AsignDataAndValidate_ComboBox_Leave( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;

			switch( cbo.Name )
			{
				case "cboForma":
				this._tInst.Forma = ( int ) ( ( cbo.SelectedValue != null ) ? cbo.SelectedValue : 0 );
				this.lblFormaValidate.Visible = ( cbo.SelectedValue != null ) ? false : true;
				break;
				case "cboGestion":
				this._tInst.Gestion = ( int ) ( ( cbo.SelectedValue != null ) ? cbo.SelectedValue : 0 );
				this.lblGestionValidate.Visible = ( cbo.SelectedValue != null ) ? false : true;
				break;
				case "cboGenero":
				this._tInst.Gender = ( int ) ( ( cbo.SelectedValue != null ) ? cbo.SelectedValue : 0 );
				this.lblGeneroValidate.Visible = ( cbo.SelectedValue != null ) ? false : true;
				break;
				case "cboTipo":
				this._tInst.Type = ( int ) ( ( cbo.SelectedValue != null ) ? cbo.SelectedValue : 0 );
				this.lblTipoValidate.Visible = ( cbo.SelectedValue != null ) ? false : true;
				break;
			}
		}

		private void VerifyDataChanges_ComboBox_SelectionChangeCommited( object sender, EventArgs e )
		{
			if ( !this._submitInsert ) this._noChanges = false;
		}

		private void dtpCreation_Leave( object sender, EventArgs e )
		{
			DateTimePicker dtp = ( DateTimePicker ) sender;
			this._tInst.Creation = dtp.Value.ToString( "yyyy-MM-dd" );
		}

		private void dtpCreation_ValueChanged( object sender, EventArgs e )
		{
			if ( ! this._submitInsert ) this._noChanges = false;
		}

	}
}
