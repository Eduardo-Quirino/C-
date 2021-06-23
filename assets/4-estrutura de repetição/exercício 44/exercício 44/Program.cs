using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_44
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 6 -Crie um algoritmo que leia dez números e imprima os
quadrados desses números:
          */
            //ENTRADA
            int num,i;
            Console.WriteLine("Quadrados de dez números digitados via teclado... ");

            //PROCESSAMENTO
            for (i = 1;i <= 10; i++) 
            {
                Console.WriteLine("Digite o "+ i + "² número:" );
                num = Int32.Parse(Console.ReadLine());//Int32.Parse() --> forma de converter STRING na variavel
                Console.WriteLine(num+"² = " + Math.Pow(num,2));
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
