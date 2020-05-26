using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
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
        public List<string> historial = new List<string>();
        public List<string> historialenlista = new List<string>();

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
        int h = 0;
        private void botonHist_Click(object sender, EventArgs e)
        {
            
            if (h % 2 == 0) 
            {
                Reset.Show();
                listBox1.Show();
                int numeros = 1;
                foreach (var item in historial)
                {
                    
                    string operacion = numeros.ToString() + ". " + item;
                    listBox1.Items.Add(operacion);
                    historialenlista.Add(operacion);
                    numeros += 1;
                }
            }
            else 
            {
                foreach (var item in historialenlista)
                {
                    listBox1.Items.Remove(item);     
                }
                listBox1.Hide();
                Reset.Hide();
            }
            h += 1;
        }

        private void botonRes_Click(object sender, EventArgs e)
        {
            operador = "-";
            try { primero = double.Parse(textbox.Text); }
            catch (System.FormatException) { textbox.Text = "Syntax Error"; };
            textbox.Clear();
        }
        //div
        private void botondiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            try { primero = double.Parse(textbox.Text); }
            catch (System.FormatException) { textbox.Text = "Syntax Error"; }
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
            try { primero = double.Parse(textbox.Text); }
            catch (System.FormatException) { textbox.Text = "Syntax Error"; }
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
                if(primero == 0) { textbox.Text = "0"; }
                else { textbox.Text = "Syntax ERROR"; }
                
            }
        }
        private void botonx_Click(object sender, EventArgs e)
        {
            operador = "x";
            try { primero = double.Parse(textbox.Text); }
            catch (System.FormatException) {textbox.Text = "Syntax Error";}
            textbox.Clear();

        }
        //DEL
        private void botonDEL_Click(object sender, EventArgs e)
        { 
            if (textbox.Text.Length == 1)
                textbox.Text = "";
            else
                try { textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1); }
                catch (System.ArgumentOutOfRangeException ep) { }

            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        int r = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in historialenlista)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
