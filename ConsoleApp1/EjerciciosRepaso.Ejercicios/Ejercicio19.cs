using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio19
    {
        public static void LongitudPalabras()
        {
            int cantidadPalabras = 0;

            Console.WriteLine("Ingrese la cantidad de palabras a ingresar:");
            cantidadPalabras = Convert.ToInt32(Console.ReadLine());

            string[] palabras = new string[cantidadPalabras];    

            for (int i = 0; i < cantidadPalabras; i++)
            {
                Console.WriteLine("Ingrese la " + (i + 1) + "° palabra");
                palabras[i] = Console.ReadLine();
                if ((i+1) == cantidadPalabras) {
                    for (int n = 0; n < cantidadPalabras; n++) {
                        Console.WriteLine("Palabra " + (n + 1) + ": es " + palabras[n] +  " con un largo de " + palabras[n].Length + " caracteres");
                    }
                }
            }

        }
    }
}
