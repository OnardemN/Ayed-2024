// See https://aka.ms/new-console-template for more information
Random aleatorio = new Random();
int n;
Console.WriteLine("Ingresa un número para las filas y columnas: ");
n = int.Parse(Console.ReadLine());

int[,] matriz = new int[n, n];
int[] diagonal = new int[n];


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matriz[i, j] = aleatorio.Next(1, 1000);
        if (i == j)
        {
            diagonal[i] = matriz[i, j];
        }
    }
}


Console.WriteLine("\nMATRIZ:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

// Imprimir la diagonal principal
Console.WriteLine("\nDIAGONAL PRINCIPAL:");
for (int i = 0; i < n; i++)
{
    Console.Write(diagonal[i] + "\t");
}
Console.WriteLine();

Console.ReadKey();
