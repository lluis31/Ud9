using System;

namespace ex5_udo9
{
    class Libro
    {
        public string autor { get; set; }
        public string titulo { get; set; }
        public string ubicacion { get; set; }

        public void Nuevo(string a, string t, string u)
        {
            this.autor = a;
            this.titulo = t;
            this.ubicacion = u;
        }
        public void Mostrar()
        {
            Console.WriteLine("Titulo: {0}. Autor: {1}. Ubicación:{2}.", this.titulo, this.autor, this.ubicacion);
        }
        public static void Ex5_udo9()
        {
            Libro L1 = new Libro();
            L1.Nuevo("Lluis Planas", "La vida con CSharp", "Valls");
            L1.Mostrar();
        }
    }
}
