using System;
using System.Globalization;

namespace ExerciciosEstruturaCondicionalIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/
            Console.WriteLine("--------------------EXERCÍCIO 1-----------------");
            Console.WriteLine("Digite um número inteiro.");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }

            Console.WriteLine("--------------------EXERCÍCIO 2-----------------");
            /*Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/
            Console.WriteLine("Digite um número inteiro.");
            int M = int.Parse(Console.ReadLine());
            if (M % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            Console.WriteLine("--------------------EXERCÍCIO 3-----------------");
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
             Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
             ordem crescente ou decrescente.*/
            Console.WriteLine("Digite os valores de A e B inteiros.");
            string[] line = Console.ReadLine().Split(' ');
            int A = int.Parse(line[0]);
            int B = int.Parse(line[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }

            Console.WriteLine("--------------------EXERCÍCIO 4-----------------");
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
              começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

            Console.WriteLine("Digite a hora inicial e a hora final do jogo.");
            string[] hora = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine(" O JOGO DUROU " + duracao + " HORA(S) ");

            Console.WriteLine("--------------------EXERCÍCIO 5-----------------");
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
              seguir, calcule e mostre o valor da conta a pagar.*/
            //CODIGO      ESPECIFICAÇÃO              PREÇO 
            // 1         Cachorro quente              R$ 4.00
            // 2             X-Salada                 R$ 4.50
            // 3             X-Bacon                  R$ 5.00
            // 4          Torrada Simples             R$ 2.00
            // 5            Refrigerante              R$ 1.50

            Console.WriteLine("Digite o código e a quantidade do item.");
            string[] CodigoQuantidade = Console.ReadLine().Split(' ');
            int codigo = int.Parse(CodigoQuantidade[0]);
            int quantidade = int.Parse(CodigoQuantidade[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



            Console.WriteLine("--------------------EXERCÍCIO 6-----------------");
            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
              seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
              nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/

            Console.WriteLine("Digite um número qualquer");
            double valor = double.Parse(Console.ReadLine());

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intervalo (0, 25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75, 100]");
            }


            Console.WriteLine("--------------------EXERCÍCIO 7-----------------");
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
             de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
             ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
             Se o ponto estiver na origem, escreva a mensagem “Origem”.
             Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
             situação.*/

            Console.WriteLine("Digite 2 valores decimais de x e y.");
            string[] valorxy = Console.ReadLine().Split(' ');
            double x = double.Parse(valorxy[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valorxy[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.WriteLine("--------------------EXERCÍCIO 8-----------------");
            /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
              que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
              qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
              Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
              mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.*/

            //                   Renda                                          Imposto de Renda
            // de 0.00 a R$ 2000.00                                                Insento
            // de 2000.01 a R$ 3000.00                                                8 %
            // de 3000.01 a 4500.00                                                   18 % 
            // acima de 4500.00                                                       28 %

            /* Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
             salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
             de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
             duas casas decimais.*/


            Console.WriteLine("Digite o valor do salario");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Insento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
