using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox.Ejemplos
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea continuar?",
                "mensaje de confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Ha seleccionado 'Sí'");
            }
            else
            {
                MessageBox.Show("Ha seleccionado 'No'");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea cerrar?",
                "confirmación de cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Error de conexion. ¿Desea reintentar?",
                "Error de conexión",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);

            if (respuesta == DialogResult.Retry)
            {
                MessageBox.Show("Reintentando conexión...");
            }
            
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(txtOpcion.Text);
            switch (opcion)
            {
                case 1:
                    MessageBox.Show("Opción 1 seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Opción 2 seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Opción 3 seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Opción no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }



        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
