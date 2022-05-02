using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Ciclos
    {
        //Imprimir todos los múltiplos de 3 que hay entre 1 y 100.
        public static void Multiplos3()
        {
            Console.WriteLine("Numeros Multiplos de 3 (del 1 al 100): ");

            for (int i = 1; i < 100; i++)//i++ es para aumentar de uno en uno.
            {
                if (i % 3 == 0)//si el residuo es cero ese numero es multiplo de 3
                {
                    Console.WriteLine(i + " Es multiplo de 3 ");
                }
            }
        }

        //Imprimir los numeros impares
        public static void Impares()
        {
            Console.WriteLine("Numeros Impares (1-100): ");
            for (int i = 1; i <= 100; i++)//i++ es para aumentar de uno en uno.
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " Es Impar");
                }
            }
        }

        //Imprimir los numeros pares
        public static void Pares()
        {
            Console.WriteLine("Numeros Pares (1-100): ");
            for (int i = 1; i <= 100; i++)//i++ es para aumentar de uno en uno.
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Es Par");
                }
            }
        }

        //Cuadrado hasta el 30
        public static void Cuadrado()
        {
            Console.WriteLine("Numeros al cuadrado (1-30): ");
            for (int i = 1; i <= 30; i++)//i++ es para aumentar de uno en uno.
            {
                    Console.WriteLine("El cuadrado del numero: " + i + " Es: " + Math.Pow(i,2));
            }
        }

        //Escribir un programa que sume los cuadrados de los cien primeros números naturales, mostrando el resultado en pantalla.
        public static void CuadradoSuma()
        {
            int i, suma;
            suma = 0;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine("Numero " + i);
                suma = suma + i * i;
                Console.WriteLine("El cuadrado es: " + Math.Pow(i,2));
            }
            Console.WriteLine("\nEl valor de suma total de los cuadrados es: " + suma);
        }

        //Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente.
        public static void ncomprendidos(int numero1, int numero2)
        {
            Console.WriteLine("Numeros comprendidos entre A y B");
            Console.WriteLine("Digite el primer numero (A): ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero (B): ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los numeros comprendidos entre " + numero1 + " y " + numero2 + " son: ");
            for (int i = numero1 + 1; i < numero2; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Sumar todos los números que se digitan por teclado mientras no sea cero
        public static void Suma()
        {
            int n1, suma = 0;
            Console.WriteLine("Sumar todos los números que se digitan por teclado (para terminar digite 0)");
            do
            {
                Console.WriteLine("Ingrese un numero a sumar: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                suma = suma + n1;
                Console.WriteLine("Resultado: " + suma);
            } while (n1 != 0);

        }
    }
}
