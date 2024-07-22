Imports System
Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Text;
Using System.Threading.Tasks;
Module Program
    Class program
        {
     
        Sub Main(args As String())

            Random aleatorio = New Random();
            Int opcion = aleatorio.Next(0, 10);

            Console.WriteLine(opcion);

            Switch(opcion)
            {
                Case 4
            opcion = opcion * 2;
                    break;
                Case 7
            opcion -= 3;
                    break;
                Case 9
            opcion = 0;
                    break;
                Default
                    Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAH!");
                    break;
            }
            Console.WriteLine(opcion);
            Console.ReadKey();





        End Sub

    End Class

End Module
