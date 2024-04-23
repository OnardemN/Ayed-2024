using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Ibarra_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            Console.WriteLine("escriba el ancho del rectangulo");
            ancho = int.Parse(Console.ReadLine());
            int altura;
            Console.WriteLine("escriba el altura del rectangulo");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("El perimetro es " + ((altura *2) + (ancho*2)));

            Console.WriteLine("El area es " + altura* ancho);

            Console.WriteLine("La diagonal es " + Math.Sqrt(altura*altura + ancho*ancho));


            Console.ReadKey();

        }
    }
}
