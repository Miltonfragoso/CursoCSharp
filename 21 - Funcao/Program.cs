/*Funções representam um processamento que possui um significado
 * Ex: 
 * Math.Sqrt(double)
 Console.WriteLine(string)

 Vantagens: modularização(dividir em partes menores), delegação do processamento e reaproveitamento usar a mesma função.

 Dados de entrada
Funções podem receber dados de entrada(parâmetros ou argumentos)
Funções podem ou não retornar uma saída


 Em orientação a objetos, funções em classes recebem o nome de métodos*/
using System;

namespace _21___Funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.*/

            Console.WriteLine("Digite 3 números inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //lógica com estrutura condicional
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }
            Console.WriteLine("----------------------------------");

            // chamando a função
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }

                // vamos criar uma função "Maior" para separar a lógica
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

        }
    }
}
