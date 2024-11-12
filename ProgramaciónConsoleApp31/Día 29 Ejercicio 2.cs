using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int mayor = 0; // Declaramos el número mayor

        // Recorrer el array utilizando foreach
        foreach (int numero in numeros)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
        }

        // Mostrar el número más grande
        Console.WriteLine("El número mayor es: " + mayor);
    }
}