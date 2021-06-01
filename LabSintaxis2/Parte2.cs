using System;
using System.Collections.Generic;
using System.Text;

namespace LabSintaxis2
{
    class Parte2
    {
        public static void Parte()
        {
           
            Console.WriteLine("Ingrese un texto por favor");
            string InputTexto = Console.ReadLine();
            if (InputTexto.Length == 0)
            {
                Console.WriteLine("Cadena vacia , se finalizara el programa");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(" MENU ");
                Console.WriteLine("1- Imprimir la cadena en mayusculas");
                Console.WriteLine("2- Imprimir la cadena en minusculas");
                Console.WriteLine("3- Cantidad de caracteres en la cadena");
                Console.WriteLine("Ingrese una opcion");
                int opcion=1;
                opcion= Console.Read();
                Console.Clear();
                switch (opcion)
                { 
                    case 1 :
                        Console.WriteLine("Llego hasta aca");
                        Console.WriteLine(InputTexto.ToUpper());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(InputTexto.ToLower());
                        break;
                    case 3:
                        int cantidad = InputTexto.Length;
                        Console.WriteLine(cantidad);
                        break;
                }
                
            }
        }
    }
}
