using System;

namespace LongestContinuousIncreasingSubSequence
{
    //https://leetcode.com/contest/leetcode-weekly-contest-49/problems/longest-continuous-increasing-subsequence/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLengthOfLCIS(new int[]{1,2,3,4,5}));
        }

        public static int FindLengthOfLCIS(int[] nums)
        {
            if( nums == null ||nums.Length == 0 ) return 0;
            if(nums.Length == 1) return 1;
            int maxLength = 1;
            int lcisSoFar = 1;
            for(int i = 1; i < nums.Length ;i++)
            {
                if(nums[i] <= nums[i-1])
                {
                    maxLength = Math.Max(lcisSoFar, maxLength);
                    lcisSoFar = 1;
                    continue;
                }
                lcisSoFar++;
            }
            return Math.Max(lcisSoFar, maxLength);
        }






        }
    }

