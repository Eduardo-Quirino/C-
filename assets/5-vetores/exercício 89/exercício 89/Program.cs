using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_89
{
    class Program
    {
        static void Main(string[] args)
        {   //ENTRADA
            int[] A = new int[] { 1, 0, 5, -2, -5, 7 };
            int soma_A0_A1_A5 = 0, i;
            Console.WriteLine("Vetor Tosco - pré-definido pelo usuário...\n ");
            Console.WriteLine("Impressão do Vetor: \n");
            soma_A0_A1_A5 = A[0] + A[1] + A[5];

            //PROCESSAMENTO
            for (i = 0; i < 6; i++) { Console.Write(A[i] + "\t"); }
            Console.WriteLine("\n\nA soma dos elementos das posições 0 , 1 e 5 vale: " + soma_A0_A1_A5);
            Console.WriteLine("\nModificação na posição 4, ela valerá 100:");
            A[4] = 100;
            Console.WriteLine("\nNovo vetor - com a modificação na posição 4, linha a linha: \n");
            for (i = 0; i < 6; i++) { Console.WriteLine(A[i]); }
            Console.WriteLine("\nNovo vetor - com a modificação na posição 4, horizontal: \n");
            for (i = 0; i < 6; i++) { Console.Write(A[i] + "\t"); }
           
            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
