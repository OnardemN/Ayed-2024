using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Ibarra_DimencionesDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            Console.Write("Escriba el radio");
            radio = int.Parse(Console.ReadLine());

            double pi = 3.14;
            Console.WriteLine("La superficie es: " + 4 * pi * radio * radio);
            Console.WriteLine("El volumen es: " + (4 * pi)/3 * radio * radio*radio);

            Console.ReadKey();














        }
    }
}
