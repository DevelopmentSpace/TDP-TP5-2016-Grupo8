using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ7
{
    public partial class Principal : Form
    {

        Criptografia criptografia;

        public Principal()
        {
            InitializeComponent();
        }


        private void Calcular_Click(object sender, EventArgs e)
        {
            //Operamos en base a si se quiere encriptar o desencriptar
            if (OpcionEncriptar.Checked)
            {
                    textoEncriptado.Text = criptografia.Encriptar(textoSinEncriptar.Text, listaEncriptadores.Text);
            }
            else
            {
                try
                {
                    textoSinEncriptar.Text = criptografia.Desencriptar(textoEncriptado.Text, listaEncriptadores.Text);
                }
                catch (Exception) //si no se puede muestra un error
                {
                    MessageBox.Show("El texto ingresado no se puede descencriptar.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crea la fachada
            criptografia = new Criptografia();

            //obtiene los encriptadores disponibles
            IEnumerator<string> enumerador = criptografia.EncriptadoresDisponibles().GetEnumerator();


            //Actualiza la lista de los encriptadores disponibles
            listaEncriptadores.Items.Clear();

            while (enumerador.MoveNext())
                listaEncriptadores.Items.Add(enumerador.Current);
        }

    }
}
