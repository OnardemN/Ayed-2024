using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_medrano_carreradehomero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homero Simpson está participando en una carrera de obstáculos.Cada obstáculo tiene una dificultad diferente (representada por un número entero). Ayuda a Homero a calcular su puntaje total.
               El usuario ingresa la cantidad de obstáculos.
                Homero debe superar cada obstáculo y sumar los puntos correspondientes, cada obstáculo superado suma 10 puntos, cada obstáculo NO superado resta 5.*/

            int obs;
            Console.WriteLine("ingrese la cantidada de obstaculos");
            obs = int.Parse(Console.ReadLine());

            int[] vector = new int[obs];


            for (int i =0; i < obs; i++)

            {
                string respuesta;
                Console.WriteLine("quiere superra el obtaculo" + i);
                respuesta = Console.ReadLine();
                

                if (respuesta == "si")
                {
                    vector[i] += 10;
                }
                else if (respuesta == "no")
                {
                    vector[i] -= 5;
                }
                else 
                {
                    Console.WriteLine("error");
                    i--;
                }
                
            }


            int acumulador;
            acumulador = 0;

            for(int i = 0; obs>i; i++)
            {
                acumulador += vector[i];
                

            }

            Console.WriteLine("tu puntuacion es " + acumulador);




            Console.ReadKey();
        }
    }
   
}
