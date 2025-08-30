namespace ExercComInterface.Services
{
    public class ImpostoNoBrasilService : IImpostosService
    {
        public double Imposto(double quantia)
        {
            if (quantia <= 100.00)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }

        }
    }
}
