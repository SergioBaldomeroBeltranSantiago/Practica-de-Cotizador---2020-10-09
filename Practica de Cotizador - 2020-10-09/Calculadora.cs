using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculadoraPrincipal1 : Form
    {
        bool operacion,zerodiv=false;
        private void Suma_Click(object sender, EventArgs e)
        {
            if(operacion) {
                Display.Text += "+";
                operacion = false;
            }
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            if (operacion) {
                Display.Text += "-";
                operacion = false;
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            if (operacion) {
                Display.Text += "x";
                operacion = false;
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (operacion) {
                Display.Text += "/";
                operacion = false;
            }
        }

        private void Digito1_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
            operacion = true;
        }

        private void Digito2_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
            operacion = true;
        }

        private void Digito3_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
            operacion = true;
        }

        private void Digito4_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
            operacion = true;
        }

        private void Digito5_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
            operacion = true;
        }

        private void Digito6_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
            operacion = true;
        }

        private void Digito7_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
            operacion = true;
        }

        private void Digito8_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
            operacion = true;
        }

        private void Digito9_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
            operacion = true;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            operacion = false;
        }

        private void Digito0_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
            operacion = true;
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            double resultado = Calcular(Leer());
            if(zerodiv==true){
                Display.Text = "Syntax Error.";
            } else {
            Display.Text = Convert.ToString(resultado);
            }
        }

        // Lo que esta comentado de esta forma es codigo que ya no se usa pero lo wa dejar ahi por si se me olvida como le hice para llegar al codigo utilizado.
        /*Lo que esta comentado de esta otra forma son explicaciones de lo que hace el codigo*/

        public ArrayList Leer() {

            /*Esta parte captura la informacion en el TextBox llamado Display en una variable de tipo String.*/
            String entrada_c = Display.Text;
            /*Se convierte la entrada de tipo String en un arreglo de caracteres, para su reasignacion en un ArrayList, no se si este paso sea redundante.*/
            char[] entrada_cc = entrada_c.ToCharArray();
            ArrayList entrada = new ArrayList();
            /*Aqui se recorre cada uno de los caracteres del arreglo de caracteres, y uno por uno se le añaden a la ArrayList , la cual se regresa al metodo Calcular.*/
            foreach (char x in entrada_cc) {
                entrada.Add(x);
            }
            return entrada;
        }

        public double Calcular(ArrayList arreglo) {
            double resultado;
            int cuno=0,cdos=0;
            string opuno="", opdos="";
            while (true) {
                /*Cada vez que ocurre una iteracion, checamos si el ArrayList tiene mas de 1 elemento, en teoria y por como hago los movimientos, 
                 * se modifica un elemento del Array y se borran 2 cada vez que se itera correctamente hasta que solo queda un elemento.*/
                if (arreglo.Count > 1)
                {
                    /*Una vez que comprobamos que hay mas de un elemento, checamos si existen elementos aritmeticos en orden jerarquico.*/
                    if (arreglo.Contains('x') || arreglo.Contains('/'))
                    {
                        //System.Diagnostics.Debug.WriteLine("Array has x or /"); No se usar herramientas de Debug mas que imprimir a consola ; n ;

                        /*Aqui ya sabemos si existe una multiplicacion o division, en este siguiente filtro verificaremos cual de las 2 existe, y cual de las 2 toma prioridad en las operaciones*/
                        if (arreglo.IndexOf('x') != -1 && (arreglo.IndexOf('x') < arreglo.IndexOf('/') || arreglo.IndexOf('/') == -1))
                        {
                            //System.Diagnostics.Debug.WriteLine("Calculating x");
                            //mov = arreglo.IndexOf('x');
                            //x = mov - 1;
                            //y = mov + 1;
                            //one = Convert.ToInt32(Convert.ToString(arreglo[x]));
                            //two = Convert.ToInt32(Convert.ToString(arreglo[y]));
                            //arreglo[x] = one * two;
                            //arreglo.RemoveAt((arreglo.IndexOf('x')));
                            //arreglo[(arreglo.IndexOf('x') - 1)] = Convert.ToString(opuno*opdos);
                            //arreglo.RemoveAt((arreglo.IndexOf('x') + 1));
                            //arreglo.Remove('x');

                            /*Estos for son la forma utilizada para capturar números de mas de uno digito.*/
                            for (int i = (arreglo.IndexOf('x') - 1); i >= 0; i--)
                            {
                                if (!(arreglo[i].Equals('x') || arreglo[i].Equals('/') || arreglo[i].Equals('+') || arreglo[i].Equals('-')))
                                {
                                    opuno = arreglo[i] + opuno;
                                    cuno++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            for (int j = (arreglo.IndexOf('x') + 1); j <= (arreglo.Count - 1); j++)
                            {
                                if (!(arreglo[j].Equals('x') || arreglo[j].Equals('/') || arreglo[j].Equals('+') || arreglo[j].Equals('-')))
                                {
                                    opdos += arreglo[j];
                                    cdos++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            /*Aqui hacemos la operacion como tal, y la asignamos al indice mas bajo que forma parte de la multiplicacion de los numeros*/
                            arreglo[(arreglo.IndexOf('x') - cuno)] = Convert.ToString(Convert.ToInt32(opuno) * Convert.ToInt32(opdos));

                            /*Al final, borramos todos los demas indices involucrados en el proceso, menos aquel donde se guarda el resultado de la operacion.*/
                            if (cuno > 1)
                            {
                                for (int k = 1; k < cuno; k++)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('x') - 1);
                                }
                            }
                            for (int l = 0; l < cdos; l++)
                            {
                                if (arreglo.Count > 2)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('x') + 1);
                                }
                                else {
                                    break;
                                }
                            }
                            arreglo.Remove('x');
                            opuno = opdos = "";
                            cuno = cdos = 0;
                            continue;
                        }
                        else if (arreglo.IndexOf('/') != -1 && (arreglo.IndexOf('/') < arreglo.IndexOf('x') || arreglo.IndexOf('x') == -1))
                        {
                            for (int i = (arreglo.IndexOf('/') - 1); i >= 0; i--)
                            {
                                if (!(arreglo[i].Equals('x') || arreglo[i].Equals('/') || arreglo[i].Equals('+') || arreglo[i].Equals('-')))
                                {
                                     opuno = arreglo[i] + opuno;
                                    cuno++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            for (int j = (arreglo.IndexOf('/') + 1); j <= (arreglo.Count - 1); j++)
                            {
                                if (!(arreglo[j].Equals('x') || arreglo[j].Equals('/') || arreglo[j].Equals('+') || arreglo[j].Equals('-')))
                                {
                                    opdos += arreglo[j];
                                    cdos++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (Convert.ToInt32(opdos) != 0)
                            {
                                arreglo[(arreglo.IndexOf('/') - cuno)] = Convert.ToString(Convert.ToInt32(opuno) / Convert.ToInt32(opdos));
                            }
                            else {
                                arreglo[(arreglo.IndexOf('/') - cuno)] = 0;
                                MessageBox.Show("Division invalida, sustituyendo valor con 0.");
                                zerodiv = true;
                            }
                            for (int k = 1; k < cuno; k++)
                            {
                                arreglo.RemoveAt(arreglo.IndexOf('/') - 1);
                            }
                            for (int l = 0; l < cdos; l++)
                            {
                                if (arreglo.Count > 2)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('/') + 1);
                                }
                                else {
                                    break;
                                }
                            }
                            arreglo.Remove('/');
                            opuno = opdos = "";
                            cuno = cdos = 0;
                            continue;
                        }
                    }
                    if (arreglo.Contains('+') || arreglo.Contains('-')) {
                        if (arreglo.IndexOf('+') != -1 && (arreglo.IndexOf('+') < arreglo.IndexOf('-') || arreglo.IndexOf('-') == -1))
                        {
                            for (int i = (arreglo.IndexOf('+') - 1); i >= 0; i--)
                            {
                                if (!(arreglo[i].Equals('x') || arreglo[i].Equals('/') || arreglo[i].Equals('+') || arreglo[i].Equals('-')))
                                {
                                    opuno = arreglo[i] + opuno;
                                    cuno++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            for (int j = (arreglo.IndexOf('+') + 1); j <= (arreglo.Count - 1); j++)
                            {
                                if (!(arreglo[j].Equals('x') || arreglo[j].Equals('/') || arreglo[j].Equals('+') || arreglo[j].Equals('-')))
                                {
                                    opdos += arreglo[j];
                                    cdos++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            arreglo[(arreglo.IndexOf('+') - cuno)] = Convert.ToString(Convert.ToInt32(opuno) + Convert.ToInt32(opdos));
                            if (cuno > 1) {
                                for (int k = 1; k < cuno; k++)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('+') - 1);
                                }
                            }
                            for (int l = 0; l < cdos; l++)
                            {
                                if (arreglo.Count > 2)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('+') + 1);
                                }
                                else {
                                    break;
                                }
                            }
                            arreglo.Remove('+');
                            opuno = opdos = "";
                            cuno = cdos = 0;
                            continue;
                        }
                        else if (arreglo.IndexOf('-') != -1 && (arreglo.IndexOf('-') < arreglo.IndexOf('+') || arreglo.IndexOf('+') == -1))
                        {
                            for (int i = (arreglo.IndexOf('-') - 1); i >= 0; i--)
                            {
                                if (!(arreglo[i].Equals('x') || arreglo[i].Equals('/') || arreglo[i].Equals('+') || arreglo[i].Equals('-')))
                                {
                                    opuno = arreglo[i] + opuno;
                                    cuno++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            for (int j = (arreglo.IndexOf('-') + 1); j <= (arreglo.Count - 1); j++)
                            {
                                if (!(arreglo[j].Equals('x') || arreglo[j].Equals('/') || arreglo[j].Equals('+') || arreglo[j].Equals('-')))
                                {
                                    opdos += arreglo[j];
                                    cdos++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            arreglo[(arreglo.IndexOf('-') - cuno)] = Convert.ToString(Convert.ToInt32(opuno) - Convert.ToInt32(opdos));
                            if (cuno > 1) {
                                for (int k = 1; k < cuno; k++)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('-') - 1);
                                }
                            }
                            for (int l = 0; l <= cdos; l++)
                            {
                                if (arreglo.Count > 2)
                                {
                                    arreglo.RemoveAt(arreglo.IndexOf('-') + 1);
                                }
                                else {
                                    break;
                                }
                            }
                            arreglo.Remove('-');
                            opuno = opdos = "";
                            cuno = cdos = 0;
                            continue;
                        }
                    }
                }
                else {
                    resultado = Convert.ToInt32(Convert.ToString(arreglo[0]));
                    break;
                }
            }
            return resultado;
        }

        public CalculadoraPrincipal1()
        {
            InitializeComponent();
            operacion = false;
        }
    }
}
