//using EjerciciosRepaso.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string elegirFuncion;
            bool flag = false;

            try
            {
                do
                {
                    Console.WriteLine(
                        "Ingrese el numero de que funcion usara: " + System.Environment.NewLine +
                        "1. IngresarNumero" + System.Environment.NewLine +
                        "2. IngresarPalabra" + System.Environment.NewLine +
                        "3. IngresarFecha"
                    );

                    elegirFuncion = Console.ReadLine();
                    ValidarNumero(elegirFuncion, "Numero", true);

                } while (flag == false);

                if (Convert.ToInt32(elegirFuncion) == 1)
                {
                    // ejercicio 1 y 2
                    IngresarNumero();
                }
                else if (Convert.ToInt32(elegirFuncion) == 2)
                {
                    // ejercicio 3 y 4
                    IngresarPalabra();
                }
                else
                {
                    IngresarFecha();
                }

                Thread.Sleep(2500);

            }
            catch (Exception ex){
                    Console.WriteLine(ex.Message);
            }

            void IngresarNumero(){
                
                string numeroInicio;
                try
                {
                    do
                    {
                        Console.WriteLine("Ingrese el numero donde iniciara");
                        numeroInicio = Console.ReadLine();
                        ValidarNumero(numeroInicio, "Numero", false);

                    } while (flag == false);

                    // ejercicio 1
                    //EjerciciosRepaso.Ejercicios.Ejercicio1.Contador(Convert.ToInt32(numeroInicio));

                    // ejercicio 2
                    //EjerciciosRepaso.Ejercicios.Ejercicio2.Contador(Convert.ToInt32(numeroInicio));

                    // ejercicio 5
                    //EjerciciosRepaso.Ejercicios.Ejercicio5.Invertir(numeroInicio);

                    // ejercicio 6
                    //EjerciciosRepaso.Ejercicios.Ejercicio6.Simplificar(Convert.ToInt32(numeroInicio));

                    // ejercicio 7
                    //EjerciciosRepaso.Ejercicios.Ejercicio7.MayorMedianoMenor(Convert.ToInt32(numeroInicio));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void IngresarPalabra() {

                //Ejercicios 3 y 4 
                //ElegirPalindromoAngrama();

                //Ejercicios 9
                //HolaUsuario();

                //Ejercicios 10
                EjerciciosRepaso.Ejercicios.Ejercicio10.AnalizarLetra();

                void HolaUsuario() {
                    string palabra;
                    Console.WriteLine("Ingrese la palabra:");
                    palabra = Console.ReadLine();

                    string mensaje = EjerciciosRepaso.Ejercicios.Ejercicio9.Conocer(palabra);

                    Console.WriteLine(mensaje);
                };

                void ElegirPalindromoAngrama()
                {
                    do
                    {
                        Console.WriteLine("Ingrese el numero de que funcion usara: " + System.Environment.NewLine +
                            "1. Palindromo" + System.Environment.NewLine +
                            "2. Angrama"
                            );

                        elegirFuncion = Console.ReadLine();

                        ValidarNumero(elegirFuncion, "Numero", true);

                    } while (flag == false);

                    if (Convert.ToInt32(elegirFuncion) == 1)
                    {
                        // ejercicio 3
                        Palindromo();
                    }
                    else
                    {
                        // ejercicio 4
                        Angrama();
                    }
                }
                

                void Palindromo() {
                    string palabra;
                    Console.WriteLine("Ingrese la palabra:");
                    palabra = Console.ReadLine();

                    bool palabraAnalizada = EjerciciosRepaso.Ejercicios.Ejercicio3.ValidarPalindromo(palabra);

                    if (palabraAnalizada)
                    {
                        Console.WriteLine(palabra + " es un Palíndromo");
                    }
                    else
                    {
                        Console.WriteLine(palabra + " NO es un Palíndromo");
                    }
                }

                void Angrama() {
                    string palabra1;
                    string palabra2;

                    Console.WriteLine("Ingrese la primera palabra:");
                    palabra1 = Console.ReadLine();

                    Console.WriteLine("Ingrese la segunda palabra:");
                    palabra2 = Console.ReadLine();

                    if (EjerciciosRepaso.Ejercicios.Ejercicio4.ValidarAnagrama(palabra1, palabra2))
                    {
                        Console.WriteLine(palabra1 + " y " + palabra2 + " son un anagrama");
                    }
                    else
                    {
                        Console.WriteLine(palabra1 + " y " + palabra2 + " NO son un anagrama");
                    }
                }
            }

            void IngresarFecha() {
                string dia;
                string mes;
                string anio;

                flag = false;

                do
                {
                    Console.WriteLine("Ingrese el dia");
                    dia = Console.ReadLine();
                    ValidarNumero(dia, "dia", false);

                } while (flag == false);

                do
                {
                    flag = false;
                    Console.WriteLine("Ingrese el mes");
                    mes = Console.ReadLine();
                    ValidarNumero(mes, "mes", false);

                } while (flag == false);

                do
                {
                    flag = false;
                    Console.WriteLine("Ingrese el anio");
                    anio = Console.ReadLine();
                    ValidarNumero(anio, "anio", false);

                } while (flag == false);

                string fecha = dia + "/" + mes + "/" + anio;

                DateTime fechaArmada = DateTime.Parse(fecha);

                // ejercicio 8
                EjerciciosRepaso.Ejercicios.Ejercicio8.DiferenciaFechas(fechaArmada);
            }

            bool ValidarNumero(string numero, string campo, bool esElegirFuncion)
            {
                int numeroInt = 0;

                if (!int.TryParse(numero, out numeroInt))
                {
                    Console.WriteLine("Numero invalida, debe ser un numero entero");
                }
                else if (numeroInt < 1)
                {
                    Console.WriteLine("El número debe ser mayor a 1");
                }
                else if (esElegirFuncion && numeroInt != 1 && numeroInt != 2 && numeroInt != 3)
                {
                    Console.WriteLine("El número debe ser 1, 2 o 3");
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Numero valido.");
                }
                return flag;
            }
        }        
    }
}
