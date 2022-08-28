using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_IMC
{
    public partial class Form1 : Form
    {
        double Altura, Peso, IMC;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out Altura))
            {
                MessageBox.Show("Informe a Altura");
               // textBox2.Focus();

            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out Altura))
            {
                MessageBox.Show("Inoforme o peso");
                //textBox2.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Altura = Convert.ToDouble(textBox1.Text);
                Peso = Convert.ToDouble(textBox2.Text);
                IMC = Peso / (Altura * Altura);

            textBox3.Text = IMC.ToString("n2");
        }

       private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (IMC <= 18.5)
            {
                MessageBox.Show("Magreza, obesidade Grau 0");
            }
            else
               if (IMC > 18.5 && IMC <= 24.9)
            {
                MessageBox.Show("Normal, Obesidade Grau 0");
            }
            else
                if (IMC > 25 && IMC <= 29.9)
            {
                MessageBox.Show("Sobrepeso, Obesidade Grau 1");
            }
            else
                 if (IMC > 30 && IMC <= 39.9)
            {
                MessageBox.Show("obesidade, obesidade grau 2");
            }
            else
                if (IMC >= 40)
            {
                MessageBox.Show("Obesidade Grave grau 3, vá se cuidar");
            }



        }       
    }
}

