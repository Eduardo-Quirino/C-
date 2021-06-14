using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variáveis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tipos  
--> Dynamic-permite valores de vários tipos diferentes 
 */
            /*Tipo --> Nome variável --> valor a receber */

            //Entrada 
            dynamic corFavorita = "Dourado";

            //Processamento 1
            Console.WriteLine(corFavorita);
            //Alterando valores da variável
            corFavorita = "Neon";

           
          
        }
    }
}
