using System;
using ex4_udo9;

namespace ex4_udo9
{
    class Persona
    {
        public string Nombre { get; set; }

        public void SetNombre(string NuevoNombre)
        {
            this.Nombre = NuevoNombre;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola soy {0}", this.Nombre);
        }

        public static void Ex4()
        {
            Persona Yo = new Persona();
            Persona Tu = new Persona();
            Yo.SetNombre("Lluis");
            Tu.SetNombre("NoLluis");
            Yo.Saludar();
            Tu.Saludar();
        }

    }
}