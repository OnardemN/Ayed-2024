using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int reloj;
            Console.WriteLine("escribi un numero");
            reloj = int.Parse(Console.ReadLine());

            

            while (reloj>=0)
            {
                Console.WriteLine(reloj);
                reloj--;
            }

            Console.ReadKey();
        }
    }
}
