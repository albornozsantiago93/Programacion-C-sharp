using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETurno
    {
        Mañana,
        Tarde
    }
    public class Aula : IMensaje<Aula>
    {
        protected List<Alumno> alumnos;
        protected EColores colorSala;
        protected Docente docente;
        protected ETurno turno;

        #region Constructores

        public Aula()
        {
            alumnos = new List<Alumno>(30);
        }

        /// <summary>
        /// Constructor de la clase aula y hace referncia a su mismo constructor por defecto para inicializar la lista de alumnos
        /// </summary>
        /// <param name="colorSala"></param>
        /// <param name="turno"></param>
        /// <param name="docente"></param>
        public Aula(EColores colorSala,ETurno turno,Docente docente)
            :this()
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Lee y setea la lisa de alumnos
        /// </summary>
        public List<Alumno> Alumnos
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

        /// <summary>
        /// Lee y setea el color de la sala del aula
        /// </summary>
        public EColores ColorSala
        {
            get
            {
                return this.colorSala;
            }
            set
            {
                this.colorSala = value;
            }
        }

        public Docente Docente
        {
            get
            {
                return this.docente;
            }
            set
            {
                this.docente = value;
            }
        }

        /// <summary>
        /// Lee y setea el turno del aula
        /// </summary>
        public ETurno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno = value;
            }
        }

        #endregion

        #region Sobrecarga
        /// <summary>
        /// Sobrecarga para añadir un alumno al aula
        /// </summary>
        /// <param name="aula"></param>
        /// <param name="alumno"></param>
        /// <returns>true si se agrego, false si ya estaba</returns>
        public static bool operator +(Aula aula,Alumno alumno)
        {
            bool retorno = false;

            foreach(Alumno alumnoAux in aula.alumnos)
            {
                if(alumnoAux != alumno)
                {
                    aula.alumnos.Add(alumno);
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Sobrecarga del metodo a base, muestra los datos por pantalla del aula
        /// </summary>
        /// <returns>Nombre del docente, color de sala,  turno y la lista de alumnos</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.Docente.Nombre + this.Docente.Apellido);
            retorno.AppendLine(this.ColorSala.ToString());
            retorno.AppendLine(this.Turno.ToString());
            
            foreach(Alumno alumnoAux in Alumnos)
            {
                retorno.AppendLine(alumnoAux.Nombre + alumnoAux.Apellido);
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Implementacion de IMensaje
        /// </summary>
        /// <returns></returns>
        public string MostrarMensaje()
        {
            return this.ToString();
        }


        public Aula Referencia
        {
            get
            {
                return this;
            }
            set
            {
                this.Docente = value.Docente;
            }
        }
        #endregion


    }
}
