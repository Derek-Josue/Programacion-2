using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5_Capas.Logica
{

    using System.Collections.Generic;
    using Unidad5_Capas.Entidades;

    public class ProductoLogica
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto("Laptop", 350000));
            productos.Add(new Producto("Mouse", 8500));
            productos.Add(new Producto("Teclado", 15000));
            productos.Add(new Producto("Monitor", 95000));
            productos.Add(new Producto("Audifonos", 12000));

            return productos;
        }
    }
}
