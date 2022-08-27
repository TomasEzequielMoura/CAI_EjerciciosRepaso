using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio8
    {
        public static void DiferenciaFechas(DateTime fecha) {

            var diferencia = (fecha - DateTime.Now).TotalDays;

            if (diferencia < 0) {
                diferencia = diferencia * (-1);
            }

            Console.WriteLine("La diferencia de fechas es de " + Math.Truncate(diferencia) + " días.");
        }

    }
}
