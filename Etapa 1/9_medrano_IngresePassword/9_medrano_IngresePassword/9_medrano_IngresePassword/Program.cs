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
            string contraseña;
            contraseña = "1234";
            Console.WriteLine("ingresa tu contraseña");

            string contraseña2;
            contraseña2 = Console.ReadLine();



            if (contraseña2 == contraseña)
            {
                Console.WriteLine("es correcta");
            }
            else
            {
                Console.WriteLine("no es correcta");

            }

            Console.ReadKey();

        }
    }
}
