
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> personajes = new List<string>
        {
            "el valiente caballero",
            "la intrépida exploradora",
            "el astuto pirata",
            "la misteriosa bruja"
        };

        List<string> lugares = new List<string>
        {
            "en un antiguo castillo",
            "en una isla desierta",
            "en un bosque encantado",
            "en las profundidades del océano"
        };

        List<string> eventos = new List<string>
        {
            "buscaba un tesoro escondido",
            "descubría un mapa secreto",
            "luchaba contra un dragón",
            "lanzaba un hechizo poderoso"
        };

        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            string personaje = personajes[random.Next(personajes.Count)];
            string lugar = lugares[random.Next(lugares.Count)];
            string evento = eventos[random.Next(eventos.Count)];
            
            Console.WriteLine("ACADEMIA.NET");
            Console.WriteLine("Autor:Jorge Chavez");
            Console.WriteLine($"{personaje} se encontraba {evento} {lugar}...");
        }
    }
}
