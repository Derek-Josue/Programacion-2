
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unidad5_Capas.Ejercicios
{
    public partial class Ejercicio3_Validaciones : Form
    {
        List<ProductoEjercicio3> productos = new List<ProductoEjercicio3>();

        public Ejercicio3_Validaciones()
        {
            InitializeComponent();

            productos.Add(new ProductoEjercicio3("Laptop", 350000));
            productos.Add(new ProductoEjercicio3("Mouse", 8500));
            productos.Add(new ProductoEjercicio3("Teclado", 15000));
            productos.Add(new ProductoEjercicio3("Monitor", 95000));
        }

        

        

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();

            foreach (ProductoEjercicio3 producto in productos)
            {
                lstProductos.Items.Add(
                    producto.Nombre + " - ₡" + producto.Precio
                );
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (lstProductos.Items.Count == 0)
            {
                MessageBox.Show("Primero debe mostrar los productos.");
            }
            else
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea guardar los cambios?",
                    "Confirmar guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    MessageBox.Show("Los cambios se guardaron correctamente.");
                }
                else
                {
                    MessageBox.Show("Se canceló el guardado.");
                }
            }
           }
    }
}
