using System;

class AreaTriangulo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Area del triangulo\n");

        while (true)
        {
            try
            {
                Console.Write("Ingrese lado a: ");
                double ladoA = double.Parse(Console.ReadLine());

                Console.Write("Ingrese lado b: ");
                double ladoB = double.Parse(Console.ReadLine());

                Console.Write("Ingrese lado c: ");
                double ladoC = double.Parse(Console.ReadLine());

                if (EsTrianguloValido(ladoA, ladoB, ladoC))
                {
                    double area = CalcularAreaTriangulo(ladoA, ladoB, ladoC);
                    Console.WriteLine($"El área del triángulo es: {area:F2}\n");
                }
                else
                {
                    Console.WriteLine("Los lados ingresados no forman un triángulo válido.\n");
                }

                Console.Write("¿Desea calcular el área de otro triángulo? (si/no): ");
                string continuar = Console.ReadLine().ToLower();
                if (continuar != "si")
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese números válidos.\n");
            }
        }

        Console.WriteLine("Programa finalizado.");
    }

    static bool EsTrianguloValido(double ladoA, double ladoB, double ladoC)
    {
        //verifica si los números ingresados forman un triangulo
        return ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA;
    }

    static double CalcularAreaTriangulo(double ladoA, double ladoB, double ladoC)
    {
        double per = (ladoA + ladoB + ladoC) / 2; // Semiperímetro
        return Math.Sqrt(per * (per - ladoA) * (per - ladoB) * (per - ladoC));
    }
}
