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
    }
}
