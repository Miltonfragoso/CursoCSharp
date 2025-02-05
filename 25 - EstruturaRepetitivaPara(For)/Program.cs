using System;

namespace _25___EstruturaRepetitivaPara_For_
{
    internal class Program
        {   /*A estrutura de repetição FOR, usamos quando conhecemos a quantidade de repetição ou uma contagem
             * for(início; condição; incremento){
             * comando 1
             * comando 2
             * }
             * 
             * 
             * início = começo da contagem, Executa só na primeira vez
             * condição = enquanto a condição for verdadeira executa e volta
             * incremento = acrescenta de um em um o numero do começo da contagem toda vez que voltar
             */




            /*Fazer um programa que pergunta quantos números inteiros serão digitados 
             em seguida digita a quantidade de números respondido na primeira questão e
             mosta o resultado da soma destes números*/
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos números inteiros você vai digitar? ");
                int N = int.Parse(Console.ReadLine());


                int soma = 0;
                for (int i = 1; i <= N; i++)
                {
                    /*placeholder*/
                    Console.Write("Valor #{0}: ", i);
                    int valor = int.Parse(Console.ReadLine());
                    soma += valor;

                }

                Console.WriteLine("Soma = " + soma);
            }
            
        }
    }
}
