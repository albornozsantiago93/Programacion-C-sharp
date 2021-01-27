using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// o Si el campeón recibido es un mago, se deberá preguntar si la resistencia a magia del enemigo es menor a la intensidad del conjuro del mago. Si lo es, la función devolverá 1.20f.
        /// o Si el campeón recibido es un guerrero y su tipo de espada es una katana, devolverá como bonificación 1.25f.
        /// o Si el campeón recibido es un guerrero y su tipo de espada es una cimitarra, devolverá como bonificación 1.15f.
        /// o Si no es ninguno de los casos anteriores, devolverá 1.
        /// </summary>
        /// <param name="champion"></param>
        /// <param name="enemy"></param>
        /// <returns></returns>
        public static float CalcularBonificacio(this Campeon champion, Enemigo enemy)
        {
            float retorno = 1;

            if(champion is Mago)
            {
                Mago magoAux = (Mago)champion;
                if(enemy.ResistenciaMagia < magoAux.IntensidadConjuro )
                {
                    retorno = (float)1.20;
                }
            }
            if(champion is Guerrero)
            {
                Guerrero guerreroAux = (Guerrero)champion;
                
                if(guerreroAux.TipoEspada == ETipoEspada.Katana)
                {
                    retorno = (float)1.25;
                }
                if(guerreroAux.TipoEspada == ETipoEspada.Cimitarra)
                {
                    retorno = (float)1.15;
                }
            }
            return retorno;
        }

    }
}
