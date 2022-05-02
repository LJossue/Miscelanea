using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Condicionales
    {
        //Ver que numero es positivo y negativo
        public static void PositivoNegativo(double numero1)
        {
            Console.WriteLine("\n¿Numero Positivo o Negativo?");
            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            if (numero1 > 0)
            {
                Console.WriteLine("El numero: " + numero1 + " es Positivo.");
            }
            else if (numero1 == 0)
            {
                Console.WriteLine("El numero: " + numero1 + " es Neutro.");
            }
            else
                Console.WriteLine("El numero: " + numero1 + " es Negativo.");
        }

        //Ver cual numero es mayor y menor
        public static void MayorMenor(double numero1, double numero2)
        {
            Console.WriteLine("\nNumero Mayor y Menor");
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("El numero " + numero1 + " es el numero mayor, por lo tanto el numero " + numero2 + " es el menor.");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El numero " + numero2 + " es el numero mayor, por lo tanto el numero " + numero1 + " es el menor.");
            }
            else
            {
                Console.WriteLine("Ambos numeros son iguales");
            }
        }

        //Numero mayor y menor de 3 numeros ingresados
        public static void MayorMenor3(double numero1, double numero2, double numero3)
        {
            Console.WriteLine("\nNumero mayor y menor de tres numeros");
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            numero3 = Convert.ToDouble(Console.ReadLine());
            if ((numero1 == numero2) && (numero2 == numero3))
            {
                Console.WriteLine("Todos los numeros son iguales.");
            }
            else if ((numero1 > numero2) && (numero1 > numero3))
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine("El numero " + numero1 + " es el numero mayor.");
                    Console.WriteLine("El numero " + numero3 + " es el numero menor.");
                }

                else if (numero3 > numero2)
                {
                    Console.WriteLine("El numero " + numero1 + " es el numero mayor.");
                    Console.WriteLine("El numero " + numero2 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + numero1 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
            else if ((numero2 > numero1) && (numero2 > numero3))
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("El numero " + numero2 + " es el numero mayor.");
                    Console.WriteLine("El numero " + numero3 + " es el numero menor.");
                }

                else if (numero3 > numero1)
                {
                    Console.WriteLine("El numero " + numero2 + " es el numero mayor.");
                    Console.WriteLine("El numero " + numero1 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + numero2 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
            else if ((numero3 > numero1) && (numero3 > numero2))
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("El numero " + numero3 + " es el numero mayor.");
                    Console.WriteLine("El numero " + numero2 + " es el numero menor.");
                }

                else if (numero2 > numero1)
                {
                    Console.WriteLine("El numero " + numero3 + " es el numero mayor.");
                    Console.WriteLine("El numero " + numero1 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + numero3 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
        }

        //Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.
        public static void SumaResta(double numero1, double numero2)
        {
            Console.WriteLine("\nDados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine("Ingrese el primer numero (A): ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero (B): ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero1 < numero2)
            {
                Console.WriteLine("A es menor que B. El resultado de la suma es: " + (numero1 + numero2));
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("A es mayor que B. El resultado de la resta es: " + (numero1 - numero2));
            }
            else
            {
                Console.WriteLine("Error. Los numeros son iguales.");
            }
        }

        //Dados dos números A y B encontrar el cociente entre A y B.
        public static void Cociente(double numero1, double numero2)
        {
            Console.WriteLine("\nEncontrar el cociente entre A y B");
            Console.WriteLine("Ingrese el numero A: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero B: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("La división no es posible");
            }
            else
            {
                Console.WriteLine("El cociente de la division entre A y B es: " + (numero1 / numero2));
            }
        }

        // Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.
        public static void SumaMultiplicacion(double numero1, double numero2)
        {
            Console.WriteLine("Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine("Ingrese el primer numero (A): ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero (B): ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            if ((numero1 < 0) || (numero2 < 0))
            {
                Console.WriteLine("Se realizara la suma de los numeros.");
                Console.WriteLine("El resultado de la suma de A y B es: " + (numero1 + numero2));
            }
            else
            {
                Console.WriteLine("Se realizara la multiplicación de los numeros.");
                Console.WriteLine("El resultado de la multiplicación de A y B es: " + (numero1 * numero2));
            }
        }

        //Calcular año bisiesto
        public static void AñoBisiesto(int año)
        {
            Console.WriteLine("Calcule el año Bisiesto");
            año = Convert.ToInt32(Console.ReadLine());
            if ((año % 4 == 0) && (año % 100 != 0 || año % 400 == 0))
            {
                Console.WriteLine("El año " + año + " es Bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " + año + " NO es Bisiesto.");
            }
            

        }

        }
}
