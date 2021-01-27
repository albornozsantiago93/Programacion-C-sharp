using System;
using System.Windows.Forms;
using Entidades;

namespace FormularioPrincipal
{
    public partial class Simulador : Form
    {
        Batalla batalla;
        public delegate void DelegadoBatalla();
        DelegadoBatalla delegadoBatallador;

        public Simulador()
        {
            InitializeComponent();
            batalla = new Batalla();
            batalla.eventoStatus += Status;
            delegadoBatallador = new DelegadoBatalla(batalla.CrearHeroesIniciales);
            delegadoBatallador += batalla.CrearEnemigo;
            delegadoBatallador += batalla.IniciarHilo;
          
        }

        public void Status(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void IniciarSimulacion_click(object sender, EventArgs e)
        {
            delegadoBatallador.Invoke();
        }

        private void Simulador_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }
    }
}
