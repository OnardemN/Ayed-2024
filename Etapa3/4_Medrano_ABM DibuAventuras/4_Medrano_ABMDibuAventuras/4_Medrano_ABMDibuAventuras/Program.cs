// See https://aka.ms/new-console-template for more information
namespace _4_Medrano_DibuAventuras
{
    internal class Program
    {
        static string RegistrarNuevoPersonaje(object[,] personajes)
        {
            Console.Clear();
            bool esIndiceValido = false;
            int indicePersonaje = 0;

            // Validación del índice para elegir el slot
            while (!esIndiceValido)
            {
                Console.Write("Elije el N° Slot del 0 al 19: ");
                string inputIndice = Console.ReadLine();
                esIndiceValido = int.TryParse(inputIndice, out indicePersonaje);
                if (esIndiceValido && indicePersonaje >= 0 && indicePersonaje < 20 && personajes[indicePersonaje, 0] == null)
                {
                    esIndiceValido = true;
                }
                else
                {
                    esIndiceValido = false;
                    Console.Clear();
                    Console.WriteLine("Índice inválido o slot ocupado.");
                }
            }

            // Solicitar datos del personaje
            Console.Write("\nNombre del personaje: ");
            string nombre = Console.ReadLine().Trim();
            Console.Write("\nNombre de la serie del Personaje: ");
            string serie = Console.ReadLine().Trim();

            int fuerza = 0;
            bool esNumeroFuerzaValido = false;
            while (!esNumeroFuerzaValido)
            {
                Console.Write("\nCantidad de fuerza: ");
                string inputFuerza = Console.ReadLine().Trim();
                esNumeroFuerzaValido = int.TryParse(inputFuerza, out fuerza);
                if (!esNumeroFuerzaValido) Console.Clear();
            }

            int defensa = 0;
            bool esNumeroDefensaValido = false;
            while (!esNumeroDefensaValido)
            {
                Console.Write("\nCantidad de defensa: ");
                string inputDefensa = Console.ReadLine().Trim();
                esNumeroDefensaValido = int.TryParse(inputDefensa, out defensa);
                if (!esNumeroDefensaValido) Console.Clear();
            }

            bool esHeroe = false;
            bool esRespuestaValida = false;
            while (!esRespuestaValida)
            {
                Console.Write("\n¿Es un héroe? >No< o >Sí<: ");
                string respuestaHeroe = Console.ReadLine().ToLower().Trim();
                if (respuestaHeroe == "si" || respuestaHeroe == "no")
                {
                    esRespuestaValida = true;
                    esHeroe = respuestaHeroe == "si";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Respuesta inválida.");
                }
            }

            // Almacenar personaje en la matriz
            personajes[indicePersonaje, 0] = nombre;
            personajes[indicePersonaje, 1] = serie;
            personajes[indicePersonaje, 2] = fuerza;
            personajes[indicePersonaje, 3] = defensa;
            personajes[indicePersonaje, 4] = esHeroe;
            Console.Clear();
            return "\n\n¡Éxito! Personaje registrado.\n\n";
        }

        static string MostrarPersonaje(object[,] personajes, int indice)
        {
            Console.WriteLine($"{personajes[indice, 0]}\t| {personajes[indice, 1]}\t| {personajes[indice, 2]}\t| {personajes[indice, 3]}\t| {personajes[indice, 4]}");
            return "";
        }

        static string ConsultarPersonaje(object[,] personajes)
        {
            Console.Write("Buscar el personaje por su nombre: ");
            string nombreABuscar = Console.ReadLine().Trim();

            Console.Clear();
            bool personajeEncontrado = false;
            for (int i = 0; i < 20; i++)
            {
                if (personajes[i, 0] != null && personajes[i, 0].ToString() == nombreABuscar)
                {
                    MostrarPersonaje(personajes, i);
                    personajeEncontrado = true;
                }
            }
            if (!personajeEncontrado)
            {
                Console.WriteLine("Personaje no encontrado.");
            }
            Console.Write("\nPresionar cualquier tecla para continuar...");
            Console.ReadKey();
            return "";
        }

        static string ModificarPersonaje(object[,] personajes)
        {
            int indicePersonaje = -1;
            bool personajeEncontrado = false;
            while (!personajeEncontrado)
            {
                Console.Clear();
                // Mostrar personajes existentes
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null)
                    {
                        MostrarPersonaje(personajes, i);
                    }
                }

