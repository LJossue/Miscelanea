using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Condicionales
    {
        static double n1, n2, n3;
        //Ver que numero es positivo y negativo
        public static void PositivoNegativo()
        {
            Console.WriteLine("\n¿Numero Positivo o Negativo?");
            Console.WriteLine("Ingrese un numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("El numero: " + n1 + " es Positivo.");
            }
            else if (n1 == 0)
            {
                Console.WriteLine("El numero: " + n1 + " es Neutro.");
            }
            else
                Console.WriteLine("El numero: " + n1 + " es Negativo.");
        }

        //Ver cual numero es mayor y menor
        public static void MayorMenor()
        {
            Console.WriteLine("\nNumero Mayor y Menor");
            Console.WriteLine("Ingrese el primer numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("El numero " + n1 + " es el numero mayor, por lo tanto el numero " + n2 + " es el menor.");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("El numero " + n2 + " es el numero mayor, por lo tanto el numero " + n1 + " es el menor.");
            }
            else
            {
                Console.WriteLine("Ambos numeros son iguales");
            }
        }

        //Numero mayor y menor de 3 numeros ingresados
        public static void MayorMenor3()
        {
            Console.WriteLine("\nNumero mayor y menor de tres numeros");
            Console.WriteLine("Ingrese el primer numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            if ((n1 == n2) && (n2 == n3))
            {
                Console.WriteLine("Todos los numeros son iguales.");
            }
            else if ((n1 > n2) && (n1 > n3))
            {
                if (n2 > n3)
                {
                    Console.WriteLine("El numero " + n1 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n3 + " es el numero menor.");
                }

                else if (n3 > n2)
                {
                    Console.WriteLine("El numero " + n1 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n2 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n1 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
            else if ((n2 > n1) && (n2 > n3))
            {
                if (n1 > n3)
                {
                    Console.WriteLine("El numero " + n2 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n3 + " es el numero menor.");
                }

                else if (n3 > n1)
                {
                    Console.WriteLine("El numero " + n2 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n1 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n2 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
            else if ((n3 > n1) && (n3 > n2))
            {
                if (n1 > n2)
                {
                    Console.WriteLine("El numero " + n3 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n2 + " es el numero menor.");
                }

                else if (n2 > n1)
                {
                    Console.WriteLine("El numero " + n3 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n1 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n3 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
        }

        //Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.
        public static void SumaResta()
        {
            Console.WriteLine("\nDados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine("Ingrese el primer numero (A): ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero (B): ");
            n2 = Convert.ToDouble(Console.ReadLine());
            if (n1 < n2)
            {
                Console.WriteLine("A es menor que B. El resultado de la suma es: " + (n1 + n2));
            }
            else if (n1 > n2)
            {
                Console.WriteLine("A es mayor que B. El resultado de la resta es: " + (n1 - n2));
            }
            else
            {
                Console.WriteLine("Error. Los numeros son iguales.");
            }
        }

        //Dados dos números A y B encontrar el cociente entre A y B.
        public static void Cociente()
        {
            Console.WriteLine("\nEncontrar el cociente entre A y B");
            Console.WriteLine("Ingrese el numero A: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero B: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            if (n2 == 0)
            {
                Console.WriteLine("La división no es posible");
            }
            else
            {
                Console.WriteLine("El cociente de la division entre A y B es: " + (n1 / n2));
            }
        }

        // Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.
        public static void SumaMultiplicacion()
        {
            Console.WriteLine("Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine("Ingrese el primer numero (A): ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero (B): ");
            n2 = Convert.ToDouble(Console.ReadLine());
            if ((n1 < 0) || (n2 < 0))
            {
                Console.WriteLine("Se realizara la suma de los numeros.");
                Console.WriteLine("El resultado de la suma de A y B es: " + (n1 + n2));
            }
            else
            {
                Console.WriteLine("Se realizara la multiplicación de los numeros.");
                Console.WriteLine("El resultado de la multiplicación de A y B es: " + (n1 * n2));
            }
        }

        //Calcular año bisiesto
        public static void AñoBisiesto()
        { 
        {
            static bool A()
                { 
            if (n2 % 4 == 0 && (n2 % 100 != 0 || n2 % 400 == 0))
                return true;
            return false;
        }
        Console.WriteLine("\nDeterminar si un año es bisiesto o no");                                      
        Console.WriteLine("Digite el año ");
        n2 = Convert.ToDouble(Console.ReadLine());
        if (A() == true)
        {
          Console.WriteLine("El año " + n2 + " es bisiesto");
        }
         else
             {
                Console.WriteLine("El año " + n2 + " no es bisiesto");
            }
          }
        }

        }
}
