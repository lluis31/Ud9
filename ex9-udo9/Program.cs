using System;

namespace ex9_udo9
{
    class Electrodomestico
    {
        public int preciobase { get; set; }
        public string color { get; set; }
        public char consumo { get; set; }
        public int peso { get; set; }


        public const int constprecio = 100;
        public const string constcolor = "Blanco";
        public const char constconsumo = 'F';
        public const int constpeso = 5;

        public Electrodomestico()
        {
            this.color = constcolor;
            this.consumo = constconsumo;
            this.preciobase = constprecio;
            this.peso = constpeso;
        }
        public Electrodomestico(int pr, int pe)
        {
            this.color = constcolor;
            this.consumo = constconsumo;
            this.preciobase = pr;
            this.peso = pe;
        }
        public Electrodomestico(string color, char consumo, int precio, int peso)
        {
            this.color = ValidarColor(color);
            this.consumo = ValidarConsumo(consumo);
            this.preciobase = precio;
            this.peso = peso;
        }
        public char ValidarConsumo(char c)
        {
            if ((c == 'A') | (c == 'B') | (c == 'C') | (c == 'D') | (c == 'E') | (c == 'F'))
            {
                return c;
            }
            else
            {
                Console.WriteLine("Consumo incorrecto. Valor por defecto 'F'");
                return 'F';
            }
        }
        public string ValidarColor(string c)
        {
            if ((c == "blanco") | (c == "negro") | (c == "azul") | (c == "rojo") | (c == "gris"))
            {
                return c;
            }
            else
            {
                Console.WriteLine("Color incorrecto. Valor por defecto 'blanco'");
                return "blanco";
            }



            static void Main(string[] args)
            {

            }
        }
    }
}
