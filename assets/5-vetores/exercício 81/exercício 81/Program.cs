using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_81
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 2° parte
          escreva um algoritimo que peça para que o usuário leia dois vetores A e B de 6 elementos cada um e crie e mostre na tela o vetor SOMA e o DIF, que serão, respectivamente, a soma e a  diferença, dos elementos correspondentes A  e B.
          */
           //ENTRADA
            int i;
            int[] A = new int[6];
            int[] B = new int[6];
            int[] SOMA = new int[6]; 
            int[] DIF = new int[6];
            Console.WriteLine("Soma e Subtração de 2 vetores de 6 elementos inteiros...");
            Console.WriteLine("LEITURA DO VETOR A:");

            //PROCESSAMENTO
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite A[" + i + "]: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\nLEITURA DO VETOR B:");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite B[" + i + "]: ");
                B[i] = int.Parse(Console.ReadLine());
                SOMA[i] = A[i] + B[i];
                DIF[i] = A[i] - B[i];
            }
            Console.Clear();
            Console.WriteLine("Impressão do vetor A:\n");
            for (i = 0; i < 6; i++) { Console.Write(A[i] + "\t"); }
            Console.WriteLine("\n\nImpressão do vetor B:\n");
            for (i = 0; i < 6; i++) { Console.Write(B[i] + "\t"); }
            Console.WriteLine("\n\nImpressão do vetor SOMA:\n");
            for (i = 0; i < 6; i++) { Console.Write(SOMA[i] + "\t"); }
            Console.WriteLine("\n\nImpressão do vetor SUBTRAÇÃO:\n");
            for (i = 0; i < 6; i++) { Console.Write(DIF[i] + "\t"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();


        }
    }
}
