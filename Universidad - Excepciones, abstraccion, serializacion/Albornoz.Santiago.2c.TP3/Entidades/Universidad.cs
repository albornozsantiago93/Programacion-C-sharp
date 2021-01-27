using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Universidad
    {
        #region Parametros
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region EClases
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion

        #region Metodos
        public  Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }


        #endregion//FALTA METODO ToString, Mostrar,Leer

        #region Sobrecarga Operadores
        public static bool operator ==(Universidad g,Alumno a)
        {
            bool retorno = false;

            if(g.alumnos.Contains(a))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Universidad g,Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g,Profesor i)
        {
            bool retorno = false;

            if(g.profesores.Contains(i))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Universidad g,Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad g,EClases clase)
        {
            Profesor retorno = null;

            foreach(var auxiliar in g.profesores)
            {
                if(auxiliar==clase)
                {
                    retorno = auxiliar;
                    break;
                }
            }
            return retorno;
        }

        public static Profesor operator !=(Universidad g ,EClases clase)
        {
            Profesor retorno = null;

            foreach(var auxiliar in g.profesores)
            {
                if(auxiliar!= clase)
                {
                    retorno = auxiliar;
                }
            }
            return retorno;
        }

        public static Universidad operator +(Universidad u,Profesor i)
        {
            Universidad retorno = null;

            if(u!=i)
            {
                u.profesores.Add(i);
                retorno = u;
            }
            return retorno;
        }

        public static Universidad operator +(Universidad u,Alumno a)
        {
            Universidad retorno = null;

            if(u!=a)
            {
                u.alumnos.Add(a);
                retorno = u;
            }
            return retorno;
        }
        #endregion//faltan operadores con universidad y clase

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

        public List<Profesor> Profesores
        {
            get
            {
                return profesores;
            }
            set
            {
                profesores= value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return jornada;
            }
            set
            {
                jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada.Insert(i, value);
            }
        }
        #endregion
    }
}
