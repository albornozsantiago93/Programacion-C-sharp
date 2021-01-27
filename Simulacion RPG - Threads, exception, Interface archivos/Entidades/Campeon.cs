using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Campeon
    {

        private int fuerzaAtaque;
        private string nombre;

        #region Propiedades
        public int FuerzaAtaque
        {
            get { return fuerzaAtaque; }
            set { fuerzaAtaque = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Campeon(string nombre, int fuerzaAtaque)
        {
            this.nombre = nombre;
            this.fuerzaAtaque = fuerzaAtaque;
        }
        #endregion

        public abstract float Atacar(Enemigo enemy);

        #region operadores

        public static bool operator ==(List<Campeon> lista, Campeon unCampeon)
        {
            bool retorno = false;

            foreach(Campeon campeonAux in lista)
            {
                if(campeonAux.Nombre == unCampeon.Nombre)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(List<Campeon> lista, Campeon unCampeon)
        {
            return !(lista == unCampeon);
        }

        public static bool operator +(List<Campeon> lista, Campeon unCampeon)
        {
            bool retorno = true;

            if(lista == unCampeon)
            {
                throw new CampeonYaExistenteException("El campeon ingresado ya existe");
            }
            return retorno;
        }

        public virtual string toString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Nombre: " + this.Nombre);
            retorno.Append("Fuerza de ataque: " + this.FuerzaAtaque.ToString());

            return retorno.ToString();
        }

        #endregion




    }
}
