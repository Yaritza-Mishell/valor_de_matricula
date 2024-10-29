using System;

namespace CalculoMatricula
{
    public class MatriculaCalculator
    {
        public static double CalcularCostoMatricula(Estudiante estudiante)
        {
            double costoBase = 0;

            // Calcular costo base de los créditos
            if (estudiante.Creditos <= 20)
            {
                costoBase = estudiante.Creditos * estudiante.ValorCredito;
            }
            else
            {
                int creditosExtras = estudiante.Creditos - 20;
                costoBase = (20 * estudiante.ValorCredito) + (creditosExtras * estudiante.ValorCredito * 2);
            }

            // Aplicar descuento según el estrato
            double descuento = estudiante.Estrato switch
            {
                1 => 0.8,
                2 => 0.5,
                3 => 0.3,
                _ => 0
            };

            return costoBase * (1 - descuento);
        }
    }
}
