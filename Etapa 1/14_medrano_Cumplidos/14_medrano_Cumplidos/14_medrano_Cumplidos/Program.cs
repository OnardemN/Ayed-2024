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
            int contador = 0;

            while (100 >= contador)
            {

                if (contador % 3 == 0 && contador % 5 == 0)
                {
                    Console.WriteLine((contador) + " buzzfizz");
                }
                else if (contador % 5 == 0)
                {
                    Console.WriteLine((contador) + " buzz");
                }

                else if (contador % 3 == 0)
                {
                    Console.WriteLine((contador) + " fizz");
                }

                else
                {
                    Console.WriteLine(contador);
                }
                contador++;


            }






            Console.ReadKey();



        }
    }
}
