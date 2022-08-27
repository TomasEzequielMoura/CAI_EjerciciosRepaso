using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio9
    {
        public static string Conocer(string palabra)
        {
            string usuario = "Tomas";
            string mensaje = "";

            if (usuario.ToUpper() == palabra.ToUpper())
            {
                mensaje = "¡Hola " + usuario + "!";
            }
            else {
                mensaje = "No te conozco";
            }

            return mensaje;
        }
    }
}
