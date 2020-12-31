using System;

namespace ex2_udo9
{
    class Empleado
    {
        string nombre;
        float sueldo;

        public Empleado()
        {
            Console.Write("Escribe el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.Write("Indique su sueldo:");
            string linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }

        public void PagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.Write("Debe abonar impuestos");
            }
            else
            {
                Console.Write("No paga impuestos");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Empleado empleado1;
            empleado1 = new Empleado();
            empleado1.PagaImpuestos();
        }
    }
}
