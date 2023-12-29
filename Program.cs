//Solicitar desde teclado el ingreso de un número N, imprimir N en base 2 (número binario). Ejemplo: N=8, se imprimirá 1000.
using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int x;
            do
            {
                Console.Write("Ingrese un numero entero: ");
                n = Console.ReadLine();
                x = Int16.Parse(n);
            } while (x < 0);

            string bin = "";
            
            while (x > 0)
            {
                if (x % 2 == 0)
                {
                    bin = "0" + bin;
                }
                else
                {
                    bin = "1" + bin;
                }
                x = (int)x / 2;
            }
            Console.WriteLine(bin);            
        }
    }
}