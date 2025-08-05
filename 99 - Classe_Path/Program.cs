/*Classe Path é uma classe que realiza operações com strings que contém informações de arquivos ou pastas*/


using System;
using System.IO;

namespace Classe_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MILTON\Desktop\Arquivos baixados\File1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
