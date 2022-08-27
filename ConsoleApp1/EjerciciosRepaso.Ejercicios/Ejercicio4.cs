using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio4
    {
        public static bool ValidarAnagrama(string palabra1, string palabra2)
        {
            // Converting string to character array
            char[] charArray = palabra1.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

            // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.

            return (reversedString == palabra2 ? true : false);
        }
    }
}
