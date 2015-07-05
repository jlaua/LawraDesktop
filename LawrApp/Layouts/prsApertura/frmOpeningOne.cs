using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//customs
using MetroFramework;
using MetroFramework.Forms;
using Options;
using Objects.Processes;

namespace LawrApp.Layouts.prsApertura
{
	public partial class frmOpeningOne : MetroForm
	{
		private string _msgRequired = "Este campo es requerido";
		private bool _isNext = false;
		private DataGeneral _data;
		private Periodo _periodo = new Periodo();
		private ParamPeriodo _param = new ParamPeriodo();

		public frmOpeningOne( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region METODOS

		private bool IsCompleteRequiredData()
		{
			int timeCloseTolTip = 1500;

			//año academico
			if ( this.cboyear.SelectedIndex < 0 )
			{
				this.ttError.Show( this._msgRequired, this.cboyear, timeCloseTolTip );
				this.cboyear.Focus();
				return false;
			}

			//tipo de año academico
			if ( this.cbotypeYear.SelectedIndex < 0 )
			{
				this.ttError.Show( this._msgRequired, this.cbotypeYear, timeCloseTolTip );
				this.cbotypeYear.Focus();
				return false;
			}

			//inicio del periodo
			int year = Convert.ToInt32( this.cboyear.Text );
			if ( ( this.dtpStartPeriod.Value.Year + 1 ) < year || this.dtpStartPeriod.Value.Year > year )
			{
				this.ttError.Show( "El inicio del periodo no puede ser programado\ncon mucho tiempo de espera.", this.dtpStartPeriod, timeCloseTolTip );
				this.dtpStartPeriod.Focus();
				return false;
			}

			//final del periodo
			TimeSpan diferencia = dtpEndPeriod.Value - dtpStartPeriod.Value;
			if ( diferencia.TotalDays <= 0 )
			{
				this.ttError.Show( "El final del periodo tiene que ser mayor al inicio.", this.dtpEndPeriod, timeCloseTolTip );
				this.dtpEndPeriod.Focus();
				return false;
			}

			//fechas que cumplen el tipo de año
			int[] types = new int[5] { 2, 3, 4, 6, 12};
			int diffMonths = this.DiffMonthsBetweenDate( this.dtpStartPeriod.Value, this.dtpEndPeriod.Value );
			if ( diffMonths < types[this.cbotypeYear.SelectedIndex] )
			{
				this.ttError.Show(
					"La cantidad mínima de meses aceptados es de: " + types[this.cbotypeYear.SelectedIndex] + " Meses.", 
					this.dtpEndPeriod, 
					2000 
				);

				this.dtpEndPeriod.Focus();
				return false;
			}

			int comp = this.dtpEndPeriod.Value.CompareTo( this.dtpStartPeriod.Value );

			//dias laborables
			if ( this.chklDaysAcademy.CheckedItems.Count == 0 )
			{
				this.ttError.Show( "Deberias seleccionar algunos dias.", this.chklDaysAcademy, timeCloseTolTip );
				this.chklDaysAcademy.Focus();
				return false;
			}

			//horas academicas
			if ( this.listHoursAcademy.Items.Count == 0 )
			{
				this.ttError.Show( "Deberias agregar al menos 1.", this.listHoursAcademy, timeCloseTolTip );
				this.listHoursAcademy.Focus();
				return false;
			}

			//duración del tiempo libre
			if ( this.listFreeTime.Items.Count == 0 )
			{
				this.ttError.Show( "Deberias agregar al menos 1.", this.listFreeTime, timeCloseTolTip );
				this.listFreeTime.Focus();
				return false;
			}

			//todo esta correcto
			return true;
		}

		public int DiffMonthsBetweenDate( DateTime dateFrom, DateTime dateTo )
		{
			int years = ( dateTo.Year - dateFrom.Year );
			int months = ( dateTo.Month - dateFrom.Month );
			int days = ( dateTo.Day - dateFrom.Day );

			if ( months < 0 )
			{
				years -= 1;
				months += 12;
			}

			if ( days < 0 )
			{
				months -= 1;
				days += DateTime.DaysInMonth( dateTo.Year, dateTo.Month );
			}

			if ( years > 0 )
			{
				months += 12;
			}

			return months;
		}

		void SaveObjectData()
		{
			_periodo.Name		= txtnameYear.Text;
			_periodo.Year		= Convert.ToInt32(cboyear.Text);
			_periodo.StartDate	= dtpStartPeriod.Value.ToString("yyyy-MM-dd");
			_periodo.EndDate	= dtpEndPeriod.Value.ToString("yyyy-MM-dd");

			//agregando parametros

			int[] types = new int[5] { 2, 3, 4, 6, 12};
			this._param.TypePeriod = types[ this.cbotypeYear.SelectedIndex ];

			//dias que trabajan
			List<int> daysWork = new List<int>();
			for ( int i = 0; i < this.chklDaysAcademy.CheckedItems.Count; i++ )
				daysWork.Add(i + 1);

			_param.WorkDays = string.Join( ",", daysWork );

			//horas academicas
			List<string> academyHours = new List<string>();
			for ( int i = 0; i < this.listHoursAcademy.Items.Count; i++ )
				academyHours.Add( this.listHoursAcademy.Items[i].ToString().Split(' ')[0] );

			_param.AcademicHour = string.Join( ",", academyHours );

			//tiempos libres
			List<string> FreeTimes = new List<string>();
			for ( int i = 0; i < this.listFreeTime.Items.Count; i++ )
				FreeTimes.Add( this.listFreeTime.Items[i].ToString().Split(' ')[0] );

			_param.BreakTime = string.Join( ",", FreeTimes );

			//uniendo los parametro con el periodo
			_periodo.Parameters = _param;

		}

		#endregion

		#region EVENTOS

		private void btnAddHoursAcademy_Click( object sender, EventArgs e )
		{
			var item = this.nudHoursAcademy.Value + " Min.";

			if ( !this.listHoursAcademy.Items.Contains( item ) )
			{
				this.listHoursAcademy.Items.Add( item );
				this.nudHoursAcademy.Value = 60;
				this.nudHoursAcademy.Focus();
			}
		}

		private void listHoursAcademy_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Delete && this.listHoursAcademy.Items.Count > 0 )
			{
				var index = this.listHoursAcademy.SelectedIndex;
				this.listHoursAcademy.Items.RemoveAt( index );
			}
		}

		private void btnAddFreeTime_Click( object sender, EventArgs e )
		{
			var item = this.nudFreeTime.Value + " Min.";

			if ( !this.listFreeTime.Items.Contains( item ) )
			{
				this.listFreeTime.Items.Add( item );
				this.nudFreeTime.Value = 20;
				this.listFreeTime.Focus();
			}
		}

		private void listFreeTime_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Delete && this.listFreeTime.Items.Count > 0 )
			{
				var index = this.listFreeTime.SelectedIndex;
				this.listFreeTime.Items.RemoveAt( index );
			}
		}

		private void btnNext_Click( object sender, EventArgs e )
		{
			if ( !this.IsCompleteRequiredData() )
				return;

			this.SaveObjectData();

			frmOpeningTwo stage = new frmOpeningTwo( this._periodo );
			stage.Show();
			this._isNext = true;
			this.Close();
		}

		private void frmOpeningConfigurations_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( !this._isNext )
			{
				frmMain main = new frmMain( this._data );
				main.Show();
			}
		}

		#endregion
	}
}
