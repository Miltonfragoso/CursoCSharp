/*Directory e DirectoryInfo são duas classes servem para nos fornecer operações com pastas
 * ex: criar pasta,listar arquivos etc
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MILTON\Desktop\Arquivos baixados";

            try
            {
                //Listar todas as pastas apartir da pasta Arquivos baixados
                IEnumerable<string> pastas = Directory.EnumerateDirectories(path,"*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach (string pasta in pastas) {
                    Console.WriteLine(pasta);
                }



                //Listar todos os arquivos apartir da pasta Arquivos baixados
                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos: ");
                foreach (string pasta in arquivos)
                {
                    Console.WriteLine(pasta);
                }


                //Criar uma pasta
                Directory.CreateDirectory(path + @"\nwefolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
