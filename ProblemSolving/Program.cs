using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(nums));
 
        }


        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            int num = 0;

           
                for (int i = 0; i < nums.Length; i++)
                {
                    num ^= nums[i];
                }
          


            return num;
        }
    }

}

