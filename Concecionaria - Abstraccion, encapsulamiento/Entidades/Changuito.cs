using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;

        public enum ETipo
        {
            Dulce,
            Leche,
            Snacks,
            Todos
        }

        #region "Constructores"
        private Changuito()
        {
            this.productos = new List<Producto>();
        }
        public Changuito(int espacioDisponible)
            :this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Mostrar(this,ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="changuito">Elemento a exponer</param>
        /// <param name="tipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>string</returns>
        public static string Mostrar(Changuito changuito, ETipo tipo)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", changuito.productos.Count, changuito.espacioDisponible);
            retorno.AppendLine("");
            foreach (Producto productoAux in changuito.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if(productoAux is Snacks)
                        {
                            retorno.AppendLine(productoAux.Mostrar());
                        }
                        break;


                    case ETipo.Dulce:
                        if(productoAux is Dulce)
                        {
                            retorno.AppendLine(productoAux.Mostrar());
                        }
                        break;

                    case ETipo.Leche:
                        if(productoAux is Leche)
                        {
                            retorno.AppendLine(productoAux.Mostrar());
                        }
                        break;

                    default:
                        retorno.AppendLine(productoAux.Mostrar());
                        break;
                }
            }

            return retorno.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se agregará el elemento</param>
        /// <param name="producto">Objeto a agregar</param>
        /// <returns>changuito</returns>
        public static Changuito operator +(Changuito changuito, Producto producto)
        {
            foreach (Producto productoAux in changuito.productos)
            {
                if (productoAux == producto)
                    return changuito;
            }

            changuito.productos.Add(producto);

            return changuito;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se quitará el elemento</param>
        /// <param name="producto">Objeto a quitar</param>
        /// <returns>changuito</returns>
        public static Changuito operator -(Changuito changuito, Producto producto)
        {
            foreach (Producto productoAux in changuito.productos)
            {
                if (productoAux == producto)
                {
                    changuito.productos.Remove(producto);
                    break;
                }
            }

            return changuito;
        }
        #endregion
    }
}
