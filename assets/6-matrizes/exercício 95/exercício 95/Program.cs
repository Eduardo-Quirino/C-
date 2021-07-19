using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_95
{
    class Program
    {
        static void Main(string[] args)
        {/*Matriz 1° parte
          Crie um programa em C que leia uma matriz A2x3 e gere e imprima a matriz transposta At, sabendo que a matriz transposta é gerada tocando linha por coluna.
         */
            //ENTRADA
            int i, j;
            int[,] A = new int[2, 3];
            int[,] At = new int[3, 2];
            Console.WriteLine("Matriz Transposta de uma matriz de 2x3: ");
            Console.WriteLine("Leitura da Matriz A: ");

            //PROCESSAMENTO
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite A[" + i + "," + j + "]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                    At[j, i] = A[i, j];
                }
            }
            Console.Clear();
            Console.WriteLine("MATRIZ A ORIGINAL:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++) { Console.Write(A[i, j] + "\t"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nMATRIZ A, TRANSPOSTA:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 2; j++) { Console.Write(At[i, j] + "\t"); }
                Console.WriteLine();
            }

            //SAIDA
            Console.WriteLine("\n\nDigite qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
