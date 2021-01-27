using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal , IMensaje<Docente>
    {
        private double valorHora;
        private bool turnoMañana;        

        #region Constructores

        /// <summary>
        /// Contructor de la clase docente, con referencia a su clase base personal y tambien a su clase base persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="valorHora"></param>

        public Docente(string nombre,string apellido,int dni,bool femenino,DateTime horaEntrada,DateTime horaSalida,double valorHora)
            :base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.valorHora = valorHora;
        }

        public Docente(string nombre, string apellido,int dni, bool femenino,DateTime horaEntrada, DateTime horaSalida,double valorHora, bool turnoMañana)
            :this(nombre,apellido,dni,femenino,horaEntrada,horaSalida,valorHora)
        {
            this.turnoMañana = turnoMañana;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad, lee y setaa el valor de hora del docente
        /// </summary>
        public double ValorHora
        {
            get
            {
                return this.valorHora;
            }
            set
            {
                this.valorHora = value;
            }
        }
        
        /// <summary>
        /// Calcula y retorna la cantidad de horas
        /// </summary>
        public double HorasMensuales
        {
            get
            {
                double retorno;

                retorno = HoraSalida.Hour - HoraEntrada.Hour;

                return retorno;
            }
        }
        
        /// <summary>
        /// Propiedad, lee y setea el turno del docente
        /// </summary>
        public bool TurnoMañana
        {
            get
            {
                return this.turnoMañana;
            }
            set
            {
                this.turnoMañana = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para obtener el salario, calculando las horas trabajadas por el valor de hora
        /// </summary>
        /// <returns>Sueldoo del docente</returns>
        protected override double CalcularSalario()
        {
            double retorno;

            retorno = ((HorasMensuales) * ValorHora) *20;

            return retorno;
        }

        /// <summary>
        /// Imprime por pantalla nombre, apellido y sueldo
        /// </summary>
        /// <returns>String nombre, apellido y sueldo</returns>
        public string mostrarDocenteSueldo()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.Apellido.ToString());
            retorno.AppendLine(", " + this.nombre.ToString());
            retorno.AppendLine(", Sueldo: $" + this.CalcularSalario().ToString());

            return retorno.ToString();
        }

        /// <summary>
        /// Override del meotdo base toString, mas los datos del docente, valor  hora y sueldo
        /// </summary>
        /// <returns>String con todos los datos de la clase docente</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.ToString());
            retorno.AppendLine(", Valor por hora: " + this.ValorHora.ToString());
            retorno.AppendLine(", Salario: " + this.CalcularSalario().ToString());

            return retorno.ToString();
        }

        public string MostrarMensaje()
        {
            throw new NotImplementedException();
        }

        public Docente Referencia
        {
            get
            {
                return this;
            }
            set
            {
                this.Dni = value.Dni;
            }
        }

        #endregion

    }
}
