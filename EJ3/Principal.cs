using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ3
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void OpcionNumero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Se crea un array con los numeros traducidos y segun el numero seleccionado se muestra su respectiva traduccion.
            string[] aux = {"One","Two","Three","Four","Five","Six", "Seven","Eight","Nine","Ten"};
            Traduccion.Text = aux[OpcionNumero.SelectedIndex];
        }
    }
}
