using System;
using System.Collections.Generic;

namespace TreeBottom
{
    class Program
    {
        static void Main(string[] args)
        {
          var r = treeBottom("(2 (7 (2 () ()) (6 (5 () ()) (11 () ()))) (5 () (9 (4 () ()) ())))");
        }
        
        public static int[] treeBottom(string tree) {
            List<int> res = new List<int>();
            Stack<int> s = new Stack<int>();
            int maxCount = 0;
            for(int i = 0 ; i < tree.Length ; i++)
            {
                if(tree[i] == '(')
                {
                    if(tree[i+1] == ')')
                    s.Push(' ');
                    continue;
                }
                if(tree[i] == ')')
                {
                     var a = s.Pop();
                     if(a == ' ') continue;
                     if(s.Count + 1 < maxCount)
                     {
                        continue;
                     }
                     if(s.Count + 1 > maxCount)
                     {
                         maxCount = s.Count + 1;
                         res.Clear();
                     }
                     res.Add(Int32.Parse(a+""));
                     continue;
                }
                if(tree[i] == ' ') continue;
                if(i == tree.Length - 1)
                {
                    s.Push(Int32.Parse(tree[i] + ""));
                }
                string num = "";
                while(tree[i] != ' ')
                {
                  num = num + tree[i];
                  i++;
                }
                s.Push(Int32.Parse(num));
            }
            return res.ToArray();
        }
                
                
                
            
            }
            
        }
    

