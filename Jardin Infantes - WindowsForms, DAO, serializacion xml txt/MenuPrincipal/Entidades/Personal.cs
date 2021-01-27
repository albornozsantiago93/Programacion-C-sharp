using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ECargo
    {
        Porteria= 100,
        Cocina= 110,
        Secretaria= 140,
        Tesoreria= 240,
        Direccion= 180
    }
    public abstract class Personal : Persona
    {
        protected DateTime horaEntrada;
        protected DateTime horaSalida;

        #region Constructores

        /// <summary>
        /// Constructor de la clase personal y con referencia a su clase base persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        protected Personal(string nombre,string apellido,int dni,bool femenino,DateTime horaEntrada,DateTime horaSalida)
            :base(nombre,apellido,dni,femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// lee y setea la hora de entrada del personal
        /// </summary>
        public DateTime HoraEntrada
        {
            get
            {
                return this.horaEntrada;
            }
            set
            {
                this.horaEntrada = value;
            }
        }

        /// <summary>
        /// lee y setea la hora de salida del personal
        /// </summary>
        public DateTime HoraSalida
        {
            get
            {
                return this.horaSalida;
            }
            set
            {
                this.horaSalida = value;
            }
        }

        /// <summary>
        /// setea el salario del personal
        /// </summary>
        public double Salario
        {
            get
            {
                return this.CalcularSalario();
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo abstracto, sera desarrollado en sus derivadas administrativo y docente
        /// </summary>
        /// <returns>Salario del personal</returns>
        protected abstract double CalcularSalario();

        /// <summary>
        /// Da formato to string a personal
        /// </summary>
        /// <returns>todos los datos del persona, incluyendo hora entrada y hora salida</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine(this.HoraEntrada.ToString());
            retorno.AppendLine(this.HoraSalida.ToString());

            return retorno.ToString();
        }

        #endregion
        
    }
}
