using System;
using System.Globalization;

namespace _24___ExerciciosEstruturaRepetitivaEnquanto_While_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
              incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
              impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            */


            Console.WriteLine("-----------------------EXERCÍCIO 1 -----------------------------------------------");

            Console.WriteLine("Entrada: ");
            int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Entrada: ");
                senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Acesso Permitido");
            Console.WriteLine();

            Console.WriteLine("-----------------------EXERCÍCIO 2 -----------------------------------------------");

            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
              cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
              menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
            */

            Console.WriteLine("Entrada: ");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse((string)valores[0]);
            int y = int.Parse((string)valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");

                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                valores = Console.ReadLine().Split(" ");
                x = int.Parse((string)valores[0]);
                y = int.Parse((string)valores[1]);
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------EXERCÍCIO 3 -----------------------------------------------");

            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
              um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
              4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
              que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
              mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
              exemplo.
            */

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Entrada: ");
            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }
                Console.WriteLine("Entrada: ");
                tipo = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
