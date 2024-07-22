// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

int tps;
Console.WriteLine("Ingrese la cantidad de tps que tiene ");
tps = int.Parse(Console.ReadLine());
int[] canttps = new int[tps];

int examenes;
Console.WriteLine("Ingrese la cantidad de exámenes que tiene ");
examenes = int.Parse(Console.ReadLine());
int[] cantex = new int[examenes];

for (int i = 0; i < tps; i++)
{
    Console.WriteLine("¿Cuanto sacaste en el tp " + (i + 1) + "?");
    canttps[i] += int.Parse(Console.ReadLine());
}

for (int i = 0; i < examenes; i++)
{
    Console.WriteLine("¿Cuanto sacaste en el examen " + (i + 1) + "?");
    cantex[i] += int.Parse(Console.ReadLine());
}


int acumexamenes = 0;
for (int i = 0; i < examenes; i++)
{
    acumexamenes += cantex[i];
}
int promedioexamenes = acumexamenes / examenes;
Console.WriteLine("El promedio de las notas de los examenes es: " + promedioexamenes);


int contadortps = 0;
for (int i = 0; i < tps; i++)
{
    if (canttps[i] >= 6)
    {
        contadortps++;
    }
}


int porcentajetps = (contadortps * 100) / tps;


if (promedioexamenes >= 6 && porcentajetps >= 75)
{
    Console.WriteLine("Phineas y Ferb aprueban la materia");
}
else
{
    Console.WriteLine("Phineas y Ferb no aprueban la materia");
}

Console.ReadKey();
