using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_41._1
{
    class Program
    {
        static void Main(string[] args)
        {/*OUTRO JEITO
          3. Crie um algoritmo que escreva os 100 primeiros números pares 
positivos na tela
          */

            //ENTRADA
            int num = 1;
            Console.WriteLine("100 primeiros números pares positivos");

            //PROCESSAMENTO
            while (num <= 100) 
            {
            if(num %2 == 0) { Console.WriteLine(num); }
                num++;
            }

            //SAIDA
            Console.ReadKey();

        }
    }
}
