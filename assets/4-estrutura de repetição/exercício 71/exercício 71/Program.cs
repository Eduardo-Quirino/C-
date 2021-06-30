using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_71
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 3° parte
          Crie um programa que leia vários elementos inteiros positivos e mostre os divisores de cada um dos números que foram
digitados:
            ﴾O algoritmo termina quando for digitado 0﴿
          */
            //ENTRADA
            int num, i;
            Console.WriteLine("Vários Números - Divisores dos números");
            Console.WriteLine("\nDigite um nº positivo, ou 0 para terminar: ");
            num = int.Parse(Console.ReadLine());
          
            //PROCESSAMENTO
            while (num > 0)
            {
                Console.WriteLine("\nDivisores de " + num + ":\n");
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0) { Console.WriteLine(i); }
                }
                Console.WriteLine("\nDigite um nº positivo, ou 0 para terminar: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pressione qualquer tecla para sair do programa...");

            //SAIDA
            Console.ReadKey();
        }
    }
}
