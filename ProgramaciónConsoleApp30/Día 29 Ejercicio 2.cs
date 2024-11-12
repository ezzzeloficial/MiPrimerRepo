using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int contador = 0; // Declaramos la suma

        // Recorrer el array utilizando foreach
        foreach (int numero in numeros)
        {
            Console.WriteLine("Número: " + numero);
            // Sumar solo los números pares
            if (numero % 2 == 0)
            {
                contador += numero; // Agregar el número a la suma
            }
        }

        // Mostrar la suma de los números pares
        Console.WriteLine("La suma de los números pares es: " + contador);
    }
}