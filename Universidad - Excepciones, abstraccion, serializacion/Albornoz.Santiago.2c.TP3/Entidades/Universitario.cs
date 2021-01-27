using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Universitario: Persona
    {
        private int legajo;

        #region Metodos
        public Universitario() { }

        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat(base.ToString());
            retorno.AppendFormat("Legajo: {0}", this.legajo);

            return retorno.ToString();
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Persona personObj = obj as Persona;
            if (personObj == null)
                return false;
            else
                return Equals(personObj);
        }

        protected abstract string ParticiparEnClase();
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            bool retorno = false;

            if(pg1.Nacionalidad== pg2.Nacionalidad)
            {
                if(pg1.DNI== pg2.DNI)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Universitario pg1,Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
