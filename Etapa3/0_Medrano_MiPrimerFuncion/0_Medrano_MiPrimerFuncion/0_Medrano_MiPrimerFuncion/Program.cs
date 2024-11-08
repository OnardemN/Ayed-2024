// See https://aka.ms/new-console-template for more information
class Program

{
    static string n(string x)
    {
        x = "Hola " + x;
        return x;
    }
    static void Main(string[] args)
    {
        string nombre;
        Console.WriteLine("Como te llamas?");
        nombre = Console.ReadLine();
        Console.WriteLine(n(nombre));

        Console.ReadKey();
    }
}