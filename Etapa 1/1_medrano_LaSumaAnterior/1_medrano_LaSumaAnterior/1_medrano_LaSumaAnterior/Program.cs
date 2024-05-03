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
            int numero1;
            Console.WriteLine("Escribi un numero");
            numero1 = int.Parse(Console.ReadLine());
            int numero2;
            Console.WriteLine("Escrbi otro");
            numero2 = int.Parse(Console.ReadLine());
            int numero3;
            Console.WriteLine("Escrbi otro");
            numero3 = int.Parse(Console.ReadLine());

            int suma;
            suma = (numero1 + numero2 + numero3);

            Console.WriteLine("La suma de los tres es " + (suma));

            Console.ReadKey();

        }
    }
}
