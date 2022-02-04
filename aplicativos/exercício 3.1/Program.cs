using System;

namespace exercício3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA --> divisão por real
            double num1, num2, resultado;
            Console.WriteLine("Divião de dois números reais...");//RECEBE O VALOR A SER DIVIDIDO
            Console.WriteLine("Digite o valor do dividendo: ");//RECEBE O VALOR A SER DIVIDIDO
            num1 = Convert.ToDouble(Console.ReadLine());//CONVERTE

            Console.WriteLine("Digite o valor do divisor: ");//RECEBE O VALOR A DIVIDIR
            num2 = Convert.ToDouble(Console.ReadLine());//RECEBE O VALOR DO DIVISOR

            //PROCESSAMENTO
            resultado = num1 / num2;
            //Math.Round (Variável de casas decimais)
            Console.WriteLine("A divisão vale: " + Math.Round(resultado, 2));
            Console.WriteLine(num1 + "/" + num2 + " = " + Math.Round(resultado, 2));//INTERPOLAÇÃO

            //SAIDA
            Console.ReadKey();
        }
    }
}
