using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    public class Operadores
    {

        static double n1, n2, n3;
        //Calcular el area de un triangulo
        public static void Areadeuntriangulo()
        {
            Console.WriteLine("\nArea de un Triangulo");
            Console.WriteLine("Escriba la Base del triangulo: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la Altura del triangulo: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: " + ((n1 * n2) / 2));
        }

        //Realizar una suma de dos numeros
        public static void Suma()
        {
            Console.WriteLine("\nSuma");
            Console.WriteLine("Escriba el primer numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es: " + (n1 + n2));
        }

        //Elevar un numero al cuadrado
        public static void ElevarAlCuadrado()
        {
            Console.WriteLine("\nNumero Elevado al Cuadrado");
            Console.WriteLine("Escriba el numero a elevar: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Math.Pow(n1, 2));
        }

        //Cambio de euros a dolares
        public static void CambioDivisas()
        {
            Console.WriteLine("\nCambio de Euros a Dolares");
            Console.WriteLine("Escriba la cantidad de Euros a cambiar: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado de la conversión es: " + (n1 * 1.06) + "USD");
        }

        //Perimetro y area de un cuadrado
        public static void PerimetroAreaCuadrado()
        {
            Console.WriteLine("\nHallar el perimetro y area de un cuadrado");
            Console.WriteLine("Escriba la altura de un lado del cuadrado");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El perimetro es: " + (n1 * 4));
            Console.WriteLine("Y su area es: " + (n1 * n1));
        }

        //Area y volumen de un cilindro
        public static void AreaVolumenCilindro()
        {
            Console.WriteLine("\nHallar el Area y volumen de un cilindro");
            Console.WriteLine("Escriba la altura del cilindro");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el radio del cilindro");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El volumen del cilindro es: " + (3.141592 * Math.Pow(n2, 2) * n1));
            Console.WriteLine("Y su area es: " + ((2 * 3.141592 * n2 * n1) + (2 * 3.141592 * Math.Pow(n2, 2))));
        }
    
        //Hallar longitud y area de una circunferencia
        public static void LongitudAreaCircunferencia()
        {
            Console.WriteLine("\nHallar longitud y area de una circunferencia");
            Console.WriteLine("Escriba el area de la circunferencia");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La longitud es: " + (2 * 3.141592) * n1);
            Console.WriteLine("Y su radio es: " + (3.141592 * Math.Pow(n1, 2)));
        }

        //Calcular el promedio de tres numeros
        public static void Promedio()
        {
            Console.WriteLine("\nPromedio de 3 números ingresados por teclado.");
            Console.WriteLine("Ingresar el primer valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el tercer valor: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("El promedio de los 3 numeros es: " + (n1 + n2 + n3) / 3);
        }
    }
}
