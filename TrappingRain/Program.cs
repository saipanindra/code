using System;

namespace TrappingRain
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine(Trap(new int[] {0, 2, 0}));
        } 
        public static int Trap(int[] height) {
            if(height.Length <=2) return 0;
            int ans = 0;
            int[] left_max = new int[height.Length];
            int[] right_max = new int[height.Length];
            left_max[0] = height[0];
            for(int i = 1 ; i < height.Length ; i++)
            {
                left_max[i] = Math.Max(left_max[i-1], height[i]);
            }
            right_max[height.Length -1] = height[height.Length - 1];
            for(int k = height.Length - 2 ; k >= 0 ; k--)
            {
                right_max[k] = Math.Max(right_max[k+1], height[k]);
            }
            for(int i = 0 ; i < height.Length ; i++)
            {
                ans += Math.Min(left_max[i], right_max[i]) - height[i];
            }
            return ans;
    }
    }
}
