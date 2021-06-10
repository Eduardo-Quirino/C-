using System;

namespace exercício_17
{
    class Program
    {
        static void Main(string[] args)
        {
        int saque, n100, n50, n20, n10, n5, n2, n1;
            //Entrada
            Console.WriteLine("Saque num caixa eletrônico");
            saque = Convert.ToInt32(Console.ReadLine());
            //Processamento
            n100 = saque / 100;
            n50 = (saque % 100) / 50;
            n20 = ((saque % 100) % 50) / 20;
            n10 = (((saque % 100) % 50) % 20) / 10;
            n5 = ((((saque % 100) % 50) % 20) % 10) / 5;
            n2 = (((((saque % 100) % 50) % 20) % 10) % 5) / 2;
            n1 = (((((saque % 100) % 50) % 20) % 10) % 5) % 2;
            //Saídas
            Console.WriteLine("R$ " + saque + " fornecerão: ");
            Console.Write(n100 + " notas de 100, " + n50 + " notas de 50, ");
            Console.Write(n20 + " notas de 20, " + n10 + " notas de 10, ");
            Console.Write(n5 + " notas de 5, " + n2 + " notas de 2, ");
            Console.Write(" e " + n1 + " notas de 1 .");
            Console.ReadKey();        }
    }
}
