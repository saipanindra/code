using System;

/*
A sequence of integers is called a zigzag sequence if each of its elements is either strictly less than both neighbors or strictly greater than both neighbors. For example, the sequence 4 2 3 1 5 3 is a zigzag, but 7 3 5 5 2 and 3 8 6 4 5 aren't.

For a given array of integers return the length of its longest contiguous sub-array that is a zigzag sequence. */
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
