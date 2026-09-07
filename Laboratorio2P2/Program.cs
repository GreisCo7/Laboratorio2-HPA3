using System;

namespace Laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificacion miLibro = new LibroCalificacion();

            Console.WriteLine("Por favor ingrese el nombre del curso:");

            string nombreDelCurso = Console.ReadLine();

            Console.WriteLine();

            miLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}