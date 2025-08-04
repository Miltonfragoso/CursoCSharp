/*FileStream: É uma classe que disponibiliza uma stream associada a um arquivo, permite operações de leitura e escrita
 * Podemos Instanciar o FileStream de diferetntes formas. Por meio de vários construtores ou pelo File ou mesmo o FileInfo 
 * FileStream é uma strim binária 
 * 
 * O StreamReader é um objeto instanciado apartir do FileStream. É uma stream capaz de ler caracteres a partir de uma stream binária(ex: FileStream)
 * Podemos Instanciar o FileStream de diferetntes formas. Por meio de vários construtores ou pelo File ou mesmo o FileInfo 
 * StreamReader é uma stream de caracteres
 * 
 * A palavra STREAM na programação ou na informática significa uma sequência de dados um termo utilizado quando a gente 
 * quer fazer a trasmição de dados em sequência ex: youtub, netflix, etc.
 */
using System;
using System.Globalization;
using System.IO;

namespace FileStream_StreamReader
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MILTON\Desktop\Arquivos baixados\File1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);

                /*Outra forma de ler o arquivo sem instanciar fs e ao invez de ler somente uma linha usamos o WHILE para ler o arquivo inteiro
                 * sr = File.OpenText(path);
                 * while (!sr.EndOfStream){
                 * string line = sr.ReadLine();
                 * Console.WriteLine(Line);
                 * }
                 * 
                 */
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            //Esta linha fecha(Manualmente) os recursos de fileStream que abrimos, porque, os recuros não são gerenciados pelo clr do .net
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
              
            }
        }
    }
}
