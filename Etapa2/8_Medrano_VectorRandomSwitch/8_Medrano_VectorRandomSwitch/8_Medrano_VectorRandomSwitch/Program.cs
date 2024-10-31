// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese tamaño del vector: ");
int n = int.Parse(Console.ReadLine());
int[] vector = new int[n];

Random aleatorio = new Random();

for (int i = 0; i < n; i++)
{
    vector[i] = aleatorio.Next(1, 1000);
}

bool continuar = true;

while (continuar)
{
    Console.WriteLine("------------------------- MENU -------------------------");
    Console.WriteLine("1- Imprimir en pantalla todos los elementos del vector.");
    Console.WriteLine("2- Buscar un número en el vector.");
    Console.WriteLine("3- Ordenar el vector (ascendente o descendente).");
    Console.WriteLine("4- Terminar la ejecución del programa.");

    int opcion;
    Console.WriteLine("Ingrese su opción:");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Elementos del vector:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + "\t");
            }
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine("Ingrese un número para buscar: ");
            int busnum = int.Parse(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < n; i++)
            {
                if (vector[i] == busnum)
                {
                    Console.WriteLine("El número " + busnum + " se encuentra en la posición " + (i + 1));
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("El número " + busnum + " no se encuentra en el vector.");
            }
            break;

        case 3:
            Console.WriteLine("Seleccione el tipo de ordenamiento:");
            Console.WriteLine("1- Ascendente");
            Console.WriteLine("2- Descendente");
            int respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (vector[j] > vector[j + 1])
                        {
                            int temp = vector[j];
                            vector[j] = vector[j + 1];
                            vector[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("ORDEN ASCENDENTE:");
            }
            else if (respuesta == 2)
            {

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (vector[j] < vector[j + 1])
                        {
                            int temp = vector[j];
                            vector[j] = vector[j + 1];
                            vector[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("ORDEN DESCENDENTE:");
            }
            else
            {
                Console.WriteLine("Ingrese una opción válida");
                break;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            break;

        case 4:
            continuar = false;
            Console.WriteLine("El programa ha finalizado.");
            break;

        default:
            Console.WriteLine("La opción no es válida.");
            break;
    }
}

Console.ReadKey();
