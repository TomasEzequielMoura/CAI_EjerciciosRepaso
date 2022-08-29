using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio13
    {
        public static void Factorial(int numeroInicio)
        {

                int n = numeroInicio;
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Factorial de {0}! = {1}\n", numeroInicio, n);
                numeroInicio--;
        }
    }
}
