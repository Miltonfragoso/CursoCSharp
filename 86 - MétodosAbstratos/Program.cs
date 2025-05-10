/*
 * Métodos abstratos: são métodos que não possuem implementação. quando a classe for genérica demais para conter sua implementaçãao.
 * 
 * No diagrama UML as classes e os métodos abstratos são escritos com itálico que significa que se trata de uma classe ou um método abstrato.
 * 
 * Se uma classe possuir pelo menos um método abstrato, então esta classe também é abstrata.
 * 
 * O método abstrato já traz o override sem o virtua.
 * 
 * No diagrama a baixo vemos uma classe abstrata FIGURA com o atributo cor e um método abstrato area, uma classe RETANGULOe uma CIRCULO.
 * O método abstrato surge porque calcular a area de uma figura é muito generico, não sabemos de que figura se trata. Já nas outras classes sabemos,
 * por isso ele não possui implementação, somente será feito nas subclasses.
 * 
 */

//   FIGURA                      RETANGULO                    CIRCULO                      <<enum>>
//------------------       -------------------        --------------------                    Cor
//  - cor                   - Largura: Double            - raio                            Preto: int 
//                          - altura: Double                                               azul: int
//------------------       --------------------       --------------------                 vermelho: int
//  +area() Double

/*
 * Fazer um programa para ler os dados de N figuras (N fornecido pelo usuário), 
 * e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas.
 */
using MétodosAbstratos.Entities;
using MétodosAbstratos.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MétodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();

            Console.Write("Insira a aquantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da figura #{i}: ");

                Console.Write("Retangulo ou circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Qual é a cor? (Preto/Azul/Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Informe o valor da largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Informe o valor da altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Retangulo(cor, largura, altura));
                }
                else
                {
                    Console.Write("Informe o valor do raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circulo(cor, raio));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Areas das figuras: ");
            foreach (Figura f in list)
            {
                Console.WriteLine(f.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
