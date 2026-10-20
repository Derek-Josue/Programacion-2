using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Ejercicios_Practicos
{
    public partial class Propiedades_Get_Set : Form
    {
        public Propiedades_Get_Set()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto1 = new Producto();

                producto1.Nombre = txtNombre.Text;
                producto1.Precio = double.Parse(txtPrecio.Text);

                producto1.MostrarDatos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validadacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}