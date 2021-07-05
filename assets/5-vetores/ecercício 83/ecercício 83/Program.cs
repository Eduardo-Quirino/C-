using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecercício_83
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 2° parte
          Escreva um algoritimo que peça para o usuário digitar os valores de um vetor de inteiros com 10 elementos e em seguida exiba o valor da soam dos elementos do vetor e o menor elemento do vetor e sua posição 
          */

            //ENTRADA
            int i, soma_do_vetor = 0, menor, posicao_do_menor = 0;
            int[] vetor = new int[10];
            Console.WriteLine("Vetor de 10 inteiros - Soma, menor elemento e sua posição");
            Console.WriteLine("Leitura do Vetor");

            //PROCESSAMENTO
            for (i = 0; i < 10; i++)//soma do vetor
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma_do_vetor += vetor[i];
            }
            menor = vetor[0];//menor vetor
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao_do_menor = i;//posição do menor vetor
                }
            }
            Console.Clear();//limpa tela
            Console.WriteLine("Vetor de 10 inteiros na tela: ");
            for (i = 0; i < 10; i++) { Console.Write(vetor[i] + "\t"); }

            //SAIDA
            Console.WriteLine("\n\nSoma dos elementos do vetor: " + soma_do_vetor);
            Console.WriteLine("Menor elemento do vetor: " + menor);
            Console.WriteLine("Posição do menor elemento do vetor: " + posicao_do_menor);
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa....");
            Console.ReadKey();
        }
    }
}
