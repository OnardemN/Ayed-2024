// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static string Pochimon;
    static string tipo;
    static int nivel;
    static int estado = 0;
    static int investigador = 0;
    static int contadorPochi = 0;
    static object[,] cantidadPochimons = new object[76, 6];

    static void RegistrarPochimon()
    {
        Console.Write("Ingrese el nombre del Pochimon: ");
        Pochimon = Console.ReadLine();
        Console.Write("\n");

        Console.Write("Ingrese el tipo (A/F/P): ");
        tipo = Console.ReadLine();
        Console.Write("\n");

        Console.Write("Ingrese el nivel: ");
        nivel = int.Parse(Console.ReadLine());
        Console.Write("\n");

        cantidadPochimons[contadorPochi + 1, 0] = contadorPochi + 1;
        cantidadPochimons[contadorPochi + 1, 1] = Pochimon;
        cantidadPochimons[contadorPochi + 1, 2] = tipo;
        cantidadPochimons[contadorPochi + 1, 3] = nivel;
        cantidadPochimons[contadorPochi + 1, 4] = 0;
        cantidadPochimons[contadorPochi + 1, 5] = 0;

        contadorPochi++;
        Console.WriteLine("Pochimon registrado correctamente. Presione ENTER para continuar.");
        Console.ReadKey();
        Console.Clear();
    }

    static void AsignarInvestigador()
    {
        Console.WriteLine("Lista de Pochimons no investigados: \n ");
        Console.WriteLine("Fila\tNombre\tTipo\tNivel");

        for (int i = 1; i <= contadorPochi; i++)
        {
            if (cantidadPochimons[i, 4].ToString() == "0")
            {
                Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 2] + "\t" + cantidadPochimons[i, 3]);
            }
        }

        Console.Write("\nIngrese el número de fila del Pochimon a asignar: ");
        int filaSeleccionada = int.Parse(Console.ReadLine());

        if (filaSeleccionada >= 1 && filaSeleccionada <= contadorPochi &&
            cantidadPochimons[filaSeleccionada, 4].ToString() == "0" && (cantidadPochimons[filaSeleccionada, 5].ToString() == "0"))
        {
            Console.Write("Ingrese el código del investigador: ");
            investigador = int.Parse(Console.ReadLine());

            cantidadPochimons[filaSeleccionada, 5] = investigador;
            cantidadPochimons[filaSeleccionada, 4] = 1;
            Console.WriteLine("Investigador asignado correctamente y estado actualizado.");
        }
        else
        {
            Console.WriteLine("Número de fila inválido o el Pochimon ya está investigado o tiene un investigador asignado.");
        }

        Console.ReadKey();
        Console.Clear();
    }

    static void ActualizarNivelPochimon()
    {
        Console.WriteLine("Fila\tNombre\tNivel");
        for (int i = 1; i <= contadorPochi; i++)
        {
            Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 3]);
        }

        Console.Write("\nIngrese el número de fila del Pochimon: ");
        int filaSeleccionada2 = int.Parse(Console.ReadLine());

        if (filaSeleccionada2 >= 1 && filaSeleccionada2 <= contadorPochi)
        {
            Random rand = new Random();
            int numRandom = rand.Next(1, 4);

            int nivelActual = Convert.ToInt32(cantidadPochimons[filaSeleccionada2, 3]);
            cantidadPochimons[filaSeleccionada2, 3] = nivelActual + numRandom;

            Console.WriteLine("Nivel actualizado correctamente. El nivel ha aumentado en " + numRandom);
        }
        else
        {
            Console.WriteLine("Número de fila inválido.");
        }

        Console.ReadKey();
        Console.Clear();
    }

    static void MarcarPochimonComoInvestigado()
    {
        Console.WriteLine("Lista de Pochimons investigados: \n ");
        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");

        for (int i = 1; i <= contadorPochi; i++)
        {
            if (cantidadPochimons[i, 4].ToString() == "1")
            {
                Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 2] + "\t" + cantidadPochimons[i, 3] + "\t" + cantidadPochimons[i, 4] + "\t" + cantidadPochimons[i, 5]);
            }
        }

        Console.Write("\nIngrese el número de fila del Pochimon a marcar como Investigado: ");
        int filaSeleccionada3 = int.Parse(Console.ReadLine());

        if (filaSeleccionada3 >= 1 && filaSeleccionada3 <= contadorPochi)
        {
            cantidadPochimons[filaSeleccionada3, 4] = 2;
            Console.WriteLine("Pochimon marcado como Investigado.");
        }
        else
        {
            Console.WriteLine("Número de fila inválido.");
        }

        Console.ReadKey();
        Console.Clear();
    }

    static void MostrarInformacionPochimons()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Información de Pochimons:");
        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");

        for (int i = 1; i <= contadorPochi; i++)
        {
            System.Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 2] + "\t" + cantidadPochimons[i, 3] + "\t" + cantidadPochimons[i, 4] + "\t" + cantidadPochimons[i, 5]);
        }

        System.Console.ReadKey();
        System.Console.Clear();
    }

    static void BuscarPochimonsPorTipo()
    {
        System.Console.Write("Ingrese el tipo (A/F/P) para buscar: ");
        string tipoBusqueda = System.Console.ReadLine();

        System.Console.WriteLine("Resultados de búsqueda por tipo: ");
        for (int i = 1; i <= contadorPochi; i++)
        {
            if (cantidadPochimons[i, 2].ToString() == tipoBusqueda)
            {
                System.Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 2] + "\t" + cantidadPochimons[i, 3]);
            }
        }

        System.Console.ReadKey();
        System.Console.Clear();
    }

    static void MostrarPochimonsPorInvestigador()
    {
        System.Console.Write("Ingrese el código del investigador: ");
        int investigadorBusqueda = System.Int32.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Resultados de búsqueda por investigador: ");
        for (int i = 1; i <= contadorPochi; i++)
        {
            if (System.Convert.ToInt32(cantidadPochimons[i, 5]) == investigadorBusqueda)
            {
                System.Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 2] + "\t" + cantidadPochimons[i, 3]);
            }
        }

        System.Console.ReadKey();
        System.Console.Clear();
    }

    static void MostrarPochimonsPicados()
    {
        System.Console.WriteLine("Pochimons picados:");
        for (int i = 1; i <= contadorPochi; i++)
        {
            if (cantidadPochimons[i, 4].ToString() == "2")
            {
                System.Console.WriteLine(cantidadPochimons[i, 0] + "\t" + cantidadPochimons[i, 1] + "\t" + cantidadPochimons[i, 2] + "\t" + cantidadPochimons[i, 3]);
            }
        }

        System.Console.ReadKey();
        System.Console.Clear();
    }

    static void Main(string[] args)
    {
        cantidadPochimons[0, 0] = "Fila";
        cantidadPochimons[0, 1] = "Nombre";
        cantidadPochimons[0, 2] = "Tipo";
        cantidadPochimons[0, 3] = "Nivel";
        cantidadPochimons[0, 4] = "Estado";
        cantidadPochimons[0, 5] = "Investigador";

        int menuOption;

        do
        {
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1. Registrar Pochimon");
            Console.WriteLine("2. Asignar Investigador");
            Console.WriteLine("3. Actualizar Nivel Pochimon");
            Console.WriteLine("4. Marcar como Investigado");
            Console.WriteLine("5. Mostrar Información de Pochimons");
            Console.WriteLine("6. Buscar Pochimons por Tipo");
            Console.WriteLine("7. Mostrar Pochimons por Investigador");
            Console.WriteLine("8. Mostrar Pochimons Picados");
            Console.WriteLine("9. Salir");
            Console.Write("Elija una opción: ");
            menuOption = int.Parse(Console.ReadLine());

            switch (menuOption)
            {
                case 1:
                    RegistrarPochimon();
                    break;
                case 2:
                    AsignarInvestigador();
                    break;
                case 3:
                    ActualizarNivelPochimon();
                    break;
                case 4:
                    MarcarPochimonComoInvestigado();
                    break;
                case 5:
                    MostrarInformacionPochimons();
                    break;
                case 6:
                    BuscarPochimonsPorTipo();
                    break;
                case 7:
                    MostrarPochimonsPorInvestigador();
                    break;
                case 8:
                    MostrarPochimonsPicados();
                    break;
                case 9:
                    Console.WriteLine("Cerrando programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (menuOption != 9);
        Console.ReadKey();
    }
}
