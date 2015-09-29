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
using Options;

namespace LawrApp.Layouts.regAlumno
{
	public partial class frm_Registers : MetroForm, IAlumno 
	{
		DataGeneral _data;
		private Thread _hilo;
		private string _keyAlumno;

		private Alumnos alum = new Alumnos();
		private tAlumno _student = new tAlumno();

		private bool _IsNewShcool	= true;
		private bool _toActualize	= false;
		private bool _inAction		= false;
		private int _codSchool		= 0;
		private int _codigoAlumno	= 0;

		public frm_Registers( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

#region PROPIEDADES

		public bool ToActualize
        {
            get { return this._toActualize; }
            set { this._toActualize = value; }
        }

        public int CodigoAlumno
        {
            get { return this._codigoAlumno; }
            set { this._codigoAlumno = value; }
        }

		public string keyAlumno
		{
			get { return this._keyAlumno; }
			set{this._keyAlumno = value;}
		}

#endregion

#region METODOS

		// Metodo del la interfaz para aggregar informacion de la escuela de procedencia
		public void AddSchool( string Name, int Codigo, string Type )
		{
			this._IsNewShcool = false;
			this._codSchool = Convert.ToInt32( Codigo );
			this.txtAlumnoColegiaProcedencia.Text = Name;
			this.cbAlumnoTipoColegio.SelectedIndex = ( Type == "ESTATAL" ) ? 0 : 1;
		}

		public void ChooseStudent( string nameAlum, int idAlum ){}

		private void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( this._toActualize )
			{
				this.panelMain.Enabled = false;
				this.pgaAlumnoLoad.Visible = true;

				this._student = this.alum.FindStudents( this._codigoAlumno );

				this.txtnombre.Text = this._student.Names;
				this.txtapellidos.Text = this._student.LastNames;
				this.cbsexo.SelectedIndex = ( this._student.Gender ) ? 1 : 0;
				this.dtbirthday.Value = Convert.ToDateTime( this._student.Birthday );
				this.txtAlumnoColegiaProcedencia.Text = this._student.NameLastSchool;
				this.cbAlumnoTipoColegio.SelectedIndex = ( this._student.TypeLastSchool ) ? 1 : 0;
				this.txtAlumnoDireccion.Text = this._student.Address;
				this.txtobservacion.Text = this._student.Observation;

				string[] ubigeo = new string[3] 
				{ 
                    this._student.Ubigeo.Substring(0, 2), 
                    this._student.Ubigeo.Substring(2, 2), 
                    this._student.Ubigeo.Substring(4, 2),
                };

				this.cbDepartamento.SelectedValue = Convert.ToInt32( ubigeo[0] );

				//this.Invoke( ( MethodInvoker ) delegate() 
				//{
				//	this.cbAlumnoDepartamento_SelectionChangeCommitted( cbDepartamento, EventArgs.Empty );
				//});

				this.cbProvincia.SelectedValue = Convert.ToInt32( ubigeo[1] );
				//this.cbAlumnoProvincia_SelectionChangeCommitted( cbAlumnoProvincia, EventArgs.Empty );

				this.cbdistrito.SelectedValue		= Convert.ToInt32( ubigeo[2] );

				if ( pbAlumnoPerfilPicture != null )
				{
					this.pbAlumnoPerfilPicture.ImageLocation = this.alum.ConfigBaseUrl + this._student.ImageSrc;
				}
			}

			this.pgaAlumnoLoad.Visible = false;
			this.panelMain.Enabled = true;

			this.alum.ListSchool( _data );

			this._inAction = false;
			this._hilo.Abort();
		}

		private bool ChangedData()
		{
			bool result = this._student.Names == this.txtnombre.Text &&
							this._student.LastNames == this.txtapellidos.Text &&
							this._student.Gender == ( this.cbsexo.Text == "MASCULINO" ) ? false : true &&
							this._student.Birthday == this.dtbirthday.Text &&
							this._student.Address == this.txtAlumnoDireccion.Text &&
							this._student.NameLastSchool == this.txtAlumnoColegiaProcedencia.Text &&
							this._student.TypeLastSchool == ( this.cbAlumnoTipoColegio.Text == "ESTATAL" ) ? false : true &&
							this._student.Observation == this.txtobservacion.Text;
			return result;
		}

