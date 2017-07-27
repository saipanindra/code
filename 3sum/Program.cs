//https://leetcode.com/problems/3sum/tabs/description
using System;
using System.Collections.Generic;

namespace _3sum
{
    class Program
    {
        static void Main(string[] args)
        {
           var r = ThreeSum(new int[] {0, 0, 0, 0, 0, 0});
           foreach(var l in r)
           {
               foreach(var v in l)
               {
                   Console.Write(v + " ");
               }
               Console.WriteLine();
           }
        }
        
        public static IList<IList<int>> ThreeSum(int[] nums) {
            IList<IList<int>> result =  new List<IList<int>>();
            HashSet<int> fixedValSet = new HashSet<int>();
            HashSet<int> endValSet = new HashSet<int>();
            Array.Sort(nums);
            if(nums.Length < 3) return result;
            for(var fixedIndex = 0; fixedIndex <= nums.Length - 3; fixedIndex++)
            {
                var fixedVal = nums[fixedIndex];
                if(fixedValSet.Contains(fixedVal))
                {
                    continue;
                }
                fixedValSet.Add(fixedVal);
                var startIndex = fixedIndex + 1;
                var endIndex = nums.Length - 1;
                while(startIndex < endIndex)
                {
                    var firstVal = nums[startIndex];
                    var endVal = nums[endIndex];
                    var sum = fixedVal + firstVal + endVal;
                    if(sum == 0)
                    {
                        if(!endValSet.Contains(endVal))
                        {
                            result.Add(new List<int>(){fixedVal, firstVal, endVal});
                            endValSet.Add(endVal);
                        }
                        endIndex--;
                        continue;
                    }
                    if(sum > 0)
                    {
                        endIndex--;
                        continue;
                    }
                    if(sum < 0)
                    {
                        startIndex++;
                        continue;
                    }
                }
                endValSet.Clear();
            }
            return result;
        }
    }
}
