using System;

namespace cs_handsons
{
    class IQA
    {

        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter the no of participants :");
            n = Convert.ToInt32(Console.In.ReadLine());
            int[] arr1 = new int[n];
            int[][] arr2 = new int[n][];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("No of attempts for Team "+i + 1);
                arr1[i] = Convert.ToInt32(Console.In.ReadLine());
                arr2[i] = new int[arr1[i]];
            }
            string final_ans = GetTotalScore(arr2);
            Console.WriteLine(final_ans);
        }
        public static string GetTotalScore(int[][] array)
        {
            int i, j, sum = 0;
            string answer = " ";
            int[] ar = new int[10];
            int[] s = new int[array.Length];
            Console.WriteLine($"Array Length is {array.Length}");
            for (i = 0; i < array.Length; i++)
            {

                Console.WriteLine($"Enter the score for team {i + 1}");
                for (j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                    sum = sum + array[i][j];
                }
                s[i] = sum;
                sum = 0;

            }
            for (i = 0; i < array.Length; i++)
            {
                answer = answer + $"Team {i + 1} Total Score is {s[i]}. ";
            }
            return answer;

        }
        
    }
}
