using System;

namespace Max_Array_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int loop = 0; loop < 3; loop++)
            {
                int[] resultArray = new int[5];
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.WriteLine("Please enter an integer: ");
                    resultArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("The array you entered is : ");
                for (int i = 0; i < resultArray.Length; i++)
                { 
                    Console.Write(resultArray[i]);
                }
                
                Console.WriteLine("\nNow pick your scoring number:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your number is {input}");
                int score = ScoreIt(resultArray, input);

                Console.WriteLine($"Your score was {score}!\n");
            }
            Console.ReadLine();
        }
        public static int ScoreIt(int[] resultArr, int input)
        {
            int score = 0;
            for (int i = 0; i < resultArr.Length; i++)
            {
                if(input == resultArr[i])
                {
                    score++;
                }
            }
            return input*score;
        }
    }
}
