using System;

namespace LargestSumInSubarray
{
    class LargestSum
    {
        public static int getLargestSum(int[] input)
        {
            //int []A={-1,2,3,4,-5,6,7,1};
            int a = input[0];
            int b = input[1];
            int c = input[2];
            int curSum = a + b + c;
            int maxSum = curSum;
            int start = 0; 
            int end = 3;
            while(end < input.Length)
            {
                int nextSum = curSum - input[start] + input[end];
                maxSum = Math.Max(nextSum, maxSum);
                curSum = nextSum;
                start++;
                end++;
            }
            return maxSum;
        }

        public static void Main(String[] args)
        {
            int[] inp = new int[]{-1,2,3,4,-5,6,7,1}; 
            Console.WriteLine(getLargestSum(inp));
        }
}
}
