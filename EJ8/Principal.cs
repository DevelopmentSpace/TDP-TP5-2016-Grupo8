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

        public void agregarUsuario(string pNombreCompleto, string pCorreoElectronico)
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

        public void modificarUsuario(string pCodigo, string pNombreCompleto, string pCorreoElectronico)
        {
            repositorio.actualizarUsuario(pCodigo, pNombreCompleto, pCorreoElectronico);
            MessageBox.Show("Usuario actualizado con exito.");

        }

        public Dictionary<string, string> obtenerPorCodigo(string pCodigo)
        {
            return repositorio.obtenerPorCodigo(pCodigo);
        }

        public IList<Dictionary<string, string>> obtenerTodos()
        {
            return repositorio.obtenerTodos();
        }

        public IList<Dictionary<string, string>> obtenerOrdenadosPor(string pComparador)
        {
            return repositorio.obtenerOrdenadosPor(pComparador);
        }


        public IList<Dictionary<string, string>> obtenerPorAproximacion(string pCadena)
        {
            return repositorio.obtenerPorAproximacion(pCadena);
        }

        public string ultimoCodigo()
        {
            return repositorio.ultimoCodigo().ToString();
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

        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaBusqueda newMDIChild = new PantallaBusqueda();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Buscar codigo";
            newMDIChild.Show();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            repositorio = new FachadaRepositorio();
        }

        private void porAproximacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaBusqueda newMDIChild = new PantallaBusqueda();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Por aproximacion de nombre";
            newMDIChild.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaListar newMDIChild = new PantallaListar();
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Listar usuarios";
            newMDIChild.Show();
        }

        private void nombreAscendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                PantallaListar newMDIChild = new PantallaListar();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Listar usuarios ordenados ascendentes";
                newMDIChild.Show();
            }
        }

        private void nombreDescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                PantallaListar newMDIChild = new PantallaListar();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Listar usuarios ordenados descendentes";
                newMDIChild.Show();
            }
        }

        private void correoDescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                PantallaListar newMDIChild = new PantallaListar();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Listar usuarios ordenados por correo descendente";
                newMDIChild.Show();
            }
        }
    }
}
