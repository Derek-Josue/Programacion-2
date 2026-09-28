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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            { 
            decimal num1 = Convert.ToDecimal(txtNum1.Text);
            decimal num2 = Convert.ToDecimal(txtNum2.Text);

                decimal resultado = num1 * num2;
                MessageBox.Show("Elresultado de la multiplicacion es: " + resultado.ToString());
            }

            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }

        }
    }
}
