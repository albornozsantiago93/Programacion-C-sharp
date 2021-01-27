using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<IMensaje> docentes = new List<IMensaje>();
            DateTime horaEntrada = new DateTime();
            DateTime horaSalida = new DateTime();

            Docente dc1 = new Docente("Miriam", "Quiuan", 15458963, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), 100);
            Docente dc2 = new Docente("Rafael", "Suarez", 20454463, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), 110);
            Docente dc3 = new Docente("Alfredo", "Lopez", 18888922, false, horaEntrada.AddHours(8), horaSalida.AddHours(17), 110);
            Docente dc4 = new Docente("Maria", "Luz", 20058111, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), 120);
            Docente dc5 = new Docente("Estela", "Freites", 18958111, true, horaEntrada.AddHours(8), horaSalida.AddHours(17), 120);

            docentes.Add(dc1);
            docentes.Add(dc2);
            docentes.Add(dc3);
            docentes.Add(dc4);
            docentes.Add(dc5);

            docentes.Add(new Aula(EColores.Amarillo, ETurno.Mañana, dc1));
            docentes.Add(new Aula(EColores.Amarillo, ETurno.Mañana, dc2));
            docentes.Add(new Aula(EColores.Naranja, ETurno.Mañana, dc3));
            docentes.Add(new Aula(EColores.Rojo, ETurno.Tarde, dc4));
            docentes.Add(new Aula(EColores.Rojo, ETurno.Tarde, dc5));

            string salida = " ";

            foreach(IMensaje item in docentes)
            {
                salida += item.MostrarMensaje();
            }

            Assert.IsTrue(salida.Length > 1);
        }
    }
}
