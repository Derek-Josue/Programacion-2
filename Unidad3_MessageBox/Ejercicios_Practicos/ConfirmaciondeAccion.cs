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
    public partial class ConfirmaciondeAccion : Form
    {
        public ConfirmaciondeAccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir del Programa?",
                "Confirmación de Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Ha seleccionado 'Sí'. El programa se cerrará.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ha seleccionado 'No'. El programa continuará.");
            }


        }
    }
}
