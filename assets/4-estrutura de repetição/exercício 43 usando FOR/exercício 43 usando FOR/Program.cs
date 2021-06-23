using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_43_usando_FOR
{
    class Program
    {
        static void Main(string[] args)
        {/*Crie um algoritmo que imprima o quadrado dos números

            de 1 a 20:
            12 = 1
            22 = 4
            32 = 9
            ...
            192 = 361
            202 = 400*/

            //ENTRADA
            int num;
            Console.WriteLine("Tabela de quadrados de 1 a 20");

            //PROCESSAMENTO
            for(num = 1; num <= 20; num++) 
            {
                Console.WriteLine(num + "² = " + Math.Pow(num,2));
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
