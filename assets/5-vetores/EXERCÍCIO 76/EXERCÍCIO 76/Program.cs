using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCÍCIO_76
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 1° parte
          Crie um programa que carregue um valor de seis elementos numéricos inteiros, calcule e mostre
            -a quantidade de números pares
            - quais os números pares
            -a quantidade de números ímpares
            -quais os números ímpares
          */

            //ENTRADA
            int i, conta_pares = 0, conta_impares = 0;
            int[] vetor = new int[6];
            Console.WriteLine("Vetor de 6 inteiros - pares ou ímpares");
            Console.WriteLine("LEITURA DO VETOR...");

            //PROCESSAMENTO
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0) { conta_pares++; }
                else { conta_impares++; }
            }
            Console.Clear();
            Console.WriteLine("Vetor original: ");
            for (i = 0; i < 6; i++) { Console.Write(vetor[i] + "\t"); }
            if (conta_pares > 0)
            {
                Console.WriteLine("\nNo vetor, há " + conta_pares + " números pares.");
                Console.WriteLine("\nVetor de Pares:\n");
                for (i = 0; i < 6; i++)
                {
                    if (vetor[i] % 2 == 0) { Console.Write(vetor[i] + "\t"); }
                }
            }
            else { Console.WriteLine("\nNão há números pares no vetor!"); }
            if (conta_impares > 0)
            {
                Console.WriteLine("\nNo vetor, há " + conta_impares + " números ímpares.");
                Console.WriteLine("\nVetor de Ímpares:\n");
                for (i = 0; i < 6; i++)
                {
                    if (vetor[i] % 2 == 1) { Console.Write(vetor[i] + "\t"); }
                }
            }
            else { Console.WriteLine("\n\nNão há números ímpares no vetor!"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
