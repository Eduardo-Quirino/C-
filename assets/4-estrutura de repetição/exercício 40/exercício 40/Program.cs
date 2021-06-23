using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_40
{
    class Program
    {/*Estrutura de repetição 1° parte
      Ex 2 - Crie um algoritimo que imprima os números inteiros de 100 a 1
      */

        static void Main(string[] args)
        {
            //ENTRADA
            int num = 100;
            Console.WriteLine("Números inteiros entre 100 e 1");

            //PROCESSAMENTO
            while (num >= 1) //imprime os números de 100 à 1
            {
                Console.WriteLine(num);
                num--;//num = num -1
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
