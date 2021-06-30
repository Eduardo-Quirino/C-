using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_65
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            int num, produto_dos_impares = 1, soma_dos_pares = 0;
            Console.WriteLine("Vários Números - Pares e ímpares");
            Console.WriteLine("Digite um nº positivo, ou 0 para terminar: ");
            num = Int32.Parse(Console.ReadLine());

            //PROCESSAMENTO
            while (num > 0)
            {
                if (num % 2 == 0) { soma_dos_pares += num; }
                else { produto_dos_impares *= num; }
                Console.WriteLine("Digite um nº positivo, ou 0 para terminar: ");
                num = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soma dos pares digitados = " + soma_dos_pares);
            Console.WriteLine("Produto dos ímpares digitados = " + produto_dos_impares);

            //SAIDA
            Console.ReadKey();
        }

    }
}

