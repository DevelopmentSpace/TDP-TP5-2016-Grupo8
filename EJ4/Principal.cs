using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ4
{
    public partial class PruebaLista : Form
    {
        public PruebaLista()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra el nombre del boton presionado;
            listBox1.Items.Add(button1.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Muestra el nombre del boton presionado;
            listBox1.Items.Add(button2.Name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Muestra el nombre del boton presionado;
            listBox1.Items.Add(button3.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Muestra el nombre del boton presionado;
            listBox1.Items.Add(button4.Name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Muestra el nombre del boton presionado;
            listBox1.Items.Add(button5.Name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Muestra el nombre del boton presionado;
            listBox1.Items.Add(button6.Name);
        }
    }
}
