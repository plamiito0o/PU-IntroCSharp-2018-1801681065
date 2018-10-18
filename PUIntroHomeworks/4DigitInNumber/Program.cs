using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4DigitInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a seven digit number");
            string userValue = Console.ReadLine();

            while (userValue.Length != 7 || int.TryParse(userValue, out int ignore) != true)
            {
                Console.WriteLine("Please input a seven digit number");
                userValue = Console.ReadLine();
            }

            int number = int.Parse(userValue);
            int digit = (number / 1000) % 10;
            Console.WriteLine($"The 4th digit is {digit}");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
