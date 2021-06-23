using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_60
{
    class Program
    {
        static void Main(string[] args)
        {
            //algoritimo que lê varios números e só para quando digitar 0 ou números negativos
            int num, contador = 0;
            Console.WriteLine("Leitura de vários números (Sem saber a quantidade)");
            Console.WriteLine("Digite um n° inteiro positivo, ou 0 para terminar");
            num = Int32.Parse(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine("Digite um n° inteiro postivo, ou 0 para terminar");
                num = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Foram digitados "+ contador +" números...");
            Console.ReadKey();
        }
    }
}

