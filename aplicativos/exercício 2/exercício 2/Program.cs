using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba três números, calcule e mostre  a multiplicação desses números. */

            //ENTRADA
            int num1, num2, num3, resultado;
            Console.WriteLine("Multiplicação de 3 números inteiros");//INFORMA TEXTO NO CONSOLE
            Console.WriteLine("Digite o primeiro número: ");//IMPRIME NO CONSOLE
            num1 = Convert.ToInt32(Console.ReadLine());//RECEBE O TEXTO DIGITADO E CONVERTE

            Console.WriteLine("Digite o segundo número: ");//IMPRIME NO CONSOLE
            num2 = Convert.ToInt32(Console.ReadLine());//RECEBE O TEXTO DIGITADO E CONVERTE

            Console.WriteLine("Digite o terceiro número: ");//IMPRIME NO CONSOLE
            num3 = Convert.ToInt32(Console.ReadLine());//RECEBE O TEXTO DIGITADO E CONVERTE

            //PROCESSAMENTO
            resultado = num1 * num2 * num3;//EXECUTA A MULTIPLICAÇÃO
            Console.WriteLine("A multiplicação vale: " + resultado);//IMPRIME O RESULTADO NO CONSOLE

            //SAIDA
            Console.ReadKey();//PERMITE QUE CONSOLE FIQUE ABERTO
        }
    }
}
