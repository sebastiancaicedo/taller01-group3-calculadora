using System;
using System.Threading.Tasks;
using ClaseCalculadora = Calculadora.CalcLib.Calculadora;

namespace Calculadora.Consola
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int a = 1;
            int b = 1;

            if (args.Length == 2)
            {
                int.TryParse(args[0], out a);
                int.TryParse(args[1], out b);
            }
            else
            {
                a = GetNextInt("Digite un numero entero (a)");
                b = GetNextInt("Digite un numero entero (b)");
            }
            ClaseCalculadora c = new();
            Console.WriteLine($"La suma de {a} + {b} es = {await c.Suma(a,b)} ");
        }

        static int GetNextInt(string mensaje = "Digite un numero")
        {

            string input;
            int output;
            do
            {
                Console.Write(mensaje);
                input = Console.ReadLine() ?? string.Empty;

            } while (!int.TryParse(input, out output));

            return output;
        }


    }
}
