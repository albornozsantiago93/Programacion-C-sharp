using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        private string mensajeBase;

        #region Metodos
        public DniInvalidoException() : base() { }


        public DniInvalidoException(Exception e):base()
        {
            this.mensajeBase = e.Message;
        }

        public DniInvalidoException(string messege) : base(messege)
        {
            this.mensajeBase = messege;
        }

        public DniInvalidoException(string messege, Exception e) : base(messege, e)
        {
            this.mensajeBase = messege;
        }
        
        #endregion
    }
}
