using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, -20, 30, -40, 50, -60 }; // Ejemplo de array

        // Reemplazar números negativos por ceros
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < 0) // Verificar si el número es negativo
            {
                numeros[i] = 0; // Reemplazar por cero
            }
        }

        foreach (int numero in numeros.Reverse())    
        {
            Console.WriteLine(numero);
        }
        
        // Imprimir los números en orden inverso
        Console.WriteLine("Números en orden inverso:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}