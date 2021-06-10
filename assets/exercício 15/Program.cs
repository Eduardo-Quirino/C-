using System;

namespace exercício_15
{
    class Program
    {
        static void Main(string[] args)
        {
int tempo, horas, minutos, segundos;
//Entrada
Console.WriteLine("Conversão de tempo a horas, minutos e segundos...");
Console.WriteLine("Digite um intervalo de tempo, e segundos: ");
tempo = Convert.ToInt32(Console.ReadLine());
//Processamento
horas = tempo / 3600;
minutos = (tempo % 3600) / 60;
segundos = (tempo % 3600) % 60;
//Saida
Console.WriteLine(tempo + "segundos, equivalem a: ");
Console.WriteLine(horas + "h, "+minutos+ "min e "+segundos+"seg");
Console.ReadKey();

        }
    }
}
