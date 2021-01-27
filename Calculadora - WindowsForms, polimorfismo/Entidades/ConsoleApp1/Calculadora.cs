using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if(operador=="-"| operador== "+" | operador== "/" | operador== "*")
            {
                retorno = operador;
            }
            return retorno;
        }

        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno=0;

            string operar = ValidarOperador(operador);

            switch(operar)
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;

                case "-":
                    retorno = numero1 - numero2;
                    break;

                case "*":
                    retorno = numero1 * numero2;
                    break;

                case "/":
                    
                   retorno = numero1 / numero2;                   
                   break;
            }
            return retorno;
        }
    }
}
