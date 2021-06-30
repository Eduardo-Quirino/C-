using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_64
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1, n2, proximo, i;
            Console.WriteLine("Série de Ricci - Similar à Fibonacci");
            Console.WriteLine("Digite o nº de termos da série que deseja imprimir:");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 1º número da série:");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número da série:");
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nSérie de Ricci com " + n + " termos: \n");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (i = 1; i <= n - 2; i++)
            {
                proximo = n1 + n2;
                n1 = n2;
                n2 = proximo;
                Console.WriteLine(proximo);
            }
            Console.ReadKey();
        }
     }
}
