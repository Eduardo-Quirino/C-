using System;

namespace exercício3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // conversão de tempo(segundos)
int h, m, s, total;
Console.WriteLine("Conversão de Tempo a Segundos....");
Console.WriteLine("Digite uma quantidade de horas:");
h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite uma quantidade de minutos:");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite uma quantidade de segundos:");
s = Convert.ToInt32(Console.ReadLine());
total = h * 3600 + m * 60 + s;
Console.WriteLine("Total, convertido = " + total + " segundos");        }
    }
}
