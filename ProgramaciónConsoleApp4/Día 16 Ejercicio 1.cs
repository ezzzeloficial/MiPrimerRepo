using System;

class Program
{
    static void Main()
    {
        //Declaramos la variable de suma
        int suma = 0;
        
        //Bucle que recorre los números del 1 al 100
        for (int i = 1; i <= 100; i++)  
        {
            suma += i; //Suma el valor de la i a la variable que sea
        }

        //Imprime el resultado de la suma
        Console.WriteLine($"La suma de los números del 1 al 10 es:" + suma);
    }
}
