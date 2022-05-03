using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Ciclos
    {
        static double n1, n2, n3;
        static double n4 = 0;
        //Imprimir todos los múltiplos de 3 que hay entre 1 y 100.
        public static void Multiplos3()
        {
            Console.WriteLine("Numeros Multiplos de 3 (del 1 al 100): ");

            for (n1 = 1; n1 < 100; n1++)//i++ es para aumentar de uno en uno.
            {
                if (n1 % 3 == 0)//si el residuo es cero ese numero es multiplo de 3
                {
                    Console.WriteLine(n1 + " Es multiplo de 3 ");
                }
            }
        }

        //Imprimir los numeros impares
        public static void Impares()
        {
            Console.WriteLine("Numeros Impares (1-100): ");
            for (n1 = 1; n1 <= 100; n1++)//i++ es para aumentar de uno en uno.
            {
                if (n1 % 2 != 0)
                {
                    Console.WriteLine(n1 + " Es Impar");
                }
            }
        }

        //Imprimir los numeros pares
        public static void Pares()
        {
            Console.WriteLine("Numeros Pares (1-100): ");
            for (n1 = 1; n1 <= 100; n1++)//i++ es para aumentar de uno en uno.
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine(n1 + " Es Par");
                }
            }
        }

        //Cuadrado hasta el 30
        public static void Cuadrado()
        {
            Console.WriteLine("Numeros al cuadrado (1-30): ");
            for (n1 = 1; n1 <= 30; n1++)//i++ es para aumentar de uno en uno.
            {
                    Console.WriteLine("El cuadrado del numero: " + n1 + " Es: " + Math.Pow(n1,2));
            }
        }

        //Escribir un programa que sume los cuadrados de los cien primeros números naturales, mostrando el resultado en pantalla.
        public static void CuadradoSuma()
        {
            for (n1 = 1; n1 <= 100; n1++)
            {
                Console.WriteLine("Numero " + n1);
                n4 = n4 + n1 * n1;
                Console.WriteLine("El cuadrado es: " + Math.Pow(n1,2));
            }
            Console.WriteLine("\nEl valor de suma total de los cuadrados es: " + n4);
        }

        //Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente.
        public static void ncomprendidos(int numero1, int numero2)
        {
            Console.WriteLine("Numeros comprendidos entre A y B");
            Console.WriteLine("Digite el primer numero (A): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero (B): ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los numeros comprendidos entre " + n1 + " y " + n2 + " son: ");
            for (n3 = n1 + 1; n3 < n2; n3++)
            {
                Console.WriteLine(n3);
            }
        }

        //Sumar todos los números que se digitan por teclado mientras no sea cero
        public static void Suma()
        {
            Console.WriteLine("Sumar todos los números que se digitan por teclado (para terminar digite 0)");
            do
            {
                Console.WriteLine("Ingrese un numero a sumar: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                n4 = n4 + n1;
                Console.WriteLine("Resultado: " + n4);
            } while (n1 != 0);

        }
    }
}
