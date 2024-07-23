// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("ingre un numero N");
n = int.Parse(Console.ReadLine());
int m;
Console.WriteLine("ingrse el numero M");
m = int.Parse(Console.ReadLine());
int[,] miprimertabla = new int[n, m];


for (int f = 0; f < n; f++)
{
    for (int c = 0; c < m; c++)
    {
        
        Console.Write(miprimertabla[f, c] +" ");
    }

    Console.WriteLine();
}
Console.ReadKey();

