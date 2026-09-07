using System;

namespace Laboratorio2P3
{
    public class LibroCalificacion
    {
        private string nombreCurso;


        public LibroCalificacion(string nombre)
        {
            nombreCurso = nombre;
        }

        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }

        public void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al libro de calificaciones para: \n{0}!", NombreCurso);
        }
    }
}