		private void JoinData()
		{
			this.alum.DataAlumno.Names			= this.txtnombre.Text;
			this.alum.DataAlumno.LastNames		= this.txtapellidos.Text;
			this.alum.DataAlumno.Birthday		= this.dtbirthday.Value.Date.ToString( "yyyy-MM-dd" );
			this.alum.DataAlumno.Address		= this.txtAlumnoDireccion.Text;
			this.alum.DataAlumno.Gender			= this.cbsexo.SelectedIndex == 0 ? false : true;
			this.alum.DataAlumno.Observation	= this.txtobservacion.Text;

			if ( this.pbAlumnoPerfilPicture.ImageLocation != null && this.pbAlumnoPerfilPicture.Image != null )
			{
				this.alum.DataAlumno.ImageKey = Helper.NameImageRandom( 10 );
				this.alum.DataAlumno.ImageSrc = this.pbAlumnoPerfilPicture.ImageLocation;
			}
			else
			{
				this.alum.DataAlumno.ImageKey = null;
				this.alum.DataAlumno.ImageSrc = null;
			}

			if ( this._IsNewShcool )
			{
				this.alum.DataAlumno.TypeLastSchool = this.cbAlumnoTipoColegio.SelectedIndex == 0 ? false : true;
				this.alum.DataAlumno.NameLastSchool = this.txtAlumnoColegiaProcedencia.Text;
			}
			else
			{
				this.alum.DataAlumno.CodigoUltimoColegio = _codSchool;
			}

			var depa = Convert.ToInt32( this.cbDepartamento.SelectedValue );
			var prov = Convert.ToInt32( this.cbProvincia.SelectedValue );
			var dist = Convert.ToInt32( this.cbdistrito.SelectedValue );

			string ubigeo = ( depa < 10 ) ? "0" + depa : depa.ToString();
			ubigeo += ( prov < 10 ) ? "0" + prov : prov.ToString();
			ubigeo += ( dist < 10 ) ? "0" + dist : dist.ToString();

			this.alum.DataAlumno.Ubigeo = ubigeo;
		}

		private bool ValidarInformacion()
		{
			if ( string.IsNullOrWhiteSpace( this.txtnombre.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Nombre del alumno  es requerido", this.lvAlumnoNombre, 3000 );
				this.txtnombre.Focus(); return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtapellidos.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "El Apellido del alumno es requerido", this.lvAlumnoApellido, 3000 );
				this.txtapellidos.Focus(); return false;
			}

			if ( this.cbsexo.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "No ha ingresado el sexo del alumno", this.lvAlumnoGenero, 3000 );
				this.cbsexo.Focus(); return false;
			}

			if ( !Helper.ValidarEdadMaximayMinima( this.dtbirthday.Value, 18, 5 ) )
			{
				this.lvAlumnoFechaNacimiento.Visible = true;
				toltipMore.ShowAlways = true;
				toltipMore.Show( "La fecha no cumple los parametros establecidos", this.lvAlumnoFechaNacimiento, 3000 );
				return false;
			}

			if ( this.cbDepartamento.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Departamento es requerido ", this.lbvdepartamento, 3000 );
				this.cbDepartamento.Focus(); return false;
			}

			if ( this.cbProvincia.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Provincia es requerida", this.lbvprovincia, 3000 );
				this.cbProvincia.Focus(); return false;
			}

