using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo
        {
            Entera,
            Descremada
        }

        private ETipo tipo;

        /// <summary>
        /// inicializa una nueva leche con parametros, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string condigo, ConsoleColor color)
            : base(condigo,marca,color)
        {
            this.tipo = ETipo.Entera;
        }

        /// <summary>
        ///inicializa una nueva leche con parametros incluyendo el tipo de leche
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca,string codigo,ConsoleColor color, ETipo tipo)
            : this(marca,codigo,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// muestra la informacion de leche y sus elementos heredados
        /// </summary>
        /// <returns>string</returns>
        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("LECHE");
            retorno.AppendLine(base.Mostrar());
            retorno.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            retorno.AppendLine("TIPO : " + this.tipo);
            retorno.AppendLine("");
            retorno.AppendLine("---------------------");

            return retorno.ToString();
        }
    }
}
