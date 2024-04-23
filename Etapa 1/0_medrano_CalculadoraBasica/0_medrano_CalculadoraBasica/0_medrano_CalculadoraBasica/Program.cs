using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ibarra_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)

        {
            int numero1;
            Console.Write("Escribe un número");
            numero1 = int.Parse (Console.ReadLine());
            int numero2;
            Console.Write("Escriba otro");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es " + (numero1 + numero2));
            Console.WriteLine("la resta es " + (numero1 - numero2));
            Console.WriteLine("la multiplicación es " + (numero1 * numero2));
            Console.WriteLine("la divicion es " + (numero1 / numero2));
            Console.WriteLine("el resto es " + (numero1 % numero2));

            Console.ReadKey();

        }
    }
}
