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
    public partial class FrmBuscarAlumno : Form
    {
        public List<Alumno> alumnos;

        public FrmBuscarAlumno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Buscar en la lisa de alumnos por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach(Alumno alum in alumnos)
            {
                if (txtApellido.Text == alum.Apellido)
                {
                    lstDatosAlumnos.Items.Add(alum.ToString());
                }
            }
            
        }

        #region PROPIEDADES

        public List<Alumno> ListaAlumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        #endregion
    }
}
