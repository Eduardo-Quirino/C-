using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_80
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 2° parte
          Crie um algoritimo que leia um vetor com 8 números inteiros, leia um número X e multiplique o vetor pelo número X lido e mostre o vetor multiplicado pelo número X          
          */
            //ENTRADA
            int i, x;
            int[] vetor = new int[8];
            int[] vetor_x = new int[8];
            Console.WriteLine("Vetor de 8 elementos inteiros - multiplicação por escalar");
            Console.WriteLine("LEITURA DO VETOR...");

            //PROCESSAMENTO
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite o número escalar x: ");
            x = int.Parse(Console.ReadLine());
            for (i = 0; i < 8; i++) { vetor_x[i] = x * vetor[i]; }
            Console.Clear();
            Console.WriteLine("Vetor Original: ");
            for (i = 0; i < 8; i++) { Console.Write(vetor[i] + "\t"); }
            Console.WriteLine("\n\nVetor Original, multiplicado pelo escalar " + x + ":");
            for (i = 0; i < 8; i++) { Console.Write(vetor_x[i] + "\t"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
