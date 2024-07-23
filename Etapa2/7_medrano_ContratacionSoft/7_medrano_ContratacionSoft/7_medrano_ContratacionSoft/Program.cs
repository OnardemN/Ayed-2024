// See https://aka.ms/new-console-template for more information
int candidatos;
Console.WriteLine("ingrese la cantidad de cadidatos");
candidatos = int.Parse(Console.ReadLine());
int[] cantcadidatos = new int[candidatos];

for (int i = 0; i < candidatos; i++)
{
    Console.WriteLine("ingrese el puntaje del candidato" + (i + 1) + ":");
    cantcadidatos[i] += int.Parse(Console.ReadLine());

}


for (int i = 0; i < cantcadidatos.Count() - 1; i++)
{
    for(int j = 0; j < cantcadidatos.Count() - i - 1; i++)
    {
        if (cantcadidatos[j] >cantcadidatos[j + 1])
        {
            int aux = cantcadidatos[j];
            cantcadidatos[j ]= cantcadidatos[j + 1];
            cantcadidatos[j + 1] = aux;
        }
    }
}

   

int valor;
Console.WriteLine("ingrese un numero ");
valor = int.Parse(Console.ReadLine());

for (int i = 0; i < cantcadidatos.Count(); i++)
{
    if (cantcadidatos[i] % valor == 0)
    {
        Console.WriteLine("puntajes que son multiplos n" + (i + 1) + " : con valor " + cantcadidatos[i]);
    }
}


Console.WriteLine("el orden de las calificaciones de mayor a menor son: ");

for (int i = 0; i < candidatos; i++)
{
    Console.WriteLine(cantcadidatos[i]);
}



