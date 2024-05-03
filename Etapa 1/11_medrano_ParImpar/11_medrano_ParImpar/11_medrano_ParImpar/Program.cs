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
            int numero;
            Console.WriteLine("ingresa un numero");
            numero = int.Parse(Console.ReadLine());

            int numero2 = 2;

            if (numero % numero2 == 0)
            {
                Console.WriteLine("es par");
            }

            else
            {
                Console.WriteLine("es impar");
            }

            Console.ReadKey();
        }
    }
}
