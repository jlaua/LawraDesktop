using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace LawrApp.Layouts.regPersonal
{
    public partial class frmFinParsonal : MetroForm
    {
        public frmFinParsonal()
        {
            InitializeComponent();
        }

        private void btnFindPersonal_Click(object sender, EventArgs e)
        {
            Layouts.regPersonal.regPersonal registrarPersonal = new Layouts.regPersonal.regPersonal();
            registrarPersonal.Show();
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Layouts.regPersonal.regPersonal frmregistroPersonal = new Layouts.regPersonal.regPersonal();
            frmregistroPersonal.Show();
            this.Close();
        }
    }
}
