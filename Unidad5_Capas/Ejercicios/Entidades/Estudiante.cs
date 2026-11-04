

using System;

namespace Unidad5_Capas.Ejercicios
{
    public class Estudiante : Persona
    {
        public int EdadCalculada
        {
            get
            {
                return DateTime.Now.Year - AnioNacimiento;
            }
        }
    }
}