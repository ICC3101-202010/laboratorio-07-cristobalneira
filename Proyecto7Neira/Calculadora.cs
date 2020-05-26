using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto7Neira
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }
        double result;
        List<string> historial = new List<string>();

        Clases.Suma suma1 = new Clases.Suma();
        Clases.Resta resta2 = new Clases.Resta();
        Clases.Multiplicacion multiplicador3 = new Clases.Multiplicacion();
        Clases.Division division4 = new Clases.Division();


        private void boton8_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "8";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "2";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "5";
        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + ".";
        }
        //HIST
        private void botonHist_Click(object sender, EventArgs e)
        {
            int c = 1;
            foreach (var item in historial)
            {
                //textBox1.Text = c+". "+item;
                c += 1;
            }
        }

        private void botonRes_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }
        //div
        private void botondiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }
        //AC
        private void botonAC_Click(object sender, EventArgs e)
        {
            textbox.Clear();
        }
        //ANS
        private void botonANS_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            primero = result;
            textbox.Text = textbox.Text + result.ToString();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "3";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "6";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "9";
        }

        private void botonMAS_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }
        //=
        private void botonigual_Click(object sender, EventArgs e)
        {
            try
            {
            
            segundo = double.Parse(textbox.Text);
            double Suma;
            double resta;
            double mult;
            double div;
            string op = "";
            switch(operador)
            {
                case "+":
                    Suma = suma1.Sumar((primero), (segundo));
                    textbox.Text = Suma.ToString();
                    result=primero + segundo;
                    op = primero.ToString() + operador + segundo.ToString() + "=" + result;
                    historial.Add(op);
                    break;
                case "-":
                    resta = resta2.Restar((primero), (segundo));
                    textbox.Text = resta.ToString();
                    result = primero - segundo;
                    op= primero.ToString() + operador + segundo.ToString() + "=" + result;
                    historial.Add(op);
                    break;
                case "x":
                    mult =multiplicador3.Multiplicar((primero), (segundo));
                    textbox.Text = mult.ToString();
                    result = primero * segundo;
                    op= primero.ToString() + operador + segundo.ToString() + "=" + result;
                    historial.Add(op);
                    break;
                case "/":
                    div = division4.Dividir((primero), (segundo));
                    if (segundo == 0)
                    {textbox.Text = "Math Error";}
                    else { textbox.Text = div.ToString(); }
                    result = primero / segundo;
                    op = primero.ToString() + operador + segundo.ToString() + "=" + result;
                    historial.Add(op);
                    break;
            }         
            }
            catch (System.FormatException ep)
            {
                textbox.Text = "Syntax ERROR";
            }
        }
        private void botonx_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }
        //DEL
        private void botonDEL_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length == 1)
                textbox.Text = "";
            else
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "1";
        }
        
        private void boton0_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "0";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxhist_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
