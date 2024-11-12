using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario la cantidad de números que quiere ingresar
        Console.WriteLine("¿Cuántos números deseas ingresar?");
        int cantidad =  Convert.ToInt32(Console.ReadLine());

        // Declarar el array con el tamaño especificado por el usuario
        int[] numeros = new int[cantidad];

        // Solicitar al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingresa el número " + (i + 1) + ":");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Comprobar si todos los elementos son iguales
        bool todosIguales = numeros.All(x => x == numeros[0]); // Verifica si todos son iguales al primer elemento

        // Mostrar el resultado
        if (todosIguales)
        {
            Console.WriteLine("Todos los elementos en el array son iguales: " + todosIguales);
        }
        else
        {
            Console.WriteLine("No todos los elementos en el array son iguales: " + todosIguales);
        }
    }
}