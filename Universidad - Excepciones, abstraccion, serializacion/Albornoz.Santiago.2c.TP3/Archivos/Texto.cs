using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            StreamWriter archivoAux = null;

            try
            {
                archivoAux = new StreamWriter(archivo);
                archivoAux.WriteLine(datos);
                retorno = true;
            }
            catch(Exception)
            {
                retorno = false;
            }

            archivoAux.Close();
            return retorno;
        }


        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            StreamReader archivoAux=null;

            try
            {
                archivoAux = new StreamReader(archivo);
                datos = archivoAux.ReadToEnd();
                retorno = true;
            }
            catch(Exception)
            {
                datos = "";
                retorno = false;
            }

            archivoAux.Close();
            return retorno;
        }

    }
}
