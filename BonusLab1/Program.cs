using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my bonus lab!");
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Please input a number between 1 and 100 and it will tell you the equivelent grade.");
                int num = int.Parse(Console.ReadLine());
                Grade(num);
                run = Continue();
            }

        }

        public static void Grade(int num)
        {
            if (num <= 60)
            {
                Console.WriteLine("F");
            }
            else if(num <= 66)
            {
                Console.WriteLine("D");
            }
            else if (num <= 79)
            {
                Console.WriteLine("C");
            }
            else if (num <= 87)
            {
                Console.WriteLine("B");
            }
            else if (num <= 99)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("A+");
            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Continue? Y/N");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't under your input let's try that again");
                run = Continue();
            }
            return run;
        }
    }
}
