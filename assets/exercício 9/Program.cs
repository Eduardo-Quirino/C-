using System;

namespace exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
     double raio, altura, area, volume;
Console.WriteLine("Área e Volume de um Cilindro");
Console.WriteLine("Digite o raio do cilindro: ");
raio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do cilindro: ");
altura = Convert.ToDouble(Console.ReadLine());
area = 2 * Math.PI * (altura + raio);
volume = Math.PI * Math.Pow(raio, 2) * altura;
Console.WriteLine("A área do cilindro é: " + Math.Round(area,2));
Console.WriteLine("O volume do cilindro é: " + Math.Round(volume, 2));
Console.ReadKey();
  }
    }
}
