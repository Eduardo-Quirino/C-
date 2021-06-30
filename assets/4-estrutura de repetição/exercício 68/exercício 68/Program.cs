using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_68
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 3° parte
         Crie um algoritmo que leia vários números inteiros e apresente o
fatorial de cada número.
O algoritmo se encerra quando se digita um número menor que 1.*/

            //ENTRADA
            int num, i, fat;
            Console.WriteLine("Vários números fatorial");
            Console.WriteLine("Digite um número positivo ou 0 para terminar: ");
            num = int.Parse(Console.ReadLine());


            //PROCESSAMENTO
           while (num >0) {
                fat = 1;
                for (i = 1; i <= num; i++) { fat *= i; }
                Console.WriteLine(num + "! = " + fat);
                Console.WriteLine("Digite um número positivo, ou 0 para terminar: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pressione qualquer tecla para sair do programa...");

            //SAIDA
            Console.ReadKey();
        }
    }
}
