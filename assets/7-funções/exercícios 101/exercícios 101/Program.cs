using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercícios_101
{
    class Program
    {
        static void Primo(int num)
        {
            int i, contador = 0;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0) { contador++; }
            }
            if (contador == 2) { Console.WriteLine(num + " é primo!"); }
            else { Console.WriteLine(num + " não é primo!"); }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Verificação de Número Primo...");
            Console.WriteLine("Digite um nº inteiro positivo: ");
            n = int.Parse(Console.ReadLine());
            Primo(n);
            Console.ReadKey();
        }
    }
}
