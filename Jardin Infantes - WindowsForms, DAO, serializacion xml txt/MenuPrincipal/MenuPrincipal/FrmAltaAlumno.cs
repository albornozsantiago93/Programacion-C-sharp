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
    public partial class FrmAltaAlumno : Form
    {
        public Alumno alumnoAux;

        public FrmAltaAlumno()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Carga los valores en los combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            cmbColorSala.DataSource = Enum.GetValues(typeof(EColores));
            cmbParentesco.DataSource = Enum.GetValues(typeof(EParentesco));
            cmbSexoAlumno.Items.Add("Femenino");
            cmbSexoAlumno.Items.Add("Masculino");
            cmbSexoTutor.Items.Add("Masculino");
            cmbSexoTutor.Items.Add("Femenino");
        }

        /// <summary>
        /// Da de alta a un alumno y a su responsable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaAlumno_Click(object sender, EventArgs e)
        {
            int legajoAlumno, dniAlumno, dniTutor;
            float precioCuota;
            bool sexoAlumno = false, sexoTutor = false; 

            #region Validaciones de datos

            if (!(int.TryParse(txtNroLegajo.Text, out legajoAlumno)))
            {
                MessageBox.Show("Numero de legajo no valido");
            }

            if(!(float.TryParse(txtPrecioCuota.Text,out precioCuota)))
            {
                MessageBox.Show("Valor de cuota no valido");
            }

            if(!(int.TryParse(txtDniAlumno.Text,out dniAlumno)))
            {
                MessageBox.Show("Dni de alumno no valido");
            }

            if (!(int.TryParse(txtDniTutor.Text, out dniTutor)))
            {
                MessageBox.Show("Dni del tutor no valido");
            }

            if (cmbSexoAlumno.ValueMember.ToString() == "Femenino".ToString())
            {
                sexoAlumno = true;
            }

            if(cmbSexoTutor.ValueMember.ToString() == "Femenino".ToString())
            {
                sexoTutor = true;
            }
            #endregion

            EParentesco parentesco;
            Enum.TryParse<EParentesco>(cmbParentesco.SelectedValue.ToString(), out parentesco);

            Responsable tutor = new Responsable(txtNombreTutor.Text, txtApellidoTutor.Text, dniTutor, sexoTutor, parentesco, txtNroTelefonoTutor.Text);

            EColores sala;
            Enum.TryParse<EColores>(cmbColorSala.SelectedValue.ToString(), out sala);

            if(tutor == null)
            {
                this.Close();
            }
            else
            {
                Alumno alumno = new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, dniAlumno, sexoAlumno, precioCuota, tutor, int.Parse(txtNroLegajo.Text), sala);
                alumnoAux = alumno;
                Console.Beep();
                MessageBox.Show("Alumno agregado " + this.txtApellidoAlumno.Text);
                this.Close();
            }
            
        }

        /// <summary>
        /// Propiedad para leer a un alumno
        /// </summary>
        public Alumno GetAlumno
        {
            get
            {
                return this.alumnoAux;
            }
        }
    }
}
