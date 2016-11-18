using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ6_
{
    public partial class Form1 : Form
    {

        AdmCuentas administrador;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            administrador = new AdmCuentas();
            administrador.CrearCliente(TipoDocumento.DNI, "12345678", "Gonzales Hernan");
            administrador.CrearCuentas();

            this.actualizarPantalla();

            label9.Text = administrador.Cliente.Nombre;
        }
        private void actualizarPantalla()
        {
            label4.Text = administrador.CuentaCorriente.Saldo.ToString();
            label5.Text = administrador.CajaDeAhorro.Saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float saldotransferir;

            float.TryParse(textBox1.Text, out saldotransferir);
            try
            {
                administrador.TransferirACajaAhorro(saldotransferir);
                this.actualizarPantalla();
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float saldotransferir;

            float.TryParse(textBox1.Text, out saldotransferir);
            try
            {
                administrador.TransferirACuentaCorriente(saldotransferir);
                this.actualizarPantalla();
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
    }
}
