using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<(string, double)> estudiantes = new List<(string, double)>();

        while (true)
        {
            Console.WriteLine("Sistema de Gestión de Estudiantes");
            Console.WriteLine("ACADEMIA.NET");
            Console.WriteLine("Autor:Jorge Chavez");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de notas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarEstudiante(estudiantes);
                    break;
                case 2:
                    MostrarEstudiantes(estudiantes);
                    break;
                case 3:
                    CalcularPromedio(estudiantes);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }

    static void AgregarEstudiante(List<(string, double)> estudiantes)
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();
        double nota = PedirNota();
        estudiantes.Add((nombre, nota));
        Console.WriteLine("Estudiante agregado correctamente.");
    }

    static void MostrarEstudiantes(List<(string, double)> estudiantes)
    {
        Console.WriteLine("Lista de estudiantes:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"{estudiante.Item1} - Nota: {estudiante.Item2}");
        }
    }

    static void CalcularPromedio(List<(string, double)> estudiantes)
    {
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
            return;
        }

        double sumaNotas = 0;
        foreach (var estudiante in estudiantes)
        {
            sumaNotas += estudiante.Item2;
        }

        double promedio = sumaNotas / estudiantes.Count;
        Console.WriteLine($"El promedio de notas es: {promedio:F2}");
    }

    static double PedirNota()
    {
        double nota;
        while (true)
        {
            Console.Write("Ingrese la nota del estudiante (0-10): ");
            if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
            {
                return nota;
            }
            Console.WriteLine("La nota debe estar entre 0 y 10. Intente nuevamente.");
        }
    }
}
