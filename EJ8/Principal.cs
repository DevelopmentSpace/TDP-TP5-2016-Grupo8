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

        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pNombreCompleto">Nombre y apellido del usuario</param>
        /// <param name="pCorreoElectronico">Correo electronico del usuario</param>
        public void agregarUsuario(string pNombreCompleto, string pCorreoElectronico)
        {
            repositorio.agregarUsuario(pNombreCompleto, pCorreoElectronico);
            MessageBox.Show("Usuario agregado con exito.");
        }

        /// <summary>
        /// Elimina un usuario al repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
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

        /// <summary>
        /// Modifica un usuario en el repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        /// <param name="pNombreCompleto">Nuevo nombre completo</param>
        /// <param name="pCorreoElectronico">Nuevo correo electronico</param>
        public void modificarUsuario(string pCodigo, string pNombreCompleto, string pCorreoElectronico)
        {
            repositorio.actualizarUsuario(pCodigo, pNombreCompleto, pCorreoElectronico);
            MessageBox.Show("Usuario actualizado con exito.");

        }

        /// <summary>
        /// Obtiene un usuario del repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        /// <returns>Diccionario con un usuario. La clave "NombreYApellido" devuelve el nombre y apellido, la clave "CorreoElectronico" devuelve el correo electronico.</returns>
        public Dictionary<string, string> obtenerPorCodigo(string pCodigo)
        {
            return repositorio.obtenerPorCodigo(pCodigo);
        }

        /// <summary>
        /// Obtiene todos los usuario del repositorio.
        /// </summary>
        /// <returns>Lista de diccionario con todos los usuarios. </returns>
        public IList<Dictionary<string, string>> obtenerTodos()
        {
            return repositorio.obtenerTodos();
        }

        /// <summary>
        /// Obtiene todos los usuario del repositorio.
        /// </summary>
        /// <param name="pComparador">Nombre del comparador</param>
        /// <returns>Lista de diccionario con todos los usuarios ordenados por un comparador. </returns>
        public IList<Dictionary<string, string>> obtenerOrdenadosPor(string pComparador)
        {
            return repositorio.obtenerOrdenadosPor(pComparador);
        }

        /// <summary>
        /// Obtiene los usuario del repositorio que se aproximan a la cadena.
        /// </summary>
        /// <param name="pCadena">Cadena</param>
        /// <returns>Lista de diccionario con todos los usuarios que se aproximan a la cadena. </returns>
        public IList<Dictionary<string, string>> obtenerPorAproximacion(string pCadena)
        {
            return repositorio.obtenerPorAproximacion(pCadena);
        }

        /// <summary>
        /// Devuelve el codigo del ultimo elemento.
        /// </summary>
        /// <returns>Cadena con el codigo del ultimo elemento.</returns>
        public string ultimoCodigo()
        {
            return repositorio.ultimoCodigo().ToString();
        }


        // -- Acciones al presionar los botones -- //

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

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            repositorio = new FachadaRepositorio();
        }
    }
}
