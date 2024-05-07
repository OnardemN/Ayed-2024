using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_medrano_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Recorre los números del 1 al N. (N lo tiene que ingresar el usuario).
              Muestra solamente los números pares*/
            int N;
            Console.WriteLine("ingres un numero ");
            N = int.Parse(Console.ReadLine());

            int contador;
            contador = 1;

            while (N>contador )
            {
                contador++;

                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                else
                {
                    Console.WriteLine();
                }



            }

            Console.ReadKey();

        }
    }
}
