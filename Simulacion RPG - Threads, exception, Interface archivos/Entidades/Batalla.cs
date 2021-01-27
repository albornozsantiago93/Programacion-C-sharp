using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoMensaje(string mensaje);

    public class Batalla : IArchivo<string>
    {
        private Enemigo enemy;
        private Thread hiloBatalla;
        private List<Campeon> listaHeroes;
        public event DelegadoMensaje eventoStatus;
       

        public Batalla()
        {
            this.listaHeroes = new List<Campeon>();
            this.hiloBatalla = new Thread(ComenzarBatalla);
        }

        public void ComenzarBatalla()
        {
            Enemigo enemigoAux = this.enemy;
            StringBuilder dañoAEnemigo = new StringBuilder();

            do
            {
                foreach(Campeon heroe in listaHeroes)
                {
                    enemigoAux.Vida= enemigoAux.Vida - heroe.Atacar(enemigoAux);
                    dañoAEnemigo.AppendLine("Enemigo " + enemigoAux.Nombre);
                    dañoAEnemigo.Append("recibio " + heroe.Atacar(enemigoAux));
                    dañoAEnemigo.Append("de " + heroe.Nombre);

                    this.Escribir(dañoAEnemigo.ToString(), "DatosDeBatalla");
                }

            } while (enemigoAux.Vida > 0);

            this.hiloBatalla.Abort();
            eventoStatus.Invoke("Simulacion finalizada, enemigo derrotado");
        }

        public void CrearEnemigo()
        {
            this.enemy = new Enemigo(5000, 70);
        }


        public void CrearHeroesIniciales()
        {
            Mago unMago = new Mago("Mago Pepe", 21, 76);
            if (listaHeroes + unMago)
            {
                eventoStatus.Invoke("Cargado el mago " + unMago.ToString());
            }
            Guerrero unGuerrero = new Guerrero("Romeo Gatuso ", 50, ETipoEspada.Katana);
            if (listaHeroes + unGuerrero)
            {
                eventoStatus.Invoke("Cargado el guerrero " + unGuerrero.ToString());
            }
        }

        public void IniciarHilo()
        {
            if(!(this.hiloBatalla.IsAlive))
                this.hiloBatalla.Start();
        }

        /// <summary>
        /// Utilizar el método ESCRIBIR de esta clase para poder registrar quien y cuánto daño 
        /// le ha hecho al enemigo en un archivo de texto.
        /// </summary>
        /// <param name="informacionAEscribir"></param>
        /// <param name="nombreArchivo"></param>
        public void Escribir(string informacionAEscribir, string nombreArchivo)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + nombreArchivo;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path);
                writer.WriteLine(informacionAEscribir);              
            }
            catch(Exception)
            {
                throw new Exception("Error al escribir en el archivo");
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