			if ( this.cbdistrito.Text == "Seleccione..." )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "Distrito es requerido", this.lblvdistrito, 3000 );
				this.cbdistrito.Focus(); return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtAlumnoDireccion.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "La direccion es requerido", this.txtAlumnoDireccion, 3000 );
				this.txtAlumnoDireccion.Focus(); return false;
			}

			if ( string.IsNullOrWhiteSpace( this.txtAlumnoColegiaProcedencia.Text ) )
			{
				toltipMore.ShowAlways = true;
				toltipMore.Show( "La Colegio de procedencia es requerido", this.txtAlumnoColegiaProcedencia, 3000 );
				this.txtAlumnoColegiaProcedencia.Focus(); return false;
			}

			return true;
		}

		private void ResetControls()
		{
			this.txtnombre.Clear();
			this.txtapellidos.Clear();
			this.cbsexo.SelectedIndex = -1;
			this.cbsexo.Text = "Seleccione...";

			this.dtbirthday.Value = DateTime.Now;
			this.cbDepartamento.SelectedIndex = -1;
			this.cbDepartamento.Text = "Seleccione...";

			this.cbProvincia.DataSource = null;
			this.cbProvincia.Text = "Seleccione...";

			this.cbdistrito.DataSource = null;
			this.cbdistrito.Text = "Seleccione...";

			this.txtAlumnoDireccion.Clear();
			this.txtobservacion.Clear();
			this.pbAlumnoPerfilPicture.Image = null;

			this.txtAlumnoColegiaProcedencia.Clear();

			this.cbAlumnoTipoColegio.SelectedIndex = -1;
			this.cbAlumnoTipoColegio.Text = "Seleccione...";

			this._codSchool = 0;
			this._IsNewShcool = false;

			this.alum.DataAlumno.Address = null;
			this.alum.DataAlumno.Birthday = null;
			this.alum.DataAlumno.CodigoUltimoColegio = 0;
			this.alum.DataAlumno.ImageKey = null;
			this.alum.DataAlumno.ImageSrc = null;
			this.alum.DataAlumno.LastNames = null;
			this.alum.DataAlumno.Names = null;
			this.alum.DataAlumno.Gender = false;
			this.alum.DataAlumno.Ubigeo = null;
		}

		private void sendDataRegistro()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._inAction = true;

			if ( ! this._toActualize )
			{
				if ( this.alum.CreateStudent( true ) > 0 )
				{
					this.pgaAlumnoLoad.Visible = false;
					MetroMessageBox.Show( this, "El Alumno se ha Registrado satisfactoriamente", "Muy Bien!",
						MessageBoxButtons.OK, MessageBoxIcon.Question );
					this.Close();
				}
				else
				{
					this.pgaAlumnoLoad.Visible = false;
					MetroMessageBox.Show( this, this.alum.MsERegistrarAlumno, "Error!!", MessageBoxButtons.OK,
					MessageBoxIcon.Error );
					alum = new Alumnos();
				}
			}
			else
			{
				if ( this.alum.ModifyStudent( this._student.Codigo ) )
				{
					this.pgaAlumnoLoad.Visible = false;
					MetroMessageBox.Show( this, "El Alumno se ha Modificado satisfactoriamente", "Muy Bien!",
					MessageBoxButtons.OK, MessageBoxIcon.Question );

					this.Close();
				}
				else
				{
					this.pgaAlumnoLoad.Visible = false;
					MetroMessageBox.Show( this, this.alum.MsERegistrarAlumno, "Error!!", MessageBoxButtons.OK,
					MessageBoxIcon.Error );
					alum = new Alumnos();
				}
			}

			this._inAction = false;
			this._hilo.Abort();
		}

#endregion

