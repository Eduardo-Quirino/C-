using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercícios_87
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 4° Parte
          
          */
            //ENTRADA
            String[] nomes = new String[5];
            double[] precos = new double[5];
            int i, qtde_precos_menor_50 = 0, contador_precos_entre_50_e_100 = 0;
            double media_precos_maiores_que_100, contador_precos_maiores_que_100 = 0;
            double soma_precos_maiores_que_100 = 0;
            Console.WriteLine("Nomes e Preços de 5 Produtos...");

            //PROCESSAMENTO
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite nome[" + i + "]: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite precos[" + i + "]: ");
                precos[i] = Double.Parse(Console.ReadLine());
                if (precos[i] < 50) { qtde_precos_menor_50++; }
                else if (precos[i] < 100) { contador_precos_entre_50_e_100++; }
                else { contador_precos_maiores_que_100++; soma_precos_maiores_que_100 += precos[i]; }
            }
            Console.Clear();
            Console.WriteLine("Lista de Produtos - Preços Respectivos");
            for (i = 0; i < 5; i++) { Console.WriteLine(nomes[i] + " - " + precos[i]); }
            Console.WriteLine("\n\nHá " + qtde_precos_menor_50 + " produtos que valem menos de R$50");
            if (contador_precos_entre_50_e_100 > 0)
            {
                Console.WriteLine("Produtos com preços entre R$ 50 e R$ 100:\n");
                for (i = 0; i < 5; i++)
                {
                    if (precos[i] > 50 && precos[i] < 100)
                    {
                        Console.WriteLine(nomes[i] + " - " + precos[i]);
                    }
                }
            }
            else { Console.WriteLine("Não há produtos entre R$50 e R$100"); }
            if (contador_precos_maiores_que_100 > 0)
            {
                media_precos_maiores_que_100 = soma_precos_maiores_que_100 / contador_precos_maiores_que_100;
                Console.WriteLine("Média dos preços maiores que R$100 = R$ " + Math.Round(media_precos_maiores_que_100, 2));
            }
            else { Console.WriteLine("Não há produtos com preços maiores que R$100"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
