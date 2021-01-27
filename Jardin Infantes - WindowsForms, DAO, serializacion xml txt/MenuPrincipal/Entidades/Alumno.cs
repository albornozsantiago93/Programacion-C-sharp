using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColores
    {
        Naranja,
        Rojo,
        Amarillo,
        Verde,
        SinSala
    }

    public class Alumno : Persona
    {
        protected EColores colorSala;
        protected int legajo;
        protected float precioCuota;
        protected Responsable responsable;

        #region Constructores

        public Alumno(string nombre,string apellido,int dni,bool femenino,float precioCuota,Responsable responsable)
            :base(nombre,apellido,dni,femenino)
        {
            this.precioCuota = precioCuota;
            this.responsable = responsable;
            this.colorSala = EColores.SinSala;
        }

        /// <summary>
        /// Constructor de la clase alumno con referencia a su clase base y a su propia clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="precioCuota"></param>
        /// <param name="responsable"></param>
        /// <param name="legajo"></param>
        /// <param name="colorSala"></param>
        public Alumno(string nombre,string apellido,int dni,bool femenino,float precioCuota,Responsable responsable,int legajo,EColores colorSala)
            :this(nombre,apellido,dni,femenino,precioCuota,responsable)
        {
            this.colorSala = colorSala;
            this.legajo = legajo;
        }


        #endregion

        #region Propiedades

        /// <summary>
        /// Lee y setea el color de la sala en la que esta el alumno
        /// </summary>
        public EColores ColorSala
        {
            get
            {
                return this.colorSala;
            }
            set
            {
                this.colorSala = value;
            }
        }

        /// <summary>
        /// Lee y setea el legajo del alumno
        /// </summary>
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        /// <summary>
        /// Lee y setea el precio de la cuota del alumno
        /// </summary>
        public float PrecioCuota
        {
            get
            {
                return this.precioCuota;
            }
            set
            {
                this.precioCuota = value;
            }
        }

        /// <summary>
        /// Lee y setea el responsable del alumno
        /// </summary>
        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
            set
            {
                this.responsable = value;
            }
        }

        #endregion

        #region Sobrecarga

        /// <summary>
        /// conversion implicida de un alumno para obtener su Responsable
        /// </summary>
        /// <param name="alumno"></param>
        public static implicit operator Responsable(Alumno alumno)
        {
            return alumno.Responsable;
        }

        /// <summary>
        /// Sobrecarga que analiza si un alumno es igual por su legajo y Responsable
        /// </summary>
        /// <param name="alumno1"></param>
        /// <param name="alumno2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            bool retorno = false;

            if (alumno1.Legajo == alumno2.Legajo)
            {
                if((Responsable)alumno1 == (Responsable)alumno2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Alumno alumno1,Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Imprime por pantalla los datos del alumno y persona en referencia a su base
        /// </summary>
        /// <returns>Persona, legajo, color sala, precio cuota y Responsable</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine(this.Legajo.ToString());
            retorno.AppendLine(this.ColorSala.ToString());
            retorno.AppendLine(this.PrecioCuota.ToString());
            retorno.AppendLine(this.Responsable.ToString());

            return retorno.ToString();

        }

        /// <summary>
        /// Imprime por pantalla nombre y apellido del alumno
        /// </summary>
        /// <returns>Nombre y apellido</returns>
        public string MostrarAlumno()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Nombre);
            retorno.AppendLine(", " + base.Apellido);

            return retorno.ToString();
        }

        #endregion
    }
}
