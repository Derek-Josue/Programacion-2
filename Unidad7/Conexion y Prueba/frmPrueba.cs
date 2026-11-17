using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Unidad7
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }
        private void btnPrueba_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    // Intenta abrir la conexión con MySQL
                    conexion.Open();
                    MessageBox.Show("¡Conexión exitosa con MySQL usando la clase centralizada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
