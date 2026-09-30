using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_operadores.Tarea_unidad2_CSharp
{
    public partial class Tarea_Unidad2_CSharp : Form
    {
        public Tarea_Unidad2_CSharp()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            if (num1 > num2)
            {
                MessageBox.Show("El primer número es mayor que el segundo.");
            }
            else if (num1 < num2)
            {
                MessageBox.Show("El primer número es menor que el segundo");
            }
            else
            {
                MessageBox.Show("Ambos números son iguales");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
