using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jornada
    {
        #region Parametros
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #endregion

        #region Metodos
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase,Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        public string Leer()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Clase: {0}", this.clase);
            retorno.AppendFormat("Instructor: {0}", this.instructor);
            retorno.AppendFormat("Alumnos: {0}",this.alumnos);
            foreach(var auxiliar in this.alumnos)
            {
                retorno.AppendFormat("" + auxiliar.ToString());
            }
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Leer();
        }

        public bool Guardar(Jornada jornada)
        {
            
        }

        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            if(j.alumnos.Contains(a))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jornada j,Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j,Alumno a)
        {
            Jornada retorno = null;

            if(j!=a)
            {
                j.alumnos.Add(a);
                retorno = j;
            }
            return retorno;
        }
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return clase;
            }
            set
            {
                clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return instructor;
            }
            set
            {
                instructor = value;
            }
        }
        #endregion
    }
}
