using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_49
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 11- Crie um algoritimo que leia um número n inteiro e calcule a soma S, dada por 
            S = 1 + 1/2 + 1/3+...+1/n
          */

            //ENTREDA
           double soma=0, n, i;
            Console.WriteLine("Soma de frações simples, do tipo 1 + 1/2 + 1/3+...+1/n");
            Console.WriteLine("Digite o número a ser calculado: ");
            n = double.Parse(Console.ReadLine());

            //PROCESSAMENTO
            for(i=1; i <= n; i++)
            {
                soma += 1/i;
            }
            Console.WriteLine("A soma de " +n+" Frações, vale "+Math.Round(soma,2));

            //SAIDA
            Console.ReadKey();
        }
    }
}
