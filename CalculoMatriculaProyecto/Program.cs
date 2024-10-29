using System;

namespace CalculoMatricula
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                // Solicitar datos al usuario
                Console.Write("Ingrese el estrato del estudiante (1-6): ");
                int estrato = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de créditos que tomará el estudiante: ");
                int creditos = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor por crédito: ");
                double valorCredito = double.Parse(Console.ReadLine());

                // Crear objeto estudiante
                Estudiante estudiante = new Estudiante(estrato, creditos, valorCredito);

                // Calcular costo de matrícula y subsidio
                double costoMatricula = MatriculaCalculator.CalcularCostoMatricula(estudiante);
                double subsidio = estudiante.CalcularSubsidio();

                // Mostrar resultados
                Console.WriteLine($"\nEl costo de la matrícula es: ${costoMatricula:F2}");
                if (subsidio > 0)
                {
                    Console.WriteLine($"El subsidio de alimentación y transporte es: ${subsidio:F2}");
                }
                else
                {
                    Console.WriteLine("No aplica subsidio de alimentación y transporte.");
                }

                // Preguntar si desea calcular nuevamente
                Console.Write("\n¿Desea calcular la matrícula de otro estudiante? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                continuar = respuesta == "s";
            }

            Console.WriteLine("Programa finalizado. ¡Hasta luego!");
        }
    }
}
