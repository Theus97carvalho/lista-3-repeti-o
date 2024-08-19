using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_tabuada_1_a_20___repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int i;

            for (numero = 1; numero <= 20; numero++)
            {
                Console.WriteLine($"\nTabuada do {numero}:");

                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar para a próxima tabuada...");
                Console.ReadKey();  
            }

        }
    }
}
