using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, aux=1, t;
            Console.WriteLine("Verificação de números triangulares");
            Console.WriteLine("quando é o produto de 3 números consecutivos");
            Console.WriteLine("Digite o n° candidato a ser triangular");
            n = Int32.Parse(Console.ReadLine());
            t = aux * (aux + 1) * (aux+2);
            while (t < n)
            {
                aux++;
                t = aux * (aux + 1) * (aux + 2);
            }
            if (t == n)
            {
                Console.Write(n+" É TRIANGULAR!");
            }
            else { Console.WriteLine(n+" NÃO É TRIANGULAR"); }
            Console.ReadKey();
        }
    }
}
