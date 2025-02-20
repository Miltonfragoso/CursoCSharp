/*
 * CLASSES: são tipos referência=> Variáveis cujo o tipo são classes não devem ser entendidas como caixas, 
 * mas ssim como ponteiros que apontam para as caixas.
 * 
 * EX: Product p1, p2 ; Na memória em uma área chamada Stack é criado duas variáveis que irão apontar em outra área 
 * da memória chamada heap onde sera criado propriamente as caixas do objeto quando, instanciarmos o objeto 
 * com o comando: p1 = new Product("TV", 900.00, 0). quando as caixinhas forem criada na Heap ele terá um endereço de 
 * memória, esse número será passado para a variável p1 da Stack significando que p1 da Stack esta apontando para a caixa 
 * na Heap que contem esse número, o endereço da memoria.
 * 
 * e se p2 receber o número de memoria de p1?
 * E se p2 = p1? R: p2 vai receber o mesmo número com o endereço da memória, e passara a apontar para a mesma caixinha
 * onde tem o objeto.
 * 
 *Tipos referência aceitam valor "null" significando que a variável não esta apontando para nenhuma caixinha na Heap 
 * 
 * 
 * ---------------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * Tipos valores ou Structs: tipos structs ou tipos valores são caixinhas com os seu valores criados na memória Stack quando declaramos uma variável do tipo
 * int, double, float, DateTime, TimeSpan, etc. menos as variáves do tipo CLASSE. 
 * 
 * Ex: double x, y;  x = 10; Na Stack a caixinha recebe direto o valor 10 e não um endereço que esteja na Heap.
 * 
 * e se y receber o valor de x?
 * E se y = x ?  R: y vai receber uma copia do valor que esta na caixa de x nesse caso o 10 também na Stack
 * 
 * Para os tipos valores nada é criado na parte da memória chamada de Heap, somente na Stack.
 * 
 * 
 * 
 * -----------------------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * 
 * Valores padrão: 
• Quando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos
• números: 0
• bool: False
• char: caractere código 0
• objeto: null
• Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", e o próprio compilador não permite que ela seja acessada.
 */
using System;

namespace TiposReferenciaTiposValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Podemos também criar nossas propias variáveis do tipo Structs assim como as Classes.
             * Vamos criar uma variável do tipo structs para representar dois pontos no plano cartesiano x,y
             * 
             * Quando criamos um variável do tipo Structs também precisamos inicializar a variável
            */

            Point p;

            //para inicializar a variável podemos atribuir valores direto.
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            //Também podemos inicializar desta forma pois tipo Structs aceita o comando new, porém com valores zero.
            Point p2 = new Point();

            Console.WriteLine(p2);
        }
    }
}
