using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> palabrasDefiniciones = new Dictionary<string, string>
        {
            { "Computadora", "Dispositivo electrónico." },
            { "Bicicleta", "Vehículo de dos ruedas." },
            { "Elefante", "Mamífero terrestre." },
            { "Guitarra", "Instrumento musical." },
            { "Perro", "Animal domestico." }
        };

        Random random = new Random();
        List<string> palabras = new List<string>(palabrasDefiniciones.Keys);

        while (true)
        {
          
            string palabraSeleccionada = palabras[random.Next(palabras.Count)];
            string definicionCorrecta = palabrasDefiniciones[palabraSeleccionada];

              
            Console.WriteLine("Bienvenidos a nuestro Juego de Adivinazas");
            Console.WriteLine("ACADEMIA.NET");
            Console.WriteLine($"Adivina el significado de la palabra: {palabraSeleccionada}");
            Console.Write("Tu respuesta: ");
            string respuestaUsuario = Console.ReadLine();

            if (respuestaUsuario.ToLower() == definicionCorrecta.ToLower())
            {
                Console.WriteLine("¡Correcto! ¡Has adivinado!");
            }
            else
            {
                Console.WriteLine($"Incorrecto. La definición correcta es: {definicionCorrecta}");
            }

            Console.Write("¿Quieres seguir jugando? (s/n): ");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() != "s")
            {
                break;
            }
        }

        Console.WriteLine("¡Gracias por jugar!");
    }
}

