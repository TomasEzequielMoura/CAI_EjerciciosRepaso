using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio5
    {
        public static void Invertir(string numero)
        {

            if (numero.Length != 5) { 
                do
                {
                    Console.WriteLine("ERROR. Ingrese un numero con 5 caracteres");
                    numero = Console.ReadLine();

                } while (numero.ToString().Length != 5);
            }

            var numeroInvertido = InvertirNumero(numero);
            Console.WriteLine("El número invertido es: " + numeroInvertido);
        }
        public static string InvertirNumero(string numero)
        {
            // Converting string to character array
            char[] charArray = numero.ToCharArray();

            // Declaring an empty string
            string numeroInvertido = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                // Append each character to the reversedstring.
                numeroInvertido += charArray[i];
            }

            return numeroInvertido;
        }

    }
}
