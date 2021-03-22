using System;

namespace Leap_Year_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Input a year to check if it is a leapyear: ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime dt = new DateTime(year);

                bool isLeapYear = false;
                if ((year % 4 == 0 && !(year % 100 == 0)) || (year % 4 == 0 && year % 400 == 0))
                {
                    isLeapYear = true;
                }
                string answer = (isLeapYear) ? " is a leapyear." : " is not a leapyear.";
                Console.WriteLine($"The year {dt} {answer}");
            }
            Console.ReadLine();
        }
    }
}
