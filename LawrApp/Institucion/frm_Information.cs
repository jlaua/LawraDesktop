﻿using System;
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

namespace LawrApp.Institucion
{
	public partial class frm_Information : MetroForm
	{
		private DataGeneral _data;
		private Thread _hilo;

		public frm_Information( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#region THREAD'S

		void LoadData()
		{

		}

		#endregion

	}
}
