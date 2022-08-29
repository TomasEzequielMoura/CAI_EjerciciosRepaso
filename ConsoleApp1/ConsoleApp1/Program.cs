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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            void IngresarNumero()
            {
                string numeroInicio;
                try
                {
                    do
                    {
                        flag = false;
                        Console.WriteLine("Ingrese el numero donde iniciara");
                        numeroInicio = Console.ReadLine();
                        //flag = ValidarNumero(numeroInicio, "Numero", false);
                        flag = ValidarDecimal(numeroInicio); 

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

                    //ejercicio 13
                    //EjerciciosRepaso.Ejercicios.Ejercicio13.Factorial(Convert.ToInt32(numeroInicio));

                    //ejercicio 14
                    //EjerciciosRepaso.Ejercicios.Ejercicio14.TablaMultiplicar(Convert.ToInt32(numeroInicio));

                    //ejercicio 16
                    //EjerciciosRepaso.Ejercicios.Ejercicio16.ContarDigitos(Convert.ToInt32(numeroInicio));

                    //ejercicio 18
                    //EjerciciosRepaso.Ejercicios.Ejercicio18.BinarioOctaHexa(Convert.ToDecimal(numeroInicio));

                    //ejercicio 20
                    EjerciciosRepaso.Ejercicios.Ejercicio20.PrimoFactorial(Convert.ToInt32(numeroInicio));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void IngresarPalabra()
            {
                //Ejercicios 3 y 4 
                //ElegirPalindromoAngrama();

                //Ejercicios 9
                //HolaUsuario();

                //Ejercicios 10
                //EjerciciosRepaso.Ejercicios.Ejercicio10.AnalizarLetra();

                //Ejercicios 11 - TODO
                //EjerciciosRepaso.Ejercicios.Ejercicio11.AnalizarPalabra();

                //Ejercicios 15
                //EjerciciosRepaso.Ejercicios.Ejercicio15.AnalizarContrasenia();

                //ejercicio 17
                //EjerciciosRepaso.Ejercicios.Ejercicio17.SueldoYAcomodar();

                //ejercicio 19
                EjerciciosRepaso.Ejercicios.Ejercicio19.LongitudPalabras();

                void HolaUsuario()
                {
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

                void Palindromo()
                {
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

                void Angrama()
                {
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

            bool ValidarDecimal(string numero)
            {
                decimal numeroDecimal = 0;

                if (!decimal.TryParse(numero, out numeroDecimal))
                {
                    Console.WriteLine("Numero invalida, debe ser un numero entero");
                }
                else if (numeroDecimal < 1)
                {
                    Console.WriteLine("El número debe ser mayor a 1");
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Numero valido.");
                }
                return flag;
            }

            void IngresarFecha()
            {

                // ejercicio 8
                //string fecha;
                //fecha = IngresarFechaSeparado();
                //EjerciciosRepaso.Ejercicios.Ejercicio8.DiferenciaFechas(fecha);

                //Ejercicios 12
                //string fecha1;
                //string fecha2;
                //(fecha1, fecha2) = IngresarDosFechas();
                //EjerciciosRepaso.Ejercicios.Ejercicio12.DiferenciaEntreDosFechas(fecha1, fecha2);
            }

            DateTime IngresarFechaSeparado()
            {
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

                return fechaArmada;
            }

            (string, string) IngresarDosFechas()
            {
                string fecha1;
                string fecha2;

                do
                {
                    Console.WriteLine("Ingrese la primera fecha");
                    fecha1 = Console.ReadLine();
                    ValidarFecha(fecha1);

                } while (flag == false);

                do
                {
                    Console.WriteLine("Ingrese la segunda fecha");
                    fecha2 = Console.ReadLine();
                    ValidarFecha(fecha2);

                } while (flag == false);

                return (fecha1, fecha2);
            }

            bool ValidarFecha(string fecha)
            {
                DateTime fechaCorreccta;    
                flag = false;

                if (!DateTime.TryParse(fecha, out fechaCorreccta))
                {
                    Console.WriteLine("Fecha invalida, debe ser un fecha real");
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
