using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad5_Capas.Logica;

namespace Unidad5_Capas
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ProductoLogica logica = new ProductoLogica();

            dgvProductos.DataSource = logica.ObtenerProductos();
        }

        
    }
}
