using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad5_Capas.Ejercicios;

namespace Unidad5_Capas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Ejercicio1());
            //Application.Run(new Ejercicio2_Herencia());
            Application.Run(new Ejercicio3_Validaciones());
        }
    }
}
