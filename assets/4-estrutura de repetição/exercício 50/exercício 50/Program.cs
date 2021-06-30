using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_50
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 12 -  Crie um algoritmo que leia um número inteiro n e mostre os
                divisores do mesmo, na tela:Ex: n = 12
                Deve mostrar na tela:               Num I Num%i
                                                    4   1  4%1  = 0
                                                    2   4   % 2 = 0
                                                    3   4   % 3 = 1
                                                    4   4   % 4 = 0
                Divisores de 12:
                1
                2
                3
                4
                6
                12
          */
            //ENTRADA
            int num, i;
            Console.WriteLine("Divisores de um número inteiro positivo:");
            Console.WriteLine("Digite um n° inteiro positivo:");
            num = Int32.Parse(Console.ReadLine());//conversão de STRING para variavel
            Console.WriteLine("Divisores de "+num+" : ");

            //PROCESSAMENTO
            for (i=1; i<=num; i++) {//possiveis divisores de n: 1,2,3,4..,n
                if (num % i==0) {//i é divisor de n
                    Console.WriteLine(i);
                }
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
