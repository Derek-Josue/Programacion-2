using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox.Ejemplos
{
    public partial class practicaSwitch : Form
    {
        public practicaSwitch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia;

            dia = Convert.ToInt32(txtDiadeSemana.Text);

            //Logica desarrollada con if else

            //if (dia == 1)
            //{
            //    MessageBox.Show("Lunes");
            //}
            //else if (dia == 2)
            //{
            //    MessageBox.Show("Martes");
            //}
            //else if (dia == 3)
            //{
            //    MessageBox.Show("Miercoles");
            //}
            //else if (dia == 4)
            //{
            //    MessageBox.Show("Jueves");
            //}
            //else if (dia == 5)
            //{
            //    MessageBox.Show("Viernes");
            //}
            //else if (dia == 6)
            //{
            //    MessageBox.Show("Sabado");
            //}
            //else if (dia == 7)
            //{
            //    MessageBox.Show("Domingo");
            //}
            //else
            //{
            //    MessageBox.Show("El numero ingresado no corresponde a un dia de la semana");
            //}



            //Logica desarrollada con switch case
            switch (dia)
            {
                //Se puede escribir de la siguiente forma
                case 1:
                    MessageBox.Show("Lunes");
                    break;
                case 2:
                    MessageBox.Show("Martes");
                    break; //El break es necesario para que no se ejecuten los siguientes casos
                case 3:
                    MessageBox.Show("Miercoles");
                    break;
                //Tambien se puede escribir de la siguiente forma
                case 4: MessageBox.Show("Jueves"); break;
                case 5: MessageBox.Show("Viernes"); break;
                case 6: MessageBox.Show("Sabado"); break;
                case 7: MessageBox.Show("Domingo"); break;

                //El default es el caso que se ejecuta cuando no se cumple ninguno de los casos anteriores
                default:
                    MessageBox.Show("El numero ingresado no corresponde a un dia de la semana");
                    break;
            }


        }
    }
}
