
namespace ExercSemInterface.Services
{
    public class ImpostoNoBrasilService
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
