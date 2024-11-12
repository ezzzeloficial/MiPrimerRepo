using System;
class Program
{
    static void Main()
    {
        //Iniciamos contadores
        int contadorPositivos = 0;
        int contadorNegativos = 0;
        int contadorCeros = 0;

        //Leer 10 números
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Introduce el número {i}");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Clasificamos el número
            if (numero > 0)
            {
                contadorPositivos++;
        
            }
            else if (numero < 0)
            {
                contadorNegativos++;
            }
            else 
            {
                contadorCeros++;
            }
        }

        //Mostrar resultados
        Console.WriteLine($"Total de números positivos: {contadorPositivos}");
        Console.WriteLine($"Total de números negativos: {contadorNegativos}");
        Console.WriteLine($"Total de Ceros: {contadorCeros}");
    }
}