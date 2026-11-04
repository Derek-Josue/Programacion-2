using System;
using System.Windows.Forms;

namespace Unidad5_Capas.Ejercicios
{
    public partial class Ejercicio2_Herencia : Form
    {
        public Ejercicio2_Herencia()
        {
            InitializeComponent();
        }

        

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.AnioNacimiento = int.Parse(txtAño.Text);

            MessageBox.Show(
                "Año de nacimiento: " + estudiante.AnioNacimiento +
                "\nEdad calculada: " + estudiante.EdadCalculada,
                "Información del estudiante"
            );
        }
    }
}