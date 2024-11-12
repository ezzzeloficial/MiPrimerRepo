using System;
class Program
{
    static void Main()
    {
        //Primera parte: Escribimos mediante números del 1 al 4 el tipo de operaciones a elegir
        Console.WriteLine("Pulse (1) para sumar");
        Console.WriteLine("Pulse (2) para restar");
        Console.WriteLine("Pulse (3) para multiplicar");
        Console.WriteLine("Pulse (4) para dividir");

        //Segunda parte: Le pedimos al usuario que elija, una de las 4 opciones
        Console.WriteLine("Elige una de las 4 opciones");
        int i = Convert.ToInt32(Console.ReadLine()); //Declaramos la variable i para hacer las diferentes operaciones

        //Pedimos que ingrese los dos números para hacer las operaciones
        Console.WriteLine("Ahora ingrese los operandos");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        //Switch para las diferentes opciones
        switch (i)
        {
           case '+':
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine("El resultado de la división es: " + (num1 / num2));
                else
                    Console.WriteLine("Error: No se puede dividir entre 0");
                break;
            default:
                Console.WriteLine("Operacion no válida");
                break;
        }
    }
}