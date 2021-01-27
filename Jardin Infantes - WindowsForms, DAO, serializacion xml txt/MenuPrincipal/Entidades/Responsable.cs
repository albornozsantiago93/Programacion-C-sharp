using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EParentesco
    {
        Madre,
        Padre,
        Abuelo,
        Abuela,
        Tia,
        Tio,
        Otro
    }
    public class Responsable : Persona
    {
        protected EParentesco parentesco;
        protected string telefono;

        #region Constructor

        /// <summary>
        /// Constructor de la clase Responsable con referencia a su clase base persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="parentesco"></param>
        /// <param name="telefono"></param>
        public Responsable(string nombre,string apellido,int dni,bool femenino,EParentesco parentesco,string telefono)
            :base(nombre,apellido,dni,femenino)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Lee y setea el parentesco del responsable
        /// </summary>
        public EParentesco Parentesco
        {
            get
            {
                return this.parentesco;
            }
            set
            {
                this.parentesco= value;
            }
        }

        /// <summary>
        /// Lee y setea el telefono del responsable
        /// </summary>
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }


        #endregion

        #region Metodos

        /// <summary>
        /// Imprime por pantalla datos del responsable
        /// </summary>
        /// <returns>nombre, apellido y telefono</returns>
        public string MostrarNombresTelefonos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Nombre);
            retorno.AppendLine(" ," + base.Apellido);
            retorno.AppendLine(", Telefono: " + this.Telefono.ToString());

            return retorno.ToString();
        }

        /// <summary>
        /// Sobrecarga del metodo base persona
        /// </summary>
        /// <returns>Todos los datos de persona incluyendo tambien relacion y telefono</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine(", Relacion: " + this.Parentesco.ToString());
            retorno.AppendLine(", Telefono: " + this.Telefono.ToString());

            return retorno.ToString();
        }

        #endregion

    }
}
