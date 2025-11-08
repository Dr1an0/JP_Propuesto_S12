using System;


namespace Semana12Prac
{
    internal class Libreria
    {
        private string[] nombres;
        private decimal[] precios;

        public Libreria()
        {
            nombres = new string[0];
            precios = new decimal[0];
        }

        public void Registrar()
        {
            Console.Write("Ingrese nombre del libro: ");
            string nombre = Console.ReadLine().Trim();

            if (nombre == "")
            {
                Console.WriteLine("No se permite nombre vacío.");
                return;
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("Ese libro ya está registrado.");
                    return;
                }
            }

            Console.Write("Ingrese precio del libro: ");
            string precioTexto = Console.ReadLine().Trim();
            decimal precio;

            if (!decimal.TryParse(precioTexto, out precio))
            {
                Console.WriteLine("El precio debe ser numérico.");
                return;
            }

            if (precio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                return;
            }

            if (precio > 1000)
            {
                Console.WriteLine("El precio máximo permitido es 1000.");
                return;
            }

            Array.Resize(ref nombres, nombres.Length + 1);
            Array.Resize(ref precios, precios.Length + 1);

            nombres[nombres.Length - 1] = nombre;
            precios[precios.Length - 1] = precio;

            Console.WriteLine("Libro registrado correctamente.");
        }

        public void Mostrar()
        {
            if (nombres.Length == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }

            Console.WriteLine("\nLista de Libros:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {nombres[i]} — S/ {precios[i]}");
            }
        }

        public void Modificar()
        {
            Console.Write("Ingrese nombre del libro a modificar: ");
            string buscar = Console.ReadLine().Trim();
            int index = -1;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("El libro no existe.");
                return;
            }

            Console.Write("Ingrese nuevo nombre: ");
            string nuevoNombre = Console.ReadLine().Trim();
            if (nuevoNombre == null || nuevoNombre == "")
            {
                Console.WriteLine("No se permite nombre vacío.");
                return;
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                if (i != index && nombres[i].Equals(nuevoNombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Ese nombre ya existe.");
                    return;
                }
            }

            Console.Write("Ingrese nuevo precio: ");
            string precioTexto = Console.ReadLine().Trim();
            decimal nuevoPrecio;

            if (!decimal.TryParse(precioTexto, out nuevoPrecio))
            {
                Console.WriteLine("El precio debe ser numérico.");
                return;
            }

            if (nuevoPrecio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                return;
            }

            if (nuevoPrecio > 1000)
            {
                Console.WriteLine("El precio máximo permitido es 1000.");
                return;
            }

            nombres[index] = nuevoNombre;
            precios[index] = nuevoPrecio;

            Console.WriteLine("Libro modificado correctamente.");
        }

        public void Eliminar()
        {
            Console.Write("Ingrese nombre del libro a eliminar: ");
            string buscar = Console.ReadLine().Trim();
            int index = -1;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("El libro no existe.");
                return;
            }

            string[] nuevosNombres = new string[nombres.Length - 1];
            decimal[] nuevosPrecios = new decimal[precios.Length - 1];

            int j = 0;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (i != index)
                {
                    nuevosNombres[j] = nombres[i];
                    nuevosPrecios[j] = precios[i];
                    j++;
                }
            }

            nombres = nuevosNombres;
            precios = nuevosPrecios;

            Console.WriteLine("Libro eliminado correctamente.");
        }
    }
}
