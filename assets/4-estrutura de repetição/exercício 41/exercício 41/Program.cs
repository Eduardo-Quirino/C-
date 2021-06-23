using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_41
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 3 - Crie um algoritmo que escreva os 100 primeiros números pares positivos na tela
          */

            //ENTRADA
            int num = 2;
            Console.WriteLine("Números pares positivos de 1 à 100");

            //PROCESSAMENTO
            while (num <= 100) 
            {
                Console.WriteLine(num);
                num += 2;//num = num +2
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
