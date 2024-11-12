using System;

class Program
{
    static void Main()
    {
        // Pedimos al usuario que introduzca una cantidad en metros
        Console.WriteLine("Introduzca una cantidad en metros:");
        double metros = Convert.ToDouble(Console.ReadLine()); // Leemos la cantidad ingresada por el usuario

        int opcion; // Inicializamos las opciones

        do
        {
            // Mostrar menú de conversiones
            Console.WriteLine("\nMenú de conversiones:");
            Console.WriteLine("1. Convertir a kilómetros");
            Console.WriteLine("2. Convertir a centímetros");
            Console.WriteLine("3. Convertir a milímetros");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción (1-4): ");

            // Leer opción del usuario
            opcion = Convert.ToInt32(Console.ReadLine());

            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case 1: // Convertir a kilómetros
                    double kilometros = metros / 1000;
                    Console.WriteLine($"{metros} metros son {kilometros} kilómetros.");
                    break;
                case 2: // Convertir a centímetros
                    double centimetros = metros * 100;
                    Console.WriteLine($"{metros} metros son {centimetros} centímetros.");
                    break;
                case 3: // Convertir a milímetros
                    double milimetros = metros * 1000;
                    Console.WriteLine($"{metros} metros son {milimetros} milímetros.");
                    break;
                case 4: // Salimos del programa
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción del 1 al 4.");
                    break;
            }

            Console.WriteLine(); // Espacio en blanco
        } while (opcion != 4); // Continuar hasta que el usuario elija salir
    }
}