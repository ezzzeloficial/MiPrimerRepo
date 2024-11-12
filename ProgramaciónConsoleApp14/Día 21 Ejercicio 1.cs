using System;
class Program
{
    static void Main()
    {
        string contraseña = "ucademyoficial"; //Declaramos contraseña correcta
        Console.WriteLine("Introduzca una contraseña"); //Le pedimos al usuario que ingrese 
        
        contraseña = Console.ReadLine();
        
        if (contraseña == contraseña)
        {
            Console.WriteLine("Acceso concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }         
    }
}