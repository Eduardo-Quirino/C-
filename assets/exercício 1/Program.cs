using System;

namespace exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
int num1, num2, soma;
Console.WriteLine("Soma de dois números inteiros");
Console.WriteLine("Digite o 1º número: ");
//Leitura da variável num1
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o 2º número: ");
//Leitura da variável num2
num2 = Convert.ToInt32(Console.ReadLine());
soma = num1 + num2;
Console.WriteLine("A soma vale: " + soma);
Console.ReadKey();        }
    }
}
