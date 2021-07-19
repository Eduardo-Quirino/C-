using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_94
{
    class Program
    {
        static void Main(string[] args)
        {/*Matiz 1° parte
          Crie um programa em C que leia os elementos de duas matrizes inteiras A e B, de 5X5 e imprima a matriz SOMA, que será a soma das duas matrizes, elemento a alemento.          
          */

            //ENTRETADA
            int i, j;
            int[,] A = new int[5, 5];
            int[,] B = new int[5, 5];
            int[,] SOMA = new int[5, 5];
            int[,] DIFERENCA = new int[5, 5];
            Console.WriteLine("Soma e Diferença de duas matrizes A e B, de 5x5");
            Console.WriteLine("Leitura da matriz A: ");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite A[" + i + "," + j + "]:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n\nLeitura da matriz B: ");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite B[" + i + "," + j + "]:");
                    B[i, j] = int.Parse(Console.ReadLine());
                    SOMA[i, j] = A[i, j] + B[i, j];
                    DIFERENCA[i, j] = A[i, j] - B[i, j];
                }
            }
            Console.Clear();
            Console.WriteLine("MATRIZ A:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++) { Console.Write(A[i, j] + "\t"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nMATRIZ B:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++) { Console.Write(B[i, j] + "\t"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nMATRIZ SOMA:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++) { Console.Write(SOMA[i, j] + "\t"); }
                Console.WriteLine();
            }
            Console.WriteLine("MATRIZ DIFERENÇA:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++) { Console.Write(DIFERENCA[i, j] + "\t"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
