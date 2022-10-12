using System;

namespace TotalScore
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] my_numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            findtotal(my_numbers);
        }

        public static int findtotal(int[] my_numbers)
        {
            
            int score = 0;
            
            foreach (int i in my_numbers)
            {
                if (i % 2 == 0)
                {
                    score = score + 1;
                    Console.WriteLine(score);
                }
                else if (i % 2 != 0 && i != 5)
                {
                    score = score + 3;
                    Console.WriteLine(score);
                }
                else
                {
                    score = score + 5;
                    Console.WriteLine(score);
                }
            }

            return score;
        }




    }
}

    
    




