using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio17
    {
        public static void SueldoYAcomodar()
        {
            string[] sueldo = new string[5];

            string[] usuario = new string[5];

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Ingrese el usuario:");
                usuario[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo:");
                sueldo[i] = Console.ReadLine();
            }

            string[] sueldoMayorAMenor = sueldo.OrderByDescending(c => c).ToArray();

            int n = 0;
            do
            {
                if (sueldoMayorAMenor[0] == sueldo[n])
                {
                    Console.WriteLine("El mayor sueldo es de " + sueldoMayorAMenor[0] + " y pertenece a " + usuario[n]);
                }

                n++;

            } while (n != 5);
        }
    }
}
