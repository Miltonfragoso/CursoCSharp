

/*Laço Forrach: é uma sintaxe opcional e simplificada para percorrer coleções*/


using System;

namespace LacoForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] vect = new string[] { " Milton ", " Bob ", " Danilsa ", "Yhaminah"  };

            //percorrer o vetor com o for e mostrar os nomes nas posições
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            //percorrer o vetor com o FOREACH

            //sintaxe: foreach + tipo do vetor nesse caso String + um apelido nesse caso nome + no meu vetor
            foreach (string nome in vect) { 
                Console.WriteLine(nome);
            }
        }
    }
}
