using System;

namespace ex6_udo9
{
    class Program
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int cilindrada { get; set; }
        public double potencia { get; set; }

        public void Nuevo(string marca, string modelo, int cilindrada, double potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }
        public void Mostrar()
        {
            Console.WriteLine("Marca: {0}. Modelo: {1}. Cilindrada:{2}. Potencia:{3}", this.marca, this.modelo, this.cilindrada, this.potencia);
        }

        public static void Ejercicio6()
        {
            Coche C1 = new Coche();
            C1.Nuevo("Ford", "mustang", 460, 5.0);
            C1.Mostrar();
        }






        static void Main(string[] args)
        {

        }
    }
}
