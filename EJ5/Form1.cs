using EJ1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ5
{
    public partial class Form1 : Form
    {
        private CalculosFiguras calculadora;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double x1,x2,x3,y1,y2,y3;
                double.TryParse(textBox1.Text, out x1);
                double.TryParse(textBox3.Text, out x2);
                double.TryParse(textBox5.Text, out x3);
                double.TryParse(textBox2.Text, out y1);
                double.TryParse(textBox4.Text, out y2);
                double.TryParse(textBox6.Text, out y3);

                if (radioButton3.Checked)
                {
                   MessageBox.Show("El resultado es : " + calculadora.AreaTriangulo(x1,x2,x3,y1,y2,y3));
                }
                else
                {
                    MessageBox.Show("El resultado es : " + calculadora.PerimetroTriangulo(x1, x2, x3, y1, y2, y3));
                }

            }
            else
            {
                double x1, y1, radio;
                double.TryParse(textBox1.Text, out x1);
                double.TryParse(textBox2.Text, out y1);
                double.TryParse(textBox4.Text, out radio);

                if (radioButton3.Checked)
                {
                    MessageBox.Show("El resultado es : " + calculadora.AreaCirculo(x1, y1,radio));
                }
                else
                {
                    MessageBox.Show("El resultado es : " + calculadora.PerimetroCirculo(x1, y1,radio));
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Hide();
            label5.Show();
            label6.Show();

            textBox3.Show();
            textBox5.Show();
            textBox6.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculadora = new CalculosFiguras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Show();
            label5.Hide();
            label6.Hide();

            textBox3.Hide();
            textBox5.Hide();
            textBox6.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
