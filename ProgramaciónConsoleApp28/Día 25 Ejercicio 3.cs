using System;

class Program
{
    static void Main()
    {
        // Create an array to store words
        string[] palabras = new string[5];
        
        // Prompt user to input words
        for (int i = 0; i < palabras.Length; i++)
        {
            Console.Write("Introduce la palabra " + (i + 1) + ": ");
            palabras[i] = Console.ReadLine();
        }

        // Display the words in reverse order
        Console.WriteLine("\nLas palabras en orden inverso son:");
        for (int i = palabras.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(palabras[i]);
        }
    }
}