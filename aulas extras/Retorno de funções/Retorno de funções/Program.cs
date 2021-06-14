using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retorno_de_funções
{
    class Program
    {
        //Programa pergunta qual o nome do USUÁRIO
        static void Main(string[] args)
        {
            //Entrada
            Console.WriteLine("Qual seu nome? ");//perguta natela
            string valor = Console.ReadLine();//recebe o valor digitado

            //Processamento
            Console.WriteLine("Olá seja bem vido "+valor+"!");//imprime texto mais o valor digitado

            //Saida
            Console.ReadLine();//permite que o console fique aberto
        }
    }
}
