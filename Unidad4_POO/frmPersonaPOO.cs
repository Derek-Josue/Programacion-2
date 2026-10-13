using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad4_POO.Ejemplos;

namespace Unidad4_POO
{
    public partial class frmPersonaPOO : Form
    {
        public frmPersonaPOO()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Persona personaUno = new Persona();

            personaUno.Nombre = "Josue";
            personaUno.Edad = 19;

            personaUno.MostrarDatos();

            Persona personaDos = new Persona();
            personaDos.Nombre = "María";
            personaDos.Edad = 25;
            personaDos.MostrarDatos();
        }
    }
}
