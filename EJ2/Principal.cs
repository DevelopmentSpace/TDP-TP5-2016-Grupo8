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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Click_Verificar(object sender, EventArgs e)
        {
            //Muestra si estan checkeado los RadioButton y los Checkbox
            MessageBox.Show("Estado de los mensajes  : " + 
                RadioBoton1.Text + ": " + RadioBoton1.Checked + " - " +
                RadioBoton2.Text + ": " + RadioBoton2.Checked + " - " +
                RadioBoton3.Text + ": " + RadioBoton3.Checked + " - " +
                Caja1.Text + ": " + Caja1.Checked + " - " +
                Caja2.Text + ": " + Caja2.Checked);
        }

    }
}
