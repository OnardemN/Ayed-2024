// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese numero para las filas y columnas ");
int n = int.Parse(Console.ReadLine());


int[,] matriz = new int[n, n];
int numero = 1;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matriz[i, j] = numero;
        numero++;
    }
}
Console.WriteLine("\nMATRIZ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}


Console.WriteLine("MATRIZ ROTADA A 90°:");
for (int i = 0; i < n; i++)
{
    for (int j = n - 1; j >= 0; j--)
    {
        Console.Write(matriz[j, i] + "\t");
    }
    Console.WriteLine();
}



Console.ReadKey();
