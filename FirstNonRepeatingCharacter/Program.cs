using System;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqueChar(""));
        }
        public static int FirstUniqueChar(string s)
        {
            int[] cache = new int[26];
            for(int i = 0 ; i < s.Length; i++)
            {
               cache[s[i] - 'a']++;
            }
            for(int i = 0; i < s.Length; i++)
            {
                if(cache[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
