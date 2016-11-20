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
    public partial class Principal : Form
    {
        private CalculosFiguras calculadora;
        
        public Principal()
        {
            InitializeComponent();

        }

        private void calcular_click(object sender, EventArgs e)
        {
            if (opcionTriangulo.Checked)
            {
                //Pasando los puntos en string a double
                double x1,x2,x3,y1,y2,y3;
                double.TryParse(punto1X.Text, out x1);
                double.TryParse(punto2X.Text, out x2);
                double.TryParse(punto3X.Text, out x3);
                double.TryParse(punto1Y.Text, out y1);
                double.TryParse(punto2YoRadio.Text, out y2);
                double.TryParse(punto3Y.Text, out y3);

                if (opcionArea.Checked)
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
                //Pasando los puntos y el radio en string a doble
                double x1, y1, radio;
                double.TryParse(punto1X.Text, out x1);
                double.TryParse(punto1Y.Text, out y1);
                double.TryParse(punto2YoRadio.Text, out radio);

                if (opcionArea.Checked)
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

        private void opcionTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            //Al cambiar de opcion se esconden los puntos que no se usan junto con sus correspondientes etiquetas.
            label3.Hide();
            label5.Show();
            label6.Show();

            punto2X.Show();
            punto3X.Show();
            punto3Y.Show();
        }

        private void opcionCirculo_CheckedChanged(object sender, EventArgs e)
        {
            //Al cambiar de opcion se esconden los puntos que no se usan junto con sus correspondientes etiquetas.
            label3.Show();
            label5.Hide();
            label6.Hide();

            punto2X.Hide();
            punto3X.Hide();
            punto3Y.Hide();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            calculadora = new CalculosFiguras();
        }

        private void salir_click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
