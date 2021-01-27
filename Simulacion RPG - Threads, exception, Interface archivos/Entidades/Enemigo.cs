using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace Entidades
{
    public class Enemigo : IArchivo<Enemigo>
    {

        private string nombre;
        private int resistenciaMagia;
        private float vida;

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int ResistenciaMagia
        {
            get { return resistenciaMagia; }
            set { resistenciaMagia = value; }
        }
        public float Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        #endregion


        public Enemigo()
        {
            this.Nombre = "El Malote";
        }

        public Enemigo(float vida, int resistenciaMagia)
        {
            this.resistenciaMagia = resistenciaMagia;
            this.vida = vida;
        }

        public void Escribir(Enemigo informacionAEscribir, string nombreArchivo)
        {

        }

        

    }
}
