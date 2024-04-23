using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_medrano_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pregunte al usuario su edad y muestre por pantalla si es mayor de edad o no.*/

            int edad;
            Console.WriteLine("¿cual es tu edad?");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            } 
            else if (edad < 18)
            {
                Console.WriteLine("eres menor de edad");
            }

            Console.ReadKey();
        }
    }
}
