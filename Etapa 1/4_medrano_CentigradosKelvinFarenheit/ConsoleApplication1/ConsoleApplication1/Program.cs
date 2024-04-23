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
            int celsius;
      
            Console.WriteLine("Ingrese los grados ");
            celsius = int.Parse(Console.ReadLine());

            Console.WriteLine("Los grados centígrados a Kelvin " + celsius + 273);
            Console.WriteLine("Los grados centígrados a fahrenheit " + celsius * 18/10 + 32);

            Console.ReadKey();


        }
    }
}
