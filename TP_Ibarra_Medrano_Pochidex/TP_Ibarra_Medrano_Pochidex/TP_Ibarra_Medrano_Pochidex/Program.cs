// See https://aka.ms/new-console-template for more information

string pochimon;
string tipo;
int nivel;
int estado = 0;
int investigador = 0;
int contador = 0;

object[,] cantpochimons = new object[76, 6];

for (int i = 0; i < 76; i++)
{
    for (int j = 0; j < 6; j++)
    {
        cantpochimons[0, 0] = "Fila";
        cantpochimons[0, 1] = "Nombre";
        cantpochimons[0, 2] = "Tipo";
        cantpochimons[0, 3] = "Nivel";
        cantpochimons[0, 4] = "Estado";
        cantpochimons[0, 5] = "ivestigador asignado";
    }
}

bool continuar = true;

while (continuar)
{
    Console.WriteLine("--------------------------------------------------\nMenú Principal - Centro de Investigación de Pochimons\n--------------------------------------------------\n");
    Console.WriteLine("Pochimones Encontrados: " + (contador) + "/75\n");
    Console.WriteLine("1.Registrar Pochimon");
    Console.WriteLine("2. Asignar Investigador a Pochimon");
    Console.WriteLine("3. Actualizar Nivel de Pochimon");
    Console.WriteLine("4. Marcar Pochimon como Investigado");
    Console.WriteLine("5. Mostrar Información de Pochimons");
    Console.WriteLine("6. Buscar Pochimons por Tipo");
    Console.WriteLine("7. Mostrar Pochimons por Investigador");
    Console.WriteLine("8. Mostrar Pochimons Picados");
    Console.WriteLine("9. Salir");
    Console.WriteLine("--------------------------------------------------\nIngrese la opción deseada:");

    int opcion;
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Ingrese el nombre del Pochimon: ");
                    pochimon = Console.ReadLine();
                    Console.Write("\n");

                    Console.Write("Ingrese el tipo(A/F/P): ");
                    tipo = Console.ReadLine();

                    Console.Write("\n");

                    Console.Write("Ingrese el nivel: ");
                    nivel = int.Parse(Console.ReadLine());

                    Console.Write("\n");


                    cantpochimons[contador + 1, 0] = contador + 1;
                    cantpochimons[contador + 1, 1] = pochimon;
                    cantpochimons[contador + 1, 2] = tipo;
                    cantpochimons[contador + 1, 3] = nivel;
                    cantpochimons[contador + 1, 4] = 0;
                    cantpochimons[contador + 1, 5] = 0;

                    contador++;


                }
            }
            break;



        case 2:

            Console.WriteLine("Lista de Pochimons no investigados: \n ");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|\n|-------|-------|-------|-------|");

            for (int i = 1; i <= contador; i++)
            {
                if (cantpochimons[i, 4].ToString() == "0")
                {
                    Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 2] + "\t|" + cantpochimons[i, 3] + "\t|");
                }
            }


            Console.WriteLine("\nIngrese el número de fila del Pochimon a asignar: ");
            int fila1 = int.Parse(Console.ReadLine());

            if (fila1 >= 1 && fila1 <= contador && cantpochimons[fila1, 4].ToString() == "0" && (cantpochimons[fila1, 5].ToString() == "0"))
            {
                Console.WriteLine("Ingrese el codigo del investigador: ");
                investigador = int.Parse(Console.ReadLine());


                cantpochimons[fila1, 5] = investigador;
                cantpochimons[fila1, 4] = 1;
                Console.WriteLine("Investigador asignado correctamente y estado actualizado.");
            }
            else
            {
                Console.WriteLine("Número de fila inválido o el Pochimon ya está investigado o tiene un investigador asignado.");
            }

            break;

        case 3:

            Console.WriteLine("|Fila\t|Nombre\t|Nivel\t|\n|-------|-------|-------|");
            for (int i = 1; i <= contador; i++)
            {
                Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 3] + "\t|");

            }
            Console.Write("Ingrese el número de fila del Pochimon: ");
            int fila2 = int.Parse(Console.ReadLine());

            if (fila2 >= 1 && fila2 <= contador)
            {
                Random numnivel = new Random();
                int numrandom = numnivel.Next(1, 4);

                int nuevoniv = Convert.ToInt32(cantpochimons[fila2, 3]);
                cantpochimons[fila2, 3] = nuevoniv + numrandom;

                Console.WriteLine("Nivel actualizado correctamente. El nivel ha aumentado en " + numrandom);
            }
            else
            {
                Console.WriteLine("Número de fila inválido.");
            }
            break;

        case 4:

            Console.WriteLine("Lista de Pochimons no investigados: \n ");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|\n|-------|-------|-------|-------|-------|-----------------------|");

            for (int i = 1; i <= contador; i++)
            {
                if (cantpochimons[i, 4].ToString() == "1")
                {
                    Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 2] + "\t|" + cantpochimons[i, 3] + "\t|" + cantpochimons[i, 4] + "\t|" + cantpochimons[i, 5] + "          \t\t \t|");
                }
            }

            Console.WriteLine("\nIngrese el número de fila del Pochimon a asignar: ");
            int fila3 = int.Parse(Console.ReadLine());

            if (fila3 >= 1 && fila3 <= contador)
            {
                cantpochimons[fila3, 4] = 2;
                Console.WriteLine("Pochimon marcado como Investigado.");
            }
            else
            {
                Console.WriteLine("Número de fila inválido.");
            }
            break;

        case 5:

            Console.WriteLine("Información de Pochimons:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|\n|-------|-------|-------|-------|-------|-----------------------|");
            for (int i = 1; i <= contador; i++)
            {
                Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 2] + "\t|" + cantpochimons[i, 3] + "\t|" + cantpochimons[i, 4] + "\t|" + cantpochimons[i, 5] + "               \t|");
            }

            break;
        case 6:
            Console.WriteLine("Ingrese el tipo de Pochimon a buscar (A/F/P):");
            string tipobuscar = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ENCONTRAR POCHIMOS CON EL TIPO:" + tipobuscar);
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|\n|-------|-------|-------|");

            for (int i = 1; i <= contador; i++)

            {
                if (cantpochimons[i, 2].ToString() == tipobuscar)
                {
                    Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 2] + "\t|");
                }

            }

            break;
        case 7:
            Console.WriteLine("Ingrese el numero de investigador:");

            int numinvestigador = int.Parse(Console.ReadLine());
            Console.WriteLine("ENCONTRAR POCHIMOS POR EL INVESTIGADOR:" + numinvestigador);
            Console.WriteLine("--------------------------------------------------------------------");



            for (int i = 1; i <= contador; i++)

            {
                if ((Convert.ToInt32(cantpochimons[i, 5]) == numinvestigador))
                {
                    Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|\n|-------|-------|-------|-------|-------|-----------------------|");
                    Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 2] + "\t|" + cantpochimons[i, 3] + "\t|" + cantpochimons[i, 4] + "\t|" + cantpochimons[i, 5] + "\t\t\t|");
                }

            }

            break;
        case 8:



            for (int i = 1; i <= contador; i++)

            {

                if ((Convert.ToInt32(cantpochimons[i, 3]) >= 30))
                {
                    Console.WriteLine("POCHIMOS CON NIVEL MAYOR A 30");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|\n|-------|-------|-------|-------|-------|-----------------------|");
                    Console.WriteLine("|" + cantpochimons[i, 0] + "\t|" + cantpochimons[i, 1] + "\t|" + cantpochimons[i, 2] + "\t|" + cantpochimons[i, 3] + "\t|" + cantpochimons[i, 4] + "\t|" + cantpochimons[i, 5] + "\t\t\t|");
                }


            }

            break;

        case 9:

            Console.WriteLine("Programa Finalizado");
            continuar = false;


            break;

        default:
            Console.WriteLine("Opción no valida, ingrese una valida");
            break;



    }
    Console.ReadKey();
}