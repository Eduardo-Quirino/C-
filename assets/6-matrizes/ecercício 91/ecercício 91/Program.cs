using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecercício_91
{
    class Program
    {
        static void Main(string[] args)
        {//Matrizes

            //Declaração de uma matriz de inteiros de 5 linhas por 5 colunas
            int[,] matriz = new int[5, 5];
            Console.WriteLine("Matriz de Números Inteiros, de 5x5:\n");
            Console.WriteLine("Leitura da Matriz...");
            for (i = 0; i < 5; i++)
            { //LINHAS
                for (j = 0; j < 5; j++)
                { //COLUNAS
                    Console.WriteLine("Digite matriz[" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Impressão da matriz de 5x5: \n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
