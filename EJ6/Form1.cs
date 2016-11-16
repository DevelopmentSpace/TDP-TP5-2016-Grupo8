using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ6
{
    public partial class Form1 : Form
    {

        private Calculadora calculadora;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            int.TryParse(textBox1.Text, out valor1);
            int.TryParse(textBox2.Text, out valor2);
            try
            {
                MessageBox.Show("El resultado del calculo es: " + calculadora.Dividir(valor2, valor1));
            }
            catch (DivisionPorCeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculadora = new Calculadora();
        }
    }
}
