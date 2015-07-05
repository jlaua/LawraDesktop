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
using Registers;
using System.Threading;

namespace LawrApp.Layouts.regPersonal
{
    public partial class FrmregPersonal : MetroForm
    {
        public Personal Personal = new Personal();
        private Thread trPersonal;
        public FrmregPersonal()
        {
            InitializeComponent();
            FocusMe();
        }
        #region Metodos
        public void ValidacionMayoriaDeEdad()
        {
            DateTime InputDate = new DateTime(this.dtpBirthdayPersonal.Value.Year, this.dtpBirthdayPersonal.Value.Month, this.dtpBirthdayPersonal.Value.Day).AddYears(18);
            DateTime InputDateMax = new DateTime(this.dtpBirthdayPersonal.Value.Year, this.dtpBirthdayPersonal.Value.Month, this.dtpBirthdayPersonal.Value.Day).AddYears(85);
            TimeSpan edadActual = DateTime.Now - InputDate;
            TimeSpan edadMax = DateTime.Now - InputDateMax;

            if (edadActual.Days < 0 && edadMax.TotalDays < 0)
            {
                this.lbVfecha_nacPersonal.Visible = true;
                tolPesonal.ShowAlways = true;
                tolPesonal.Show("Mnimo 18 años de edad", dtpBirthdayPersonal, 3000);
            }
            else
                this.lbVfecha_nacPersonal.Visible = false;
        }
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
                            {
                                this.lbVTipo_DocumentPersonal.Visible = false;
                                this.txtDocumentNumberPersonal.Enabled= true;
                            };
                        }
                    }
            }

        }
        private void sendDataPersonal()
        {
            CheckForIllegalCrossThreadCalls = false;

            if (this.Personal.SendDataPersonal())
            {
                MetroMessageBox.Show(this, "\n" + "\n\n OK continua...",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MetroMessageBox.Show(this, this.Personal.MsERegistrarPersonal,
                          "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string validardia()
        {
            if (dtpBirthdayPersonal.Value.Day < 10)
            {
                return Convert.ToString("0" + dtpBirthdayPersonal.Value.Day);

            }
            else
                return Convert.ToString(dtpBirthdayPersonal.Value.Day);
        }
        public string validarMes()
        {
            if (dtpBirthdayPersonal.Value.Month < 10)
            {
                return Convert.ToString("0" + dtpBirthdayPersonal.Value.Month);
            }
            else
                return Convert.ToString(dtpBirthdayPersonal.Value.Month);
        }
        public void MensajeDbatosCorrectos()
        {
            MetroMessageBox.Show(this, "", "Correcto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void IngresaPersonal()
        {
            this.Personal.DataPersonal.Names = this.TxtNamePersonal.Text;
            this.Personal.DataPersonal.LasName = this.txtLastNamesPersonal.Text;
            this.Personal.DataPersonal.Birthday = this.dtpBirthdayPersonal.Value.Year.ToString() + "-" + validarMes() + "-" + validardia();
            this.Personal.DataPersonal.Sexo = this.cboSexoPersonal.Text;
            this.Personal.DataPersonal.TypeDocument = this.cboTypeDocumentPersonal.SelectedIndex;
            this.Personal.DataPersonal.DocumentNumber = this.txtDocumentNumberPersonal.Text;
            this.Personal.DataPersonal.Profession = this.cbProfesion.SelectedIndex;
            this.Personal.DataPersonal.Adress = this.txtAddressPersonal.Text;
            this.Personal.DataPersonal.Phone = this.txtPhonesPersonal.Text;
            this.Personal.DataPersonal.Mail = this.txtEmailPersonal.Text;
        }

        public bool ValidarInformacionBasica()
        {
            if (string.IsNullOrWhiteSpace(this.TxtNamePersonal.Text))
            {
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Nombre del Alumno es requerido", this.TxtNamePersonal, 3000);
                this.TxtNamePersonal.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.txtLastNamesPersonal.Text))
            {
                this.tolPesonal.Show("Apellido del Alumno es requerido", this.txtLastNamesPersonal, 3000);
                this.TxtNamePersonal.Focus();
                return false;
            }
            if (this.cboSexoPersonal.Text == "Seleccione...")
            {
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("El sexo del alumno es requerido", this.cboSexoPersonal, 3000);
                this.cboSexoPersonal.Focus();
                return false;
            }
            if (this.cboTypeDocumentPersonal.Text == "Seleccione...")
            {
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Minimo es un documento requerido", this.cboTypeDocumentPersonal, 3000);
            }

            if (this.cboTypeDocumentPersonal.Text != "Seleccione..." && string.IsNullOrWhiteSpace(this.txtDocumentNumberPersonal.Text))
            {
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Este campo es requerido", this.txtDocumentNumberPersonal, 3000);
                this.txtDocumentNumberPersonal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtAddressPersonal.Text))
            {
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Este campo es requerido", this.txtAddressPersonal, 3000);
                this.txtAddressPersonal.Focus();
                return false;
            }
            if (!string.IsNullOrWhiteSpace(this.txtEmailPersonal.Text) && (this.lbvcorreopersonal.Visible == true))
            {
                return false;
            }
            return true;
        }
        private bool ValidaCamposOblogatotio()
        {
            if (string.IsNullOrEmpty(this.TxtNamePersonal.Text))
                return false;
            if (string.IsNullOrEmpty(this.txtLastNamesPersonal.Text))
                return false;
            if (this.cboSexoPersonal.Text == "Seleccione...")
                return false;
            if (this.cbProfesion.Text == "Seleccione...")
                return false;
            if (this.cboTypeDocumentPersonal.Text == "Seleccione...")
                return false;
            if (string.IsNullOrEmpty(txtDocumentNumberPersonal.Text))
                return false;
            if (string.IsNullOrEmpty(txtAddressPersonal.Text))
                return false;
            else
                return true;
        }

        #endregion

        #region Eventos

        private void TxtNamePersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.solotexto(e.KeyChar);
        }

        private void FrmregPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F3)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult resultado = ofd.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void cboTypeDocumentPersonal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.cboTypeDocumentPersonal.Text == "Seleccione...")
                this.lbVTipo_DocumentPersonal.Visible = true;
            else
                this.lbVTipo_DocumentPersonal.Visible = false;
                this.txtDocumentNumberPersonal.Enabled = true;
        }

        private void FrmregPersonal_Load(object sender, EventArgs e)
        {
            TxtNamePersonal.Focus();
        }

        private void dtpBirthdayPersonal_Leave(object sender, EventArgs e)
        {
            ValidacionMayoriaDeEdad();
        }

        private void btnAddPersonal_Click_1(object sender, EventArgs e)
        {
            int[] _InputFecha = new int[3] {this.dtpBirthdayPersonal.Value.Day,this.dtpBirthdayPersonal.Value.Month, 
                                                                              this.dtpBirthdayPersonal.Value.Year };
            DateTime fechaRegistrada = new DateTime(_InputFecha[2], _InputFecha[1], _InputFecha[0]);

            if (ValidarInformacionBasica() == false) return;
            if (ValidaCamposOblogatotio() == false || Helper.ValidacionMayoriaDeEdad(fechaRegistrada) == false)
            return;
            this.trPersonal = new Thread(new ThreadStart(this.sendDataPersonal));
            IngresaPersonal();
            MensajeDbatosCorrectos();
            this.trPersonal.Start();
        }

        private void TxtNamePersonal_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtNamePersonal.Text))
            {
                this.lbValidacionnamePersonal.Visible = true;
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Nombre de alumno obligatorio", TxtNamePersonal, 3000);
            }
            else
                this.lbValidacionnamePersonal.Visible = false;
        }

        private void cboSexoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboSexoPersonal.Text == "Seleccione...")
                this.lbValidacionSexoPersonal.Visible = true;
            else
                this.lbValidacionSexoPersonal.Visible = false;
        }

        private void cbProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbProfesion.Text == "Seleccione...")
                this.lblVProfesionPersonal.Visible = true;
            else
                this.lblVProfesionPersonal.Visible = false;
        }

        private void txtLastNamesPersonal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLastNamesPersonal.Text))
            {
                this.lbVApellidoPersonal.Visible = true;
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Apellido del Alumnno es requerido", txtLastNamesPersonal, 3000);
            }
            else
                this.lbVApellidoPersonal.Visible = false;
        }

        private void txtDocumentNumberPersonal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDocumentNumberPersonal.Text))
            {
                this.lblVnumerodeDocumentPersonal.Visible = true;
                this.tolPesonal.ShowAlways = true;
                this.tolPesonal.Show("Apellido del Alumnno es requerido", this.txtDocumentNumberPersonal, 3000);
            }
            else
                this.lblVnumerodeDocumentPersonal.Visible = false;
        }

        private void txtAddressPersonal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAddressPersonal.Text))
                this.lbVDireccionPersonal.Visible = true;
            else
                this.lbVDireccionPersonal.Visible = false;
        }

        #endregion

        private void txtEmailPersonal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtEmailPersonal.Text))
            {
                if (Helper.CorreoElectronico(this.txtEmailPersonal.Text) == false)
                    this.lbvcorreopersonal.Visible = true;
            }
        }

        private void txtEmailPersonal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtEmailPersonal.Text))
            {
                if (Helper.CorreoElectronico(this.txtEmailPersonal.Text) == false)
                    this.lbvcorreopersonal.Visible = true;
                else
                    this.lbvcorreopersonal.Visible = false;
            }
            else
                this.lbvcorreopersonal.Visible = false;
        }

        private void cboSexoPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
                e.SuppressKeyPress = true;
        }

        private void cbProfesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
                e.SuppressKeyPress = true;
        }

        private void cboTypeDocumentPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
                e.SuppressKeyPress = true;
        }

    }
}
