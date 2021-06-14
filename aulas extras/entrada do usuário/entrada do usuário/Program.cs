using System;

namespace entrada_do_usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            string nome = ""; //cria variável para receber dados digitados  
            Console.WriteLine("Escreva seu nome: ");//pergunta na tela

            //Processamento
            nome = Console.ReadLine();//recebe os dados digitados
            Console.WriteLine("Sejá bem vindo ao C# : ");
            Console.WriteLine(nome);//imprime texto digitado

            //Saida
            Console.ReadLine();


        }
    }
}
