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
    public partial class FrmAltaEmpleado : Form
    {
        public Administrativo administrativoAux;
        

        public FrmAltaEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos en los comboBox
        /// </summary>
        private void FrmMenuAltaEmpleado_Load(object sender, EventArgs e)
        {
            cmbCargoEmpleado.DataSource = Enum.GetValues(typeof(ECargo));
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");
            txtSalarioBase.Text = "30.000";
        }

        /// <summary>
        /// Da de alta a un administrativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            DateTime horaIngreso = new DateTime();
            DateTime horaSalida = new DateTime();
            int dni;
            bool sexo = false;
            ECargo cargo;

            if (cmbSexo.Text == "Femenino")
                sexo = true;

            
            Enum.TryParse<ECargo>(cmbCargoEmpleado.SelectedValue.ToString(), out cargo);

            if(int.TryParse(txtDni.Text,out dni))
            {
                Administrativo nuevoEmpleado = new Administrativo(txtNombre.Text, txtApellido.Text, dni, sexo, horaIngreso.AddHours(double.Parse(txtHoraIngreso.Text)), horaSalida.AddHours(double.Parse(txtHoraSalida.Text)), cargo);
                string msj= txtNombre.Text.ToUpper() + ", " + txtApellido.Text.ToUpper()+ "\nDADO DE ALTA";
                administrativoAux = nuevoEmpleado;
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
        /// Propiedad para leer un empleado administrativo
        /// </summary>
        public Administrativo GetAdministrativo
        {
            get
            {
                return this.administrativoAux;
            }
        }


    }
}
