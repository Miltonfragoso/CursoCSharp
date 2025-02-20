

/*Suponha que se queira uma calculadora para calcular a soma de uma quantidade variável de valores
 Silução Ruim usando sobrecarga*/


using System;

namespace ModificadorDePrametrosParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S1 = Calculadora.sum(2, 3);
            int S2 = Calculadora.sum(2, 3, 4);


            Console.WriteLine(S2);
            Console.WriteLine(S1);

            // Instanciar o vetor e colocar os dados nele. Essa função só é ruim porque fica muito verboso com o new int, porem resolve
            int s3 = Calculadora.Soma(new int [] { 1, 2, 3 });
            int s4 = Calculadora.Soma(new int [] { 1, 2, 3, 4, 8, 19 });


            int s5 = Calculadora.SomaBoa(3, 6, 10 , 50, 40 );
            Console.WriteLine(s5);
        }
    }
}
