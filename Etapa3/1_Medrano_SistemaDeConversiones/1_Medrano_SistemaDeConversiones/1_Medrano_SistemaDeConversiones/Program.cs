// See https://aka.ms/new-console-template for more
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Medrano_SistemaDeConversiones
{
    class Program
    {

        static string deci(int x)
        {
            string bin = " ";
            while (x > 0)
            {
                bin = (x % 2) + bin;
                x /= 2;
            }
            return bin;
        }
        static int binario(string x)
        {
            return Convert.ToInt32(x, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para pasarlo a binario:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("En binario es: " + (deci(num)));
            Console.ReadKey();
            Console.WriteLine("Ingrese un numero en binario");
            string bin1 = Console.ReadLine();
            Console.WriteLine("En decimal es :"+binario(bin1));
            Console.ReadKey();
        }
    }
}