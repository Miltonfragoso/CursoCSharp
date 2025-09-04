/*
 * Faça um programa para ler um arquivo contendo funcionários (nome e salário) no
 formato .csv, armazenando-os em uma lista. Depois, ordenar a lista por nome e mostrar
 o resultado na tela. Nota: o caminho do arquivo pode ser informado "hardcode".

Maria Brown,4300.00
Alex Green,3100.00
Bob Grey,3100.00
Anna White,3500.00
Alex Black,2450.00
Eduardo Rose,4390.00
Willian Red,2900.00
Marta Blue,6100.00
Alex Brown,5000.00
 */

using InterfaceIComparableParte02.Enteties;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparableParte02
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
                    List<Funcionario> list = new List<Funcionario>();

                    //Enquanto não chegar ao final do arquivo
                    //Adiciona cada linha lida no arquivo a minha lista
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    //Não tem como ordenar funcionaroio sem comparar
                    //Ordena a lista
                    list.Sort();

                    foreach (Funcionario f in list)
                    {
                        Console.WriteLine(f);
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
