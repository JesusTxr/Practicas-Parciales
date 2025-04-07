using System;

namespace ejercicio2
{
    class Producto
    {
        public int Costo { get; set; }
        public int Pago { get; set; }

        public Producto(int Costo, int Pago)
        {
            this.Costo = Costo;
            this.Pago = Pago;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Su cambio es de: {CalcularCambio()}");
        }
    
        public int CalcularCambio()
        {
            return Pago - Costo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Costo del producto");
            int Costo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuanto esta pagando?");
            int Pago = Convert.ToInt32(Console.ReadLine());

            Producto miProducto = new Producto(Costo, Pago);

            miProducto.MostrarInfo();
        }
    }
}
