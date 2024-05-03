using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_medrano_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre por consola (con un print) los  números de 1 a 100 (ambos incluidos y con un salto de línea entre  cada impresión), sustituyendo los siguientes: 
 - Múltiplos de 3 por la palabra "fizz". 
 - Múltiplos de 5 por la palabra "buzz". 
 - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".*/

            int num;
            num = 0;

            while (num < 100)
            {
                num++;

                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (num%3!=0 && num%5!=0)
                {
                    Console.WriteLine(num);
                }

                if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }

            Console.ReadKey();


             
        }
    }
}
