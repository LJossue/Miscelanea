using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Programa

    {
         public static void Main()
        {
                try
                {
                    Menus.MenuPrincipal();
                    String menu = null;
                    menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "1":
                            Menus.MenuOperadores();

                            String s1 = null;
                            s1 = Console.ReadLine();

                            switch (s1)
                            {
                                case "1":
                                    Operadores.Areadeuntriangulo();
                                    Menus.Volver();
                                    break;
                                case "2":
                                    Operadores.Suma();
                                    Menus.Volver();
                                    break;
                                case "3":
                                    Operadores.ElevarAlCuadrado();
                                    Menus.Volver();
                                    break;
                                case "4":
                                    Operadores.CambioDivisas();
                                    Menus.Volver();
                                    break;
                                case "5":
                                    Operadores.PerimetroAreaCuadrado();
                                    Menus.Volver();
                                    break;
                                case "6":
                                    Operadores.AreaVolumenCilindro();
                                    Menus.Volver();
                                    break;
                                case "7":
                                    Operadores.LongitudAreaCircunferencia();
                                    Menus.Volver();
                                    break;
                                case "8":
                                    Operadores.Promedio();
                                    Menus.Volver();
                                    break;
                                case "9":
                                    Console.Clear();
                                    Console.WriteLine("Salió del programa.");
                                    return;
                                default:
                                    Console.WriteLine("Error de Digitación");
                                    Menus.Volver();
                                    break;

                            }
                            break;

                        case "2":
                            Menus.MenuCondicionales();
                            String s2 = null;
                            s2 = Console.ReadLine();

                            switch (s2)
                            {
                                case "1":
                                    Condicionales.PositivoNegativo();
                                    Menus.Volver();
                                    break;

                                case "2":
                                    Condicionales.MayorMenor();
                                    Menus.Volver();
                                    break;

                                case "3":
                                    Condicionales.MayorMenor3();
                                    Menus.Volver();
                                    break;

                                case "4":
                                    Condicionales.SumaResta();
                                    Menus.Volver();
                                    break;

                                case "5":
                                    Condicionales.Cociente();
                                    Menus.Volver();
                                    break;

                                case "6":
                                    Condicionales.SumaMultiplicacion();
                                    Menus.Volver();
                                    break;

                                case "7":
                                    Condicionales.AñoBisiesto();
                                    Menus.Volver();
                                    break;
                                case "8":
                                    Console.Clear();
                                    Console.WriteLine("Salió del programa.");
                                    return;
                                default:
                                    Console.WriteLine("Error de Digitación");
                                    Menus.Volver();
                                    break;
                            }

                            break;

                        case "3":
                            Menus.MenuCiclos();
                            String s3 = null;
                            s3 = Console.ReadLine();
                            switch (s3)
                            {
                                case "1":
                                    Ciclos.Multiplos3();
                                    Menus.Volver();
                                    break;
                                case "2":
                                    Ciclos.Impares();
                                    Menus.Volver();
                                    break;
                                case "3":
                                    Ciclos.Pares();
                                    Menus.Volver();
                                    break;
                                case "4":
                                    Ciclos.Cuadrado();
                                    Menus.Volver();
                                    break;
                                case "5":
                                    Ciclos.CuadradoSuma();
                                    Menus.Volver();
                                    break;
                                case "6":
                                    Ciclos.ncomprendidos(1, 2);
                                    Menus.Volver();
                                    break;
                                case "7":
                                    Ciclos.Suma();
                                    Menus.Volver();
                                    break;
                                case "8":
                                    Console.Clear();
                                    Console.WriteLine("Salió del programa.");
                                    return;
                                default:
                                    Console.WriteLine("Error de Digitación");
                                    Menus.Volver();
                                    break;

                            }
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Salió del programa.");
                            return;

                            //default:
                            //    Console.WriteLine("Error de Digitación");
                            //    break;
                    }
                }
                catch (Exception)
                {
                Console.WriteLine("hola");
                }
        }
    }
}


