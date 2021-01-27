using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Alumno : Universitario
    {
        #region Parametros
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region EEstadoCuenta
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region Metodos
        public Alumno() { }

        public Alumno(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad,Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad,Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat(base.MostrarDatos());
            retorno.AppendFormat("Clases que toma: {0}", this.claseQueToma);
            retorno.AppendFormat("Estado de Cuenta: {0}", this, estadoCuenta);

            return retorno.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Toma clases de: {0}", this.claseQueToma);

            return retorno.ToString();
        }

        public string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat(this.MostrarDatos());

            return retorno.ToString();
        }




        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Alumno a,Universidad.EClases clases)
        {
            bool retorno = false;

            if(a.claseQueToma== clases)
            {
                if(a.estadoCuenta!= EEstadoCuenta.Deudor)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Alumno a,Universidad.EClases clases)
        {
            return !(a == clases);
        }
        #endregion
    }
}
