using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_operadores.Ejemplos
{
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        private void Colores_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //si el color seleccionado es valido, se cambia el color de fondo del formulario
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
