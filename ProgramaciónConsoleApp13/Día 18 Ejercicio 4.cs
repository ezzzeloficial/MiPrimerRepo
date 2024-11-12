using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Elige un día de la semana entre 1 y 7");
        int diaSemana = Convert.ToInt32(Console.ReadLine());

        switch (diaSemana)
        {
            case 1:
                Console.WriteLine("Es lunes");
                break;
       
            case 2:
                Console.WriteLine("Es martes");
                break;

            case 3:
                Console.WriteLine("Es miércoles");
                break;

            case 4:
                Console.WriteLine("Es jueves");
                break;
       
            case 5:
                Console.WriteLine("Es viernes");
                break;

            case 6:
                Console.WriteLine("Es sábado");
                break;

            case 7:
                Console.WriteLine("Es domingo");
                break;

            default:
                Console.WriteLine("Día no válido");
                break;
        }
    }
}