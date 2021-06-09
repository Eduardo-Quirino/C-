using System;

namespace exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
double tc, tf;
Console.WriteLine("Conversão de Temperatura de Farenheit a Celsius");
Console.WriteLine("Digite uma temperatura, em graus Farenheit: ");
tf = Convert.ToDouble(Console.ReadLine());
tc = 5 * (tf - 32) / 9;
Console.WriteLine(tf + "ºF equivalem a: " + Math.Round(tc,1) + "ºC");
Console.ReadKey();     
   }
    }
}
