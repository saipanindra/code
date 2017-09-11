using System;
using System.Collections.Generic;

namespace PeriodicSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(periodicSequence(11, 2, 6, 12));
            Console.WriteLine(periodicSequence(1, 2, 3, 5));
        }
        
        public static int periodicSequence(int s0, int a, int b, int m)
        {
            // (a * s[i-1] + b) mod m.
            Dictionary<int, int> d = new Dictionary<int, int>();
            int k = 0;
            int diff = 0;
            int prev_diff = -1;
            int hitcount = 0;
            d.Add(s0, k);
            k++;
            int attempts  = 0;
            int prev = s0;
            int current = prev;
            int most_recent_occurance_of_current = 0;
            while(hitcount < 2 && attempts < 10)
            {
                prev = current;
                current = (a * prev  + b) % m;
                if(!d.TryGetValue(current, out most_recent_occurance_of_current))
                {
                    d.Add(current, k);
                    k++;
                    attempts++;
                    continue;
                }
                diff = k - most_recent_occurance_of_current;
                if(prev_diff == -1)
                {
                    prev_diff = diff;
                    d[current] = k;
                    k++;
                    attempts++;
                    continue;
                }
                if( prev_diff != diff)
                {
                   d.Clear();
                   d.Add(current, k);
                   k++;
                   hitcount = 0;
                   attempts++;
                   continue;
                }
                d[current] = k;
                k++;
                attempts++;
                hitcount++;
            }
            return diff;
        }
    }
}
