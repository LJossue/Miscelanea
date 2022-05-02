using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Operadores
    {
        //Calcular el area de un triangulo
        public static void Areadeuntriangulo(double numero1, double numero2)
        {

            Console.WriteLine("\nArea de un Triangulo");
            Console.WriteLine("Escriba la Base del triangulo: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la Altura del triangulo: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: " + ((numero1 * numero2) / 2));

        }

        //Realizar una suma de dos numeros
        public static void Suma(double numero1, double numero2)
        {
            Console.WriteLine("\nSuma");
            Console.WriteLine("Escriba dos numeros enteros: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es: " + (numero1 + numero2));
        }

        //Elevar un numero al cuadrado
        public static void ElevarAlCuadrado(double numero1)
        {
            Console.WriteLine("\nNumero Elevado al Cuadrado");
            Console.WriteLine("Escriba el numero a elevar: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Math.Pow(numero1, 2));
        }

        //Cambio de euros a dolares
        public static void CambioDivisas(double numero1)
        {
            Console.WriteLine("\nCambio de Euros a Dolares");
            Console.WriteLine("Escriba la cantidad de Euros a cambiar: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado de la conversión es: " + (numero1 * 1.06) + "USD");
        }

        //Perimetro y area de un cuadrado
        public static void PerimetroAreaCuadrado(double numero1)
        {
            Console.WriteLine("\nHallar el perimetro y area de un cuadrado");
            Console.WriteLine("Escriba la altura de un lado del cuadrado");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El perimetro es: " + (numero1 * 4));
            Console.WriteLine("Y su area es: " + (numero1 * numero1));
        }

        //Area y volumen de un cilindro
        public static void AreaVolumenCilindro(double numero1, double numero2)
        {
            Console.WriteLine("\nHallar el Area y volumen de un cilindro");
            Console.WriteLine("Escriba la altura del cilindro");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el radio del cilindro");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El volumen del cilindro es: " + (3.141592 * Math.Pow(numero2, 2) * numero1));
            Console.WriteLine("Y su area es: " + ((2 * 3.141592 * numero2 * numero1) + (2 * 3.141592 * Math.Pow(numero2, 2))));
        }
    
        //Hallar longitud y area de una circunferencia
        public static void LongitudAreaCircunferencia(double numero1, double numero2)
        {
            Console.WriteLine("\nHallar longitud y area de una circunferencia");
            Console.WriteLine("Escriba el area de la circunferencia");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La longitud es: " + (2 * 3.141592) * numero1);
            Console.WriteLine("Y su radio es: " + (3.141592 * Math.Pow(numero1, 2)));
        }

        //Calcular el promedio de tres numeros
        public static void Promedio(int n1, int n2, int n3)
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
