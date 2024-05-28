using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_medrano_lafiestadestitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar la cantidad de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a calcular el promedio de comida que necesitará por invitado. El programa solicitará al usuario que ingrese la cantidad de invitados y luego pedirá la cantidad de comida que cada invitado consume, asegurándose de que los valores ingresados estén dentro del rango permitido (de 1 a 100). Una vez que se hayan ingresado todos los datos, el programa calculará el promedio de comida por invitado y lo mostrará en pantalla.

             El programa solicitará al usuario que ingrese la cantidad de invitados a la fiesta.Luego, para cada invitado, el programa solicitará que se ingrese la cantidad de comida que come (un número entre 1 y 100), asegurándose de que el valor ingresado esté dentro del rango permitido. Si el valor ingresado no está dentro del rango, se mostrará un mensaje de error y se pedirá que se ingrese nuevamente.Una vez que se hayan ingresado los datos de todos los invitados, el programa calculará el promedio de comida por invitado.Finalmente, el programa mostrará en pantalla el promedio de comida por invitado.*/

            int xinvitados;
            Console.WriteLine("cuantos invitados son");
            xinvitados = int.Parse(Console.ReadLine());
            int[] vector = new int[xinvitados];
          
            for (int i = 0; i < xinvitados; i++)
            {
                int comida;
                Console.WriteLine("cantidad de comida que consume invitado "+i);
                comida = int.Parse(Console.ReadLine());

                if (comida>=1 && comida<=100)
                {
                    vector[i] += comida;
                }
                else
                {
                    Console.WriteLine("error");
                    i--;
                }


            }


            int acumulador;
            acumulador = 0;

            for (int i = 0; xinvitados > i; i++)
            {
                acumulador += vector[i];


            }

            Console.WriteLine("el promedio x persona es  " + acumulador/xinvitados);






            Console.ReadKey();
        }
    }
    
}
