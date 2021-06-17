using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_21
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double trabalho, lab, prova, faltas, media;
            Console.WriteLine("Relatório de Notas do Semestre (notas de 0 a 10):");
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova escrita: ");
            prova = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do teste em laboratório: ");
            lab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o nº de faltas: ");
            faltas = Convert.ToDouble(Console.ReadLine());
            if (faltas <= 16)
            { //Aluno tem presença suficiente para calcular suas notas
                media = (trabalho * 2 + lab * 2 + prova * 6) / 10;
                if (media >= 7)
                {
                    Console.WriteLine(nome + " está aprovado, com média " + media);
                }
                else if (media >= 5)
                {
                    Console.WriteLine(nome + " está de EXAME e precisa de " + (10 - media) + " para aprovar ....");
                }
                else { Console.WriteLine(nome + " foi reprovado (a), com média " + media); }
            }
            else { Console.WriteLine(nome + " foi reprovado (a) por faltas!!!"); }

            //Saida
            Console.ReadKey();
        }
    }
}
