using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_numero_maior___repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double primeiroValor;
            double segundoValor;

            Console.WriteLine("Digite o primeiro numero:");
            primeiroValor = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite um valor maior que o primeiro:");
                segundoValor = double.Parse(Console.ReadLine());

                if (segundoValor <= primeiroValor)
                {
                    Console.WriteLine("Valor inválido. O segundo valor deve ser maior que o primeiro.");
                }
            } while (segundoValor <= primeiroValor);

            Console.WriteLine($"Você digitou o primeiro valor: {primeiroValor}");

            Console.WriteLine($"Você digitou o segundo valor, que é maior que o primeiro: {segundoValor}");

        }
    }
}
