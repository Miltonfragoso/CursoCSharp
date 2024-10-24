using System;
using System.Globalization;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* As variáveis são usadas para guardar informação durante a execução de uma aplicação.
             * quando a aplicação termina o valor da variável deixa de existir
             * as variáveis são como caixas preparadas para receber um determinado tipo de dados.
             */

            int N1 = 0;
            char letra = 'a';
            float valor = 5.3f;
            double valor1 = 5.3;
            decimal valor3 = 5.3M;
            string nome = "Milton Fragoso";
            byte num = 10; //0 e 255
            bool completo = false;
            object obj1 = "Maria";

            Console.WriteLine(N1);
            Console.WriteLine(letra);
            Console.WriteLine(valor);
            Console.WriteLine(valor1);
            Console.WriteLine(valor3);
            Console.WriteLine(num);
            Console.WriteLine(completo);
            Console.WriteLine(obj1);


            // o tipo var é definido pelo valor atribuido na compilação
            var aux = 10;

            //para ler o valor em uma variável
            Console.WriteLine("O valor na variável nome é:" + nome);


            int num1, num2, res;

            num1 = 10;
            num2 = 10;
            res = num1 * num2;
            Console.WriteLine("A multiplicação de " + num1 + " mais " + num2 + " é igual a : " + res);


            //Saída de dados
            Console.Write("Bom dia!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");

            char genero = 'F';
            int idade = 50;
            double saldo = 10.35460;
            string Nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(Nome);


            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais ", Nome, idade, saldo);
            //Concatenação
            Console.WriteLine(Nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
            //Interpolação
            Console.WriteLine($"{Nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
        }
    }
}
