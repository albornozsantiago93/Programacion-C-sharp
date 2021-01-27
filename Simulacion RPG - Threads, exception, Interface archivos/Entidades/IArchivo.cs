using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivo <T>
    {
        void Escribir(T informacionAEscribir, string nombreArchivo);
    }
}
