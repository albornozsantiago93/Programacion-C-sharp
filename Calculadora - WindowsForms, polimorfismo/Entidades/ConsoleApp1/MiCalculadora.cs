using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }

        public void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(double.Parse(this.txtNumero1.Text));
            Numero numero2 = new Numero(double.Parse(this.txtNumero2.Text));

            string operador = this.cmbOperador.Text;


            lblResultado.Text = Convert.ToString(Calculadora.Operar(numero1,numero2,operador));


        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "";
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double numeroDecimal;
            string cadenaMostrar="";

            numeroDecimal = double.Parse(this.lblResultado.Text);

            if(numeroDecimal>0)
            {
                string cadena = "";

                while(numeroDecimal>0)
                {
                    if(numeroDecimal % 2 ==0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroDecimal = (int)(numeroDecimal / 2);
                }
                cadenaMostrar = cadena;
            }
            else
            {
                if(numeroDecimal== 0)
                {
                    cadenaMostrar = "0";
                }
            }

            lblResultado.Text = cadenaMostrar;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            char[] arrayNumeros = this.lblResultado.Text.ToCharArray();
            string cadenaMostrar = "";
            int suma = 0;

            Array.Reverse(arrayNumeros);
            

            for(int i=0;i<arrayNumeros.Length;i++)
            {
                if(arrayNumeros[i] == '1')
                {
                    suma += (int)Math.Pow(2, i);
                }
            }
            cadenaMostrar = suma.ToString();

            lblResultado.Text = cadenaMostrar;
        }
    }
}
