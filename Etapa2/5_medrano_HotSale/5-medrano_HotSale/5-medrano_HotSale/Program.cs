// See https://aka.ms/new-console-template for more information
int productos;
Console.WriteLine("ingrese la cantidad de productos vendidos");
productos = int.Parse(Console.ReadLine());
int[] cantproductos = new int[productos];

for(int i =0; i<productos; i++)
{
    Console.WriteLine("ingrese el precio de cada producto" + (i +  1));
    cantproductos[i] += int.Parse(Console.ReadLine());

}

for (int i = 0; i < cantproductos.Count() - 1; i++)
{
    for (int j=0; j < cantproductos.Count() - 1 - i; j++)
    {
        if (cantproductos[j] < cantproductos[j + 1])
        {
            int aux = cantproductos[j];
            cantproductos[j] = cantproductos[j + 1];
            cantproductos[j + 1] = aux;
        }
    }
}

Console.WriteLine("el producto mas carro es " + cantproductos[0]);
Console.WriteLine("el producto mas varato es " + cantproductos[productos - 1]);

Console.ReadKey();

