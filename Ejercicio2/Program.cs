using System;

class Promedio
{
    static void Main(string[] args)
    {
        Console.WriteLine("Promedio total del alumno\n");

        try
        {
            // Solicitar las calificaciones al usuario
            Console.Write("Ingrese la calificación de las prácticas (0-100): ");
            double practicas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del examen (0-100): ");
            double examen = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación de las tareas (0-100): ");
            double tareas = double.Parse(Console.ReadLine());

            // Verificar que las calificaciones estén en el rango válido
            if (EsCalificacionValida(practicas) && EsCalificacionValida(examen) && EsCalificacionValida(tareas))
            {
                // Calcular la calificación total
                double calificacionTotal = CalcularCalificacionTotal(practicas, examen, tareas);
                Console.WriteLine($"La calificación total del alumno es: {calificacionTotal:F2}");
            }
            else
            {
                Console.WriteLine("Las calificaciones deben estar en el rango de 0 a 100.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese valores numéricos válidos.");
        }

        Console.WriteLine("Programa finalizado.");
    }

    static bool EsCalificacionValida(double calificacion)
    {
        return calificacion >= 0 && calificacion <= 100;
    }

    static double CalcularCalificacionTotal(double practicas, double examen, double tareas)
    {
        // Pesos de cada actividad
        const double pesoPracticas = 0.55;
        const double pesoExamen = 0.30;
        const double pesoTareas = 0.15;

        // Calcular la calificación total ponderada
        return (practicas * pesoPracticas) + (examen * pesoExamen) + (tareas * pesoTareas);
    }
}
