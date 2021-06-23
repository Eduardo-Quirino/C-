using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_39
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de Repetição-1° parte
       Ex 1 - Clie um algoritimo que escreva na tela os n° inteiros entre 1 e 100
      */
            //ENTRADA
            int num = 1;
            Console.WriteLine("Números inteiros entre 1 e 100");

            //PROCESSAMENTO
            while (num <= 100)//mostra os números de 1 à 100
            {
                Console.WriteLine(num);//imprime no console 
                num++;//num = num + 1
            }
            
            //SAIDA
            Console.ReadKey();

        }
    }
}
