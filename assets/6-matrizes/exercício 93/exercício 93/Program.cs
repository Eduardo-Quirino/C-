using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_93
{
    class Program
    {
        static void Main(string[] args)
        {/*Matrizes 1° PARTE
          3. Crie um programa em C que leia os elementos de uma 
          ​matriz inteira de 5x5 e 
          escreva todos os elementos que estão 
          ​acima da diagonal principal:*/


            //ENTRADA
            int i, j;
            int[,] matriz = new int[5, 5];
            Console.WriteLine("Matriz de 5x5 - Triangular Superior e Inferior");
            Console.WriteLine("Leitura da Matriz 5x5:\n");

            //PROCESSAMENTO
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite matriz[" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Matriz Original:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++) { Console.Write(matriz[i, j] + "\t"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nMatriz Triangular Inferior:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i > j) Console.Write(matriz[i, j] + "\t");
                    else { Console.Write("\t"); }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nMatriz Triangular Superior:\n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i < j) Console.Write(matriz[i, j] + "\t");
                    else { Console.Write("\t"); }
                }
                Console.WriteLine();
            }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
