using System;

class Program
{
    static void Main()
    {
        int i = 0; // Declarar variable para contar el número de positivos ingresados
        int num;   // Declarar variable que almacena el número ingresado

        // Bucle que continuará hasta que el número sea negativo
        do 
        {
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine()); //Utilizamos el Convert.ToInt32 para que no hayan errores y no necesita agregarel "Parse"
            
            if (num > 0) //Utilizamos el if como "condición"
            {
                i++; // Incrementa el contador si el número es positivo
            }
            
        } while (num >= 0); // El bucle se detiene cuando se ingresa un número negativo
        
        Console.WriteLine("Cantidad de números positivos ingresados: " + i); //Mostramos la cantidad de números positivos ingresados
    }
}