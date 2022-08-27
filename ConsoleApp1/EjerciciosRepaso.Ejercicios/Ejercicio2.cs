using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio2
    {
        public static void Contador(int numeroInicio)
        {

            int numeroRegistro = 895380;
            //for (int i = numeroInicio; i.ToString().Length <= 3; i++)            
            for (int i = numeroInicio; i <= (numeroRegistro % 1000); i++)
            {
                if (i % 3 == 0 && !IsPrime(i))
                {
                    Console.WriteLine(i + " - " + "Es divisible por 3");
                }
                else if (i % 3 != 0 && IsPrime(i))
                {
                    Console.WriteLine(i + " - " + "Es primo");
                }
                else if (i % 3 == 0 && IsPrime(i))
                {
                    Console.WriteLine(i + " - " + "Es primo y divisible por 3");
                }
                else
                {
                }
                Thread.Sleep(500);
            }


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
