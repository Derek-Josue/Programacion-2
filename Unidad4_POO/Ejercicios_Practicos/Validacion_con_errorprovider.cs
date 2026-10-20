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
    public partial class Validacion_con_errorprovider : Form
    {
        public Validacion_con_errorprovider()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
            if (double.TryParse(txtPrecio.Text, out double precio))
            {
                errorProvider1.SetError(txtPrecio, "");
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "Ingrese un valor numérico válido");
            }
        }
    }
}
