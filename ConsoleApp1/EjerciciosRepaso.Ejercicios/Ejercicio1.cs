using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicios
{
    public class Ejercicio1
    {
        public static void Contador(int numeroInicio)
        {
            int numeroRegistro = 895380;
            //for (int i = numeroInicio; i.ToString().Length <= 3; i++)            
            for (int i = numeroInicio; i <= (numeroRegistro % 1000) ; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i + " - " + "Foo");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine(i + " - " + "Bar");
                }
                else if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i + " - " + "FooBar");
                }
                else { 
                    Console.WriteLine(i);
                }
                Thread.Sleep(50);
            }
        }
    }
}
