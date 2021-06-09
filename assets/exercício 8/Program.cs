using System;

namespace exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {

    //double é uma variável real
double b, altura, volume;
Console.WriteLine("Cálculo do Volume de uma Pirâmide");
Console.WriteLine("Digite a área da base da pirâmide: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura da pirâmide: ");
altura = Convert.ToDouble(Console.ReadLine());
volume = b * altura / 3;
Console.WriteLine("O volume da pirâmide é: " + volume);
Console.ReadKey();
}        }
    }

