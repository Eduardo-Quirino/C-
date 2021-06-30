using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_66
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 3°parte
         Crie um algoritmo que leia a idade e o sexo de 6 pessoas e
            mostre:
            - A média das idades
            - A porcentagem de maiores de idade
            - A porcentagem de menores de idade
            - A porcentagem de mulheres, maiores de idade.
            SUGESTÃO:

            Variável sexo pode ser inteira. Ex: Sexo [ 0 – M | 1 – F]
          */

            double i, media_de_idades, soma_de_idades = 0, idade, contador_mulheres_maiores = 0;
            double contador_maiores_de_idade = 0, contador_menores_de_idade = 0;
            double porc_maiores, porc_menores, porc_mulheres_maiores;
            char sexo;
            Console.WriteLine("Idade e Sexo de 6 pessoas...");
            for (i = 1; i <= 6; i++)
            {
                Console.WriteLine("Digite a idade da " + i + "ª pessoa:");
                idade = Double.Parse(Console.ReadLine());
                soma_de_idades += idade;
                if (idade >= 18) { contador_maiores_de_idade++; }
                else { contador_menores_de_idade++; }
                Console.WriteLine("Digite o sexo da " + i + "ª pessoa: [M|F] ");
                sexo = Convert.ToChar(Console.ReadLine());
                if (idade >= 18 && (sexo == 'F' || sexo == 'f')) { contador_mulheres_maiores++; }
            }
            Console.Clear();//Limpa a tela do Console
            media_de_idades = soma_de_idades / 6;
            porc_maiores = 100 * (contador_maiores_de_idade) / 6;
            porc_menores = 100 * (contador_menores_de_idade) / 6;
            porc_mulheres_maiores = 100 * (contador_mulheres_maiores) / 6;
            Console.WriteLine("Média das idades digitadas: " + Math.Round(media_de_idades, 1));
            Console.WriteLine("Porcentagem de maiores de idade: " + Math.Round(porc_maiores, 1) + " %");
            Console.WriteLine("Porcentagem de menores de idade: " + Math.Round(porc_menores, 1) + " %");
            Console.WriteLine("Porcentagem de mulheres, maiores de idade: " + Math.Round(porc_mulheres_maiores, 1) + " %");
            Console.WriteLine("\n\nDigite qualquer tecla para sair do programa....");
            Console.ReadKey();
        }
    }
}
