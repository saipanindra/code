using System;
using System.Collections.Generic;

namespace MagicDictionary
{
    public class MagicDictionary
    {
        private HashSet<string> set ;
        public MagicDictionary() {
            set = new HashSet<string>();
        }
        public void BuildDict(string[] dict){
            set.Clear();
            foreach(string s in dict)
            {
                set.Add(s);
            }
        }
        
        public bool Search(string word)
        {
            List<string> tranlatedWords = new List<string>();
            for(int i = 0 ; i < word.Length; i++)
            {
                tranlatedWords = TranslateWords(word, i);
                foreach(var w in tranlatedWords)
                {
                   if(set.Contains(w))
                  {
                    return true;
                  }
                }
            }
            
            return false;
        }

        private  List<string> TranslateWords(string word, int i)
        {
            List<string> translatedWords = new List<string>();
            char currentChar = word[i];
            for(int j = 0 ; j < 26; j++)
            {
                char replacementChar = (char)((int)'a' + j);
                if(currentChar != replacementChar)
                {
                    var translatedWord = word.Substring(0, i) + replacementChar + word.Substring(i + 1);
                    translatedWords.Add(translatedWord);
                }
            }
            return translatedWords;
        }

        static void Main(string[] args)
        {
            MagicDictionary d  = new MagicDictionary();
            d.BuildDict(new string[]{"hello", "leetcode"});
            d.Search("hhllo");
        }
    }
}
