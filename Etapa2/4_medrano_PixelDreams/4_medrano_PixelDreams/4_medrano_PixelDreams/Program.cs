// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

int participantes;
Console.WriteLine("ingre la cantidad de participantes");
participantes = int.Parse(Console.ReadLine());
int[] cantpart = new int[participantes];

for (int i = 0; i < participantes; i++)
{
    Console.WriteLine("ingresa los puntajes de los participantes" + (i + 1));
    cantpart[i] += int.Parse(Console.ReadLine());
}

Console.WriteLine("orden");


for (int i = 0; i < cantpart.Count() - 1; i++)
{
    for (int j = 0; j < cantpart.Count() - i - 1; j++)
    {
        if (cantpart[j] < cantpart[j + 1])
        {
            int aux = cantpart[j];
            cantpart[j] = cantpart[j + 1];
            cantpart[j + 1] = aux;

        }
    }
}
for (int i = 0; i < participantes; i++)
{
    Console.WriteLine(cantpart[i]);

}

Console.WriteLine("el primer lugar es " + cantpart[0]);

Console.WriteLine("el ultimo lugar es " + cantpart[participantes - 1]);

Console.ReadKey();
