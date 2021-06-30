using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_77
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 1° parte
          Faça um programa que carregue um vetor dez números reais, calcule e mostre a quantidade de números negativos e a soma dos números positivos desse vetor
          */

            //ENTRADA
            double[] numeros = new double[10];
            double soma_positivos = 0, conta_negativos = 0;
            int i;
            Console.WriteLine("Vetor de 10 números reais - positivos ou negativos");
            Console.WriteLine("LEITURA DO VETOR...");

            //PROCESSAMENTO
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite numeros[" + i + "]: ");
                numeros[i] = Double.Parse(Console.ReadLine());
                if (numeros[i] >= 0) { soma_positivos += numeros[i]; }
                else { conta_negativos++; }
            }
            Console.Clear();
            Console.WriteLine("Vetor Na Tela:\n");
            for (i = 0; i < 10; i++) { Console.Write(numeros[i] + "\t"); }
            Console.WriteLine("\n\nSoma dos Positivos: " + soma_positivos);
            Console.WriteLine("\nQuantidade de negativos digitados: " + conta_negativos);

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
