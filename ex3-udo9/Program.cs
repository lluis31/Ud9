using System;

namespace ex3_udo9
{
    class Calculo
    {
        int valor1, valor2;

        public Calculo()
        {
            Console.Write("Escribe el primer valor:");
            string linea = Console.ReadLine();
            valor1 = int.Parse(linea);
            Console.Write("Escribe el segundo valor:");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }

        public void Sumar()
        {
            int suma;
            suma = valor1 + valor2;
            Console.WriteLine("La suma es:" + suma);
        }

        public void Restar()
        {
            int resta;
            resta = valor1 - valor2;
            Console.WriteLine("La resta es:" + resta);
        }

        public void Multiplicar()
        {
            int multiplicacion;
            multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicación es:" + multiplicacion);
        }

        public void Dividir()
        {
            int division;
            division = valor1 / valor2;
            Console.WriteLine("La división es:" + division);
        }

        static void Main(string[] args)
        {
            Calculo opera = new Calculo();
            opera.Sumar();
            opera.Restar();
            opera.Multiplicar();
            opera.Dividir();
            Console.ReadKey();
        }
    }
}
