using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_84
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetor 2° parte
          Crie um algoritimo que leia um vetor com 8 números inteiros, calcule e mostre na tela os números primos e sua respectivas posições
          */

            //ENTRADA
            
            int i, contador_de_divisores, contador_de_primos = 0, divisor;
            int[] vetor = new int[8];
            Console.WriteLine("Vetor de 8 números inteiros - Ocorrência de Primos ");
            Console.WriteLine("Leitura do Vetor");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
                contador_de_divisores = 0;
                for (divisor = 1; divisor <= vetor[i]; divisor++)
                {
                    if (vetor[i] % divisor == 0) { contador_de_divisores++; }
                }
                if (contador_de_divisores == 2) { contador_de_primos++; }
            }
            Console.Clear();
            Console.WriteLine("Impressão do Vetor");
            for (i = 0; i < 8; i++) { Console.Write(vetor[i] + "\t"); }
            if (contador_de_primos > 0)
            {
                Console.WriteLine("\n\nExistem " + contador_de_primos + " números primos:");
                for (i = 0; i < 8; i++)
                {
                    contador_de_divisores = 0;
                    for (divisor = 1; divisor <= vetor[i]; divisor++)
                    {
                        if (vetor[i] % divisor == 0) { contador_de_divisores++; }
                    }
                    if (contador_de_divisores == 2) { Console.WriteLine(vetor[i] + " na posição " + i); }
                }
            }
            else { Console.WriteLine("\n\nNão foram digitados números primos..."); }
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();


        }
    }
}
