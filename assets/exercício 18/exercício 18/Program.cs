using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_18
{
    class Program
    {
        static void Main(string[] args)
        {
           //Entrada
            int num;
            Console.WriteLine("Par ou ímpar - o que ele é? ");
            Console.WriteLine("Digite um n° inteiro positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Processamento
            if (num % 2 == 0)
            {//se o resto da divisão de num por 2 for igual a zero
                Console.WriteLine(num + " É PAR! ");

            }
            else
            {
                Console.WriteLine(num + " É IMPAR! ");
            }

            //Saida
            Console.ReadKey();

        }
    }
}
