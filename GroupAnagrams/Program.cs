using System;
using System.Collections.Generic;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
           var  r = GroupAnagrams(new string[]{"eat", "tea", "tan", "ate", "nat", "bat"});
        } 
        public static IList<IList<string>> GroupAnagrams(string[] strs) {
        HashSet<int> h = new HashSet<int>();
        IList<IList<string>> r = new List<IList<string>>();
        for(int i = 0 ; i < strs.Length ; i++)
        {
            if(h.Contains(i))
            continue;
            h.Add(i);
            List<string> s= new List<string>(){strs[i]};
            List<string> l = new List<string>(strs);
            var t1 = strs[i].ToCharArray();
            Array.Sort(t1);
            for(int j = i + 1; j < strs.Length ; j++)
            {
              if(h.Contains(j)) continue;
              var t2 = strs[j].ToCharArray();
              Array.Sort(t2);
              if(new string(t2) == new string(t1))
              {
                  s.Add(strs[j]);
                  h.Add(j);
              }
            }
            r.Add(s);
        }
        return r;
        }
    }
}
