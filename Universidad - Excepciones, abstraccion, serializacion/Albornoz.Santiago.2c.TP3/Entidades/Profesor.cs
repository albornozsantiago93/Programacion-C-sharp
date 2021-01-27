using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Profesor: Universitario
    {
        #region Parametros
        private static Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Metodos
        private void _randomClases()
        {
            Random random = new Random();
        }

        static Profesor()
        {
            Random random = new Random();
        }

        private Profesor()
        {
            _randomClases();
        }

        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            _randomClases();
        }

        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat(base.MostrarDatos());

            return retorno.ToString();
        }

        public string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Clases del dia: {0}", this.ParticiparEnClase());

            return retorno.ToString();
        }




        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Profesor i,Universidad.EClases clases)
        {
            bool retorno = false;
            
            if(i == clases)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator!=(Profesor i,Universidad.EClases clases)
        {
            return !(i == clases);
        }
        #endregion
    }
}
