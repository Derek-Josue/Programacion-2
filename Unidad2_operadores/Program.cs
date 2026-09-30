using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad2_operadores.Ejemplos;
using Unidad2_operadores.Tarea_unidad2_CSharp;

namespace Unidad2_operadores
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
            Application.Run(new Tarea_Unidad2_CSharp());
            
        }
    }
}
