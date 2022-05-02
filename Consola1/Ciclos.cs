using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Ciclos
    {
        public static void Multiplos3()
        {
            Console.WriteLine("Numeros Multiplos de 3 (del 1 al 100): ");

            for (int i = 1; i < 100; i++)//i++ es para aumentar de uno en uno.
            {
                if (i % 3 == 0)//si el reciduo es cero ese numero es multiplo de 3
                {
                    Console.WriteLine(i + " Es multiplo de 3 ");
                }
            }
        }
    }
}
