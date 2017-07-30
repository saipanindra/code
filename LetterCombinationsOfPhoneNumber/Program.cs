//https://leetcode.com/problems/letter-combinations-of-a-phone-number/tabs/description
using System;
using System.Collections.Generic;

namespace LetterCombinationsOfPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        var r = LetterCombinations("23");
        //foreach(var i in r)
        //{
            //Console.Write(i  + " ");
        //}
        var r2 = LetterCombinationsTailRecursive("234");
        foreach (var i in r2)
        {
            Console.Write(i + " ");
        }
            
        }
        public static IList<string> LetterCombinations(string digits) {
          if(string.IsNullOrEmpty(digits))
          {
              return new List<string>();
          }
          Dictionary<char, string> digitMap = new Dictionary<char, string>();
          digitMap['2'] = "abc";
          digitMap['3'] = "def";
          digitMap['4'] = "ghi";
          digitMap['5'] = "jkl";
          digitMap['6'] = "mno";
          digitMap['7'] = "pqrs";
          digitMap['8'] = "tuv";
          digitMap['9'] = "wxyz";

          List<string> maplist = new List<string>();
          foreach(var d in digits)
          {
             if(!digitMap.ContainsKey(d))
                continue;
             maplist.Add(digitMap[d]);
          }
          
          return _LetterCombinations(maplist, 0);
        }
        
        private static IList<string> _LetterCombinations(List<string> maplist, int index)
        {
            List<string> resultList = new List<string>();
            if(index == maplist.Count -1)
            {
                foreach(char c in maplist[index])
                {
                    resultList.Add(c.ToString());
                }
                return resultList;
            }
            
            foreach(char c in maplist[index])
            {
                   var suffixList = _LetterCombinations(maplist, index + 1);
                   foreach(var s in suffixList)
                   {
                       resultList.Add(c+s);
                   }
            }
            return resultList;
        }
        

        public static List<string> LetterCombinationsTailRecursive(string digits)
        {
            if(string.IsNullOrEmpty(digits))
          {
              return new List<string>();
          }
          Dictionary<char, string> digitMap = new Dictionary<char, string>();
          digitMap['2'] = "abc";
          digitMap['3'] = "def";
          digitMap['4'] = "ghi";
          digitMap['5'] = "jkl";
          digitMap['6'] = "mno";
          digitMap['7'] = "pqrs";
          digitMap['8'] = "tuv";
          digitMap['9'] = "wxyz";

          List<string> maplist = new List<string>();
          foreach(var d in digits)
          {
             if(!digitMap.ContainsKey(d))
                continue;
             maplist.Add(digitMap[d]);
          }
            return _LetterCombinationsTailRecursive(maplist, 0, new List<string>());
        }
        private static List<string> _LetterCombinationsTailRecursive(List<string> maplist, int index, List<string> resultSoFar)
        {
             var resultList = new List<string>();
             if(resultSoFar.Count == 0)
             {
                 foreach(var c in maplist[index])
                 {
                     resultSoFar.Add(c+"");
                 }
                 return _LetterCombinationsTailRecursive(maplist, index + 1, resultSoFar);
             }
            if(index == maplist.Count)
                return resultSoFar;
             foreach( var s in resultSoFar)
             {
                 foreach(var c in maplist[index])
                 {
                     resultList.Add(s + c);
                 }
             }
             
            return _LetterCombinationsTailRecursive(maplist, index +1, resultList);
        }
        

        
        
    }
    

}
