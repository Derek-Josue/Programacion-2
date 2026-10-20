using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO
{
    public partial class frmValidadores : Form
    {
        public frmValidadores()
        {
            InitializeComponent();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.");
                e.Cancel = true; // no permite salir hasta corregir 
            }
            else
            {
                errorProvider1.SetError(txtNombre, string.Empty);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool todobien = true;
            //validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.");
                todobien = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, string.Empty);
            }

            //validar edad
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0 || edad > 120)
            {
                errorProvider1.SetError(txtEdad, "La edad debe ser un número entre 0 y 120.");
                todobien = false;
            }
            else
            {
                errorProvider1.SetError(txtEdad, string.Empty);
            }

            //validar correo
            if (!txtCorreo.Text.Contains("@"))
            {
                errorProvider1.SetError(txtCorreo, "El correo debe contener un '@'.");
                todobien = false;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, string.Empty);
            }

        }
    }
}
