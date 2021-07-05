using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_85
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetor 2° parte
          Crie um algoritimo que leia e carregue um vetor de 10 posições calcule e mostre:
            - o menor elemento do vetor e em que posição eese elemento está 
            - o menor elemento do vetor e em que posição eese elemento está
          */

            //ENTRADA
            int i, menor, maior, posicao_maior = 0, posicao_menor = 0;
            int[] v = new int[10];
            Console.WriteLine("Vetor de 10 elementos inteiros - maior e menor e suas posições");
            Console.WriteLine("Leitura do Vetor:");

            //PROCESAMENTO
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite v[" + i + "]: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            menor = v[0]; maior = v[0];
            for (i = 0; i < 10; i++)
            {
                if (v[i] > maior) { maior = v[i]; posicao_maior = i; }
                if (v[i] < menor) { menor = v[i]; posicao_menor = i; }
            }
            Console.Clear();
            Console.WriteLine("Vetor Impresso na tela: \n");
            for (i = 0; i < 10; i++) { Console.Write(v[i] + "\t"); }
            Console.WriteLine("\n\nMaior elemento do vetor: " + maior + " na posição " + posicao_maior);
            Console.WriteLine("\n\nMenor elemento do vetor: " + menor + " na posição " + posicao_menor);

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
