using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_96
{
    class Program
    {//Criar um algoritimo (void) para trocar duas variáveis
        static void troca(int num1, int num2) {
            int aux;
            aux = num1;
            num1 = num2;
            num2 = aux;
            Console.WriteLine("\nVariaveis trocadas: " + num1 + " e " + num2);
        }


        static void Main(string[] args)
        {   //ENTRADA
            int n1, n2;
            Console.WriteLine("Troca de duas variáveis - usando funções...");
            Console.WriteLine("Digite o 1° número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número: ");
            n2 = int.Parse(Console.ReadLine());

            //PROCESSAMENTO
            Console.WriteLine("\n\nVariáveis originais: n1 = "+n1+" e n2 = "+n2);
            troca(n1, n2);

            //SAIDA
            Console.ReadKey();

        }
    }
}
