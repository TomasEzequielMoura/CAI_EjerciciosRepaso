using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio10
    {

        public static void AnalizarLetra() {
            string palabra;
            int palabraNumero = 0;
            Console.WriteLine("Ingrese la palabra:");
            palabra = Console.ReadLine();

            if (int.TryParse(palabra, out palabraNumero)) {
                Console.WriteLine(palabra + " es un numero");
            }
            else {
                if (palabra.ToUpper() == "A" || palabra.ToUpper() == "E" || palabra.ToUpper() == "I" || palabra.ToUpper() == "O" || palabra.ToUpper() == "U")
                {
                    Console.WriteLine(palabra + " es una vocal");
                }
                else
                {
                    Console.WriteLine(palabra + " es una consonante.");
                }
            };

        }

    }
}
