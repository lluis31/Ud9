using System;

namespace ex8_udo9
{
    class Persona2
    {
        public string nombre;
        public int edad;
        public string DNI;
        public string sexo;
        public int peso;
        public int altura;
        public const string s = "H";

        public Persona2()
        {
            this.nombre = "";
            this.edad = 0;
            this.DNI = "12345678A";
            this.sexo = s;
            this.peso = 0;
            this.altura = 0;
        }
        public Persona2(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = "12345678A";
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }
        public Persona2(string nombre, int edad, string DNI, string sexo, int peso, int altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }






        static void Main(string[] args)
        {

        }
    }
}
