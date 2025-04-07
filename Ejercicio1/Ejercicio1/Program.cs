using System;

namespace ejercicio1
{
   class Persona
   {
        public string Nombre { get; set;}
        public string Apellido { get; set; }

        public Persona(string Nombre, string Apellido)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Su nombre es {Nombre} {Apellido}");
            Console.WriteLine($"Su apellido es {Apellido} {Nombre}");
        }
   }

   class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es su nombre?");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Cual es su apellido?");
            string Apellido = Console.ReadLine();

            Persona miPersona = new Persona(Nombre, Apellido);

            miPersona.MostrarInfo();
        }
   }
}
