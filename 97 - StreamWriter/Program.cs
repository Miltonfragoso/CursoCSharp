/*StreamWriter: é um objeto instanciado apartir do FileStream.
 * E uma stream capaz de escrever caracteres a partir de uma stream binária(ex: FileStream).
 */


using System;
using System.IO;

namespace Stream_Writer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //objetivo: Ler os dados do arquivo 1 e copiar no arquivo 2 porém tudo maiúsculo
            string caminhoPastaOrigem = @"C:\Users\MILTON\Desktop\Arquivos baixados\File1.txt";
            string caminhoPastaDestino = @"C:\Users\MILTON\Desktop\Arquivos baixados\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(caminhoPastaOrigem);

                using (StreamWriter sw = File.AppendText(caminhoPastaDestino))
                {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
