using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola :)");
        Console.WriteLine("¿Cómo te llamas?");
        string x = Console.ReadLine();

        // Espacio para evitar errores en la compilación
        Console.WriteLine($"No puedes llamarte {x}. ");
        Console.WriteLine("¿Sabes por qué?");

        // Esperamos a que el usuario responda
        string response = Console.ReadLine();

        // Esperando a que el usuario responda con: "¿por qué?"
        if (response.Equals("¿por qué?", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Porque una persona tan especial como tú debería tener un nombre que suene a AMOR ETERNO.");
            Console.ReadLine();
            Console.WriteLine("¿Quieres escuchar una canción que te exprese ese sentimiento? (sí/no)");

            string quiereEscucharLaCancion = Console.ReadLine();
            if (quiereEscucharLaCancion.Equals("sí", StringComparison.OrdinalIgnoreCase) || 
                quiereEscucharLaCancion.Equals("claro", StringComparison.OrdinalIgnoreCase) || 
                quiereEscucharLaCancion.Equals("por supuesto", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    // Aquí pones la URL de YouTube que deseas abrir
                    string url = "https://www.youtube.com/watch?v=LrnGg2XWPKA"; // Ejemplo de enlace
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true // Abre el enlace en el navegador predeterminado
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hubo un problema al intentar abrir el enlace: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Entendido, ¡quizás en otro momento!");
            }
        }
        else 
        {
            Console.WriteLine("Porque una persona tan especial como tú debería tener un nombre que suene a AMOR ETERNO.");
        }
    }
}