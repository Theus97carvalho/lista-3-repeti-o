using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_intervalo_tabuada___repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valorX;
            int intervaloA;
            int intervaloB;

            do
            {
                Console.WriteLine("Digite um numero positivo (X):");
                valorX = int.Parse(Console.ReadLine());

                if (valorX <= 0)
                {
                    Console.WriteLine("numero inválido. Por favor, digite um número positivo.");
                }
            } while (valorX <= 0);

            Console.WriteLine("Digite o valor inicial do intervalo (A):");
            intervaloA = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite o valor final do intervalo (B), deve ser maior que A:");
                intervaloB = int.Parse(Console.ReadLine());

                if (intervaloB <= intervaloA)
                {
                    Console.WriteLine("Valor inválido. B deve ser maior que A.");
                }
            } while (intervaloB <= intervaloA);

            Console.WriteLine($"\nTabuada do {valorX} de {intervaloB} até {intervaloA}:");
            for (int i = intervaloB; i >= intervaloA; i--)
            {
                Console.WriteLine($"{valorX} x {i} = {valorX * i}");

            }
        }
    }
}