using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio6
    {

        public static void Simplificar(int numeroInicio)
        {
            Console.WriteLine("Ingrese el numero 'b'");
            string numeroSecundario = Console.ReadLine();

            int resultado = Calculo(numeroInicio, Convert.ToInt32(numeroSecundario));

            Console.WriteLine("(a + b) * (a - b) = " + resultado);
        }

        public static int Calculo(int a, int b) {
            Console.WriteLine("(a+b)*(a-b) == a * a + a * (−b) + b * a + b * (−b)");

            int resultado = a * a - a * b + b * a - b * b;

            return resultado;
        }
    }
}
