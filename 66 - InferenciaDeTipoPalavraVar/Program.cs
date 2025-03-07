/*A variável var recebe o tipo conforme o valor atribuido inferindo nela o tipo string bool ou int.
 */

using System;

namespace InferenciaDeTipoPalavraVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20.0;
            var z = "Milton";


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
