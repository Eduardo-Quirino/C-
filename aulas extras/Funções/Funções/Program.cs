using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada


            //Processamento
            exibirMsg();//exile msg da função criada em static void exibirMsg()
            gerarPreco(100, "aulas C#");//passando parametro do preço
            gerarPreco(50, "aulas de PHP");
            //Saida
            Console.ReadLine();


        }
        //criando uma nova função void=> sem retorno
        //função de mensagens 
        static void exibirMsg()
        {
            Console.WriteLine("Bem vindo ao meu espaço de estudo!");
            Console.WriteLine("Eduardo Quirino ");
          
        }
        //função de valores
        static void gerarPreco(int preco, string nome)//criando parâmetro só funciona dentro da função
        {
            Console.WriteLine("Nome do produto: "+ nome );//nome do produto concatenado
            Console.WriteLine(preco);
        } 

    }
}
