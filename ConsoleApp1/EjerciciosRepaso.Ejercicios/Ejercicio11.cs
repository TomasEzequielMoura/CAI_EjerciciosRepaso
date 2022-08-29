using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio11
    {
        public static void AnalizarPalabra()
        {
            string palabra;
            string apellido;
            string nombre;
            int edad = 0;

            string[] arrayDatos;

            Console.WriteLine("Ingrese la palabra:");
            palabra = Console.ReadLine();

            arrayDatos = palabra.Split(' ');

            Console.WriteLine(arrayDatos[0] + arrayDatos[1] + arrayDatos[2]);

        }
    }
}
