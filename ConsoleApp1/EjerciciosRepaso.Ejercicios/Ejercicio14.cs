using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio14
    {
        public static void TablaMultiplicar(int numeroInicio)
        {

            for (int i = 0; i < 11; i++)
            {
                int multiplicado = numeroInicio * i ;

                Console.WriteLine(numeroInicio + " * " + i + " = " + multiplicado);

                //i++;
            }
            
        }
    }
}
