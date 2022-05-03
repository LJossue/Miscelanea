using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Menus
    {
        //Volver al menu principal (main)
        public static void Volver()
        {
            String RespuestaContinuar = null;
            do
            {
                // COMANDO para regresar al MENU
                Console.WriteLine("\n¿Desea continuar usando el programa y volver al menu? SI/NO)");
                RespuestaContinuar = Console.ReadLine();
                if ((RespuestaContinuar == "SI") || (RespuestaContinuar == "si"))
                {
                    Console.Clear();
                    Programa.Main();
                }

                else if ((RespuestaContinuar == "NO") || (RespuestaContinuar == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Salió del programa.");
                    Environment.Exit(1);
                }
            } while ((RespuestaContinuar != "SI") && (RespuestaContinuar != "NO"));
        }
        //Menu Principal
        public static void MenuPrincipal()
        {
            Console.WriteLine("Bienvenido al Menú, Escoja una opción: \n" +
            "\n1.- Operadores" +
            "\n2.- Condicionales" +
            "\n3.- Ciclos" +
            "\n4.- Salir"
            );
        }

        //Menu Operadores
        public static void MenuOperadores()
        {
            Console.WriteLine("\n----------------------------------------------------------------" +
            "\n Operadores: " +
            "\n¿Qué operación desea realizar? Escoja una opción: \n " +
            "\n1.- Area del triangulo" +
            "\n2.- Suma" +
            "\n3.- Elevación al Cuadrado" +
            "\n4.- Cambio de divisas (Euro a Dolar)" +
            "\n5.- Perimetro y area de un cuadrado" +
            "\n6.- Area y Volumen de un Cilindro" +
            "\n7.- Radio, longitud y area de una circunferencia" +
            "\n8.- Calcular el promedio de 3 numeros" +
            "\n9.- Salir");
        }

        //Menu Condicionales
        public static void MenuCondicionales()
        {
            Console.WriteLine("\n----------------------------------------------------------------" +
            "\nCondicionales: " +
            "\n¿Qué operación desea realizar? Escoja una opción: \n " +
            "\n1.- Saber si un numero es positivo o negativo" +
            "\n2.- Ingresar dos numeros y verificar cual es el mayor y el menor" +
            "\n3.- Ingresar tres numeros y calcular cual es el mayor y menor" +
            "\n4.- Dados dos números A y B, sumarlos si A es menor que B o sino restarlos." +
            "\n5.- Dados dos números A y B encontrar el cociente entre A y B." +
            "\n6.- Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos" +
            "\n7.- Calcular si un año es bisiesto" +
            "\n8.- Salir");
        }

        //Menu Ciclos
        public static void MenuCiclos()
        {
            Console.WriteLine("\n----------------------------------------------------------------" +
            "\nCiclos: " +
            "\n¿Qué operación desea realizar? Escoja una Opción: \n" +
            "\n1.-Multiplos de 3 entre los numeros 1 y 100" +
            "\n2.-Numeros Impares entre 0 y 100" +
            "\n3.-Numeros Pares del 1 al 100" +
            "\n4.-Los cuadrados de los números del 1 al 30" +
            "\n5.-Sumar los cuadrados de los cien primeros números naturales" +
            "\n6.-Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente" +
            "\n7.-Sumar todos los números que se digitan por teclado mientras no sea cero"+
            "\n8.- Salir");
        }
    }
}
