using IntroducaoDelegates.Services;
using System;

namespace IntroducaoDelegates
{

    //Criando um delegate
    //Ele vai ser uma referência para um método que recebe dois double e retorna um double
    delegate double BinaryNumericOperation(double n1, double n2);

    public class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12.0;

            //O objeto op do tipo BinaryNumericOperation pode receber qualquer método que tenha a mesma assinatura
            BinaryNumericOperation op = CalculationService.Sum;
            double result3 = op(a, b);


            double result = CalculationService.Sum(a, b);
            double result1 = CalculationService.Max(a, b);

            //Esse método Square não pode ser referenciado pelo delegate BinaryNumericOperation porque ele não tem a mesma assinatura
            double result2 = CalculationService.Square(a);
        }
    }
}
