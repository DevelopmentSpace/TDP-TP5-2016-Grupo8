using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ8
{
    public partial class Principal : Form
    {
        IRepositorioUsuarios repositorio;

        public Principal()
        {
            InitializeComponent();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaUsuario newMDIChild = new PantallaUsuario();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Agregar usuario";
            newMDIChild.Show();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
        }
    }
}
