using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_90
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            int i;
            int[] vet = new int[10];
            Console.WriteLine("Vetor multiplicado pelos seus índices...");
            Console.WriteLine("LEITURA DO VETOR");

            //PROCESSAMENTO
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite vet[" + i + "]: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vetor Original:\n");
            for (i = 0; i < 10; i++) { Console.Write(vet[i] + "\t"); }
            Console.WriteLine("\n\nVetor Original, multiplicado pelos seus índices:\n");
            for (i = 0; i < 10; i++) { Console.Write(i * vet[i] + "\t"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
