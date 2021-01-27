using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.numero = double.Parse(numero);
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double retorno;

            retorno = n1 - n2;

            return retorno;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double retorno;

            retorno = n1 + n2;

            return retorno;
        }

        public static double operator *(Numero n1,Numero n2)
        {
            double retorno;

            retorno = n1 * n2;

            return retorno;
        }

        public static double operator /(Numero n1,Numero n2)
        {
            double retorno;

            retorno = n1 / n2;

            return retorno;
        }

        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if(double.TryParse(strNumero,out retorno))
            {
                return retorno;
            }

            return retorno;
        }

        private string SetNumero
        {
            set
            {                
                this.numero = ValidarNumero(value);
            }
            get
            {
                return this.numero.ToString();
            }
        }
    }
}
