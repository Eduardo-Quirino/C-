using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba dois números, calcule e mostre a subtração do primeiro */

            //ENTRADA
            int num1, num2, soma;
            Console.WriteLine("Soma de dois números inteiros");//INFORMA NA TELA
            Console.WriteLine("Digite o 1º número: ");//RECEBE O QUE FOI DIGITADO NA VARIAVEL NUM1
            num1 = Convert.ToInt32(Console.ReadLine());//CONVERTE O QUE FOI DIGITADO PARA TIPO INTEIRO --> Console.ReadLine SEMPRE QUE FOR DIGITADO ALGO NO CONSOLE
            Console.WriteLine("Digite o 2º número: "); //RECEBE O QUE FOI DIGITADO NA VARIAVEL NUM2
            num2 = Convert.ToInt32(Console.ReadLine());//CONVERTE O QUE FOI DIGITADO PARA TIPO INTEIRO--> Console.ReadLine SEMPRE QUE FOR DIGITADO ALGO NO CONSOLE

            // PROCESSAMENTO
            soma = num1 + num2;
            Console.WriteLine("A soma vale: " + soma);

            //SAIDA
            Console.ReadKey();

        }
    }
}
