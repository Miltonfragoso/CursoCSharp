/*Fazer um programa para ler o nome de um aluno eas três notas que ele obteve nos três trimestres do ano
 (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada) Ao final, mostrar qual a nota final do aluno no ano.
Dizer tamém se o aluno está APROVADO ou REPROVADO, e em caso negativo, quantos pontos faltam para o aluno obter o mínimo
para ser aprovado(que é 60 pontos). Voce deve criar uma classe aluno para resolver este problema.

                                                    ALUNO
                                     ------------------------------------
                                             -Nome: String 
                                             -Nota: double
                                     ------------------------------------
                                             +NotaFinal() double
 */
using System;
using System.Globalization;

namespace ExercicoPOO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2" , CultureInfo.InvariantCulture));

            if (aluno.NotaFinal() > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                double Faltam = 60 - aluno.NotaFinal();
                Console.WriteLine("FALTARAM " + Faltam.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

            //Console.WriteLine("NOTA FINAL = "
            //   + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            //if (aluno.Aprovado())
            //{
            //    Console.WriteLine("APROVADO");
            //}
            //else
            //{
            //    Console.WriteLine("REPROVADO");
            //    Console.WriteLine("FALTARAM "
            //    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
            //    + " PONTOS");
            //}

        }
    }
}
