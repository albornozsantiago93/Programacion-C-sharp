using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        protected int dni;
        protected bool femenino;

        #region Constructores

        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        protected Persona(string nombre,string apellido,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        protected Persona(string nombre,string apellido,int dni,bool femenino)
            :this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// lee y setea apellido de persona
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// lee y setea nombre de persona
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// lee y setea dni de persona
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        /// <summary>
        /// lee y setea sexo de persona
        /// </summary>
        public bool Femenino
        {
            get
            {
                return this.femenino;
            }
            set
            {
                this.femenino = value;
            }
        }



        #endregion

        #region Metodos

        /// <summary>
        /// Da formato a string los datos de la persona
        /// </summary>
        /// <returns>Datos de la persona, nombre, apellido, dni y su sexo</returns>
        public virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.Nombre);
            retorno.AppendLine(", " + this.Apellido);
            retorno.AppendLine(", Dni: " + this.Dni.ToString());
            if(this.femenino == true)
            {
                retorno.AppendLine(", Femenino");
            }
            else
            {
                retorno.AppendLine(", Masculino");
            }
            

            return retorno.ToString();
        }

        #endregion
    }
}
