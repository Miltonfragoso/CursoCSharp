using System;

namespace CriandExcecoesPersonalizadasExerc.Entities
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

        public void UpdateDates(DateTime cheKin, DateTime checkOut)
        {
            Entrada = cheKin;
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
