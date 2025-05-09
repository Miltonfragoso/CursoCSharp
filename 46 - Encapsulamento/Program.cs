/*     ---------------------        OS 3 PILARES DA PROGRAMAÇÃO ORIENTADA A OBJETOS   ----------------------------   *
 *                                                            EMCAPSULAMENTO
 *                                                               HERANÇA
 *                                                             POLIMORFISMO   
 */

/*• EMCAPSULAMENTO PRIMEIRO PILAR DA ORIENTAÇÃO A OBJETO
 * é um princípio que consiste em
esconder detalhes de implementação
de um componente, expondo apenas
operações seguras e que o mantenha
em um estado consistente.
• Regra de ouro: o objeto deve sempre
estar em um estado consistente, e a
própria classe deve garantir isso.*/

/* Opção 1: implementação manual
• Todo atributo é definido como private
• Implementa-se métodos Get e Set para cada atributo, conforme
regras de negócio
• Nota: não é usual na plataforma C#*/

using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
