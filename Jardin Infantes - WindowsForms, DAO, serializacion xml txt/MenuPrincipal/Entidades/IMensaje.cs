using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMensaje<T>
    {
        //No tiene constructores, parametros
        //Propiedades, metodos y atributos, no deja implementarlos
        string MostrarMensaje();

        T Referencia();

    }
}
