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
    public partial class FrmAltaAula : Form
    {
        List<Docente> docentes;
        List<Alumno> alumnos;
        Aula aulaAux;

        public FrmAltaAula()
        {            
            InitializeComponent();
        }

        /// <summary>
        /// Carga una lista con todos los alumnos y docentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaAula_Load(object sender, EventArgs e)
        {
            foreach (Docente profe in docentes)
            {
                lstProfesores.Items.Add(profe.Apellido);
            }
            foreach( Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(alumno.MostrarAlumno());
            }

            cmbColorSala.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
        }

        /// <summary>
        /// Agrega a un docente a una aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Object profeAux;

            if((profeAux = lstProfesores.SelectedItem) != null)
            {
                txtDocente.Text =  lstProfesores.SelectedItem.ToString();
            }
        }



        /// <summary>
        /// Saca a un alumno de su aula y lo agrega al aula a crear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Object alumnoAux;

            if((alumnoAux = lstAlumnos.SelectedItem)!= null)
            {
                lstAulaNueva.Items.Add(alumnoAux);

                lstAlumnos.Items.Remove(alumnoAux);
            }

            
        }


        /// <summary>
        /// Da de alta un aula con docente, turno , color y sus alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaAula_Click(object sender, EventArgs e)
        {
            ETurno turno;
            EColores colorSala;
            
            Enum.TryParse<ETurno>(cmbTurno.SelectedValue.ToString(), out turno);
            Enum.TryParse<EColores>(cmbColorSala.SelectedValue.ToString(), out colorSala);

            foreach (Docente profe in docentes)
            {
                if (profe.Apellido.ToString() == txtDocente.Text)
                {
                    Aula aula = new Aula(colorSala, turno, profe);

                    foreach (Alumno alum in alumnos)
                    {
                        if(alum.MostrarAlumno() == lstAulaNueva.Text)
                        {
                            alum.ColorSala = colorSala;
                            alumnos.Add(alum);
                            aula.Alumnos.Add(alum);
                        }
                    }

                    aulaAux = aula;
                    Console.Beep();
                    MessageBox.Show("Aula creada");
                    this.Close();
                }

                
            }

        }

        #region Propiedades
        /// <summary>
        /// Lee y setea la lista de los docentes
        /// </summary>
        public List<Docente> ListaDocentes
        {
            get
            {
                return this.docentes;
            }
            set
            {
                this.docentes = value;
            }
        }

        /// <summary>
        /// Lee y setea la lista de los alumnos
        /// </summary>
        public List<Alumno> ListaAlumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Lee y setea la lista de las aulas
        /// </summary>
        public Aula Aula
        {
            get
            {
                return this.aulaAux;
            }
            set
            {
                this.aulaAux = value;
            }
        }

        
        #endregion
    }
}
