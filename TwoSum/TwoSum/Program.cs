using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = TwoSumMethod(new int[] { 3, 2, 4}, 6);
            foreach (var n in r)
                Console.Write(n + " ");
            Console.Read();
        }

    public static int[] TwoSumMethod(int[] nums, int target)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!d.ContainsKey(nums[i]))
            {
                 d.Add(nums[i], i);
            }
            if (d.ContainsKey(target - nums[i]) && d[target -nums[i]] != i)
            {
                return new int[] { Math.Min(i, d[target - nums[i]]), Math.Max(i, d[target - nums[i]]) };
            }
           
        }
        return new int[] { };
    }
}
}
 

