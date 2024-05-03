using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_medrano_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que pregunte una y otra vez si desea terminar el programa, salvo si se contesta exactamente SI (en mayúsculas y sin tilde).*/
            String pregunta;
            pregunta = "";

            while  (pregunta != "SI")
            {
                Console.WriteLine("desea terminar con el programa ");
                pregunta = Console.ReadLine();

               
            }
            Console.WriteLine("hasta luego");
            Console.ReadKey();
          
     
            {

            }
        }
    }
}
