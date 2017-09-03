using System;
using System.Collections.Generic;

namespace buggyCode
{
    //Generate buggy code in contest.
    class Program
    {
        static void Main(string[] args)
        {
          var r = taskMaker(new string[] {
            "ans = 0", 
 "for i in range(n):", 
 "    for j in range(n):", 
 "    //DB 3//for j in range(1, n):", 
 "    //DB 2//for j in range(n + 1):", 
 "        ans += 1", 
 "return ans" 
          }, 3);
        }
        
        
        public static string[] taskMaker(string[] source, int challengeId)
        {
            List<string> res = new List<string>();
            for(int i = 0 ; i < source.Length ; i++)
            {
                if(!source[i].Contains("//DB"))
                {
                    res.Add(source[i]);
                    continue;
                }
                string[] taskComponents = source[i].Split(new string[]{"//"}, StringSplitOptions.None);
                int dbId = Int32.Parse(taskComponents[1].Split(' ')[1]);
                if(dbId != challengeId) continue;
                res[res.Count - 1] = taskComponents[0] + taskComponents[2];
            }
            return res.ToArray();
        }
            }
        }
    

