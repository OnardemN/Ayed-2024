using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           int edad;
            Console.WriteLine("¿Cuál es tu edad?");
            edad = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= edad)
            {
                Console.WriteLine("cumplido " + contador);
                contador++;
            }

            Console.ReadKey();


        }
    }
}
