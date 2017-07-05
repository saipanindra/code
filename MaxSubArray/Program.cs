using System;
namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Result r1 = MaxSubArray(new int[]{9, -10, 7, 3});
            Console.WriteLine($"Max Sum : {r1.Ans}");
            Console.WriteLine($"Start Index : {r1.StartIndex}");
            Console.WriteLine($"End Index : {r1.EndIndex}");

            Result r2 = MaxSubArray(new int[]{1, -3, 2, -5, 7, 6, -1, -4, 11, -23});
            Console.WriteLine($"Max Sum : {r2.Ans}");
            Console.WriteLine($"Start Index : {r2.StartIndex}");
            Console.WriteLine($"End Index : {r2.EndIndex}");
        }
        public static Result MaxSubArray(int[] input)
        {
            Result r = new Result(0, 0, 0);
            r.Ans = 0;
            var sum = 0;
            var maxSum = 0;
            var tempStartIndex = 0;
            //9 -10 7 1
            for(int i = 0 ; i < input.Length ;i++)
            {
                if(sum + input[i] < 0)
                {
                    sum = 0;
                    tempStartIndex = i + 1;
                }
                else
                {
                    sum += input[i];
                    int localMax = Math.Max(maxSum, sum);
                    if(localMax > maxSum)
                    {
                        r.StartIndex = tempStartIndex;
                        r.EndIndex = i;
                        maxSum = localMax;
                    }
                }
            }
            r.Ans = maxSum;
            return r;
        }

    }
}
