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
                catch (Exception)
                {
                    MessageBox.Show("El texto ingresado no se puede descencriptar.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            criptografia = new Criptografia();
        }

        private void OpcionEncriptar_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpcionDescencriptar_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
