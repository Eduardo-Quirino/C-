using System;

namespace exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta;
Console.WriteLine("Cálculo do Discriminante (delta): ");
Console.WriteLine("da equação de 2º grau ax² + bx + c = 0");
Console.WriteLine("");
Console.WriteLine("Digite o valor de a: ");
A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de b: ");
B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de c: ");
C = Convert.ToDouble(Console.ReadLine());
delta = Math.Pow(B, 2) - 4 * A * C;
Console.WriteLine("O discriminante (delta) vale: " + delta);
Console.ReadKey();
        }
    }
} 