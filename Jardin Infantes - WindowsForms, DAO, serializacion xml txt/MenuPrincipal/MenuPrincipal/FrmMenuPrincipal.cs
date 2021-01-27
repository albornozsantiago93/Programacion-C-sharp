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
    public partial class FrmMenuPrincipal : Form
    {
        public List<Docente> docentes;
        public List<Administrativo> empleados;
        public List<Responsable> responsables;
        public List<Alumno> alumnos;
        public List<Aula> aulas;
        bool flag = true;
        

        public FrmMenuPrincipal()
        {
            InitializeComponent();

            docentes = new List<Docente>();
            empleados = new List<Administrativo>();
            responsables = new List<Responsable>();
            alumnos = new List<Alumno>();
            aulas = new List<Aula>();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        #region ALTAS

        /// <summary>
        /// Da de alta un alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno altaAlumno = new FrmAltaAlumno();

            altaAlumno.ShowDialog();
            
            //dialogResult.ok

            alumnos.Add(altaAlumno.GetAlumno);
            responsables.Add(altaAlumno.GetAlumno.Responsable);         
                      
        }

        /// <summary>
        /// Da de alta a un empleado administrativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaEmpleado frmAltaEmpleado = new FrmAltaEmpleado();

            frmAltaEmpleado.ShowDialog();

            empleados.Add(frmAltaEmpleado.GetAdministrativo);

        }

        /// <summary>
        /// Da de alta a un docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaDocente frmDocente = new FrmAltaDocente();

            frmDocente.ShowDialog();

            docentes.Add(frmDocente.GetDocente);
            
        }

        /// <summary>
        /// Da de alta a un aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaDeAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAula altaAula = new FrmAltaAula();
            altaAula.ListaDocentes = docentes;
            altaAula.ListaAlumnos = alumnos;

            altaAula.ShowDialog();

            alumnos = altaAula.ListaAlumnos;
            docentes = altaAula.ListaDocentes;
            aulas.Add(altaAula.Aula);
        }
        #endregion


        #region INFORMES

        /// <summary>
        /// Imprime por pantalla la Informacion de todos los responsables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informacionDePadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstInforme.Items.Clear();
            lstInforme.Items.Add("\t\tInformacion de Responsables");
            lstInforme.Items.Add(" ");
            foreach (Responsable tutor in responsables)
            {
                lstInforme.Items.Add(tutor.ToString());
            }
        }

        /// <summary>
        /// Imprime por pantalla la lista de docentes y su sueldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sueldoDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstInforme.Items.Clear();
            lstInforme.Items.Add("\t\tSueldo de Docentes");
            lstInforme.Items.Add(" ");
            foreach (Docente docenteAux in docentes)
            {
                lstInforme.Items.Add(docenteAux.mostrarDocenteSueldo());
            }
        }

        /// <summary>
        /// Calcula e imprime la cantidad recaudada por cada aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recaudacionPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstInforme.Items.Clear();

            float acumuladorSalaRoja = 0, acumuladorSalaAmarilla = 0, acumuladorSalaVerde = 0, acumuladorSalaNaranja = 0;
            
            foreach(Alumno cliente in alumnos)
            {
                if(cliente.ColorSala == EColores.Rojo)
                {
                    acumuladorSalaRoja += cliente.PrecioCuota;
                }
                if (cliente.ColorSala == EColores.Verde)
                {
                    acumuladorSalaVerde += cliente.PrecioCuota;
                }
                if (cliente.ColorSala == EColores.Naranja)
                {
                    acumuladorSalaNaranja += cliente.PrecioCuota;
                }
                if (cliente.ColorSala == EColores.Amarillo)
                {
                    acumuladorSalaAmarilla += cliente.PrecioCuota;
                }
            }

            lstInforme.Items.Add("\t\tRecaudacion por Sala");
            lstInforme.Items.Add(" ");
            lstInforme.Items.Add("Sala Amarilla: $" + acumuladorSalaAmarilla);
            lstInforme.Items.Add("Sala Roja: $" + acumuladorSalaRoja);
            lstInforme.Items.Add("Sala Verde: $" + acumuladorSalaVerde);
            lstInforme.Items.Add("Sala Naranja: $" + acumuladorSalaNaranja);
        }

        /// <summary>
        /// Calcula el total recaudado del jardin, pasando por la lista de los alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recaudacionTotalDelJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstInforme.Items.Clear();
            float totalRecaudado = 0;

            foreach(Alumno cliente in alumnos)
            {
                totalRecaudado += cliente.PrecioCuota;
            }

            lstInforme.Items.Add("\t\t Recaudacion Total");
            lstInforme.Items.Add(" ");
            lstInforme.Items.Add("$ " + totalRecaudado);

        }

        /// <summary>
        /// Busca a un alumno en especifico por su apellido y lo muestra sus datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarAlumno buscarAlumno = new FrmBuscarAlumno();
            buscarAlumno.ListaAlumnos = alumnos;

            buscarAlumno.ShowDialog();

            alumnos = buscarAlumno.ListaAlumnos;
        }

        #endregion


        #region CARGA DE DATOS

        /// <summary>
        /// Carga de datos hardcodeados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region Carga de datos 

            while (flag)
            {
                DateTime horaEntrada = new DateTime();
                DateTime horaSalida = new DateTime();

                #region Alta Tutor
                Responsable r1 = new Responsable("Pedro", "Perez", 30010423, false, EParentesco.Tio, 43069568.ToString());
                Responsable r2 = new Responsable("Juan", "Lopez", 22210427, false, EParentesco.Padre, 42069528.ToString());
                Responsable r3 = new Responsable("Raul", "Ramirez", 23310413, false, EParentesco.Padre, 42361168.ToString());
                Responsable r4 = new Responsable("Eduardo", "Suarez", 18010413, false, EParentesco.Abuelo, 49196528.ToString());
                Responsable r5 = new Responsable("Cesar", "Imbert", 29910345, false, EParentesco.Padre, 42069228.ToString());
                Responsable r6 = new Responsable("Santiago", "Fagundez", 30010423, false, EParentesco.Padre, 44069533.ToString());
                Responsable r7 = new Responsable("Maria", "Blacher", 35210123, true, EParentesco.Tia, 46669568.ToString());
                Responsable r8 = new Responsable("Jimena", "Lopez", 35910883, true, EParentesco.Madre, 42064868.ToString());
                Responsable r9 = new Responsable("Cecilia", "Gomez", 23330223, true, EParentesco.Madre, 42589568.ToString());
                Responsable r10 = new Responsable("Juan", "Gomez", 23010111, false, EParentesco.Padre, 42589568.ToString());
                Responsable r11 = new Responsable("Alberto", "Perez", 23330223, false, EParentesco.Padre, 42589568.ToString());
                Responsable r12 = new Responsable("Carlos", "Sagradin", 23010223, false, EParentesco.Padre, 18589568.ToString());
                Responsable r13 = new Responsable("Pedro", "Lopez", 23014223, false, EParentesco.Padre, 22589568.ToString());
                Responsable r14 = new Responsable("Sebastian", "Machado", 13010223, false, EParentesco.Padre, 21589568.ToString());
                Responsable r15 = new Responsable("Nicolas", "Cejudo", 23210223, false, EParentesco.Padre, 42589568.ToString());
                Responsable r16 = new Responsable("Ignacio", "Ramirez", 10010223, false, EParentesco.Padre, 42588868.ToString());
                Responsable r17 = new Responsable("Matias", "Gonzales", 18010223, false, EParentesco.Padre, 42589268.ToString());
                Responsable r18 = new Responsable("Jose", "Burgos", 23014223, false, EParentesco.Padre, 20589565.ToString());
                Responsable r19 = new Responsable("Antonio", "Ibarra", 21510223, false, EParentesco.Tio, 22533568.ToString());
                Responsable r20 = new Responsable("Facundo", "Palomo", 18010223, false, EParentesco.Tio, 32589511.ToString());
                Responsable r21 = new Responsable("Agustin", "Guarna", 19010223, false, EParentesco.Tio, 35586668.ToString());
                Responsable r22 = new Responsable("Gonzalo", "Mazo", 20010223, false, EParentesco.Tio, 33585568.ToString());
                Responsable r23 = new Responsable("Leo", "Flamini", 20810223, false, EParentesco.Tio, 42589568.ToString());
                Responsable r24 = new Responsable("Carlos", "Diaz", 18014221, false, EParentesco.Padre, 20333225.ToString());
                Responsable r25 = new Responsable("Sergio", "Retamozo", 23042223, false, EParentesco.Abuelo, 12534568.ToString());
                Responsable r26 = new Responsable("Angel", "Gomez", 23010523, false, EParentesco.Abuelo, 12586668.ToString());
                Responsable r27 = new Responsable("Juan", "Lopez", 230126563, false, EParentesco.Abuelo, 13589568.ToString());
                Responsable r28 = new Responsable("Esteban", "Gomez", 23020223, false, EParentesco.Abuelo, 42589568.ToString());
                Responsable r29 = new Responsable("Cecilia", "Martinez", 28020113, true, EParentesco.Madre, 42389528.ToString());
                Responsable r30 = new Responsable("Rosa", "Sosa", 23225473, true, EParentesco.Madre, 42389528.ToString());
                Responsable r31 = new Responsable("Maria", "Sanchez", 22050673, true, EParentesco.Madre, 42389528.ToString());
                Responsable r32 = new Responsable("Ines", "Aguirre", 32020273, true, EParentesco.Madre, 42589568.ToString());
                Responsable r33 = new Responsable("Mirta", "Pereyra", 33013573, true, EParentesco.Madre, 42549568.ToString());
                Responsable r34 = new Responsable("Jesica", "Rojas", 33613376, true, EParentesco.Madre, 43349568.ToString());
                Responsable r35 = new Responsable("Julia", "Molina", 35013226, true, EParentesco.Madre, 42349568.ToString());
                Responsable r36 = new Responsable("Marta", "Castro", 37013296, true, EParentesco.Madre, 43549568.ToString());
                Responsable r37 = new Responsable("Agustina", "Ruiz", 35013226, true, EParentesco.Madre, 43389568.ToString());
                Responsable r38 = new Responsable("Nelida", "Diaz", 35013296, true, EParentesco.Tia, 43359568.ToString());
                Responsable r39 = new Responsable("Norma", "Garcia", 33010246, true, EParentesco.Tia, 43399568.ToString());
                Responsable r40 = new Responsable("Alicia", "Sanchez", 38010543, true, EParentesco.Tia, 42553568.ToString());
                Responsable r41 = new Responsable("Sandra", "Lopez", 28010241, true, EParentesco.Tia, 42553558.ToString());
                Responsable r42 = new Responsable("Laura", "Rodriguez", 28010241, true, EParentesco.Tia, 46553868.ToString());
                Responsable r43 = new Responsable("Agostina", "Britez", 28010241, true, EParentesco.Abuela, 46153528.ToString());
                Responsable r44 = new Responsable("Giuliana", "Herrera", 28010221, true, EParentesco.Abuela, 48553728.ToString());
                Responsable r45 = new Responsable("Florencia", "Gomez", 23010221, true, EParentesco.Abuela, 46553528.ToString());
                Responsable r46 = new Responsable("Victoria", "Rodriguez", 22210321, true, EParentesco.Abuela, 42529568.ToString());
                Responsable r47 = new Responsable("Samanta", "Castro", 21210521, true, EParentesco.Abuela, 41582158.ToString());
                Responsable r48 = new Responsable("Jesica", "Gimenez", 27210223, true, EParentesco.Madre, 48382151.ToString());
                Responsable r49 = new Responsable("Solange", "Rodriguez", 29210123, true, EParentesco.Madre, 48686354.ToString());
                Responsable r50 = new Responsable("Alicia", "Diaz", 26010523, true, EParentesco.Madre, 42585156.ToString());




                responsables.Add(r1);
                responsables.Add(r2);
                responsables.Add(r3);
                responsables.Add(r4);
                responsables.Add(r5);
                responsables.Add(r6);
                responsables.Add(r7);
                responsables.Add(r8);
                responsables.Add(r9);
                responsables.Add(r10);
                responsables.Add(r11);
                responsables.Add(r12);
                responsables.Add(r13);
                responsables.Add(r14);
                responsables.Add(r15);
                responsables.Add(r16);
                responsables.Add(r17);
                responsables.Add(r18);
                responsables.Add(r19);
                responsables.Add(r20);
                responsables.Add(r21);
                responsables.Add(r22);
                responsables.Add(r23);
                responsables.Add(r24);
                responsables.Add(r25);
                responsables.Add(r26);
                responsables.Add(r27);
                responsables.Add(r28);
                responsables.Add(r29);
                responsables.Add(r30);
                responsables.Add(r31);
                responsables.Add(r32);
                responsables.Add(r33);
                responsables.Add(r34);
                responsables.Add(r35);
                responsables.Add(r36);
                responsables.Add(r37);
                responsables.Add(r38);
                responsables.Add(r39);
                responsables.Add(r40);
                responsables.Add(r41);
                responsables.Add(r42);
                responsables.Add(r43);
                responsables.Add(r44);
                responsables.Add(r45);
                responsables.Add(r46);
                responsables.Add(r47);
                responsables.Add(r48);
                responsables.Add(r49);
           
     responsables.Add(r50);


                #endregion

                #region Alta Alumno
                Alumno al1 = new Alumno("Nicolas", "Ramirez", 10523698, false, 180, r1, 1, EColores.Amarillo);
                Alumno al2 = new Alumno("Carlos", "Lopez", 10523698, false, 180, r2, 2, EColores.Rojo);
                Alumno al3 = new Alumno("Dilan", "Ramirez", 10523698, false, 180, r3, 3, EColores.SinSala);
                Alumno al4 = new Alumno("Nicolas", "Suarez", 10523698, false, 180, r4, 4, EColores.Naranja);
                Alumno al5 = new Alumno("Matias", "Imbert", 12523698, false, 180, r5, 5, EColores.Rojo);
                Alumno al6 = new Alumno("Agustina", "Fagundez", 11523698, true, 180, r6, 6, EColores.Verde);
                Alumno al7 = new Alumno("Lucia", "Gonzales", 10523698, true, 180, r7, 7, EColores.SinSala);
                Alumno al8 = new Alumno("Rocio", "Lopez", 160523698, true, 180, r8, 8, EColores.Rojo);
                Alumno al9 = new Alumno("Leila", "Gomez", 10243698, true, 180, r9, 9, EColores.SinSala);
                Alumno al10 = new Alumno("Rocio", "Diaz", 20525798, true, 180, r10, 41, EColores.Rojo);
                Alumno al11 = new Alumno("Rocio", "Gomez", 40509898, true, 180, r11, 42, EColores.Rojo);
                Alumno al12 = new Alumno("Florencia", "Diaz", 47893698, true, 180, r12, 43, EColores.Rojo);
                Alumno al13 = new Alumno("Maria", "Rojas", 20323628, true, 180, r13, 44, EColores.Rojo);
                Alumno al14 = new Alumno("Josefina", "Ramirez", 30513648, true, 180, r14, 45, EColores.Rojo);
                Alumno al15 = new Alumno("Macarena", "Castro", 20225698, true, 180, r15, 46, EColores.Rojo);
                Alumno al16 = new Alumno("Agostina", "Fenoy", 22526698, true, 180, r16, 47, EColores.Rojo);
                Alumno al17 = new Alumno("Bianca", "Molina", 21523600, true, 180, r17, 48, EColores.Rojo);
                Alumno al18 = new Alumno("Alicia", "Gomez", 10123008, true, 180, r18, 49, EColores.Rojo);
                Alumno al19 = new Alumno("Leila", "Gimenez", 20563698, true, 180, r19, 50, EColores.Rojo);
                Alumno al20 = new Alumno("Ximena", "Vazques", 30634698, true, 180, r20, 10, EColores.Rojo);
                Alumno al21 = new Alumno("Mariela", "Rojas", 19523601, true, 180, r21,11, EColores.Rojo);
                Alumno al22 = new Alumno("Sofia", "Ponce", 12513695, true, 180, r22,12, EColores.Rojo);
                Alumno al23 = new Alumno("Barbara", "Ojeda", 50323692, true, 180, r23, 13, EColores.Rojo);
                Alumno al24 = new Alumno("Belen", "Cardozo", 10583692, true, 180, r24, 14, EColores.Rojo);
                Alumno al25 = new Alumno("Camila", "Vargas", 12533628, true, 180, r25, 15, EColores.Rojo);
                Alumno al26 = new Alumno("Candela", "Ramos", 20513638, true, 180, r26, 16, EColores.Rojo);
                Alumno al27 = new Alumno("Ariana", "Paz", 10323608, true, 180, r27, 17, EColores.Verde);
                Alumno al28 = new Alumno("Ayelen", "Farias", 20523118, true, 180, r28, 18, EColores.Verde);
                Alumno al29 = new Alumno("Betina", "Roldan", 22323698, true, 180, r29, 19, EColores.Verde);
                Alumno al30 = new Alumno("Delfina", "Mendez", 33323498, true, 180, r30, 20, EColores.Verde);
                Alumno al31 = new Alumno("Carla", "Guzman", 42521608, true, 180, r31, 21, EColores.Verde);
                Alumno al32 = new Alumno("Clauda", "Silva", 43527628, true, 180, r32, 22, EColores.Verde);
                Alumno al33 = new Alumno("Celeste", "Ortiz", 10223698, true, 180, r33, 23, EColores.Verde);

                Alumno al34 = new Alumno("Adrian", "Rojas", 12423421, false, 180, r34, 24, EColores.Naranja);
                Alumno al35 = new Alumno("Raul", "Carrizo", 30023690, false, 180, r35, 25, EColores.Naranja);
                Alumno al36 = new Alumno("Juan", "Peralta", 30513198, false, 180, r36, 26, EColores.Naranja);
                Alumno al37 = new Alumno("Eloy", "Castillo", 60323618, false, 180, r37, 27, EColores.Naranja);
                Alumno al38 = new Alumno("Nicolas", "Arias", 70525338, false, 180, r38, 28, EColores.Naranja);
                Alumno al39 = new Alumno("Matias", "Caceres",20522498, false, 180, r39, 29, EColores.Naranja);
                Alumno al40 = new Alumno("Esteban", "Rivero", 40523698, false, 180, r40, 30, EColores.Amarillo);
                Alumno al41 = new Alumno("Adolfo", "Miranda", 10523598, false, 180, r41, 31, EColores.Amarillo);
                Alumno al42 = new Alumno("Antonio", "Guzman", 22513398, false, 180, r42, 32, EColores.Amarillo);
                Alumno al43 = new Alumno("Aldo", "Figueroa", 30526290, false, 180, r43, 33, EColores.Amarillo);
                Alumno al44 = new Alumno("Jose", "Muñoz", 22523698, false, 180, r44, 34, EColores.Amarillo);
                Alumno al45 = new Alumno("Alberto", "Ledesma", 23423698, false, 180, r45, 35, EColores.Amarillo);
                Alumno al46 = new Alumno("Roberto", "Lopez", 26525698, false, 180, r46, 36, EColores.Amarillo);
                Alumno al47 = new Alumno("Carlos", "Quiroga", 40523698, false, 180, r47, 37, EColores.Amarillo);
                Alumno al48 = new Alumno("Saul", "Godoy", 20213608, false, 180, r48, 38, EColores.SinSala);
                Alumno al49 = new Alumno("Nestor", "Gomez", 15526498, false, 180, r49, 39, EColores.SinSala);
                Alumno al50 = new Alumno("Santiago", "Perez", 15213698, false, 180, r50, 40, EColores.SinSala);

                alumnos.Add(al1);
                alumnos.Add(al2);
                alumnos.Add(al3);
                alumnos.Add(al4);
                alumnos.Add(al5);
                alumnos.Add(al6);
                alumnos.Add(al7);
                alumnos.Add(al8);
                alumnos.Add(al9);
                alumnos.Add(al10);
                alumnos.Add(al11);
                alumnos.Add(al12);
                alumnos.Add(al13);
                alumnos.Add(al14);
                alumnos.Add(al15);
                alumnos.Add(al16);
                alumnos.Add(al17);
                alumnos.Add(al18);
                alumnos.Add(al19);
                alumnos.Add(al20);
                alumnos.Add(al21);
                alumnos.Add(al22);
                alumnos.Add(al23);
                alumnos.Add(al24);
                alumnos.Add(al25);
                alumnos.Add(al26);
                alumnos.Add(al27);
                alumnos.Add(al28);
                alumnos.Add(al29);
                alumnos.Add(al30);
                alumnos.Add(al31);
                alumnos.Add(al32);
                alumnos.Add(al33);
                alumnos.Add(al34);
                alumnos.Add(al35);
                alumnos.Add(al36);
                alumnos.Add(al37);
                alumnos.Add(al38);
                alumnos.Add(al39);
                alumnos.Add(al40);
                alumnos.Add(al41);
                alumnos.Add(al42);
                alumnos.Add(al43);
                alumnos.Add(al44);
                alumnos.Add(al45);
                alumnos.Add(al46);
                alumnos.Add(al47);
                alumnos.Add(al48);
                alumnos.Add(al49);
                alumnos.Add(al50);



                #endregion

                #region Alta Docente
                Docente dc1 = new Docente("Miriam", "Quiuan", 15458963, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), 100);
                Docente dc2 = new Docente("Rafael", "Suarez", 20454463, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), 110);
                Docente dc3 = new Docente("Alfredo", "Lopez", 18888922, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), 110);
                Docente dc4 = new Docente("Maria", "Luz", 20058111, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), 120);
                Docente dc5 = new Docente("Estela", "Freites", 18958111, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), 120);

                docentes.Add(dc1);
                docentes.Add(dc2);
                docentes.Add(dc3);
                docentes.Add(dc4);
                docentes.Add(dc5);
                #endregion

                #region Alta Administrativo

                Administrativo ad1 = new Administrativo("Sofia", "Gomez", 37558458, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Cocina);
                Administrativo ad2 = new Administrativo("Raul", "Perez", 24558118, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Direccion);
                Administrativo ad3 = new Administrativo("Cecilia", "Soraide", 25858469, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Tesoreria);
                Administrativo ad4 = new Administrativo("Agustin", "Pastor", 24758123, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Porteria);
                Administrativo ad5 = new Administrativo("Agustina", "Lopez", 30052258, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Secretaria);
                Administrativo ad6 = new Administrativo("Nelida", "Monro", 30052258, true, horaEntrada.AddHours(8), horaSalida.AddHours(14), ECargo.Cocina);
                Administrativo ad7 = new Administrativo("Alicia", "Diaz", 30052258, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Secretaria);
                Administrativo ad8 = new Administrativo("Gaston", "Gonzales", 30052258, false, horaEntrada.AddHours(8), horaSalida.AddHours(15), ECargo.Secretaria);
                Administrativo ad9 = new Administrativo("Jose", "Pereyra", 30052258, false, horaEntrada.AddHours(8), horaSalida.AddHours(13), ECargo.Cocina);
                Administrativo ad10 = new Administrativo("Carlos", "Vargas", 30052258, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), ECargo.Porteria);

                empleados.Add(ad1);
                empleados.Add(ad2);
                empleados.Add(ad3);
                empleados.Add(ad4);
                empleados.Add(ad5);
                empleados.Add(ad6);
                empleados.Add(ad7);
                empleados.Add(ad8);
                empleados.Add(ad9);
                empleados.Add(ad10);

                #endregion

                flag = false;
            }

            Console.Beep();
            MessageBox.Show("DATOS CARGADOS");
            #endregion            
        }

        #endregion
    }
}
