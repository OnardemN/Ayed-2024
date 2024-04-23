using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_medrano_HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre; 
            Console.WriteLine("¿cual es tu nombre?");
            nombre=Console.ReadLine();
            Console.WriteLine("hola," + nombre);
            Console.ReadKey();
        }
    }
}
