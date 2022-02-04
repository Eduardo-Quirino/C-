using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba dois números, calcule e mostre a divisão do primeiro número pelo segundo, Sabe que o segundo número não pode ser zero, portanto não é necessário se preocupar com validações.*/
            // multiplicação

            //ENTRADA --> divisão por real
            double num1, num2, resultado;
            Console.WriteLine("Divião de dois números reais...");//RECEBE O VALOR A SER DIVIDIDO
            Console.WriteLine("Digite o valor do dividendo: ");//RECEBE O VALOR A SER DIVIDIDO
            num1 = Convert.ToDouble(Console.ReadLine());//CONVERTE

            Console.WriteLine("Digite o valor do divisor: ");//RECEBE O VALOR A DIVIDIR
            num2 = Convert.ToDouble(Console.ReadLine());//RECEBE O VALOR DO DIVISOR

            //PROCESSAMENTO
            resultado = num1 / num2;
           //Math.Round (Variável de casas decimais)

            Console.WriteLine("A divisão vale: "+resultado);
            Console.WriteLine(num1+ "/"+num2+ " = "+ resultado);//INTERPOLAÇÃO

            //SAIDA
            Console.ReadKey();

        }
    }
}
