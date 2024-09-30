using System.Runtime.CompilerServices;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private string Operation; 

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            valor1 = Convert.ToInt32(textBox1.Text);
            Operation = "x";
            textBox1.Text = " ";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Operation = "+";
            valor1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(textBox1.Text);
            Operation = "-";
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(textBox1.Text);
            Operation = "/";
            textBox1.Text = " ";
         
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = " ";
            resultado = 0; 


            Operation = "+";

            switch (Operation)
            {
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "/":
                    if (valor2 == 0 || valor1 == 0)
                    {
                        Console.WriteLine("Error no se puede didivir por cero");
                    } else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                default:
                    Console.WriteLine("Valor no deseado..");

                    break;      
            }

            string valorAsegurado = Convert.ToString(resultado); 

            textBox1.Text = valorAsegurado;
        } 

        private void button17_Click(object sender, EventArgs e)
        {  
            // borra los valores
            textBox1.Text = "  ";
        }
    }
}

