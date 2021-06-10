using System;

namespace exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {
   int garrafas, caixas, sobra;
            //Entrada
            Console.WriteLine("Garrafas e Caixas de Cerveja");
            Console.WriteLine("Digite a quantidade de garrafas de cerveja a embalar:");
            garrafas = Convert.ToInt32(Console.ReadLine());
            //Processamento
            caixas = garrafas / 24;
            sobra = garrafas % 24;// % é o operador de resto da divisão inteira
            //Saída
            Console.Write("Serão necessárias " + caixas + " caixas de cerveja");
            Console.WriteLine(" e sobrarão " + sobra + " garrafas sem embalar....");
            Console.ReadKey();        }
    }
}
