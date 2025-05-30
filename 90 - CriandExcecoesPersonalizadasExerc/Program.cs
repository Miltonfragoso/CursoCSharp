/*
 * Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída) e mostrar os dados da reserva, 
 * inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar novamente a reserva com os dados 
 * atualizados. O programa não deve aceitar dados inválidos para a reserva, conforme as seguintes regras:
   - Alterações de reserva só podem ocorrer para datas futuras
   - A data de saída deve ser maior que a data de entrada
                                                         Reserva
                                                ------------------------------------------------
                                                -  -NumeroDoQuarto: int                        -
                                                - -Entrada: Date                               -
                                                -  -Saida: Date                                -
                                                ------------------------------------------------            
                                                - +Duracao(): int                              -
                                                -  +Atualizar(entrada: Date, saida: Date): void-
 */
using CriandExcecoesPersonalizadasExerc.Entities;
using System;

namespace CriandExcecoesPersonalizadasExerc
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

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Erro na reserva: as datas para atualização das reservas precisam ser datas futuras");
                }
                else if(checkOut <= checkIn)
                {
                    Console.WriteLine("Erro na reserva: a data de saída tem que ser maior a data de entrada");
                }
                else
                {
                    reserva.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reserva: " + reserva);
                }

            }
        }
    }
}
