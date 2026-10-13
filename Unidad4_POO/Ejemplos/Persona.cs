using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Ejemplos
{
    internal class Persona
    {
        // Atributos o campos
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }




        //Metodo o Accion 
        public void MostrarDatos()
        { 
            MessageBox.Show("Nombre:" + Nombre + "\nEdad: " + Edad);

        }

    }
}
