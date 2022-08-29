using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio15
    {

        public static void AnalizarContrasenia()
        {
            string usuario;
            string contrasenia;
            int contador = 0;
            bool flag = false;

            Console.WriteLine("Ingrese el usuario:");
            usuario = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese la contraseña: ");
                contrasenia = Console.ReadLine();

                if (usuario == contrasenia)
                {
                    Console.WriteLine("Bienvenido: " + usuario);
                    flag = true;
                }
                else {
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta");
                }
                contador++;
                if (contador == 3) {
                    flag = true;
                }
            } while (flag == false);

            if (contador == 3)
            {
                Console.WriteLine("Clave bloqueada");
            }

        }
        
    }
}
