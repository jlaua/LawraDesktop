using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Objects.Processes;
using Objects.Tables;
using Options;
using System.Threading;
using MetroFramework;
using MetroFramework.Controls;
using Registers;

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmAlumno : MetroForm, IFrmAlumno
	{
		private Alumnos alum = new Alumnos();
		private DataGeneral _data;

		private bool _isNewStudent = false;
		private int _idClass;

		private bool _IsNewShcool = true;
		private int _codSchool = 0;

		private Thread _hilo;

		public frmAlumno( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region PROPIEDADES

		public bool IsNewStudent
		{
			get { return this._isNewStudent; }
			set { this._isNewStudent = value; }
		}

		public int IdClase
		{
			get { return this._idClass; }
			set { this._idClass = value; }
		}

		#endregion

		#region HILOS

		private void LoadDataTableLastSchool()
		{
			CheckForIllegalCrossThreadCalls = false;
			this.alum.ListSchool( this._data );
			List<tCurso> cursos =  this.alum.ListaCursos( this._idClass );

			foreach ( tCurso items in cursos )
			{
				var temp = new object[] 
				{
					items.Codigo,
					items.Name,
					"",
					false
				};
				this.dgcursosExonerados.Rows.Add( temp );
			}
		}

		#endregion

		#region METODOS DE INTERFAZ

		public void AddDocuments( tDocumentoAlumno Odocument, string NameDocument )
		{
			bool continuar = true;

			foreach ( DataGridViewRow row in this.dgvDocuments.Rows )
			{
				string nameDocumentInGrid = row.Cells[0].Value.ToString();

				if ( nameDocumentInGrid == NameDocument )
				{
					MetroMessageBox.Show( this, "el tipo de Documento: " + " " + NameDocument, ", ya esta asignado al alumno", MessageBoxButtons.OK, MessageBoxIcon.Information );
					continuar = false;
					break;
				}
			}

			if ( !continuar ) return;

			string strExpire	= ( string.IsNullOrEmpty( Odocument.ExpirationDate ) ) ? "No expira" : Odocument.ExpirationDate;
			bool hasImage		= ( string.IsNullOrEmpty( Odocument.ImageSrc ) ) ? false : true;

			object[] obj = new object[5] { NameDocument, Odocument.DocumentNumber, strExpire, hasImage, "" };
			
			this.dgvDocuments.Rows.Add( obj );

			alum.DataDocumento = Odocument;
		}

		public void AddParent( tApoderado Parient, string NameParent, string NameDocument )
		{
			bool continua	= true;

			foreach( DataGridViewRow row in this.dgvParents.Rows )
			{
				string nameParentInGrid = row.Cells[0].Value.ToString();
				
				if ( nameParentInGrid == NameParent )
				{
					MetroMessageBox.Show( this, "el tipo de Apoderado: " + " " + NameParent, ", ya esta asignado al alumno.", MessageBoxButtons.OK, MessageBoxIcon.Error );
					continua = false;
					break;
				}
			}

			if ( ! continua ) return;

			object[] obj = new object[4] { NameParent, ( Parient.Names + " " + Parient.LastNames ), NameDocument, "" };

			this.dgvParents.Rows.Add(obj);

			alum.DataApoderado = Parient;
		}

		public void AddSchool( string Name, int Codigo, string Type )
		{
			this._IsNewShcool = false;
			this._codSchool = Convert.ToInt32( Codigo );
			this.txtnombrecolegio.Text = Name;
			this.cbotipocolegio.SelectedItem = Type;
			this.lbvtipocolegio.Visible = false;
		}

		#endregion

		#region METODOS

		private void JoinDataStudent()
		{
			List<tCursoExonerado> cursoExonerado = new List<tCursoExonerado>();

			this.alum.DataAlumno.Names			= this.txtnombre.Text;
			this.alum.DataAlumno.LastNames		= this.txtapellidos.Text;
			this.alum.DataAlumno.Birthday		= this.dtpbirthday.Value.Date.ToString( "yyyy-MM-dd" );
			this.alum.DataAlumno.Address		= this.txtdireccion.Text;
			this.alum.DataAlumno.Gender			= this.cbosexo.SelectedIndex == 0 ? false : true;
			this.alum.DataAlumno.Observation	= this.txtotrasObservaciones.Text;

			if ( this.pbPerfilPicture.ImageLocation != null && pbPerfilPicture.Image != null )
			{
				this.alum.DataAlumno.ImageKey = Helper.NameImageRandom( 10 );
				this.alum.DataAlumno.ImageSrc = pbPerfilPicture.ImageLocation;
			}
			else
			{
				this.alum.DataAlumno.ImageKey = null;
				this.alum.DataAlumno.ImageSrc = null;
			}

			foreach ( DataGridViewRow row in dgcursosExonerados.Rows )
			{
				tCursoExonerado tempData = new tCursoExonerado();

				if ( ( bool ) row.Cells[3].Value )
				{
					tempData.CodigoCurso			= Convert.ToInt32( row.Cells[0].Value );
					tempData.Observation			= row.Cells[2].Value.ToString();

					this.alum.DataCursoExonerado	= tempData;

				}
			}

			if ( this._IsNewShcool )
			{
				this.alum.DataAlumno.TypeLastSchool = this.cbotipocolegio.SelectedIndex == 0 ? false : true;
				this.alum.DataAlumno.NameLastSchool = txtnombrecolegio.Text;
			}
			else
			{
				this.alum.DataAlumno.CodigoUltimoColegio = this._codSchool;
			}

			var depa = Convert.ToInt32( this.cbodepartamento.SelectedValue );
			var prov = Convert.ToInt32( this.cboprovincia.SelectedValue );
			var dist = Convert.ToInt32( this.cbodistrito.SelectedValue );

			string ubigeo = ( depa < 10 ) ? "0" + depa : depa.ToString();
			ubigeo += ( prov < 10 ) ? "0" + prov : prov.ToString();
			ubigeo += ( dist < 10 ) ? "0" + dist : dist.ToString();

			this.alum.DataAlumno.Ubigeo = ubigeo;
		}

		private void ResetControls()
		{
			txtnombre.Clear();
			txtapellidos.Clear();
			this.cbosexo.SelectedIndex = -1;
			this.cbosexo.Text = "Seleccione...";

			this.dtpbirthday.Value = DateTime.Now;
			this.cbodepartamento.SelectedIndex = -1;
			this.cbodepartamento.Text = "Seleccione...";

			this.cboprovincia.DataSource = null;
			this.cboprovincia.Text = "Seleccione...";

			this.cbodistrito.DataSource = null;
			this.cbodistrito.Text = "Seleccione...";

			this.txtdireccion.Clear();

			this.pbPerfilPicture.Image = null;
			this.lblUrlPerfilPicture.Text = "";

			this.txtnombrecolegio.Clear();

			this.cbotipocolegio.SelectedIndex = -1;
			this.cbotipocolegio.Text = "Seleccione...";

			this._codSchool = 0;
			this._IsNewShcool = false;

			this.dgvDocuments.Rows.Clear();
			this.dgvParents.Rows.Clear();

			this.alum.DataAlumno = new tAlumno();

			this.alum.DataDocumento = new tDocumentoAlumno();
			this.alum.DataApoderado = new tApoderado();
		}

		private void sendDataRegistro()
		{
			CheckForIllegalCrossThreadCalls = false;

			if ( this.alum.SendDataStudent( this._data ) > 0 )
			{
				this.pgsload.Visible = false;

				MetroMessageBox.Show(
					this, "El Alumno se ha Registrado satisfactoriamente", "Muy Bien!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Question
				);

				this.ResetControls();

				frmMatricula matri = new frmMatricula( this._data );
				matri.Show();
			}
			else
			{
				this.pgsload.Visible = false;
				MetroMessageBox.Show( this, this.alum.MsERegistrarAlumno, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		#endregion

		#region FUNCIONES

		private bool ValidarInformacionBasica()
		{
			if ( string.IsNullOrWhiteSpace( txtnombre.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Nombre del alumno  es requerido", this.lbVnombreAlumno, 3000 );
				this.txtnombre.Focus();
				return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtapellidos.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "El Apellido del alumno es requerido", this.lbVApellidoAlumno, 3000 );
				this.txtapellidos.Focus();
				return false;
			}

			if ( this.cbosexo.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "No ha ingresado el sexo del alumno", this.cbosexo, 3000 );
				this.cbosexo.Focus();
				return false;
			}

			if ( !Helper.ValidarEdadMaximayMinima( this.dtpbirthday.Value, 18, 5 ) )
			{
				lbVFecha.Visible = true;
				toltipMore.ShowAlways = true;
				toltipMore.Show( "La fecha no cumple los parametros establecidos", this.lbVFecha, 3000 );
				return false;
			}

			if ( this.cbodepartamento.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Departamento es requerido ", this.lbvdepartamento, 3000 );
				this.cbodepartamento.Focus();
				return false;
			}

			if ( this.cboprovincia.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Provincia es requerida", this.lbvprovincia, 3000 );
				this.cboprovincia.Focus();
				return false;
			}

			if ( this.cbodistrito.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Distrito es requerido", this.lblvdistrito, 3000 );
				this.cbodistrito.Focus();
				return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtdireccion.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "La direccion es requerido", txtdireccion, 3000 );
				this.txtdireccion.Focus();
				return false;
			}
			return true;
		}

		private bool validarInformacionAbanzada()
		{
			if ( string.IsNullOrWhiteSpace( this.txtnombrecolegio.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "El colegio de procedencia es requerido", this.lbvcolegioprocedencia, 3000 );
				this.txtnombrecolegio.Focus();
				return false;
			}

			if ( this.cbotipocolegio.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "El tipo colegio de procedencia es requerido", this.lbvtipocolegio, 3000 );
				this.txtnombrecolegio.Focus();
				return false;
			}
			if ( this.dgvParents.Rows.Count == 0 )
			{
				this.lbvpariente.Visible = true;
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Minimo un pariente", this.lbvpariente, 3000 );

				return false;
			}
			else
			{
				this.lbvpariente.Visible = false;
			}

			if ( this.dgvDocuments.Rows.Count == 0 )
			{
				this.lbdocumentos.Visible = true;
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Minimo un pariente", this.lbvpariente, 3000 );

				return false;
			}
			else if ( this.dgvDocuments.Rows.Count > 0 )
			{
				this.lbdocumentos.Visible = true;
			}


			return true;
		}

		#endregion

		#region EVENTOS

		private void frmPrsRegisterStudent_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadDataTableLastSchool ) );

			this.cbodepartamento.ValueMember = "CodDepartamento";
			this.cbodepartamento.DisplayMember = "NombreDepartamento";
			this.cbodepartamento.DataSource = this._data.Tables["Departamentos"];

			this.cbodepartamento.SelectedIndex = -1;
			this.cbodepartamento.Text = "Seleccione...";

			this.tabRegitroAlumno.SelectedTab = tabinfoBasica;
			this.potrasConfiguraciones.Enabled = false;

			this._hilo.Start();

			this.txtnombre.Select();
		}

		private void btnOpenFrmParents_Click( object sender, EventArgs e )
		{
			frmParents parents = new frmParents( this._data );
			parents.Owner = this;
			parents.AddressOfSon = this.txtdireccion.Text;
			parents.ShowDialog( this );
		}

		private void btnOpenFrmDocuments_Click( object sender, EventArgs e )
		{
			frmDocumentos doc = new frmDocumentos( this._data.Tables["TipoDocumento"] );
			doc.Owner = this;
			doc.ShowDialog( this );
		}

		private void btnSearchColegio_Click( object sender, EventArgs e )
		{
			frmSearchSchool School = new frmSearchSchool( this._data.Tables["UltimoColegio"] );
			School.Owner = this;
			School.ShowDialog( this );
		}

		private void cbosexo_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

		private void dgvDocuments_KeyDown( object sender, KeyEventArgs e )
		{
			int IndexRow;

			try
			{
				if ( e.KeyCode == Keys.Delete )
				{
					MetroGrid dg = ( ( MetroGrid ) ( sender ) );
					e.SuppressKeyPress = true;
					IndexRow = dg.CurrentRow.Index;
					alum.FindDocumentNumber( this.dgvDocuments.Rows[IndexRow].Cells[1].Value.ToString() );
					dg.Rows.RemoveAt( IndexRow );
				}
			}
			catch ( Exception ex )
			{
				MetroMessageBox.Show( this, "Se registro un error:\n" + ex.Message, "Error", MessageBoxButtons.OK,
																							MessageBoxIcon.Error );
			}
		}

		private void dgvParents_KeyDown( object sender, KeyEventArgs e )
		{
			int IndexRow;

			try
			{
				if ( e.KeyCode == Keys.Delete )
				{
					MetroGrid dg = ( ( MetroGrid ) ( sender ) );
					e.SuppressKeyPress = true;
					IndexRow = dg.CurrentRow.Index;
					alum.FindParentName( this.dgvParents.Rows[IndexRow].Cells[1].Value.ToString() );
					dg.Rows.RemoveAt( IndexRow );
				}
			}
			catch ( Exception ex )
			{
				MetroMessageBox.Show( this, "Se Registro un error:\n" + ex.Message, "ERROR!", MessageBoxButtons.OK,
																							 MessageBoxIcon.Error );
			}
		}

		private void txtnombre_KeyPress( object sender, KeyPressEventArgs e )
		{
			e.Handled = Helper.solotexto( e.KeyChar );
		}

		private void txtapellidos_KeyPress( object sender, KeyPressEventArgs e )
		{
			e.Handled = Helper.solotexto( e.KeyChar );
		}

		private void txtnombre_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtnombre.Text ) )
			{
				this.lbVnombreAlumno.Visible = true;
				this.toltipMore.ShowAlways = true;
				this.toltipMore.Show( "Ingrese el nombre del alumno", this.txtnombre, 3000 );
			}
			else
				lbVnombreAlumno.Visible = false;
		}

		private void txtapellidos_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtapellidos.Text ) )
			{
				this.lbVApellidoAlumno.Visible = true;
				this.toltipMore.ShowAlways = true;
				this.toltipMore.Show( "Campo Apellido requerido", this.txtapellidos, 2000 );
			}
			else
				this.lbVApellidoAlumno.Visible = false;
		}

		private void cbosexo_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( cbosexo.Text == "Seleccione..." )
				lbgenero.Visible = true;
			else
				lbgenero.Visible = false;
		}

		private void txtdireccion_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtdireccion.Text ) )
			{
				this.lbVdireccion.Visible = true;
				this.toltipMore.ShowAlways = true;
				this.toltipMore.Show( "Campo Direccion requerido", this.txtdireccion, 2000 );
			}
			else
				this.lbVdireccion.Visible = false;
		}

		private void dtpbirthday_Leave( object sender, EventArgs e )
		{
			DateTimePicker DatePicker = ( DateTimePicker ) sender;

			if ( !Helper.ValidarEdadMaximayMinima( DatePicker.Value, 18, 5 ) )
			{
				lbVFecha.Visible = true;
				toltipMore.Show( "La fecha no cumple los parametros establecidos", this.lbVFecha, 3000 );
			}
			else
				lbVFecha.Visible = false;
		}

		private void cbodepartamento_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ( ComboBox ) sender );
			this.cboprovincia.ValueMember = "ClaveUbigeo";
			this.cboprovincia.DisplayMember = "NombreProvincia";

			this.cboprovincia.DataSource = this._data.Tables["Provincias"].Select( "Cod_Departamento=" + cbo.SelectedValue );
			this.cboprovincia.SelectedIndex = -1;
			this.cboprovincia.Text = "Seleccione...";

			if ( this.cbodistrito.Items.Count > 0 ) this.cbodistrito.DataSource = null;

			this.cbodistrito.SelectedIndex = -1;
			this.cbodistrito.Text = "Seleccione...";
		}

		private void cboprovincia_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ( ComboBox ) sender );

			var strQuery = this._data.Tables["Provincias"].Select( "ClaveUbigeo = " + cbo.SelectedValue + "AND Cod_Departamento=" + this.cbodepartamento.SelectedValue );

			DataRow[] codProvincia =  strQuery;
			Object[] cods = codProvincia[0].ItemArray;

			this.cbodistrito.ValueMember = "ClaveUbigeo";
			this.cbodistrito.DisplayMember = "NombreDistrito";
			this.cbodistrito.DataSource = this._data.Tables["Distritos"].Select( "Cod_Provincia=" + cods[0].ToString() );
			this.cbodistrito.SelectedIndex = -1;
			this.cbodistrito.Text = "Seleccione...";
		}

		private void cbosexo_Leave( object sender, EventArgs e )
		{
			if ( this.cbosexo.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Este campo es requerido", this.cbosexo, 2000 );
			}
		}

		private void cbodepartamento_Leave( object sender, EventArgs e )
		{
			if ( this.cbodepartamento.Text == "Seleccione..." )
			{
				this.lbvdepartamento.Visible = true;
				this.toltipMore.ShowAlways = true;
				this.toltipMore.Show( "Este campo es requerido", this.cbodepartamento, 2000 );
			}
			else
				this.lbvdepartamento.Visible = false;
		}

		private void cboprovincia_Leave( object sender, EventArgs e )
		{
			if ( this.cboprovincia.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Provincia es requerido", this.cboprovincia, 2000 );
				this.lbvprovincia.Visible = true;
			}
			else
				this.lbvprovincia.Visible = false;
		}

		private void cbodistrito_Leave( object sender, EventArgs e )
		{
			if ( this.cbodistrito.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Distrito es requerido", this.cbodistrito, 2000 );
				this.lblvdistrito.Visible = true;
			}
			else
				this.lblvdistrito.Visible = false;
		}

		private void txtnombre_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( txtnombre.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Este campo es requerido", this.txtnombre, 2000 );
			}
		}

		private void txtapellidos_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtapellidos.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Este campo es requerido", this.txtapellidos, 2000 );
			}
		}

		private void txtdireccion_Leave( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( this.txtdireccion.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Direccion del alumno es requerido", this.txtdireccion, 2000 );
			}

		}

		private void cbodistrito_SelectionChangeCommitted( object sender, EventArgs e )
		{
			if ( this.cbodistrito.Text == "Seleccione..." )
				this.lblvdistrito.Visible = true;
			else
				this.lblvdistrito.Visible = false;
		}

		private void txtnombrecolegio_KeyDown( object sender, KeyEventArgs e )
		{
			if ( !Helper.solotexto( ( char ) e.KeyCode ) &&
					!Helper.solonumeros( ( char ) e.KeyCode )
					&& e.KeyData != Keys.Back
					&& e.KeyData != Keys.Right
					&& e.KeyData != Keys.Left )
			{
				e.SuppressKeyPress = true;
				return;
			}

			MetroTextBox txt = ( MetroTextBox ) sender;

			try
			{
				DataRow[] dt = this._data.Tables["UltimoColegio"].Select( "Name = '" + txt.Text + "'" );

				if ( dt.Length > 0 )
				{
					this._codSchool = Convert.ToInt32( dt[0]["Codigo"] );
					this.cbotipocolegio.SelectedItem = dt[0]["TypeSchool"];
					this._IsNewShcool = false;
				}
				else
				{
					this._codSchool = 0;
					this.cbotipocolegio.SelectedIndex = -1;
					this.cbotipocolegio.Text = "Seleccione";
					this._IsNewShcool = true;
				}
			}
			catch ( Exception ex ) { }
		}

		private void txtnombrecolegio_TextChanged_1( object sender, EventArgs e )
		{
			MetroTextBox txt = ( MetroTextBox ) sender;

			try
			{
				DataRow[] dt = this._data.Tables["UltimoColegio"].Select( "Name = '" + txt.Text + "'" );

				if ( dt.Length > 0 )
				{
					this._codSchool = Convert.ToInt32( dt[0]["Codigo"] );

					this.cbotipocolegio.SelectedItem = dt[0]["TypeSchool"];
					this.lbvtipocolegio.Visible = false;

					this._IsNewShcool = false;
				}
				else
				{
					this._codSchool = 0;

					this.cbotipocolegio.SelectedIndex = -1;
					this.cbotipocolegio.Text = "Seleccione";
					this.lbvtipocolegio.Visible = true;

					this._IsNewShcool = true;
				}

				if ( string.IsNullOrWhiteSpace( txtnombrecolegio.Text.Trim() ) )
				{
					this.lbvcolegioprocedencia.Visible = true;
					this.cbotipocolegio.Enabled = false;
				}
				else
				{
					this.cbotipocolegio.Enabled = true;
					this.lbvcolegioprocedencia.Visible = false;
				}
			}
			catch ( Exception ex ) { }
		}

		private void cbotipocolegio_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ComboBox ) sender;
			try
			{
				string fill = "Name = '" + this.txtnombrecolegio.Text.Trim() + "' and TypeSchool = '" + cbo.SelectedItem + "'";
				DataRow[] dt = this._data.Tables["TypeSchool"].Select( fill );

				if ( dt.Length > 0 )
				{
					this._codSchool = Convert.ToInt32( dt[0]["Codigo"] ); ;
					this._IsNewShcool = false;
				}
				else
				{
					this._codSchool = 0;
					this._IsNewShcool = true;
				}

				if ( cbo.SelectedItem == null )
					this.lbvtipocolegio.Visible = true;
				else
					this.lbvtipocolegio.Visible = false;
			}
			catch ( Exception ex ) { }
		}

		private void btnsiguieteInfAvanzada_Click( object sender, EventArgs e )
		{

			if ( validarInformacionAbanzada() == false ) return;

			this.txtnombre.Focus();

			this.pInfoAdvanced.Enabled = false;
			this.tabRegitroAlumno.SelectedTab = this.tabotrasconfig;
			this.potrasConfiguraciones.Enabled = true;
		}

		private void btnatrasOtrasConfiguraciones_Click( object sender, EventArgs e )
		{
			tabRegitroAlumno.SelectedTab = this.tabinfoAvanzada;
			this.pInfoAdvanced.Enabled = true;
			this.potrasConfiguraciones.Enabled = false;

		}

		private void btnsiguienteOConf_Click( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.sendDataRegistro ) );
			this.pgsload.Visible = true;

			this.JoinDataStudent();

			this._hilo.Start();
		}

		private void btmatras_Click( object sender, EventArgs e )
		{
			frmAsignaClase asign = new Layouts.prsMatricula.frmAsignaClase( this._data );
			asign.IsNewStudent = this._isNewStudent;
			asign.Show();
			this.Close();
		}

		#endregion

		#region EVENTOS WIZARD

		private void btnSearchPerfilPicture_Click( object sender, EventArgs e )
		{
			this.openPerfilPicture.Filter = "Images | *.jpg; *.png; *.jpeg";
			DialogResult result = this.openPerfilPicture.ShowDialog();

			if ( result == DialogResult.OK )
			{
				var src = this.openPerfilPicture.FileName;

				pbPerfilPicture.Load( src );

				lblUrlPerfilPicture.Text = src;
				toltipMore.SetToolTip( lblUrlPerfilPicture, src );
			}
		}

		private void btnInfoBasicNext_Click( object sender, EventArgs e )
		{
			int validos = 0;

			validos += string.IsNullOrWhiteSpace( this.txtnombre.Text ) ? 1 : 0;
			validos += string.IsNullOrWhiteSpace( this.txtapellidos.Text ) ? 1 : 0;
			validos += ( this.cbosexo.SelectedIndex < 0 ) ? 1 : 0;
			validos += ( this.cbosexo.SelectedIndex < 0 ) ? 1 : 0;
			validos += string.IsNullOrEmpty( this.txtdireccion.Text ) ? 1 : 0;
			validos += !Helper.ValidarEdadMaximayMinima( this.dtpbirthday.Value, 18, 5 ) ? 1 : 0;

			validos += ( this.cbodepartamento.Text == "Seleccione..." ) ? 1 : 0;
			validos += ( this.cboprovincia.Text == "Seleccione..." ) ? 1 : 0;
			validos += ( this.cbodistrito.Text == "Seleccione..." ) ? 1 : 0;

			if ( ValidarInformacionBasica() == false ) return;

			if ( validos > 0 ) return;

			this.pInfoAdvanced.Enabled = true;
			this.tabRegitroAlumno.SelectedTab = this.tabinfoAvanzada;
			this.pinfobasica.Enabled = false;

			this.txtnombrecolegio.Focus();
		}

		private void btnInfoAdvancedPreview_Click( object sender, EventArgs e )
		{
			this.pInfoAdvanced.Enabled = false;
			this.tabRegitroAlumno.SelectedTab = this.tabinfoBasica;
			this.pinfobasica.Enabled = true;
		}

		#endregion

		private void dgcursosExonerados_CellBeginEdit( object sender, DataGridViewCellCancelEventArgs e )
		{
			this.dgcursosExonerados.Rows[e.RowIndex].Cells[3].Value = true;
		}

		private void dgcursosExonerados_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			string text = this.dgcursosExonerados.Rows[e.RowIndex].Cells[2].Value.ToString();

			if( string.IsNullOrWhiteSpace( text ) )
			{
				this.dgcursosExonerados.Rows[e.RowIndex].Cells[3].Value = false;
			}
		}

	}
}
