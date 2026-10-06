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
            if (listBoxColores.SelectedItem != null)
            {
                string colorSeleccionado = listBoxColores.SelectedItem.ToString();

                if (colorSeleccionado == "Rojo")
                {
                    this.BackColor = Color.Red;
                }
                else if (colorSeleccionado == "Verde")
                {
                    this.BackColor = Color.Green;
                }
                else if (colorSeleccionado == "Azul")
                {
                    this.BackColor = Color.Blue;
                }
            }
        }

        private void Tarea_Unidad2_CSharp_Load(object sender, EventArgs e)
        {
            listBoxColores.Items.Add("Rojo");
            listBoxColores.Items.Add("Verde");
            listBoxColores.Items.Add("Azul");
        }

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostramos el cuadro de diálogo de colores
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un color y presiona Aceptar, cambia el fondo
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
