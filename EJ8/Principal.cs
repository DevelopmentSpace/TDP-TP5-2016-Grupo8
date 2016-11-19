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
        FachadaRepositorio repositorio;

        public Principal()
        {
            InitializeComponent();
        }

        public void agregarUsuario(string pNombreCompleto,string pCorreoElectronico)
        {
            repositorio.agregarUsuario(pNombreCompleto, pCorreoElectronico);
            MessageBox.Show("Usuario agregado con exito.");
        }

        public void eliminarUsuario(string pCodigo)
        {
            try
            {
                repositorio.eliminarUsuario(pCodigo);
                MessageBox.Show("Usuario eliminado con exito.");

            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Clave no encontrada en la lista");
            }

        }

        public void modificarUsuario(string pCodigo,string pNombreCompleto,string pCorreoElectronico)
        {
            repositorio.actualizarUsuario(pCodigo, pNombreCompleto, pCorreoElectronico);
            MessageBox.Show("Usuario actualizado con exito.");

        }

        public Dictionary<string,string> obtenerPorCodigo(string pCodigo)
        {
            return repositorio.obtenerPorCodigo(pCodigo);
        }

        public string ultimoCodigo()
        {
            return repositorio.ultimoCodigo().ToString();
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



        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaUsuario newMDIChild = new PantallaUsuario();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Eliminar usuario";
            newMDIChild.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaUsuario newMDIChild = new PantallaUsuario();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Modificar usuario";
            newMDIChild.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            repositorio = new FachadaRepositorio();
        }
    }
}
