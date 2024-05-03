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
            Console.WriteLine("ingresa tu edad");
            edad = int.Parse(Console.ReadLine());

            int saldo;
            Console.WriteLine("e ingresa tus ingresos mensuales");
            saldo = int.Parse(Console.ReadLine());

            if (edad>=19 && saldo>=100000)
            {
                Console.WriteLine("podes cobrar");
            }
            else
            {
                Console.WriteLine("no podes cobrar");
            }

            Console.ReadKey();

        }
    }
}
