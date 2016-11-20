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

        private void PantallaListar_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Listar usuarios":
                    {
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerTodos();
                        foreach (var usuario in listaUsuario)
                        {
                             usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;

                    }
                case "Listar usuarios ordenados ascendentes":
                    {
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerOrdenadosPor("");
                        foreach (var usuario in listaUsuario)
                        {
                            usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;
                        }
                case "Listar usuarios ordenados descendentes":
                    {
                        IList<Dictionary<string, string>> listaUsuario = ((Principal)this.MdiParent).obtenerOrdenadosPor("NombreDescendente");
                        foreach (var usuario in listaUsuario)
                        {
                            usuariosEncontrados.Rows.Add(usuario["Codigo"], usuario["NombreYApellido"], usuario["CorreoElectronico"]);
                        }
                        break;
                        }
                case "Listar usuarios ordenados por correo descendente":
                    {
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
