using System;

class Program
{
    static void Main()
    {
        //Crear array de 3 nombres
        string [] nombres = new string [3];
        nombres [0]= "Ana";
        nombres [1]= "Carlos";
        nombres [2]= "María";    
       
       //Mostrar los nombres en un bucle
       for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Nombre " + (i + 1) + ": " + nombres[i]);
        }
    }
}