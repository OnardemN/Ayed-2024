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
            string palabra;
            Console.WriteLine("ingrese una palabra");
            palabra = Console.ReadLine();
            int contador = 0;

            while (contador < 10)
            {
                Console.WriteLine("palabra: " + (palabra));
                contador++;
                

            }

            Console.ReadKey();
        }
    }
}
