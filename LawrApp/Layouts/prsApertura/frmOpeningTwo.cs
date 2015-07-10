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
using Objects.Tables;

namespace LawrApp.Layouts.prsApertura
{
	public partial class frmOpeningTwo : MetroForm
	{
		List<tGrado> _grado = new List<tGrado>();
		List<tSeccion> _seccion = new List<tSeccion>();
		List<tTurno> _turno = new List<tTurno>();
		List<tNivel> _nivel = new List<tNivel>();
		
		tPeriodo _periodo;
		private bool _isNext = false;

		public frmOpeningTwo( tPeriodo age )
		{
			this._periodo = age;
			InitializeComponent();
		}

		#region METODOS

		private bool IsCompleteRequiredData()
		{
			//grados
			if ( this.dgvGrado.Rows[0].IsNewRow )
			{
				this.ttError.Show( "Este dato no puede estar vacio", this.dgvGrado, 2500 );
				this.dgvGrado.Focus();
				return false;
			}

			//Niveles
			if ( this.dgvNivel.Rows[0].IsNewRow )
			{
				this.ttError.Show( "Este dato no puede estar vacio", this.dgvNivel, 2500 );
				this.dgvNivel.Focus();
				return false;
			}

			//Seccion
			if ( this.dgvSeccion.Rows[0].IsNewRow )
			{
				this.ttError.Show( "Este dato no puede estar vacio", this.dgvSeccion, 2500 );
				this.dgvSeccion.Focus();
				return false;
			}

			//Turnos
			if ( this.dgvTurno.Rows[0].IsNewRow )
			{
				this.ttError.Show( "Este dato no puede estar vacio", this.dgvTurno, 2500 );
				this.dgvTurno.Focus();
				return false;
			}

			//Salones
			if ( this.dgvSalon.Rows[0].IsNewRow )
			{
				this.ttError.Show( "Este dato no puede estar vacio", this.dgvSalon, 2500 );
				this.dgvSalon.Focus();
				return false;
			}

			return true;
		}

		void ClearEmptyRows()
		{
			//grados
			if( ! this.dgvGrado.Rows[0].IsNewRow )
			{
				for( int i = 0; i < this.dgvGrado.Rows.Count; i++ )
				{
					if( this.dgvGrado.Rows[i].Cells[1].Value == null )
						this.dgvGrado.Rows.RemoveAt(i);
				}
			}

			//secciones
			if ( !this.dgvSeccion.Rows[0].IsNewRow )
			{
				for ( int i = 0; i < this.dgvSeccion.Rows.Count; i++ )
				{
					if ( this.dgvSeccion.Rows[i].Cells[1].Value == null )
						this.dgvSeccion.Rows.RemoveAt( i );
				}
			}

			//turnos
			if ( !this.dgvTurno.Rows[0].IsNewRow )
			{
				for ( int i = 0; i < this.dgvTurno.Rows.Count; i++ )
				{
					if ( this.dgvTurno.Rows[i].Cells[1].Value == null )
						this.dgvTurno.Rows.RemoveAt( i );
				}
			}

			//niveles
			if ( !this.dgvNivel.Rows[0].IsNewRow )
			{
				for ( int i = 0; i < this.dgvNivel.Rows.Count; i++ )
				{
					if ( this.dgvNivel.Rows[i].Cells[1].Value == null )
						this.dgvNivel.Rows.RemoveAt( i );
				}
			}

			//salones
			if ( !this.dgvSalon.Rows[0].IsNewRow )
			{
				for ( int i = 0; i < this.dgvSalon.Rows.Count; i++ )
				{
					if ( this.dgvSalon.Rows[i].Cells[1].Value == null )
						this.dgvSalon.Rows.RemoveAt( i );
				}
			}
		}

		void SaveObjectData()
		{
			foreach( DataGridViewRow row in this.dgvGrado.Rows )
			{
				if (! row.IsNewRow)
				{
					tGrado gr = new tGrado();
					object value = row.Cells[1].Value;

					gr.Name = value == null ? string.Empty : value.ToString();
					this._grado.Add(gr);
				}
			}

			//this._periodo.Grados = this._grado;
		}

		#endregion

		#region EVENTOS

		private void frmOpeningTwo_Load( object sender, EventArgs e )
		{

		}

		private void btnNext_Click( object sender, EventArgs e )
		{
			//this.ClearEmptyRows();

			//if ( !this.IsCompleteRequiredData() )
			//	return;

			//this.SaveObjectData();

			frmOpeningThree three = new frmOpeningThree();
			three.Show();
			this.Show();
		}

		#endregion

	}
}
