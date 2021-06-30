using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_73
{
    class Program
    {
        static void Main(string[] args)
        {//Vetores 1° parte
            int i;
            int[] v = new int[12];
            Console.WriteLine("Vetor de 12 inteiros - par ou impar...");
            Console.WriteLine("LEITURA DO VETOR...");
            for (i=0; i<12; i++)
            {
                Console.WriteLine("Digite v [" + i + "]: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vetor impresso na tela - PAR ou IMPAR:\n");
            for(i=0; i<12; i++)
            {
                if (v[i] % 2 == 0)
                {
                    Console.WriteLine(v[i] + " é PAR!");
                }
                else { Console.WriteLine(v[i] + " é IMPAR!"); }
            }
            Console.WriteLine("\n\nPresione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
