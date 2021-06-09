using System;

namespace exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
double pole, milim;
Console.WriteLine("Conversão de Polegadas a Milímetros");
Console.WriteLine("Digite o valor, em polegadas: ");
pole = Convert.ToDouble(Console.ReadLine());
milim = pole * 25.4;
Console.WriteLine(pole + " pol. = " + milim + " mm.");
Console.ReadKey();
} }
}
