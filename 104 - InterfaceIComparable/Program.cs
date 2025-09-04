//Vamos começar com um exercício simples sem usar o IComparable para  entender 


//Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por
//linha), armazenando-os em uma lista. Depois, ordenar os dados dessa lista e mostra-los
//ordenadamente na tela. Nota: o caminho do arquivo pode ser informado "hardcode".

/*Maria Brown
Alex Green
Bob Grey
Anna White
Alex Black
Eduardo Rose
Willian Red
Marta Blue
Alex Brown*/

using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Área de trabalho\Arquivos baixados\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();

                    //Enquanto não chegar ao final do arquivo
                    //Adiciona cada linha lida no arquivo a minha lista
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    //Ordena a lista
                    list.Sort();

                    foreach (string s in list)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
