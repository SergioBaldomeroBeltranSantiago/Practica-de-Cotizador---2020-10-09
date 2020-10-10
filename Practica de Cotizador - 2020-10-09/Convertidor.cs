using Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_Cotizador___2020_10_09
{
    public partial class Cotizador : Form
    {
        public Cotizador()
        {
            InitializeComponent();
            MXNusd.Checked = false;
            USDmxn.Checked = false;
        }

        private void MenuCalculadora_Click(object sender, EventArgs e)
        {
            CalculadoraPrincipal1 x = new CalculadoraPrincipal1();
            x.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir y cancelar la operacion?", "Cancelar operacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
        }

        private float StringInt(string entrada) {
            float salida;
            double nx;
            bool convertidor = Double.TryParse(entrada, out nx);
            if (convertidor)
            {
                salida = (float)nx;
            }
            else {
                salida = 0;
            }
            return salida;
        }

        private void Process_Click(object sender, EventArgs e)
        {
            if ((!Input.Text.Equals("")) && (MXNusd.Checked || USDmxn.Checked))
            {
                float num = StringInt(Input.Text);
                if (MXNusd.Checked)
                {
                    float resultado = (float)(num / 21.13);
                    Output.Text = (resultado + " USD.");
                }
                else {
                    float resultado = (float)(num * 21.13);
                    Output.Text = (resultado + " MXN.");
                }
            }
            else {
                if (Input.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar una cantidad a convertir para que el programa funcione.");
                }
                else if (MXNusd.Checked == false & USDmxn.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar si desea convertir de dolares a pesos o viceversa para que el programa funcione.");
                }
                else {
                    MessageBox.Show("Debe ingresar una cantidad y seleccionar el tipo de conversion para que el programa funcione.");
                }
            }
        }
    }
}
