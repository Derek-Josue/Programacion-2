using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox.Ejercicios_Practicos
{
    public partial class Switch_Case : Form
    {
        public Switch_Case()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
             int numero;
            numero = Convert.ToInt32(txtNúmero.Text);

            switch (numero)
            {

                case 1:
                    MessageBox.Show("El número ingresado es 1");
                    break;
                case 2:
                    MessageBox.Show("El número ingresado es 2");
                    break;
                case 3:
                    MessageBox.Show("El número ingresado es 3");
                    break;
                case 4:
                    MessageBox.Show("El número ingresado es 4");
                    break;
                default:
                    MessageBox.Show("Número no válido. Por favor, ingrese un número entre 1 y 4.");
                    break;

            }

        }
    }
}