#region EVENTOS

		private void frm_Registers_Load( object sender, EventArgs e )
		{
			this._hilo = new Thread( new ThreadStart( this.LoadData ) );

			this.cbDepartamento.ValueMember = "CodDepartamento";
			this.cbDepartamento.DisplayMember = "NombreDepartamento";
			this.cbDepartamento.DataSource = this._data.Tables["Departamentos"];

			this.cbDepartamento.SelectedIndex = -1;
			this.cbDepartamento.Text = "Seleccione...";
			this._inAction = true;

			this._hilo.Start();
		}

		private void frm_Registers_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( this._inAction )
				e.Cancel = true;
		}

	#region ClICK

		private void btnAlumnoguardar_Click( object sender, EventArgs e )
		{
			if ( !this.ValidarInformacion() ) return;
			
			this.btnguardar.Enabled = false;
			this.btncancelar.Enabled = false;
			this.btnAlumnoSearchPerfilPicture.Enabled = false;
			this.btnAlumnoColegioProcedencia.Enabled = false;
			this.pgaAlumnoLoad.Visible = true;

			this.ControlBox = false;

			this._hilo = new Thread( new ThreadStart( this.sendDataRegistro ) );

			if ( _toActualize )
			{
				if ( ! this.ChangedData() )
				{
					this.JoinData();
					this._inAction = true;

					this._hilo.Start();
				}
				else
				{
					this.Close();
				}
			}
			else
			{
				this.JoinData();
				this._inAction = true;

				this._hilo.Start();
			}
		}

		private void btncancelar_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btnAlumnoColegioProcedencia_Click( object sender, EventArgs e )
		{
			mdl_LastSchools Colegios = new mdl_LastSchools( this._data.Tables["UltimoColegio"] );
			Colegios.Owner = this;
			Colegios.ShowDialog(this);
		}
		
		private void btnAlumnoSearchPerfilPicture_Click( object sender, EventArgs e )
		{
			this.openPerfilPicture.Filter = "Images | *.jpg; *.png; *.jpeg";
			DialogResult result = this.openPerfilPicture.ShowDialog();

			if ( result == DialogResult.OK )
			{
				string src = this.openPerfilPicture.FileName;

				System.IO.FileInfo info = new System.IO.FileInfo(src);

				if ( ( info.Length / 1048576 ) < 5 )
				{
					this.pbAlumnoPerfilPicture.Load( src );
					this.lblpathPicture.Text = src;
					this.toltipMore.SetToolTip( this.lblpathPicture, src );
				}
				else
					MetroMessageBox.Show( this, "El Tamaño maximo para una imagen es de 5MB.", "LA imagen a superado el tamaño Maximo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}

	#endregion

	#region SELECTIONCHNGECOMMITTED

		private void cbDepartamento_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ( ComboBox ) sender );
			this.cbProvincia.ValueMember = "ClaveUbigeo";
			this.cbProvincia.DisplayMember = "NombreProvincia";

			this.cbProvincia.DataSource = this._data.Tables["Provincias"].Select( "Cod_Departamento=" + cbo.SelectedValue );

			this.cbProvincia.SelectedIndex = -1;
			this.lbvdepartamento.Visible = false;
			this.cbProvincia.Text = "Seleccione...";

			if ( this.cbdistrito.Items.Count > 0 ) this.cbdistrito.DataSource = null;

			this.cbdistrito.SelectedIndex = -1;
			this.cbdistrito.Text = "Seleccione...";
		}

		private void cbProvincia_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( ( ComboBox ) sender );

			var strQuery = this._data.Tables["Provincias"].Select( "ClaveUbigeo = " + cbo.SelectedValue + "AND Cod_Departamento=" +
			this.cbDepartamento.SelectedValue );

			DataRow[] codProvincia = strQuery;
			Object[] cods = codProvincia[0].ItemArray;

			this.cbdistrito.ValueMember = "ClaveUbigeo";
			this.cbdistrito.DisplayMember = "NombreDistrito";
			this.cbdistrito.DataSource = this._data.Tables["Distritos"].Select( "Cod_Provincia=" + cods[0].ToString() );
			this.cbdistrito.SelectedIndex = -1;
			this.lbvprovincia.Visible = false;
			this.cbdistrito.Text = "Seleccione...";
		}
		
		private void cbdistrito_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this.lblvdistrito.Visible = false;
		}
		
		private void cbAlumnoTipoColegio_SelectionChangeCommitted( object sender, EventArgs e )
		{
			this.lbvtipocolegio.Visible = false;
		}

	#endregion

	#region TEXTCHANGED

		private void txtAlumnoColegiaProcedencia_TextChanged( object sender, EventArgs e )
		{
			TextBox txt = ( TextBox ) sender;

			try
			{
				DataRow[] dt = this._data.Tables["UltimoColegio"].Select( "Name = '" + txt.Text + "'" );

				if ( dt.Length > 0 )
				{
					this._codSchool = Convert.ToInt32( dt[0]["Codigo"] );

					this.cbAlumnoTipoColegio.SelectedItem = dt[0]["TypeSchool"];
					this.cbAlumnoTipoColegio.Enabled = false;

					this._IsNewShcool = false;
				}
				else
				{
					this._codSchool = 0;

					this.cbAlumnoTipoColegio.SelectedIndex = -1;
					this.cbAlumnoTipoColegio.Text = "Seleccione";
					this.lbvtipocolegio.Visible = true;

					this._IsNewShcool = true;
				}

				if ( string.IsNullOrWhiteSpace( this.txtAlumnoColegiaProcedencia.Text.Trim() ) )
				{
					this.lvAlumnoColegioProcedencia.Visible = true;
					this.cbAlumnoTipoColegio.Enabled = false;
				}
				else
				{
					this.cbAlumnoTipoColegio.Enabled = true;
					this.lvAlumnoColegioProcedencia.Visible = false;
				}
			}
			catch ( Exception ex ) { }

		}
		
		private void txtAlumnonombre_TextChanged( object sender, EventArgs e )
		{
			if ( string.IsNullOrEmpty( this.txtnombre.Text ) )
				this.lvAlumnoNombre.Visible = true;
			else
				this.lvAlumnoNombre.Visible = false;

			if ( string.IsNullOrEmpty( this.txtapellidos.Text ) )
				this.lvAlumnoApellido.Visible = true;
			else
				this.lvAlumnoApellido.Visible = false;

			if ( string.IsNullOrEmpty( this.txtAlumnoDireccion.Text ) )
				this.lbVdireccion.Visible = true;
			else
				this.lbVdireccion.Visible = false;
		}

	#endregion

	#region LEAVE

		private void dtAlumnobirthday_Leave( object sender, EventArgs e )
		{
			DateTimePicker DatePicker = ( DateTimePicker ) sender;

			if ( !Helper.ValidarEdadMaximayMinima( DatePicker.Value, 18, 5 ) )
			{
				this.lvAlumnoFechaNacimiento.Visible = true;
				toltipMore.Show( "La fecha no cumple los parametros establecidos", this.lvAlumnoFechaNacimiento, 3000 );
			}
			else
				this.lvAlumnoFechaNacimiento.Visible = false;
		}

	#endregion

		private void cbDepartamento_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode != Keys.Down && e.KeyCode != Keys.Up )
				e.SuppressKeyPress = true;
		}

#endregion

	}
}
