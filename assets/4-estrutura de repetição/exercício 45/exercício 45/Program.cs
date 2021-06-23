using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_45
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 7 - Crie um algoritimo que imprima todos os números de 1 até 200 e imprima a soma deles 
          */
            //ENTRADA
            int soma = 0, i;
            Console.WriteLine("Soma dos números entre 1 e 200");

            //PROCESSAMENTO
            Console.WriteLine("Os números entre 1 e 200, são: ");
            for (i = 1; i <= 200; i++){
                Console.WriteLine(i);
                soma = soma + i;
            }
            Console.WriteLine("A soma dos números entre 1 e 200 vale: " + soma);

            //SAIDA
            Console.ReadKey();
        }
    }
}
