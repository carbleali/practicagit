using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste = 0;
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rb1.Checked)
            {
                tipoTelegrama = 'o';
            }
            else if (rb2.Checked)
            {
                tipoTelegrama = 'u';
            }
                numPalabras = textoTelegrama.Split().Length;
                if (tipoTelegrama == 'o')
                    if (numPalabras <= 10)
                        coste = 2.5;
                    else
                        coste = 2.5 + 0.5 * (numPalabras - 10);
                else
                if (tipoTelegrama == 'u')
                    if (numPalabras <= 10)
                        coste = 5;
                    else
                        coste = 5 + 0.75 * (numPalabras - 10);
                txtPrecio.Text = coste.ToString() + " euros";
            
        }
    }
}
