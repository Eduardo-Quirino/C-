using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_86
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 2°parte*/

            //ENTRADA
            double maior, posicao_do_maior = 0;
            double[] vetor = new double[15];
            double[] vetor_novo = new double[15];
            int i;
            Console.WriteLine("LEITURA DO VETOR...");
            Console.WriteLine("Vetor de 15 elementos - quem é o maior e novo vetor");

            //PROCESSAMENTO
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = Double.Parse(Console.ReadLine());
            }
            maior = vetor[0];
            for (i = 0; i < 15; i++)
            {
                if (vetor[i] > maior) { maior = vetor[i]; posicao_do_maior = i; }
            }
            for (i = 0; i < 15; i++) { vetor_novo[i] = vetor[i] / maior; }
            Console.Clear();

            Console.WriteLine("Vetor Impresso na tela:");
            for (i = 0; i < 15; i++) { Console.Write(vetor[i] + "\t"); }
            Console.WriteLine("\n\nMaior elemento do vetor: " + maior);
            Console.WriteLine("Posição do maior elemento do vetor: " + posicao_do_maior);
            Console.WriteLine("\n\nNovo vetor na tela, dividido pelo maior elemento:");
            for (i = 0; i < 15; i++) { Console.Write(Math.Round(vetor_novo[i], 2) + "\t"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa... ");
            Console.ReadKey();
        }
    }
}
