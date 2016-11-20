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
    public partial class Principal : Form
    {

        AdmCuentas administrador;

        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga el programa, crea un administrador de cuentas junto con su cliente.
            administrador = new AdmCuentas();
            administrador.CrearCliente(TipoDocumento.DNI, "12345678", "Gonzales Hernan");
            administrador.CrearCuentas();

            this.actualizarPantalla();

            //Muestra en pantalla el nombre y apellido del cliente
            NomYApeCliente.Text = administrador.Cliente.Nombre;
        }
        private void actualizarPantalla()
        {
            //Se encarga de actualizar los saldos en pantalla
            SaldoCuentaCorriente.Text = administrador.CuentaCorriente.Saldo.ToString();
            SaldoCajaAhorro.Text = administrador.CajaDeAhorro.Saldo.ToString();
        }

        private void transferirCCaCA_Click(object sender, EventArgs e)
        {
            float saldotransferir;
            float.TryParse(MontoAUsar.Text, out saldotransferir);

            try
            {
                administrador.TransferirACuentaCorriente(saldotransferir);
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El monto ingreso no es valido.");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("El monto no puede ser negativo.");
            }
            this.actualizarPantalla();

        }

        private void transferirCAaCC_Click(object sender, EventArgs e)
        {
            float saldotransferir;
            float.TryParse(MontoAUsar.Text, out saldotransferir);

            try
            {
                administrador.TransferirACajaAhorro(saldotransferir);
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El monto ingresado no es valido.");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("El monto no puede ser negativo.");
            }
            this.actualizarPantalla();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void debitarCajaAhorro_Click(object sender, EventArgs e)
        {
            float montoADebitar;
            float.TryParse(MontoAUsar.Text, out montoADebitar);

            try
            {
                administrador.CajaDeAhorro.DebitarSaldo(montoADebitar);
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El monto ingresado no es valido.");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("El monto no puede ser negativo.");
            }
            this.actualizarPantalla();
        }

        private void debitarCuentaCorriente_Click(object sender, EventArgs e)
        {
            float montoADebitar;
            float.TryParse(MontoAUsar.Text, out montoADebitar);

            try
            {
                administrador.CuentaCorriente.DebitarSaldo(montoADebitar);
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El monto ingresado no es valido.");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("El monto no puede ser negativo.");
            }
            this.actualizarPantalla();
        }

        private void acreditarCajaAhorro_Click(object sender, EventArgs e)
        {
            float montoADebitar;
            float.TryParse(MontoAUsar.Text, out montoADebitar);

            try
            {
                administrador.CajaDeAhorro.AcreditarSaldo(montoADebitar);
            }
            catch (SaldoException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El monto ingresado no es valido.");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("El monto no puede ser negativo.");
            }
            this.actualizarPantalla();
        }

        private void acreditarCuentaCorriente_Click(object sender, EventArgs e)
        {
            {
                float montoADebitar;
                float.TryParse(MontoAUsar.Text, out montoADebitar);

                try
                {
                    administrador.CuentaCorriente.AcreditarSaldo(montoADebitar);
                }
                catch (SaldoException)
                {
                    MessageBox.Show("Saldo insuficiente");
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("El monto ingresado no es valido.");
                }

                catch (ArgumentException)
                {
                    MessageBox.Show("El monto no puede ser negativo.");
                }
                this.actualizarPantalla();
            }
        }
    }
}
