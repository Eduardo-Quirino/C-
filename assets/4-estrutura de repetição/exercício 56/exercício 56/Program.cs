using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_56
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            int n, i;
            Console.WriteLine("Tabuada de um n° inteiro");

            //PROCESSAMENTO
            Console.WriteLine("\nDigite um n° inteiro: ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Tabuada do "+ n + " :\n ");
            for(i = 1; i<= 10; i++)
            {
                Console.WriteLine(n+"x"+ i+ " = "+ n*1);
            }
            //SAIDA
            Console.ReadKey();
        }
    }
}
