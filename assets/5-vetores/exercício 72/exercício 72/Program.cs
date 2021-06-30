using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_72
{
    class Program
    {
        static void Main(string[] args)
        {//Vetores 1° parte
            //ENTRADA
            int i;
            int[] vet = new int[10];
            Console.WriteLine("Vetor de 10 números inteiros");
            Console.WriteLine("LEITURA DO TETOR...\n");

            //PROCESSAMENTO
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite vet[" + i + "]: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Impressão do vetor na tela:\n");
            for (i = 0; i < 10; i++) { Console.Write(vet[i] + "\t"); }
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");

            //SAIDA
            Console.ReadKey();
        }
    }
}
