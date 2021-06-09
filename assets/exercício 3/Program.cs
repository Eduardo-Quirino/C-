using System;

namespace exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiplicação
int num1, num2, num3,resultado;
Console.WriteLine("Multiplicação de 3 números inteiros");
Console.WriteLine("Digite o 1º número: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o 2º número: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o 3º número: ");
num3 = Convert.ToInt32(Console.ReadLine());
resultado = num1 * num2 * num3;
Console.WriteLine("A multiplicação vale: " + resultado);
Console.ReadKey();  }
    }
}
