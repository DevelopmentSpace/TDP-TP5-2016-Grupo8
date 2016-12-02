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
    public partial class PantallaBusqueda : Form
    {
        public PantallaBusqueda()
        {
            InitializeComponent();
        }

        //Segun el tipo al hacer click en buscar, va a buscar lo que se especifique. 
        private void botonBusqueda_Click(object sender, EventArgs e)
        {

            if (this.Text == "Buscar codigo")
            {
                if (resultadoBusqueda.Rows.Count == 1)
                {
                    resultadoBusqueda.Rows.RemoveAt(0);
                }

                try
                {

                    Dictionary<string, string> usuario = ((Principal)this.MdiParent).obtenerPorCodigo(textoBusqueda.Text);
                    resultadoBusqueda.Rows.Add(textoBusqueda.Text, usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No se han encontrado usuarios con ese codigo");
                }
               
            }
            else
            {
                int numeroFilas = resultadoBusqueda.Rows.Count;
                for (int i = 0; i <= numeroFilas - 1; i++)
                {
                    resultadoBusqueda.Rows.RemoveAt(0);
                }


                IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerPorAproximacion(textoBusqueda.Text);
                foreach (var usuario in listaUsuario)
                {

                       resultadoBusqueda.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                }

            }

        }

        //Segun el nombre de la pantalla, se cambia el nombre de la label tipo de busqueda.
        private void PantallaBusqueda_Load(object sender, EventArgs e)
        {
            if (this.Text == "Buscar codigo")
            {
                TipoBusqueda.Text = "por codigo unico de usuario";
            }
            else
            {
                TipoBusqueda.Text = "por aproximacion de nombre y apellido";
            }
        }
    }
}
