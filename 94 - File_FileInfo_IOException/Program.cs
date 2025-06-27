/*File e FileInfo são duas classes básicas para utilização de arquivo que pertencem ao Namespace System.IO
 * elas realiza operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream
 * 
 * Diferença:
 * File é uma classe mais simples disponibiliza operações estaticas sem precisar instanciar o objeto. ela é mais simples porém mais lenta porque 
 * realiza verificação de segurança a cada operação.
 * 
 * FileInfo instancia os objetos e apartir dele chamamos as operações. sem verificação de segurança.
 * 
 * IOException pertence também ao Namespace System.IO é a super classe de todas exeções quando trabalhamos com arquivo
 *  • DirectoryNotFoundException
    • DriveNotFoundException
    • EndOfStreamException
    • FileLoadException
    • FileNotFoundException
    • PathTooLongException
    • PipeException
 */
using System;
using System.IO;

namespace File_FileInfo_IOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoPastaOrigem = @"C:\Users\MILTON\Desktop\Arquivos baixados\File1.txt";
            string caminhoPastaDestino = @"C:\Users\MILTON\Desktop\Arquivos baixados\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoPastaOrigem);
                fileInfo.CopyTo(caminhoPastaDestino);

                //Como não tem nenhum arquivo instanciado passamos o caminho direto na função
                string[] linhas = File.ReadAllLines(caminhoPastaOrigem);
                foreach (string linha in linhas) { Console.WriteLine(linha); }

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
