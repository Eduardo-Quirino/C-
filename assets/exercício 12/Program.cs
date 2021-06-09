using System;

namespace exercício_12
{
    class Program
    {
 static void Main(string[] args)
{
    double xA, xB, yA, yB, distancia;
Console.WriteLine("Distância entre dois pontos A e B");
Console.WriteLine("Digite a abcissa do ponto A (xA): ");
xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a ordenada do ponto A (yA): ");
yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a abcissa do ponto B (xB): ");
xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a ordenada do ponto B (yB): ");
yB = Convert.ToDouble(Console.ReadLine());
distancia = Math.Sqrt(Math.Pow(xB-xA,2) + Math.Pow(yB-yA,2));
Console.WriteLine("A distância entre os pontos A e B vale: " + distancia);
Console.ReadKey();
} 
}
    }

