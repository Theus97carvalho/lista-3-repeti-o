using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_fibonati___repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anterior = 1;
            int atual = 1;
            int proximo;
            int i;
            Console.WriteLine("Os 30 primeiros valores da série de Fibonacci são:");

            Console.Write($"{anterior}, {atual}");

            for ( i = 3; i <= 30; i++)
            {
                proximo = anterior + atual;
                Console.Write($", {proximo}");

                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine();

        }
    }
}
