using System;

class Program
{
    static void Main()
    {
        int num;// Declarar variable que almacena el número ingresado

        Console.WriteLine("Ingrese un número");
        num = Convert.ToInt32(Console.ReadLine());

        //Bucle de 1 a 10 para Calcular la multiplicación
        for (int i = 1; i <= 10; i++) 
        {
          int multiplicacion = num * i; //Calcular la multiplicación
          Console.WriteLine($"{num} x {i} = {multiplicacion}"); //Mostrar resultado
        }  
    }
}