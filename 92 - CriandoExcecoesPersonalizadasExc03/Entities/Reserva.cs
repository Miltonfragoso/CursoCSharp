using CriandoExcecoesPersonalizadasExc03.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CriandExcecoesPersonalizadasExerc02.Entities
{
    internal class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime entrada, DateTime saida)
        {
            if (saida <= entrada)
            {
                throw new DomainExceptions("A data de saída tem que ser maior a data de entrada");
            }

            NumeroQuarto = numeroQuarto;
            Entrada = entrada;
            Saida = saida;
        }

        //Esse método duração vai retornar o calcúlo das horas desde a data de  entrada até a data de saída
        public int Duracao()
        {
            TimeSpan duracao = Saida.Subtract(Entrada);
            return (int)duracao.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainExceptions( "As datas para atualização das reservas precisam ser datas futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainExceptions("A data de saída tem que ser maior a data de entrada");
            }

            Entrada = checkIn;
            Saida = checkOut;

        }

        public override string ToString()
        {
            return "Quarto "
                + NumeroQuarto
                + ", check-in: "
                + Entrada.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Saida.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + " nights";
        }
    }
}
