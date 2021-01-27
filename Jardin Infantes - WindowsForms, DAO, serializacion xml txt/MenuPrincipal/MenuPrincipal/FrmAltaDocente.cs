using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MenuPrincipal
{
    public partial class FrmAltaDocente : Form
    {
        public Docente docenteAux;

        public FrmAltaDocente()
        {
            InitializeComponent();
        }
        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");
        }

        /// <summary>
        /// Da de alta a un docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            DateTime horaIngreso = new DateTime();
            DateTime horaSalida = new DateTime();
            int dni;
            bool sexo = false;

            if (cmbSexo.Text == "Femenino")
                sexo = true;

            if(int.TryParse(txtDni.Text,out dni))
            {
                Docente nuevoDocente = new Docente(txtNombre.Text, txtApellido.Text, dni, sexo, horaIngreso.AddHours(double.Parse(txtHoraIngreso.Text)), horaSalida.AddHours(double.Parse(txtHoraSalida.Text)),double.Parse(txtValorHora.Text));

                docenteAux = nuevoDocente;
                string msj = txtNombre.Text.ToUpper() + ", " + txtApellido.Text.ToUpper() + "\nDADO DE ALTA";
                Console.Beep();
                MessageBox.Show(msj);
                this.Close();
            }
            else
            {
                MessageBox.Show("Dni no valido");
            }
        }

        /// <summary>
        /// Propiedad para leer y un docente
        /// </summary>
        public Docente GetDocente
        {
            get
            {
                return this.docenteAux;
            }
        }


    }
}
