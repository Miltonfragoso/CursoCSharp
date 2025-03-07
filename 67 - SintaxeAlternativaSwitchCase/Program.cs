/*SWITCH-CASE: Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste do valor de uma variável.
 */

using System;

namespace SintaxeAlternativaSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usando o if
            int x = int.Parse(Console.ReadLine());
            string day;

            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3)
            {
                day = "Tuesday";
            }
            else if (x == 4)
            {
                day = "Wednesday";
            }
            else if (x == 5)
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine("Day: " + day);

            // usando o switch-case
            int y = int.Parse(Console.ReadLine());
            string dia;
            switch (y)
            {
                case 1:
                    dia = "Sunday";
                    break;
                case 2:
                    dia = "Monday";
                    break;
                case 3:
                    dia = "Tuesday";
                    break;
                case 4:
                    dia = "Wednesday";
                    break;
                case 5:
                    dia = "Thursday";
                    break;
                case 6:
                    dia = "Friday";
                    break;
                case 7:
                    dia = "Saturday";
                    break;
                default:
                    dia = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + dia);
        }
    }
}
