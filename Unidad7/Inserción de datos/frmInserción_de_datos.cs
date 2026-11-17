using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad7.Inserción_de_datos
{
    public partial class frmInserción_de_datos : Form
    {
        public frmInserción_de_datos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Consulta SQL con parámetros para prevenir inyecciones SQL
            string query = "INSERT INTO clientes (Nombre, Correo) VALUES (@nombre, @correo)";

            // 3. Usamos la clase Conexion centralizada
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    // Asignar los valores de los TextBox a los parámetros
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Cliente insertado correctamente en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpiar los campos para un nuevo registro
                            txtNombre.Clear();
                            txtCorreo.Clear();
                            txtNombre.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    
}
