// See https://aka.ms/new-console-template for more information
using System;
namespace _2_Medrano_AreaVolumen
{
    class Program
    {
        static double area(double x)
        {
            double pi = 3.14;
            x = pi * (x * x);
            return x;
        }
        static double volumen(double y, double x)
        {
            y = area(y) * x;
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del circulo:");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio del cilindro:");
            double radiocili = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine(volumen(radiocili, altura));
            Console.ReadKey();


        }
    }

}