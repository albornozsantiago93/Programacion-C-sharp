using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum ETipoEspada
    {
        Katana,
        Cimitarra
    }
    public class Guerrero : Campeon
    {
        ETipoEspada tipoEspada;
        public ETipoEspada TipoEspada
        {
            get { return tipoEspada; }
            set { tipoEspada = value; }
        }

        public Guerrero(string nombre, int fuerzaAtaque, ETipoEspada tipEsp) : base(nombre, fuerzaAtaque)
        {
            this.tipoEspada = tipEsp;
        }

        public override float Atacar(Enemigo enemy)
        {
            float retorno = this.FuerzaAtaque * this.CalcularBonificacio(enemy);

            return retorno;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Tipo de espada : " + this.TipoEspada);
            return sb.ToString();
        }

    }
}
