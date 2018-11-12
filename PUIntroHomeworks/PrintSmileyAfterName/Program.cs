using System;
using System.Text;

namespace PrintSmileyAfterName
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\plami\Desktop\Work_Folder\PU-IntroCSharp-2018-1801681065\PUIntroHomeworks\PrintSmileyAfterName\files\students.txt");
            System.Console.WriteLine("Contents of students.txt=");
            int SmileyStudents = 0;
            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                string FirstName = elements[1];
                string SecondName = elements[2];
                string ThirdName = elements[3];
                string name = $"{FirstName} {SecondName} {ThirdName}";
                int sum1 = 0;
                int sum2 = 0;
                int sum3 = 0;
                int sum = 0;
                for(int i=0;i<FirstName.Length;i++)
                {
                    sum1 = sum1 + (int)FirstName[i];
                }
                for(int i=0;i<SecondName.Length;i++)
                {
                    sum2 = sum2 + (int)SecondName[i];
                }
                for(int i=0;i<ThirdName.Length;i++)
                {
                    sum3 = sum3 + (int)ThirdName[i];
                }
                sum = sum1 + sum2 + sum3;

            }
            if (sum > 25000)
            {
                Console.WriteLine($"{FirstName} {SecondName} {ThirdName} {(char)9786}");
                SmileyStudents = 1;
            }

            Console.WriteLine($"TOTAL LINES: {lines.Length}");
            Console.WriteLine($"Total smiley students: {SmileyStudents}");
            
           
            
            Console.ReadKey();
        }
    }
        
}
    

