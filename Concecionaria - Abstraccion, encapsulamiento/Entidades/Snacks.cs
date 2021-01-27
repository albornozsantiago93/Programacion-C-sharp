using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks: Producto
    {
        /// <summary>
        /// Inicializa un nuevo Snacks con parametros
        /// </summary>
        /// <param name="codigo">codigo del snacks</param>
        /// <param name="marca">marca del snacks</param>
        /// <param name="color">color del snacks</param>
        /// <returns></returns>
        public Snacks(EMarca marca, string codigo, ConsoleColor color) 
            : base(codigo, marca, color)
        {

        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        /// <summary>
        /// Muesta por pantalla informacion de snack y los elementos heredados
        /// </summary>
        /// <returns>todos los datos a mostrar</returns>

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
