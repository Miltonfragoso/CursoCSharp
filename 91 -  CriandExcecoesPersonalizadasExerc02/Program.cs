/*ALTERAÇÕES: 
 * Foi passada a lógica de veríficação da atualização da reserva para a classe reserva, feito alterações no método atualizar reserva
 * passou a retornar uma string, se essa string retornar nula é porque não teve erro, se não vai retornar a string com o tipo de erro.
 */
using CriandExcecoesPersonalizadasExerc02.Entities;
using System;

namespace CriandExcecoesPersonalizadasExerc02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do quarto: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("data do Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("data do Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro na reserva: a data de saída tem que ser maior a data de entrada");
            }
            else
            {
                Reserva reserva = new Reserva(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");
                Console.Write("data do Check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("data do Check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string erro = reserva.UpdateDates(checkIn, checkOut);
                if (erro != null)
                {
                    Console.WriteLine("Erro da reserva: " + erro);
                }
                else
                {
                    Console.WriteLine("Reserva: " + reserva);
                }

            }
        }
    }
}
