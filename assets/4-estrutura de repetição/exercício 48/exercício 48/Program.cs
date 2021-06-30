using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_48
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 10 - Crie um algortimo que mostre os números entre 1000 e 2000 (inclusive) que,quando divididos por 11 dão resto igual a 5
          */
            //ENTRADA
            int i;
            Console.WriteLine("Números entre 1000 e 2000, que quando divididos por 11 dão resto 5...");
            //PROCESSAMENTO
            for(i=1000; i <= 2000; i++)
            {
                if (i%11==5) { Console.WriteLine(i); }
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
