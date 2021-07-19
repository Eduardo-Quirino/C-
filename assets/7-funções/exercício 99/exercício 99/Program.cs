using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_99
{
    class Program
    {
        static int dobro(int x)
        {
            return 2 * x;
        }
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Dobro de três números - usando funções");
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite o " + i + "º número: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Dobro de " + num + " = " + dobro(num));
            }
            Console.ReadKey();
        }
    }
}
