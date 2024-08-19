using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_M_ou_F___repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            //sempre dá entrada invalida por algum motivo

            do
            {
                Console.WriteLine("Digite o sexo (F para feminino, M para masculino):");
                sexo = Console.ReadLine();

                if (sexo != "f" && sexo != "m" );
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite 'F' para feminino ou 'M' para masculino.");
                }
            } while (sexo != "F" && sexo != "M");

            Console.WriteLine($"Você digitou: {sexo}");
        }
    }
}
