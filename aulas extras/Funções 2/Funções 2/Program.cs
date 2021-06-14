using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada 
            exibirMsg();
            gerarPreco(60);
            gerarPreco(30);
            gerarPreco(20);
            gerarPreco(-20);
            gerarPreco(-20223);
            gerarPreco(-3);




            //Processamento

            //Saida

            Console.ReadLine();

        }
        static void gerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);  //preço ABSOLUTO traz um valor negativo em positivo
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: "+ valorFinal);
        }

        //criando uma nova função void=> sem retorno
        //função de mensagens 
        static void exibirMsg()
        {
            Console.WriteLine("Bem vindo ao meu espaço de estudo!");
            Console.WriteLine("Eduardo Quirino ");

        }

    }

}
