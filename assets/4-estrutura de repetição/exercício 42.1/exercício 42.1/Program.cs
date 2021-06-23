using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_42._1
{
    class Program
    {
        static void Main(string[] args)
        {/*OUTRO JEITO
           Estrutura de repetição 1° parte
           Ex 4 - Crie um algoritmo que imprima na tela os números múltiplos de 5, entre 1 e 600:
          */

            //ENTRADA
            int num = 1;
            Console.WriteLine("Números múltiplos de 5 entre 1 e 600");

            //PROCESSAMENTO
            while (num <= 600) 
            {
            if(num %5 == 0) { Console.WriteLine(num); }
                num++;
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
