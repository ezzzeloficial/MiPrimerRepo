using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce tu edad:"); //Declaramos que introduzca la edad
        int edad = Convert.ToInt32(Console.ReadLine()); //Imprimimos la edad introducida

        bool esMayorDeEdad = edad >= 18; //creamos un booleano para indicar que es verdadero al introducir 18 años
        Console.WriteLine("La edad introducida es mayor de 18" + esMayorDeEdad); //Imprimimos el veradero
    }
}