                Console.Write("\nNombre del Personaje a modificar: ");
                string nombreABuscar = Console.ReadLine().Trim();
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null && personajes[i, 0].ToString() == nombreABuscar)
                    {
                        indicePersonaje = i;
                        personajeEncontrado = true;
                        break;
                    }
                }

                if (indicePersonaje == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Personaje no encontrado.");
                    personajeEncontrado = false;
                }
            }

            int nuevaFuerza = 0;
            int nuevaDefensa = 0;
            bool esNumeroFuerzaValido = false;
            bool esNumeroDefensaValido = false;
            while (!esNumeroFuerzaValido)
            {
                Console.Clear();
                Console.Write("Nueva Fuerza: ");
                string inputFuerza = Console.ReadLine().Trim();
                esNumeroFuerzaValido = int.TryParse(inputFuerza, out nuevaFuerza);
            }
            while (!esNumeroDefensaValido)
            {
                Console.Clear();
                Console.Write("Nueva Defensa: ");
                string inputDefensa = Console.ReadLine().Trim();
                esNumeroDefensaValido = int.TryParse(inputDefensa, out nuevaDefensa);
            }

            personajes[indicePersonaje, 2] = nuevaFuerza;
            personajes[indicePersonaje, 3] = nuevaDefensa;
            return "¡Personaje modificado exitosamente!";
        }

        static string EliminarPersonaje(object[,] personajes)
        {
            int indicePersonaje = -1;
            bool personajeEncontrado = false;
            while (!personajeEncontrado)
            {
                Console.Clear();
                // Mostrar personajes existentes
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null)
                    {
                        MostrarPersonaje(personajes, i);
                    }
                }

                Console.Write("\nNombre del Personaje a borrar: ");
                string nombreABorrar = Console.ReadLine().Trim();
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null && personajes[i, 0].ToString() == nombreABorrar)
                    {
                        indicePersonaje = i;
                        personajeEncontrado = true;
                        break;
                    }
                }

                if (indicePersonaje == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Personaje no encontrado.");
                    personajeEncontrado = false;
                }
            }

            // Eliminar personaje
            for (int i = 0; i < 5; i++)
            {
                personajes[indicePersonaje, i] = null;
            }

            Console.Clear();
            return "¡Personaje eliminado exitosamente!";
        }

        static string OrdenarPersonajesAlfabeticamente(object[,] personajes)
        {
            List<string> nombresPersonajes = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                if (personajes[i, 0] != null)
                {
                    nombresPersonajes.Add(personajes[i, 0].ToString());
                }
            }
            nombresPersonajes.Sort();

            int x = 0;
            foreach (string nombre in nombresPersonajes)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (personajes[y, 0] != null && personajes[y, 0].ToString() == nombre)
                    {
                        var temp = new object[5];
                        for (int i = 0; i < 5; i++)
                        {
                            temp[i] = personajes[y, i];
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            personajes[y, i] = personajes[x, i];
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            personajes[x, i] = temp[i];
                        }
                    }
                }
                x++;
            }
            return "";
        }

        static void Main(string[] args)
        {
            object[,] personajes = new object[20, 5];
            bool continuar = true;
            string respuesta;

            while (continuar)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Nuevo Personaje");
                Console.WriteLine("2. Consultar Personaje");
                Console.WriteLine("3. Modificar Personaje");
                Console.WriteLine("4. Eliminar Personaje");
                Console.WriteLine("5. Mostrar todos los personajes");
                Console.WriteLine("--------------------------------------");
                Console.Write("\nIngrese la opción que desee: ");
                respuesta = Console.ReadLine().Trim();

                switch (respuesta)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(RegistrarNuevoPersonaje(personajes));
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(ConsultarPersonaje(personajes));
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(ModificarPersonaje(personajes));
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(EliminarPersonaje(personajes));
                        break;
                    case "5":
                        Console.Clear();
                        OrdenarPersonajesAlfabeticamente(personajes);
                        for (int i = 0; i < 20; i++)
                        {
                            if (personajes[i, 0] != null)
                            {
                                MostrarPersonaje(personajes, i);
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
