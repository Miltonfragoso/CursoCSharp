/*
 * Espressão ternária é uma sintaxi opcional do if else, quando se deseja decidir um valor com base em uma condição
 */

using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto;
            if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.5;
            }
            Console.WriteLine(desconto);
            Console.WriteLine();

            //sintaxe
            //(condição) ? valor_se_verdadeiro : valor_ se_falso
            double descontoTernario = (preco < 20) ? preco * 0.1 : preco * 0.5;
            Console.WriteLine("Desconto ternário = " + descontoTernario);
        }
    }
}
