using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Verificar(object sender, EventArgs e)
        {
            
            MessageBox.Show("Estado de los mensajes  : " + 
                RadioBoton1.Text + ": " + RadioBoton1.Checked + " - " +
                RadioBoton2.Text + ": " + RadioBoton2.Checked + " - " +
                RadioBoton3.Text + ": " + RadioBoton3.Checked + " - " +
                Caja1.Text + ": " + Caja1.Checked + " - " +
                Caja2.Text + ": " + Caja2.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
