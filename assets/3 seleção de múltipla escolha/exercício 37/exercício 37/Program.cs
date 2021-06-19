using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_37
{
    class Program
    {
        static void Main(string[] args)
        {
            /*USO DO SWITCH CASE
             */
            //ENTRADA
            int op, quantidades_de_calorias = 0;//valor inicial
            Console.WriteLine("Restaurante -A XEPA");
            Console.WriteLine("Veja a assinale suas opções de refeição");

            //PRATO PRINCIPAL
            Console.WriteLine("PRATO PRINCIPAL");
            Console.WriteLine("-----------------");
            Console.WriteLine("1 Vegetariano");
            Console.WriteLine("2 Peixe");
            Console.WriteLine("3 Frango");
            Console.WriteLine("4 Carne");
            Console.WriteLine("-----------------");
            Console.WriteLine("Digite o número de sua prefência: ");
            Console.WriteLine("Ou 0 para nenhuma OPÇÃO ");
            op = Convert.ToInt32(Console.ReadLine());
            //PROCESSAMENTO switch ==> Escolha de opção inteira ou caractere
            switch (op) 
            {
                //a += b; a = a + b;
                case 1://quantidade_de_calorias = quantidade_de_calorias + 180;
                    quantidades_de_calorias += 180; break;

                case 2:
                    quantidades_de_calorias += 230; break;

                case 3:
                    quantidades_de_calorias += 250; break;
                case 4:
                    quantidades_de_calorias += 350; break;
                default:
                    quantidades_de_calorias = 0; break;


            }

            //SOBREMESA
            Console.WriteLine("SOBREMESA");
            Console.WriteLine("-----------------");
            Console.WriteLine("1 Abacaxi");
            Console.WriteLine("2 Sorvete diet");
            Console.WriteLine("3 Mousse diet");
            Console.WriteLine("4 mousse");
            Console.WriteLine("Digite qualquer outro n° se não quiser alguma das opções acima");
            Console.WriteLine("-----------------");
            Console.WriteLine("Digite o número de sua preferência: ");
            Console.WriteLine("Ou 0 para nenhuma OPÇÃO ");

            op = Convert.ToInt32(Console.ReadLine());

            //PROCESSAMENTO switch ==> Escolha de opção inteira ou caractere
            switch (op)
            {
                //a += b; a = a + b;
                case 1://quantidade_de_calorias = quantidade_de_calorias + 180;
                    quantidades_de_calorias += 75; break;

                case 2:
                    quantidades_de_calorias += 110; break;

                case 3:
                    quantidades_de_calorias += 170; break;
                case 4:
                    quantidades_de_calorias += 200; break;
                default:
                    quantidades_de_calorias = 0; break;


            }

            //BEBIDA
            Console.WriteLine("BEBIDA");
            Console.WriteLine("-----------------");
            Console.WriteLine("1 Chá");
            Console.WriteLine("2 Suco de Laranja");
            Console.WriteLine("3 Suco de Melão");
            Console.WriteLine("4 Refrigerante diet");
            Console.WriteLine("Digite qualquer outro n° se não quiser alguma das opções acima");
            Console.WriteLine("-----------------");
            Console.WriteLine("Digite o número de sua preferência: ");
            Console.WriteLine("Ou 0 para nenhuma OPÇÃO ");

            op = Convert.ToInt32(Console.ReadLine());

            //PROCESSAMENTO switch ==> Escolha de opção inteira ou caractere
            switch (op)
            {
                //a += b; a = a + b;
                case 1://quantidade_de_calorias = quantidade_de_calorias + 180;
                    quantidades_de_calorias += 20; break;

                case 2:
                    quantidades_de_calorias += 70; break;

                case 3:
                    quantidades_de_calorias += 100; break;
                case 4:
                    quantidades_de_calorias += 65; break;
                default:
                    quantidades_de_calorias = 0; break;
            }

            Console.WriteLine("Quantidade de calorias da refeição: " + quantidades_de_calorias + " Cal");

            //SAIDA
            Console.ReadKey();

        }
    }
}
