using System;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.ReadLine(); Lê da entrada padrão (teclado) até a quebra de linha (Enter)
             Retorna os dadosn lidos na forma de string*/

            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            /*Escrever uma frase e armazenar cada palavra em uma variável
             usamos o comando split('') que é uma função que serve para recortar uma string*/

            string[] V = Console.ReadLine().Split(' ');
            string a = V[0];
            string b = V[1];
            string c = V[2];

            Console.WriteLine("você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
