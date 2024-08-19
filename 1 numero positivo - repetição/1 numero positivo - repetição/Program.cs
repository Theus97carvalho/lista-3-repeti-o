using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_numero_positivo___repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor;

            do
            {
                Console.WriteLine("Digite um valor positivo:");
                valor = double.Parse(Console.ReadLine());

                if (valor <= 0)
                {
                    Console.WriteLine("numero inválido, insira um número positivo.");
                }
            } while (valor <= 0);

            Console.WriteLine($"Você digitou um valor positivo: {valor}");

        }
    }
}
