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
    public partial class PantallaUsuario : Form
    {
        public PantallaUsuario()
        {
            InitializeComponent();
        }

        private void AceptarAccion_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Agregar usuario":
                    {
                        this.Close();
                        break;
                    }
                case "Modificar usuario":
                    {
                        AccionEjecutarse.Text = "Modifica un usuario";
                        break;
                    }
                case "Mostrar usuario":
                    {
                        AccionEjecutarse.Text = "Muestra un usuario";
                        break;
                    }

            }
        }

        private void CancelarAccion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaUsuario_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Agregar usuario":
                    {
                        AccionEjecutarse.Text = "Agrega un usuario";
                        break;
                    }
                case "Modificar usuario":
                    {
                        AccionEjecutarse.Text = "Modifica un usuario";
                        break;
                    }
                case "Mostrar usuario":
                    {
                        AccionEjecutarse.Text = "Muestra un usuario";
                        break;
                    }

            }


        }
    }
}
