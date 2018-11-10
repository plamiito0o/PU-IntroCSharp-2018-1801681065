using System;
using System.Text;

namespace PrintSmileyAfterName
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] names = System.IO.File.ReadAllLines(@"C:\Users\plami\Desktop\Work_Folder\PU-IntroCSharp-2018-1801681065\PUIntroHomeworks\PrintSmileyAfterName\files\students.txt");
            System.Console.WriteLine("Contents of students.txt=");
                      
                //Console.WriteLine("\t" + line);
                /*int sum = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    sum += (int)names[i];
                  
                }
               if (sum >15000)
            { 
                PrintSmileys(names);
            }*/
           // }
            PrintSmileys(names);
           
             void PrintSmileys(string[] words)
            {
                for (int i = 0; i < words.Length; i++)
                { Console.WriteLine($"Name:{words[i]}{(char)9786}"); }
            }
            Console.ReadKey();
        }
    }
        
}
    

