using System;

namespace MinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = {1, 2};
            int[] input2 = {3, 4, 5};
            int[] input3 = {3, 5, 4, 2, 6, 5, 6, 6, 5, 4, 8, 3};
            int[] input4 = {2, 5, 3, 5, 4, 4, 2, 3};
            Console.WriteLine(getMinimumDistanceV2(input1, 2, 1,2));
            Console.WriteLine(getMinimumDistanceV2(input2, input2.Length, 3, 5));
            Console.WriteLine(getMinimumDistanceV2(input3, input3.Length, 3, 6));
            Console.WriteLine(getMinimumDistanceV2(input4, input4.Length, 3, 2));

        }

        static int getMinimumDistanceV2(int[] a, int n, int x, int y)
        {
            int prev = -1;
            int minDistance = Int32.MaxValue;
            for(int i = 0 ; i < n; i++)
            {
                if(a[i] == x || a[i] == y)
                {
                    if(prev == -1) //not set
                    {
                        prev = i;
                        continue;
                    }
                    if(a[prev] == a[i]) // same element found
                    {
                        prev = i;
                        continue;
                    }
                    minDistance = Math.Min(minDistance, i - prev); 
                }
            }
            return minDistance;
        }
    }
}
                    
        