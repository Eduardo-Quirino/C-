/*
 * Criado por SharpDevelop.
 * Usuário: edu35
 * Data: 16/06/2021
 * Hora: 13:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exercício_29
{
	class Program
	{
		public static void Main(string[] args)
		{
double preco_produto, aumento, novo_preco;
Console.WriteLine("Aumento de Preços e Classificação dos Preços");
Console.WriteLine("Digite o preço do produto, em R$:");
preco_produto = Convert.ToDouble(Console.ReadLine());
if(preco_produto <= 50) { aumento = 0.05 * preco_produto; }
else if(preco_produto <= 100) { aumento = 0.10 * preco_produto; }
else { aumento = 0.15 * preco_produto; }
novo_preco = preco_produto + aumento;
if(novo_preco <= 80) { Console.WriteLine("Novo Preço = R$ " + Math.Round(novo_preco,2) + " - BARATO"); }
else if(novo_preco <= 120){ Console.WriteLine("Novo Preço = R$ " + Math.Round(novo_preco, 2) + " - NORMAL"); }
else if(novo_preco <= 200){ Console.WriteLine("Novo Preço = R$ " + Math.Round(novo_preco, 2) + " - CARO"); }
else{ Console.WriteLine("Novo Preço = R$ " + Math.Round(novo_preco, 2) + " - MUITO CARO");}
Console.ReadKey();	
		}
	}
}