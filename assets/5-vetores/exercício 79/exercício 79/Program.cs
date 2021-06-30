using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_79
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 1° parte
          Faça um programa que carregue um vetor com sete números inteiros, calcule e mostre:
            -os números multiplos de 2
            -os números multiplos de 3
            -os números multiplos de 2 e de 3 ao mesmo tempo
          */

            //ENTRADA
            int i, cont_de_2 = 0, cont_de_3 = 0, cont_de_2_e_de_3 = 0;
            int[] vetor = new int[7];
            Console.WriteLine("Vetor de 7 inteiros - há múltiplos de 2 ou de 3?");
            Console.WriteLine("LEITURA DO VETOR...");

            //PROCESSAMENTO
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0) { cont_de_2++; }
                if (vetor[i] % 3 == 0) { cont_de_3++; }
                if (vetor[i] % 2 == 0 && vetor[i] % 3 == 0) { cont_de_2_e_de_3++; }
            }
            Console.Clear();
            Console.WriteLine("Vetor Original na Tela:");
            for (i = 0; i < 7; i++) { Console.Write(vetor[i] + "\t"); }
            if (cont_de_2 > 0)
            {
                Console.WriteLine("\n\nHá " + cont_de_2 + " múltiplos de 2 no vetor:\n");
                for (i = 0; i < 7; i++)
                {
                    if (vetor[i] % 2 == 0) { Console.Write(vetor[i] + "\t"); }
                }
            }
            else { Console.WriteLine("\n\nNão há múltiplos de 2 no vetor..."); }
            if (cont_de_3 > 0)
            {
                Console.WriteLine("\n\nHá " + cont_de_3 + " múltiplos de 3 no vetor:\n");
                for (i = 0; i < 7; i++)
                {
                    if (vetor[i] % 3 == 0) { Console.Write(vetor[i] + "\t"); }
                }
            }
            else { Console.WriteLine("\n\nNão há múltiplos de 3 no vetor..."); }
            if (cont_de_2_e_de_3 > 0)
            {
                Console.WriteLine("\n\nHá " + cont_de_2_e_de_3 + " múltiplos de 2 e 3 ao mesmo tempo, no vetor:\n");
                for (i = 0; i < 7; i++)
                {
                    if (vetor[i] % 2 == 0 && vetor[i] % 3 == 0) { Console.Write(vetor[i] + "\t"); }
                }
            }
            else { Console.WriteLine("\n\nNão há múltiplos de 2 e 3, ao mesmo tempo, no vetor..."); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa....");
            Console.ReadKey();
        }
    }
}
