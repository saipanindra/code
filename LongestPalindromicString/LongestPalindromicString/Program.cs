using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindromeDP("cbbd"));
            Console.Read();
        }

        public static string LongestPalindromeN3(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            int  maxi = 0, maxj = 0, longestmatch = 0;
            for (int startIndex = 0; startIndex < s.Length; startIndex++)
            {
                for (int endIndex = 0; endIndex < s.Length; endIndex++)
                {
                    if (isPalindrome(s, startIndex, endIndex))
                    {
                        if (endIndex - startIndex + 1 > longestmatch)
                        {
                            maxi = startIndex;
                            maxj = endIndex;
                            longestmatch = endIndex - startIndex + 1;
                        }
                    }
                }
            }
            return s.Substring(maxi, maxj - maxi + 1);
        }

        public static string LongestPalindromeDP(string s)
        {
            bool[][] cache = new bool[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                cache[i] = new bool[s.Length];
            }

            int start = 0;
            int maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                cache[i][i] = true;
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                cache[i][i + 1] = s[i] == s[i + 1];
                if (cache[i][i + 1])
                {
                    start = i;
                    maxLength = 2;
                }
            }
            for (int stringLength = 3; stringLength <= s.Length; stringLength++)
            {
                for (int i = 0; i < s.Length - stringLength + 1; i++)
                {
                    int j = i + stringLength - 1;
                    cache[i][j] = cache[i + 1][j - 1] && s[i] == s[j];
                    if (cache[i][j])
                    {
                        if (stringLength > maxLength)
                        {
                            maxLength = stringLength;
                            start = i;
                        }
                    }
                }
            }
            return s.Substring(start, maxLength);
        }
        private static bool isPalindrome(string s, int startIndex, int endIndex)
        {
            while (s[startIndex] == s[endIndex])
            {
                startIndex++;
                endIndex--;
                if (startIndex > endIndex) return true;
            }
            return false;
        }

    }
    }
