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
    public partial class Form1 : Form
    {

        Criptografia criptografia;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                richTextBox2.Text = criptografia.Encriptar(richTextBox1.Text, comboBox1.Text);
            }
            else
            {
                richTextBox1.Text = criptografia.Desencriptar(richTextBox2.Text, comboBox1.Text);
            }

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            criptografia = new Criptografia();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
