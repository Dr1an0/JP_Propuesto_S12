using System;


namespace Semana12Prac
{
    public class Program
    {
        static void Main(string[] args)
        {
            Libreria lib = new Libreria();
            int opcion;

            do
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n===== MENÚ LIBRERÍA =====");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Mostrar libros");
                Console.WriteLine("3. Modificar libro");
                Console.WriteLine("4. Eliminar libro");
                Console.WriteLine("5. Salir");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Seleccione opción: ");
                Console.ResetColor();
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: lib.Registrar(); break;
                    case 2: lib.Mostrar(); break;
                    case 3: lib.Modificar(); break;
                    case 4: lib.Eliminar(); break;
                    case 5: Console.WriteLine("Fin del programa."); break;
                    default: Console.WriteLine("Opción inválida."); break;
                }

            } while (opcion != 5);
        }
    }
}
