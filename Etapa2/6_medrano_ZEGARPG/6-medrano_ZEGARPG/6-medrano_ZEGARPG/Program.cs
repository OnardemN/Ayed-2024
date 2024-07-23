// See https://aka.ms/new-console-template for more information
int objetos;
Console.WriteLine("ingrese la cantidad de objetos ");
objetos = int.Parse(Console.ReadLine());
int[] cantobjetos = new int[objetos];

int valor;
Console.WriteLine("ingrese el valor minimo");
valor = int.Parse(Console.ReadLine());

for (int i = 0; i < objetos; i++)
{
    Console.WriteLine("ingre los valores de los objetos n  " + (i + 1));
    cantobjetos[i] += int.Parse(Console.ReadLine());
}

for (int i = 0; i < objetos; i++)
{
    if (cantobjetos[i] >= valor)
    {
        Console.WriteLine("posiscion   " + (i+1)+ ":" + cantobjetos[i]);
    }
}

Console.ReadKey();

