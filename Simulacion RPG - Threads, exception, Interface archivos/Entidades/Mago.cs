using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mago : Campeon
    {

        int intensidadConjuro;

        public Mago(string nombre, int fuerzaAtaque, int intensConjuro)
            : base(nombre, fuerzaAtaque)
        {
            this.intensidadConjuro = intensConjuro;
        }

        public int IntensidadConjuro
        {
            get { return intensidadConjuro; }
            set { intensidadConjuro = value; }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Intensidad Conjuro : " + this.intensidadConjuro);
            return sb.ToString();
        }

        public override float Atacar(Enemigo enemy)
        {
            float retorno = this.FuerzaAtaque * this.IntensidadConjuro * this.CalcularBonificacio(enemy);

            return retorno;
        }

    }
}
