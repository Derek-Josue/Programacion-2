using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO
{
    public class Producto
    {
        private string nombre;
                
        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
            }
        }

        private double precio;
        public double Precio
        {
            get { return precio; }
            set 
            { if (value >= 0)
                {
                    precio = value;
                }
                else
                {
                    throw new ArgumentException("El precio no puede ser negativo.");
                }
            
            }
        }

       
        public void MostrarDatos()
        {
            MessageBox.Show("Nombre: " + nombre + "\nPrecio: " + precio);
        }
    }
}

