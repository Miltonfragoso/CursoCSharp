using System;

namespace _69___FuncoesInteressantesParaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG           ";

            //ToUpper converte todos os caracteres da string para maiúsculo
            string s1 = original.ToUpper();

            //ToLower converte todos os caracteres da string para minúsculo
            string s2 = original.ToLower();

            //Trim apaga os espaços em branco tanto os da frente como os de trás na estring
            string s3 = original.Trim();

            //IndexOf onde esta a primeira sequência bc qual a posição na string
            int n1 = original.IndexOf("bc");

            //LastIndexOf onde esta a última sequência bc qual a posição na string
            int n2 = original.LastIndexOf("bc");

            //A função substring contem sobercarga em uma pode passar somente o índici inicial e no outo o índici inicial e ate onde pretende cortar

            //Substring somente com índice recortar a string cortar o 0, 1, 2 começa apartir do 3
            string s4 = original.Substring(3);

            //Substring recortar a string cortar o 0, 1, 2 começa apartir do 3 somente ate 5 caraceres
            string s5 = original.Substring(3, 5);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1);
            Console.WriteLine("LastIndexOf('bc'): -" + n2);
            Console.WriteLine("substring(3): " + s4);
            Console.WriteLine("substring(3, 5): " + s5);
        }
    }
}