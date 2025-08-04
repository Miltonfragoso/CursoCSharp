/*Using block: é uma sintaxie simplificada que garante que os objetos IDisposable serão fechados.
 * Objetos IDisposable Não são gerenciados pelo CLR.Eles precisam ser manualmente fechados.
 * EX: Font, FileStream, StreamReader, StreamWriter
 */
using System;
using System.IO;

namespace Bloco_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MILTON\Desktop\Arquivos baixados\File1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {

                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
