using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Divisibilidade de um nº por 2 ou 5 ou 10...");
            Console.WriteLine("Digite um nº inteiro positivo: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 10 == 0) { Console.WriteLine(num + " é divisível por 10..."); }
            else { Console.WriteLine(num + " não é divisível por 10..."); }
            if (num % 5 == 0) { Console.WriteLine(num + " é divisível por 5..."); }
            else { Console.WriteLine(num + " não é divisível por 5..."); }
            if (num % 2 == 0) { Console.WriteLine(num + " é divisível por 2..."); }
            else { Console.WriteLine(num + " não é divisível por 2..."); }
            if (num % 2 == 0 && num % 5 == 0 && num % 10 == 0)
            {
                Console.WriteLine(num + " é divisível por 2, por 5 e por 10 ao mesmo tempo...");
            }
            else { Console.WriteLine(num + " não é divisível por 2, por 5 e por 10 ao mesmo tempo"); }
            Console.ReadKey();
        }
    }
}
