using System;
class Program
{
    static void Main()
    {
        //Mostrar menú de opciones
        Console.WriteLine("Elige una de las 3 opciones");
        Console.WriteLine("Opción 1: {Saludar}");
        Console.WriteLine("Opción 2: {Mostrar fecha actual}");
        Console.WriteLine("Opción 3: {Salir}");

        //Leer opción que escoge el usuario
        int opcion = Convert.ToInt32(Console.ReadLine());

        //Ejecutar la opción seleccionada
        switch (opcion)
        {
            case 1:
                Console.WriteLine("¡Hey! ¿Todo bien?");
                break;
            case 2:
                Console.WriteLine($"La fecha actual es: {DateTime.Now}");
                break;
            case 3:
                Console.WriteLine("Saliendo...");
                break;
            default:
                 Console.WriteLine("Opción no válida. selecciona una opción del 1 al 3.");
                break;
        }
        Console.WriteLine();//Añadimos un espacio
    }
}