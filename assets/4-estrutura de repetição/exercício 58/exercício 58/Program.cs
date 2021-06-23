using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_58
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,fat = 1;
            Console.WriteLine("Fatorial de um número inteiro positivo...");
            Console.WriteLine("Digite um n° inteiro positivo:");
            n = Int32.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (i = 1; i <= n; i++)
                {
                    fat *= i;
                }
                Console.WriteLine(n + "! = " + fat);
            }else if (n == 0)
            {
                Console.Write("0! = 1");
            }
            else
            {
                Console.WriteLine("Não existe fatorial de n° negativo");
            }
                 
            Console.ReadLine();
        }
    }
}
