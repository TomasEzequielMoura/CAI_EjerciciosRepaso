using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio20
    {
        public static void PrimoFactorial(int numeroInicio) {
            int contadorDePrimos = 0;

            int n = numeroInicio;

            for (int i = n - 1; i > 0; i--)
            {
                n*= i;
                if (IsPrime(i + 1)) { contadorDePrimos++; }
                
            }

            Console.WriteLine("Factorial de {0}! = {1} y tiene {2} numeros primos", numeroInicio, n, contadorDePrimos);
            numeroInicio--;


        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
