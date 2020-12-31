using System;

namespace ex1_udo9
{
    class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno()
        {
            Console.Write("Escribe tu nombre:");
            nombre = Console.ReadLine();
            Console.Write("Escribe tu edad:");
            string linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write(nombre + " es mayor de edad.");
            }
            else
            {
                Console.Write(nombre + " no es mayor de edad.");
            }
        }

        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Imprimir();
            alumno1.EsMayorEdad();
            Console.ReadKey();
        }
    }
}
