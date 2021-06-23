using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_43
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
         Ex 5 - Crie um algoritmo que imprima o quadrado dos         números de 1 a 20:

                12 = 1
                22 = 4
                32 = 9
                ...
                192 = 361
                202 = 400
          */

            //ENTRADA
            int num = 1;
            Console.WriteLine("Quadrads dos números de 1 até 20");

            //PROCESSAMENTO
            while(num <= 20)
            {
                Console.WriteLine(num + "² = " + Math.Pow(num,2));//eleva o número por 2
                num++;//num = num +1 
                            }

            //SAIDA
            Console.ReadKey();

        }
    }
}
