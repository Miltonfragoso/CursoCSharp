/*Bloco finally é um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.
 * Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do processamento.
 */
using System;
using System.IO;

namespace ExecContinuBlocoFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileStream é uma classe da biblioteca .NET usada para ler, gravar, abrir e fechar arquivos em disco.
            //Ela fornece uma maneira de trabalhar com arquivos como fluxos de bytes.
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                /*um StreamReader é uma classe da biblioteca .NET usada para ler caracteres de um fluxo de dados (como arquivos de texto) 
                 * de forma mais conveniente, especialmente quando o conteúdo é texto (e não apenas bytes como no FileStream).*/
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Esse bloco independente de ter ocorrido erro ou não ele executa o fechamento do recurso FileStream que  foi aberto para ler um arquivo
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
