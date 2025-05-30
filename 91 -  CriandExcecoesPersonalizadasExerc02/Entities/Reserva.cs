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

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "As datas para atualização das reservas precisam ser datas futuras";
            }
            if (checkOut <= checkIn)
            {
                return "A data de saída tem que ser maior a data de entrada";
            }

            Entrada = checkIn;
            Saida = checkOut;

            // O retorno nullo indica que não teve nehum erro.
            return null;
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
