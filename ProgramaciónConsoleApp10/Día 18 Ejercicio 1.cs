using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su edad"); //Pedimos al usuario su edad
        int edad = Convert.ToInt32(Console.ReadLine()); //Lee la edad

        if (edad < 12) //En el caso de que tenga 12
        {
            Console.WriteLine("Eres un niño");
        }
        else if (edad >=12 && edad <=18) //Uso de && para que verifique la edad del usuario entre esos dos números
        {
            Console.WriteLine("Eres un adolescente");
        }
        else //Mayor de 18
        {
            Console.WriteLine("Eres un adulto");
        }
    }
}