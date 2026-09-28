using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            string input1 = txtNumero1.Text;
            string input2 = txtNumero2.Text;

            if (int.TryParse(input1, out int numero1) && int.TryParse(input2, out int numero2))
            {
                int resultado = numero1 + numero2;
                MessageBox.Show("El resultado de la suma es: " + resultado.ToString());
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
