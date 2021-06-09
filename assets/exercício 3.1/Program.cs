using System;

namespace exercício3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Divisão
double num1, num2, resultado;
Console.WriteLine("Divisão de dois números reais...");
Console.WriteLine("Digite o valor do dividendo: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do divisor: ");
num2 = Convert.ToDouble(Console.ReadLine());
resultado = num1 / num2;
// Math.Round(variável, nº de casas decimais)
Console.WriteLine("A divisão vale: " + Math.Round(resultado,2));
Console.WriteLine(num1 + " / "+ num2 + " = " + Math.Round(resultado, 2));
Console.ReadKey();        }
    }
}
