using System;

namespace exercício_16
{
    class Program
    {
        static void Main(string[] args)
        {

    int tempo, anos, meses, semanas, dias;
            //Entrada
            Console.WriteLine("Conversão de dias em anos, meses, semanas e dias....");
            Console.WriteLine("Digite um intervalo de tempo, em dias: ");
            tempo = Convert.ToInt32(Console.ReadLine());
            //Processamento
            anos = tempo / 365;
            meses = (tempo % 365) / 30;
            semanas = ((tempo % 365) % 30) / 7;
            dias = (((tempo % 365) % 30)) % 7;
            //Saída
            Console.WriteLine(tempo + " dias, equivalem, APROXIMADAMENTE, a: ");
            Console.Write(anos + " anos, " + meses + " meses, " + semanas + " semanas e ");
            Console.WriteLine(dias + " dias...");
            Console.ReadKey();    }
    }
}
