using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio18
    {
        public static void BinarioOctaHexa(decimal numeroInicio)
        {

            int original = Convert.ToInt32(numeroInicio);

            string binary = Convert.ToString(original, 2);

            string octal = Convert.ToString(original, 8);


            string hexa = original.ToString("X");


            Console.WriteLine("Decimal ingresado: " + numeroInicio + System.Environment.NewLine +
                "original: " + original + System.Environment.NewLine +
                "binario: " + binary + System.Environment.NewLine +
                "octal: " + octal + System.Environment.NewLine +
                "hexadecimal: " + hexa + System.Environment.NewLine 
                );
        }

        

    }
}
