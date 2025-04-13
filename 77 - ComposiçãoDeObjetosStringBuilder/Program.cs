// Instanciar manualmente os objetos e mostre-os na tela do terminal.
using System;
using ComposiçãoDeObjetosStringBuilder.Entities;

namespace ComposiçãoDeObjetosStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Faça uma boa viagem! ");
            Comentario c2 = new Comentario("Uau, isso é incrível! ");

            Publicar p1 = new Publicar(
                DateTime.Parse("21/06/2018 13:05:44 "),
                " Viajando para Nova Zelandia ",
                " Eu estou visitando este belo Pais ",
                12);
            p1.AddComentario(c1);
            p1.AddComentario(c2);




            Comentario c3 = new Comentario(" Boa noite! ");
            Comentario c4 = new Comentario(" Que a força esteja com você! ");

            Publicar p2 = new Publicar(
                DateTime.Parse("28/07/2018 23:14:19 "),
                " Boa noite pessoal ",
                " Nos vemos amanhâ ",
                12);
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
        }
    }
}
