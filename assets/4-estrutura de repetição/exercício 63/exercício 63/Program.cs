using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_63
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            int n, anterior=0,atual=1, proximo,i;
            Console.WriteLine("Série de Fibonacci - Série que começa com 1 1...");
            Console.WriteLine("Digite o n° de termos da série, que quer gerar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSérie de Fibonacci com "+n+" termos:\n");

            //PROCESSAMENTO
            for (i=1; i<=n; i++)
            {
                Console.WriteLine(atual);
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            //SAIDA
            Console.ReadKey();

        }
    }
}
