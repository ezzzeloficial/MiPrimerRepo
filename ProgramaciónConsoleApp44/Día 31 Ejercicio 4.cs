using System;

class Program
{
    static void Main(string[] args)
    {
        int[] listaNumeros = { 1, 2, 5, 7, 9 };
        bool todosPositivos = true;

        for (int i = 0; i < listaNumeros.Length; i++)
        {
            if (listaNumeros[i] <= 0)  // Verificar si el número es positivo o negativo
            {
                todosPositivos = false;
                break;
            }
        }

        if (todosPositivos)
        {
            Console.WriteLine("Todos los números son positivos.");
        }
        else
        {
            Console.WriteLine("No todos los números son positivos.");
        }
    }
}
