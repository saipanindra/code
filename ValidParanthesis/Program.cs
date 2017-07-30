using System;
using System.Collections.Generic;

namespace ValidParanthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("({}[(])"));
        }

        public static bool IsValid(string s) {
            if(string.IsNullOrEmpty(s)) return true;
            List<char> openingBraces = new List<char>{'(', '[', '{'};
            List<char> closingBraces = new List<char>{')', ']', '}'};
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if(closingBraces.Contains(c))
                {
                     if(stack.Count == 0 || stack.Peek() != openingBraces[closingBraces.IndexOf(c)])
                     {
                         return false;
                     }
                     stack.Pop();
                     continue;
                }
                stack.Push(c);
            }
            return stack.Count == 0;
          }
    }
}
