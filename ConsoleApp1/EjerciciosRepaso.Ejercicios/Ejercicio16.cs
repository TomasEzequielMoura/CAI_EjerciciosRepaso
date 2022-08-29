using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio16
    {
        public static void ContarDigitos(int numeroInicio)
        {

            string numeroInicioStr = numeroInicio.ToString();

            Console.WriteLine("Número ingresado: " + numeroInicio + " – Tiene " + numeroInicioStr.Length + " dígitos");
            
        }
    }
}
