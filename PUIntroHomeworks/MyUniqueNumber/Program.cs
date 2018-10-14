using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;

            Console.WriteLine("How old are you ?");
            string userValue = Console.ReadLine();
            int myAge = int.Parse(userValue) + 10;

            Console.WriteLine("What is your faculty number ?");
            userValue = Console.ReadLine();
            int facNumber = int.Parse(userValue);

            double uniqueNumber = Math.Round((myAge * facNumber) / pi, 4);

            Console.WriteLine("Your unique number is " + uniqueNumber);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
