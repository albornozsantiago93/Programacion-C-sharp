using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public abstract class Persona
    {
        #region Parametros
        private string apellido;
        private string nombre;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region ENacionalidad
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Metodos
        public Persona()
        {

        }

        public Persona(string nombre,string apellido,ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.dni = 0;
        }

        public Persona(string nombre,string apellido,int dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre,string apellido,string dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            int.TryParse(dni,out this.dni);
        }

        public string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Nombre: {0}", this.nombre);
            retorno.AppendFormat("Apellido: {0}", this.apellido);
            retorno.AppendFormat("Dni: {0}", this.dni);
            retorno.AppendFormat("Nacionalidad: {0}", this.nacionalidad);

            return retorno.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            int retorno = 0;

            switch(nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if(dato>1 && dato <89999999)
                    {
                        retorno = dato;
                    }
                    break;

                case ENacionalidad.Extranjero:
                    if(dato >89999999 && dato<99999999)
                    {
                        retorno = dato;
                    }
                    break;
            }
            return retorno;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            Regex rgx= new Regex(@"mal");

            if(rgx.IsMatch(dato))
            {
                int.TryParse(dato, out retorno);
            }
            else
            {

            }
            return retorno;
        }

        private string ValidarNombre(string dato)
        {
            string retorno = " ";
            Regex rgx = new Regex(@"[a - zA - ZñÑ\s]{ 2,50}");

            if(rgx.IsMatch(dato))
            {
                retorno = dato;
            }
            return retorno;
        }
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
               return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string StringToDNI
        {
            set
            {
                int.TryParse(value, out this.dni);
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }


        #endregion
    }
}
