using System;
using System.Collections.Generic;

namespace _61___ListaNaPratica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            //método Add = Adiciona elementos a minha lista no final da lista
            list.Add("Milton");
            list.Add("Danilsa");
            list.Add("Yahminah");
            list.Add("Marcos");
            list.Add("Yahmi");
            list.Add("Yahm");
            //método insert = adicina elemntos na posição na qual você deseja definir
            list.Insert(1, "Conceição");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //método count = mostra o tamanho da lista
            Console.WriteLine("Tamanho da lista: " + list.Count);


            //usando a função/ método Test
            string s1 = list.Find(Test);
            Console.WriteLine("O primeiro elemento da lista que começa com 'Y' é : " + s1);


            //usando lambda
            string s2 = list.Find(x => x[0] == 'D');
            Console.WriteLine("O primeiro elemento da lista que começa com 'D' é : " + s2);


            //usando lambda
            string s3 = list.FindLast(x => x[0] == 'Y');
            Console.WriteLine("O último elemento da lista que começa com 'Y' é : " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Primeiro elemento que começa com 'M' esta na posição: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Último elemento que começa com 'M' esta na posição: " + pos2);



            // esse método remove apartir da posição 2, 2 elementos
            list.RemoveRange(3, 1);
            foreach (string item in list) { Console.WriteLine(item); }
            Console.WriteLine("================================================================================================");

            // método fandAll = vai na minha lista pega todo mundo que tem tamanho 5 
            List<string> list2 = list.FindAll(x => x.Length >= 5);
            foreach (string item in list2) { Console.WriteLine(item); }
            Console.WriteLine("================================================================================================");


            // esse método pede uma string no parametro
            list.Remove("Milton");
            foreach (string item in list) { Console.WriteLine(item); }
            Console.WriteLine("================================================================================================");

            // esse método pede um predicado/lambda no parametro
            list.RemoveAll(x => x[0] == 'Y');
            foreach (string item in list) { Console.WriteLine(item); }
            Console.WriteLine("================================================================================================");

            // esse método remove na posição
            list.RemoveAt(2);
            foreach (string item in list) { Console.WriteLine(item); }
            Console.WriteLine("================================================================================================");

        }

        //função criada para testar...Esta função pode ser trocada por uma expressão lambda x => x[0] == 'Y'
        static bool Test(string s) { return s[0] == 'Y'; }
    }
}


//método find encontra o primeiro elemento da lista que satisfaça um predicado 
//método findLast encontra o último elemento da lista que satisfaça um predicado 
//predicado é uma função que retorna ou verdadeiro ou falso conforme a lógica implementada
//método FindIndex encontra a primera posição de um elemento na lista
//método FindLastIndex encontra a última posição de um elemento na lista
//método FindAll filtrar a lista com base em um predicado/Expressão Lambda
//método Remove remove elementos da lista 
//método RemoveAll
//método RemoveAt
//método RemoveRange