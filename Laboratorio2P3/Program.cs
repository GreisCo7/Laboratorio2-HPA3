using Laboratorio2P3;
using System;

namespace Laboratorio2P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificacion miLibro =
                new LibroCalificacion("Programación Orientada a Objetos");

            LibroCalificacion miLibro2 = 
                new LibroCalificacion("Estructuras de Datos");


            Console.WriteLine("El nombre del curso es: {0}", miLibro.NombreCurso);

            Console.WriteLine("El nombre del curso es: {0}", miLibro2.NombreCurso);

            Console.WriteLine("\nEscriba el nombre del curso:");

            string elNombreCurso = Console.ReadLine();

            miLibro.NombreCurso = elNombreCurso;

            Console.WriteLine("El nombre del curso es: {0}", miLibro.NombreCurso);

        }
    }
}