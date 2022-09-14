using System;
using Backend;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculadora
{
    //[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Calculadora : Form
    {
        //private const object GetDebuggerDisplay;
        double primero;
        double segundo;
        string operador;
        public Calculadora()


        {
            InitializeComponent();
        }
        Backend.Clases.Suma p1 = new Backend.Clases.Suma();
        Backend.Clases.Resta p2 = new Backend.Clases.Resta();
        Backend.Clases.Multiplicacion p3 = new Backend.Clases.Multiplicacion();
        Backend.Clases.Division p4 = new Backend.Clases.Division();

        public object Sum { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.textBox1.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bot0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Bot1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void Bot4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void Bot5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void Bot6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void Bot7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void BotPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void BotIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);
            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
               case "+":
                    Sum = p1.Sum((primero), (segundo));
                    textBox1.Text = Sum.ToString();
                    break;
                case "-":
                    Res = p2.Res((primero), (segundo));
                    textBox1.Text = Res.ToString();
                    break;
                case "*":
                    Mul = p3.Mul((primero), (segundo));
                    textBox1.Text = Mul.ToString();
                    break;
                case "/":
                    Div = p4.Div((primero), (segundo));
                    textBox1.Text = Div.ToString();
                    break;
            }
        }
    }
}

