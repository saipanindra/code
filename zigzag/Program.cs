using System;

namespace zigzag
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(zigzag(new int[]{9, 8, 8, 5, 3, 5, 3, 2, 8, 6}));
           Console.WriteLine(zigzag(new int[] {4,4}));
                    
        }
        
        private static int zigzag(int[] a)
        {
            int z = a[1]==a[0] ? 1 : 2;
            int ans =  z;
            for(int i = 2; i < a.Length ; i++)
            {
                if((a[i] > a[i-1] && a[i-1]< a[i-2]) || (a[i] < a[i-1] && a[i-1] > a[i-2]))
                {
                    z++;
                }
                else
                {
                    z = a[i] != a[i-1] ? 2 : 1;
                }
                ans = Math.Max(z,ans);
            }
            return ans;
        }
    }
}
