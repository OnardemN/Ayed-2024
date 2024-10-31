// See https://aka.ms/new-console-template for more information
class Program
{
    static double area(double x)
    {
        double pi = 3.14;
        x = pi * (x * x);

        return x;
    }

    static double volumen(double y, double z)
    {
        y = area(z) * y;

        return y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del circulo");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine(area(radio));

        Console.WriteLine("Ingrese la altura del cilindro");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el radio del cilindro");
        double radio1 = double.Parse(Console.ReadLine());
        Console.WriteLine(volumen(altura, radio1));


        Console.ReadKey();
    }
}
