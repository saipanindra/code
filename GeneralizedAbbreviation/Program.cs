using System;
using System.Collections.Generic;
namespace GeneralizedAbbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
         var r = GenerateAbbreviations("a");
        }
        
        public static IList<string> GenerateAbbreviations(string word) {
           IList<string> res = new List<string>();
           if(word == null) return res;
           if(word == "") {
               res.Add("");
               return res;
           }
           if(string.IsNullOrEmpty(word)) return res;
           helper(word, 0, "", res);
           return res;
        }
        
        private static void helper(string word, int index, string resultWordSoFar, IList<string> result)
        {
           char last  =  string.IsNullOrEmpty(resultWordSoFar) ? '*': resultWordSoFar[resultWordSoFar.Length -1];
           char current = word[index];
           int lastAsInt = -1;
           int numberToAdd = 1;
           bool isLastAnInt = Int32.TryParse(last +"", out lastAsInt);
           if(isLastAnInt)
           {
             numberToAdd +=  lastAsInt;
           }
           if(index == word.Length - 1)
           {
               result.Add(resultWordSoFar + current);
               if(numberToAdd >= 1)
               {
                   if(isLastAnInt)
                        resultWordSoFar = resultWordSoFar.Remove(resultWordSoFar.Length - 1);
                   result.Add(resultWordSoFar + numberToAdd);
                   return;
               }
               result.Add(resultWordSoFar + 1);
               return;
           }
           helper(word, index + 1, resultWordSoFar + current, result);
           if(numberToAdd >= 1)
           {
                if(isLastAnInt)
                        resultWordSoFar = resultWordSoFar.Remove(resultWordSoFar.Length - 1);
                helper(word, index + 1,  resultWordSoFar + numberToAdd, result);
           }
           else
           {
                helper(word, index + 1, resultWordSoFar + 1, result);
           }
        }
        }
    }