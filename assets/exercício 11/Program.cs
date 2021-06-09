using System;

namespace exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double L1, L2, L3, T, area;
Console.WriteLine("Área de um triângulo - Fórmula de Herão");
Console.WriteLine("Digite o valor do 1º lado do triângulo: ");
L1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do 2º lado do triângulo: ");
L2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do 3º lado do triângulo: ");
L3 = Convert.ToDouble(Console.ReadLine());
T = (L1 + L2 + L3) / 2;
//Math.sqrt(x) é a raiz quadrada de x
area = Math.Sqrt(T*(T-L1)*(T-L2)*(T-L3));
Console.WriteLine("A área do triângulo vale: " + area);
Console.ReadKey();
}       
 }
    }

