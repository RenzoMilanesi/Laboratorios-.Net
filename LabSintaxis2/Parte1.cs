using System;

namespace LabSintaxis2
{
    class Parte1
    {
        public static void Parte()
        {
            string InputTexto;

            Console.WriteLine("Ingrese un texto");
            InputTexto = Console.ReadLine();
            Console.WriteLine();
            if (InputTexto.Length == 0)
            {
                Console.WriteLine("Texto vacio");
            }
            else
                {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1) Frase ingresada con Mayusculas");
                Console.WriteLine("2) Frase ingresada con Minusculas");
                Console.WriteLine("3) Cantidad de caracteres en la frase");
                Console.Clear();
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.Clear();
                if (opcion.Key == ConsoleKey.D1) { Console.WriteLine(InputTexto.ToUpper()); }
                else if (opcion.Key == ConsoleKey.D2) { Console.WriteLine(InputTexto.ToLower()); }
                else if (opcion.Key == ConsoleKey.D3) { Console.WriteLine(InputTexto.Length); }
                }
            }
        }

    }
