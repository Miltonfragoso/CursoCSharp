using System;

namespace _19___EstruturaCondicionalIfElse
{
    internal class Program
    {
        /*A estrutura condicional pode ser simples, composta ou encadeada
         if(condição){
               comando
           }
          else {
                comando
            } 
          se condição for verdadeira executa o comando e pula fora
          se não, executa o comando do else
         else if = coloca outra condição 
         */
        static void Main(string[] args)
        {
            // simples 
            int x = 10;

            Console.WriteLine("Bom dia ");

            if (x < 5)
            {
                Console.WriteLine("Boa tarde ");
            }

            Console.WriteLine("Boa noite");


            // composta
            Console.WriteLine("Entre com um número inteiro");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            // Encadeada
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora <= 23)
            {
                Console.WriteLine("Boa noite");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
/*Nota: se o bloco de comandos possuir apenas um comando, as chaves são opcionais.*/