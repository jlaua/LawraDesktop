using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using Options;
namespace LawrApp.Layouts.regPersonal
{
    public partial class regPersonal : MetroForm
    {
        public regPersonal()
        {
            InitializeComponent();
            FocusMe();
        }
        #region Metodos
        public void ValidarCamposPersonal()
        {
            foreach (Control ControlPersonal in this.PanelPersonal.Controls)
            {
                if (ControlPersonal is MetroTextBox)
                {

                    if ((ControlPersonal.Name == "TxtNamePersonal"))
                    {
                        string nombtres = ControlPersonal.Text;
                        if (string.IsNullOrEmpty(nombtres))
                            lbValidacionnamePersonal.Visible = true;
                        else
                            lbValidacionnamePersonal.Visible = false;
                    }
                    if ((ControlPersonal.Name == "txtLastNamesPersonal"))
                    {
                        string Apellidos = ControlPersonal.Text;
                        if (string.IsNullOrEmpty(Apellidos))
                            this.lbVApellidoPersonal.Visible = true;
                        else
                            this.lbVApellidoPersonal.Visible = false;
                    }
                    if ((ControlPersonal.Name == "txtDocumentNumberPersonal"))
                    {
                        string NumeroDocument = ControlPersonal.Text;
                        if (string.IsNullOrEmpty(NumeroDocument))
                            this.lblVnumerodeDocumentPersonal.Visible = true;
                        else
                            this.lblVnumerodeDocumentPersonal.Visible = false;
                    }
                    if ((ControlPersonal.Name == "txtAddressPersonal"))
                    {
                        string Ciudad = ControlPersonal.Text;
                        if (string.IsNullOrEmpty(Ciudad))
                            this.lbVDireccionPersonal.Visible = true;
                        else
                            this.lbVDireccionPersonal.Visible = false;
                    }
                }
                else
                    if (ControlPersonal is ComboBox)
                    {
                        if ((ControlPersonal.Name == "cboSexoPersonal"))
                        {
                            string texto = ControlPersonal.Text;
                            if (texto == "Seleccione...")
                                this.lbValidacionSexoPersonal.Visible = true;
                            else
                                this.lbValidacionSexoPersonal.Visible = false;
                        }
                        if ((ControlPersonal.Name == "cbProfesion"))
                        {
                            string Parentesco = ControlPersonal.Text;
                            if (Parentesco == "Seleccione...")
                                this.lblVProfesionPersonal.Visible = true;
                            else
                                this.lblVProfesionPersonal.Visible = false;
                        }
                        if ((ControlPersonal.Name == "cboTypeDocumentPersonal"))
                        {
                            string NumeroDocument = this.cboTypeDocumentPersonal.Text;
                            if (NumeroDocument == "Seleccione...")
                                this.lblVnumerodeDocumentPersonal.Visible = true;
                            else
                                this.lbVTipo_DocumentPersonal.Visible = false;
                        }
                    }
            }

        }

        #endregion
        #region Eventos
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void TxtNamePersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.solotexto(e);

        }
        private void regPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F3)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult resultado = ofd.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }   
            }
        }

        private void regPersonal_Load(object sender, EventArgs e)
        {
            TxtNamePersonal.Focus();
        }
        #endregion

        private void cboTypeDocumentPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeDocumentPersonal.Text != "Seleccione...")
                txtDocumentNumberPersonal.Enabled = true;
        }

        private void TxtNamePersonal_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposPersonal();
        }


    }
}
