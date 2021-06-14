using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retorno_de_funções_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
          int soma1 = Somar(1,2,3);
          int soma2 = Somar(10,20,30);
          int soma3 = Somar(100, 200,300);

            //Processamento
            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);


            //Saida
            Console.ReadLine();//permite que o console fique aberto

        }

        //Processamento de funções
        static void gerarPreco(int preco)
        {
            int preAbs = Math.Abs(preco);
            int valorFinal = preAbs + (2 * preAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }
        static int Somar(int a, int b, int c) // tipo de retorno VOID--> Int - Float - Bool - String
        {
            int resultadoFinal = a + b + c;//parâmetros
            return resultadoFinal; //retorna um valor

        }
    }
}
