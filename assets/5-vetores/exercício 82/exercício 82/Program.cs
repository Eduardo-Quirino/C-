using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_82
{
    class Program
    {
        static void Main(string[] args)
        {
            
//Ler um vetor de inteiros de 8 elementos e imprimir o vetor invertido
//Exemplo vetor = 2 5 8 1 9 7 3 4, deve imprimir: 4 3 7 9 1 8 5 2
            int i; int[] vetor = new int[8];
            Console.WriteLine("Inversão de um Vetor de 8 inteiros");
            Console.WriteLine("LEITURA DO VETOR...");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vetor Original:");
            for (i = 0; i < 8; i++) { Console.Write(vetor[i] + "\t"); }
            Console.WriteLine("\n\nVetor Original INVERTIDO:");
            for (i = 7; i >= 0; i--) { Console.Write(vetor[i] + "\t"); }
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();


        }
    }
}
