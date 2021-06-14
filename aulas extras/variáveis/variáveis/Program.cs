using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //--> Int-inteiros (-156 como 32456)  
            //--> Float-flutuantes com casas decimais ==> Double / Decimal(1.45 como 14.000)
            //--> Bool-boleano- true ou false
            //--> String- " texto "
            //--> Char- 'caracter'

            //Entrada de Variáveis
            int segundaGuerraMundial = 1942;//Número inteiro
            string corFavorita = "Azul";//Tipo texto
            float velocidadeF1 = 260.77f;//para indicar que é float colocar f no fim da expleção 
            bool segundaGuerraMundialAconteceu = true;

            // Processamento
            Console.WriteLine("Ano da segunda guerra mundial: "+segundaGuerraMundial);
            Console.WriteLine("Cor favorita: "+corFavorita);
            Console.WriteLine("Velocidade do F1: "+velocidadeF1);
            Console.WriteLine("Aconteceu a segunda guerra mundial? "+segundaGuerraMundialAconteceu);

            //Saida
            Console.ReadLine();
        }
    }
}
