﻿using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            int result = AgeAfter10Years(age);
            Console.WriteLine("You will be " + result + " years old after 10 years.");
            Console.ReadKey();
        }

        static int AgeAfter10Years(int currentAge)
        {
            int ageAfter10Years = currentAge+10;
            return ageAfter10Years;
            
        }
    }
}
