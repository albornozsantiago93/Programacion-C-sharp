using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        protected ECargo cargo;
        public static double salarioBase;

        #region Constructores
        /// <summary>
        /// Constructor de la clase Administrativo y con referencia a su clase base personal y persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="cargo"></param>
        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida,ECargo cargo)
            : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            salarioBase = 30000;
            this.cargo = cargo;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Lee y setea el cargo del administrativo
        /// </summary>
        public ECargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }      

        #endregion

        #region Metodos
        /// <summary>
        /// Calucla el salario dependiendo el cargo del administrativo
        /// </summary>
        /// <returns>Salario del administrativo</returns>
        protected override double CalcularSalario()
        {
            double retorno = 0;

            if(ECargo.Cocina== this.Cargo)
            {
                retorno = ((double)ECargo.Cocina * salarioBase)/100;
            }

            if(ECargo.Direccion== this.Cargo)
            {
                retorno = ((double)ECargo.Direccion * salarioBase) / 100;
            }

            if(ECargo.Porteria == this.Cargo)
            {
                retorno = ((double)ECargo.Porteria * salarioBase) / 100;
            }

            if(ECargo.Secretaria == this.Cargo)
            {
                retorno = ((double)ECargo.Secretaria * salarioBase) / 100;
            }

            if(ECargo.Tesoreria== this.Cargo)
            {
                retorno = ((double)ECargo.Tesoreria * salarioBase) / 100;
            }

            return retorno;
        }

        /// <summary>
        /// Muestra por pantalla los datos del administrativo
        /// </summary>
        /// <returns>Datos de clase persona, personal, cargo y sueldo</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.ToString());
            retorno.AppendLine(", Cargo: " + this.Cargo.ToString());
            retorno.AppendLine(" , Sueldo: " + this.CalcularSalario().ToString());

            return retorno.ToString();
        }

        #endregion


    }
}
