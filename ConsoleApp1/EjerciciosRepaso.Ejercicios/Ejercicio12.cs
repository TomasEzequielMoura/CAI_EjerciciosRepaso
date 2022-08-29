using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio12
    {
        public static void DiferenciaEntreDosFechas(string fecha1, string fecha2)
        {

            DateTime fecha1DT = DateTime.Parse(fecha1);
            DateTime fecha2DT = DateTime.Parse(fecha2);

            double totalDays = (fecha1DT - fecha2DT).TotalDays;

            if (totalDays < 0)
            {
                totalDays = totalDays * (-1);
            }

            var totalYears = Math.Truncate(totalDays / 365);
            var totalMonths = Math.Truncate((totalDays % 365) / 30);
            var remainingDays = Math.Truncate((totalDays % 365) % 30);
            Console.WriteLine("La diferencia es de {0} año(s), {1} mese(s) and {2} día(s)", totalYears, totalMonths, remainingDays);

        }
    }
}