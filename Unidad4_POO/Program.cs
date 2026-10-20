using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad4_POO.Ejercicios_Practicos;

namespace Unidad4_POO
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
            //Application.Run(new frmErrorProvider());
            //Application.Run(new frmValidadores());
            //Application.Run(new frmPersonaPOO());
            //Application.Run(new Clase_y_Objeto());
            //Application.Run(new Propiedades_Get_Set());
            Application.Run(new Validacion_con_errorprovider());

        }
    }
}
