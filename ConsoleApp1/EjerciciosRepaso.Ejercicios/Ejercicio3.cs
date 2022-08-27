using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio3
    {
        public static bool ValidarPalindromo(string palabra) {
            return palabra.SequenceEqual(palabra.Reverse());
        }
    }
}
