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
                            Operadores.Areadeuntriangulo(1, 2);
                            Menus.Volver();
                            break;
                        case "2":
                            Operadores.Suma(1, 2);
                            Menus.Volver();
                            break;
                        case "3":
                            Operadores.ElevarAlCuadrado(1);
                            Menus.Volver();
                            break;
                        case "4":
                            Operadores.CambioDivisas(1);
                            Menus.Volver();
                            break;
                        case "5":
                            Operadores.PerimetroAreaCuadrado(1);
                            Menus.Volver();
                            break;
                        case "6":
                            Operadores.AreaVolumenCilindro(1, 2);
                            Menus.Volver();
                            break;
                        case "7":
                            Operadores.LongitudAreaCircunferencia(1, 2);
                            Menus.Volver();
                            break;
                        case "8":
                            Operadores.Promedio(1, 2, 3);
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
                            Condicionales.PositivoNegativo(1);
                            Menus.Volver();
                            break;
                        
                        case "2":
                            Condicionales.MayorMenor(1, 2);
                            Menus.Volver();
                            break;

                        case "3":
                            Condicionales.MayorMenor3(1, 2, 3);
                            Menus.Volver();
                            break;

                        case "4":
                            Condicionales.SumaResta(1, 2);
                            Menus.Volver();
                            break;

                        case "5":
                            Condicionales.Cociente(1, 2);
                            Menus.Volver();
                            break;

                        case "6":
                            Condicionales.SumaMultiplicacion(1, 2);
                            Menus.Volver();
                            break;

                        case "7":
                            Condicionales.AñoBisiesto(1);
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
                    }
                    break;
                default:
                    Console.WriteLine("Error de Digitación");
                    break;
            }
            Console.ReadKey();

        }
    }
}


