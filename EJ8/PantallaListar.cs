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
    public partial class PantallaListar : Form
    {
        public PantallaListar()
        {
            InitializeComponent();
        }

        //Al abrir la pantalla, segun el tipo, se cargan las listas que correspondan.
        private void PantallaListar_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Listar usuarios":
                    {
                        TipoListado.Text = "Todos los usuarios";
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerTodos();
                        foreach (var usuario in listaUsuario)
                        {
                             usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;

                    }
                case "Listar usuarios ordenados ascendentes":
                    {
                        TipoListado.Text = "Segun nombre ascendente.";
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerOrdenadosPor("");
                        foreach (var usuario in listaUsuario)
                        {
                            usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;
                        }
                case "Listar usuarios ordenados descendentes":
                    {
                        TipoListado.Text = "Segun nombre descendente";
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerOrdenadosPor("NombreDescendente");
                        foreach (var usuario in listaUsuario)
                        {
                            usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;
                        }
                case "Listar usuarios ordenados por correo descendente":
                    {
                        TipoListado.Text = "Segun correo electronico descendente";
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerOrdenadosPor("CorreoDescendente");
                        foreach (var usuario in listaUsuario)
                        {
                            usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;
                    }
                    
            }
        }
    }
}
