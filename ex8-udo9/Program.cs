using System;

namespace ex8_udo9
{
    class Password
    {
        public int Longitud { get; set; }
        public int Contraseña { get; set; }
        public void Crear()
        {
            this.Longitud = 8;
            Random r = new Random();
            this.Contraseña = r.Next(10000000, 99999999);
        }



        static void Main(string[] args)
        {
       
        }
    }
}
