using System;

namespace CalculoMatricula
{
    public class Estudiante
    {
        // Propiedades
        public int Estrato { get; set; }
        public int Creditos { get; set; }
        public double ValorCredito { get; set; }

        // Constructor
        public Estudiante(int estrato, int creditos, double valorCredito)
        {
            Estrato = estrato;
            Creditos = creditos;
            ValorCredito = valorCredito;
        }

        // Método para calcular el subsidio de alimentación y transporte
        public double CalcularSubsidio()
        {
            return Estrato == 1 ? 200000 : Estrato == 2 ? 100000 : 0;
        }
    }
}
