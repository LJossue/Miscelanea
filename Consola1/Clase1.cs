using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Clase1

    {
         static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Menú, Escoja una opción: \n" +
                "\n1.- Operadores" +
                "\n2.- Condicionales" +
                "\n3.- Ciclos" +
                "\n4.- Arreglos" +
                "\n5.- Salir"
                );
            String menu = null;
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("¿Qué operación desea realizar? Escoja una opción: \n " +
                     "\n1.- Area del triangulo" +
                    "\n2.- Suma" +
                    "\n3.- Elevación al Cuadrado" +
                    "\n4.- Cambio de divisas (Euro a Dolar)" +
                    "\n5.- Perimetro y area de un cuadrado" +
                    "\n6.- Area y Volumen de un Cilindro" +
                    "\n7.- Radio, longitud y area de una circunferencia" +
                    "\n8.- Calcular el promedio de 3 numeros" +
                    "\n9.- Salir");

                    String s1 = null;
                    s1 = Console.ReadLine();

                    switch (s1)
                    {
                        case "1":
                            Console.WriteLine("Area de un Triangulo");
                            Console.WriteLine("Escriba la Base del triangulo: ");
                            double numero1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Escriba la Altura del triangulo: ");
                            double numero2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El area del triangulo es: " + ((numero1 * numero2) / 2));
                            break;
                        case "2":
                            Console.WriteLine("Suma");
                            Console.WriteLine("Escriba dos numeros enteros: ");
                            int numero3 = Convert.ToInt32(Console.ReadLine());
                            int numero4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El resultado de la suma es: " + (numero3 + numero4));
                            break;
                        case "3":
                            Console.WriteLine("Numero Elevado al Cuadrado");
                            Console.WriteLine("Escriba el numero a elevar: ");
                            double numero5 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El resultado es: " + Math.Pow (numero5,2));
                            break;
                        case "4":
                            Console.WriteLine("Cambio de Euros a Dolares");
                            Console.WriteLine("Escriba la cantidad de Euros a cambiar: ");
                            double numero6 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El resultado de la conversión es: " + (numero6 * 1.06) + "USD");
                            break;
                        case "5":
                            Console.WriteLine("Hallar el perimetro y area de un cuadrado");
                         Console.WriteLine("Escriba la altura de un lado del cuadrado");
                            double numero7 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El perimetro es: " + (numero7 * 4));
                            Console.WriteLine("Y su area es: " + (numero7 * numero7));
                            break;
                        case "6":
                            Console.WriteLine("Hallar el Area y volumen de un cilindro");
                            Console.WriteLine("Escriba la altura del cilindro");
                            double numero8 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Escriba el radio del cilindro");
                            double numero9 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El volumen del cilindro es: " + (3.141592 * Math.Pow(numero9, 2) * numero8));
                            Console.WriteLine("Y su area es; " + ((2 * 3.141592 * numero9 * numero8) + (2* 3.141592 * Math.Pow(numero9,2))));
                            break;
                        case "7":
                            Console.WriteLine("Hallar longitud y area de una circunferencia");
                            Console.WriteLine("Escriba el area de la circunferencia");
                            double numero10 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("La longitud es: " + (2 * 3.141592) * numero10);
                            Console.WriteLine("Y su radio es: " + (3.141592 * Math.Pow(numero10,2)));
                            break;
                        case "8":
                            int n1; int n2; int n3;
                            Console.WriteLine("promedio de 3 números ingresados por teclado.");
                            Console.WriteLine("Ingresar el primer valor: ");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresar el segundo valor: ");
                            n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresar el tercer valor: ");
                            n3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("El promedio de los 3 numeros es: " + (n1+n2+n3) / 3);
                            break;
                        case "9":
                            Console.WriteLine("Salir");
                            return;
                        default:
                            Console.WriteLine("Error de Digitación");
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


