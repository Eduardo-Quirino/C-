using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_42
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
           Ex 4 - Crie um algoritmo que imprima na tela os números múltiplos de 5, entre 1 e 600:
          */

            //ENTRADA
            int num = 5;
            Console.WriteLine("Números múltiplos de 5 entre 1 e 600");

            //PROCESSAMENTO
            while (num <= 600) 
            {
                Console.WriteLine(num);
                num += 5;
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
