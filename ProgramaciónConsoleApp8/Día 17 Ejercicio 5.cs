using System;
class Program
{
    static void Main()
    {
        int contador = 0; //Inicializar contador
        int num; //Declarar variable num que ingresa el usuario

        do
        {
            Console.WriteLine("Ingresa un número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0) //Verifica si el número es diferente de 0 
            {
                contador++; //Incrementa el contador
            }
        } while (num != 0); //Continúa el bucle mientras el número no sea 0
        Console.WriteLine($"Has ingresado {contador} números."); //Muestra el resultado
    }
}