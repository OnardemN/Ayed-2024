using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_medrano_elrayocarreraveloz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El Rayo McQueen está compitiendo en una carrera de alta velocidad. Necesita un programa en C# que le ayude a registrar los tiempos de cada vuelta y calcular algunas estadísticas importantes. 

              El programa debe:
              Permitir a Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos. Utiliza un array para almacenar estos tiempos.
              Calcular y mostrar en pantalla el tiempo total de la carrera.
              Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
              Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el menor tiempo registrado.
              El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo McQueen y luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.*/

            int xvuelta;
            Console.WriteLine("ingrese la cantidada de vueltas");
            xvuelta = int.Parse(Console.ReadLine());
            int[] vector = new int[xvuelta];

            for (int i = 0; i < xvuelta; i++)
            {
               
                Console.WriteLine("cuanto tiempo duro la carerra" + (i+1)+"?");
                vector[i] += int.Parse(Console.ReadLine());
            }
      



            int mejorvuelta = 0;
            int mejortiempo = vector[0];
            for (int i = 0; i < xvuelta; i++)
            {
                mejorvuelta += vector[i];
                if (vector[i] < mejortiempo)
                {
                    mejortiempo = vector[i];
                   
                }
            }
            



            int acumulador;
            acumulador = 0;

            for (int i = 0; xvuelta > i; i++)
            {
                acumulador += vector[i];
            }


            Console.WriteLine("la suma del tiempo en total es :" + acumulador);
            Console.WriteLine("el promedio es :" + acumulador / xvuelta);
            Console.WriteLine("la mejor vuelta es :" + mejortiempo);
            Console.ReadKey();
        }
    }
}
