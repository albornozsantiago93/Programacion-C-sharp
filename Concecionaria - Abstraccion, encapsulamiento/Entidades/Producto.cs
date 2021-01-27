using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }

        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;


        /// <summary>
        /// Inicializa un nuevo Producto con parametros
        /// </summary>
        /// <param name="codigo">codigo del producto</param>
        /// <param name="marca">marca del producto</param>
        /// <param name="color">color del paquete</param>
        /// <returns></returns>
        public Producto(string codigo,EMarca marca,ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias { get; }
        

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Sobrecarga del operador para dar formato a los elementos de la clase.
        /// </summary>
        /// <returns></returns>
        public static explicit operator string(Producto producto)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("CODIGO DE BARRAS: {0}\r\n", producto.codigoDeBarras);
            retorno.AppendFormat("MARCA          : {0}\r\n", producto.marca);
            retorno.AppendFormat("COLOR EMPAQUE  : {0}\r\n", producto.colorPrimarioEmpaque);
            retorno.AppendLine("---------------------");

            return retorno.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            bool retorno = false;
                
            if (producto1.codigoDeBarras == producto2.codigoDeBarras)
            {
                 retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1.codigoDeBarras == producto2.codigoDeBarras);
        }
    }
}
