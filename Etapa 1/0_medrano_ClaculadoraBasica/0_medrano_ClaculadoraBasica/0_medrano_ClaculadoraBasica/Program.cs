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
            numero2 = int.Parse(Console.ReadLine());//Leer numeros enteros

            Console.WriteLine("la suma es: " + (numero1 + numero2));
            Console.WriteLine("la resta es: " + (numero1 - numero2));
            Console.WriteLine("la multiplicacion es: " + (numero1 * numero2));
            Console.WriteLine("la division es: " + (numero1 / numero2));
            Console.WriteLine("el resto es: " + (numero1 % numero2));


            Console.ReadKey();
        }
    }
}
