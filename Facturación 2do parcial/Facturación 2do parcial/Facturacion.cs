using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitTest
{
    class Facturacion
    {
        public static int Sumar(int num1, int num2)
        {
            int suma;

            suma = num1 + num2;

            if (suma > 0)
            {
                return suma;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.Write("\n\tSuma de Dos Numeros");

            Console.Write("\nIngrese un numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("\nIngrese el numero 2: ");
            num2 = Int32.Parse(Console.ReadLine());


            resultado = Sumar(num1, num2);
            Console.WriteLine("El Resultado es: " + resultado);

            Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
