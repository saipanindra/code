using System;
using System.Collections.Generic;

namespace ExclusiveTimeOfFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = ExclusiveTime(2, new List<string>() { "0:start:0", "1:start:2", "1:end:5", "0:end:6" });
            foreach (var i in r)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
        public static int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] result = new int[n];
            int prev_time = 0;
            Stack<int> s = new Stack<int>();

            foreach (var log in logs)
            {
                string[] logComponents = log.Split(':');
                int fid = Int32.Parse(logComponents[0]);
                string status = logComponents[1];
                int timestamp = Int32.Parse(logComponents[2]);

                if (status == "start")
                {
                    if (s.Count > 0)
                    {
                        int lastExecutingFunctionId = s.Peek();
                        result[lastExecutingFunctionId] += timestamp - prev_time;
                    }
                    s.Push(fid);
                    prev_time = timestamp;
                }
                else
                {
                    result[s.Pop()] += timestamp - prev_time + 1;
                    prev_time = timestamp + 1;
                }
            }
            return result;
        }
    }
}
