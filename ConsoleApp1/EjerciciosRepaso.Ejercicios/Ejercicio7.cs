using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio7
    {
        public static void MayorMedianoMenor(int numeroInicio) {

            string numeroDos;
            string numeroTres;
            string numeroCuatro;
            string numeroCinco;

            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese el numero 2");
                numeroDos = Console.ReadLine();
                ValidarNumero(numeroDos, "Numero 2", false);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el numero 3");
                numeroTres = Console.ReadLine();
                ValidarNumero(numeroTres, "Numero 3", false);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el numero 4");
                numeroCuatro = Console.ReadLine();
                ValidarNumero(numeroCuatro, "Numero 4", false);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el numero 5");
                numeroCinco = Console.ReadLine();
                ValidarNumero(numeroCinco, "Numero 5", false);
            } while (flag == false);

            int[] arrayNumeros = new int[] { numeroInicio, Convert.ToInt32(numeroDos), Convert.ToInt32(numeroTres), Convert.ToInt32(numeroCuatro), Convert.ToInt32(numeroCinco) };

            int[] arrayOrdenado = OrdenarArray(arrayNumeros);

            Console.WriteLine(System.Environment.NewLine+
                "El numero mas chico del array es  " + arrayOrdenado[4] + System.Environment.NewLine +
                "El numero del medio del array es  " + arrayOrdenado[2] + System.Environment.NewLine +
                "El numero mas grande del array es  " + arrayOrdenado[0] + System.Environment.NewLine
                );

            bool ValidarNumero(string numero, string campo, bool esElegirFuncion)
            {
                int numeroInt = 0;

                if (!int.TryParse(numero, out numeroInt))
                {
                    Console.WriteLine("Numero invalida, la nota debe ser un numero entero");
                }
                else if (numeroInt < 1)
                {
                    Console.WriteLine("El número debe ser mayor a 1");
                }
                else if (esElegirFuncion && numeroInt != 1 && numeroInt != 2)
                {
                    Console.WriteLine("El número debe ser 1 o 2");
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Numero valido.");
                }
                return flag;
            }

            int[] OrdenarArray(int[] array)
            {
                Console.WriteLine("Array antes de ordenarlo: ");

                foreach (int value in array)
                {
                    Console.Write(value + " ");
                }

                Console.WriteLine("\n");
                Array.Sort(array);
                Array.Reverse(array);

                Console.WriteLine("Array despues de ser ordenado: ");
                foreach (int value in array)
                {
                    Console.Write(value + " ");
                }

                return array;
            }
        }

        


    }
}
