﻿using System;
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
                        ((Principal)this.MdiParent).agregarUsuario(nombreYapellidoUsuario.Text, correoUsuario.Text);
                        this.Close();
                        break;
                    }
                case "Modificar usuario":
                    {
                        ((Principal)this.MdiParent).modificarUsuario(codigoUsuario.Text,nombreYapellidoUsuario.Text,correoUsuario.Text);
                        this.Close();

                        break;
                    }
                case "Eliminar usuario":
                    {
                        ((Principal)this.MdiParent).eliminarUsuario(codigoUsuario.Text);
                        this.Close();
                        break;
                    }

            }
        }

        private void CancelarAccion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Al cargar segun el tipo, habilita los botones necesarios
        private void PantallaUsuario_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Agregar usuario":
                    {
                        codigoUsuario.Enabled = false;
                        codigoUsuario.Text = ((Principal)this.MdiParent).ultimoCodigo();
                        AccionEjecutarse.Text = "Agrega un usuario";           
                        break;
                    }
                case "Modificar usuario":
                    {
                        AccionEjecutarse.Text = "Modificar usuario";
                        break;
                    }
                case "Eliminar usuario":
                    {
                        nombreYapellidoUsuario.Enabled = false;
                        correoUsuario.Enabled = false;
                        AccionEjecutarse.Text = "Eliminar un usuario";
                        break;
                    }

            }


        }

        //Cada vez que se sale del texto para elegir codigo ejecuta esto.
        private void codigoUsuario_Leave(object sender, EventArgs e)
        {
            if (Text == "Eliminar usuario" || Text == "Modificar usuario")
            {
                try
                {
                    Dictionary<string, string> usuario = ((Principal)this.MdiParent).obtenerPorCodigo(codigoUsuario.Text);
                    nombreYapellidoUsuario.Text = usuario["NombreYApellido"];
                    correoUsuario.Text = usuario["CorreoElectronico"];
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Codigo no encontrado");
                    this.Close();
                }
            }
        }

        private void codigoUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
