// See https://aka.ms/new-console-template for more information
Random aleatorio = new Random();

Console.WriteLine("Ingrese n para el número de filas:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese m para el número de columnas:");
int m = int.Parse(Console.ReadLine());

int[,] matriz1 = new int[n, m];
int[,] matriz2 = new int[n, m];



for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matriz1[i, j] = aleatorio.Next(1, 100);
    }
}

Console.WriteLine("\nMATRIZ 1:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matriz1[i, j] + "\t");
    }
    Console.WriteLine();
}

//segunda matriz
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matriz2[i, j] = aleatorio.Next(1, 100);
    }
}

Console.WriteLine("\nMATRIZ 2:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matriz2[i, j] + "\t");
    }
    Console.WriteLine();
}


Console.WriteLine("\nSUMA DE LAS MATRICES:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matriz1[i, j] + matriz2[i, j] + "\t");
    }
    Console.WriteLine();
}


Console.ReadKey();
