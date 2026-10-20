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
    public partial class Clase_y_Objeto : Form
    {
        public Clase_y_Objeto()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();

            producto1.Nombre = "Manzana";
            producto1.Precio = 100;  
           
            producto1.MostrarDatos();

            Producto producto2 = new Producto();
            producto2.Nombre = "Mamon";
            producto2.Precio = 250;
            producto2.MostrarDatos();
        }
    }
}
