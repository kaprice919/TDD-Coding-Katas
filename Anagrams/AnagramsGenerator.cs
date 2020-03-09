using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    public class AnagramsGenerator
    {

        public static List<string> generateAnagrams(string anagram)
        {
            HashSet<string> anagrams = new HashSet<string>();
            permute(anagrams, anagram.ToCharArray(), 0, anagram.Length);

            return anagrams.ToList();
        }

       
        private static void permute(HashSet<string> anagrams, char[] anagram, int start, int end)
        {
            if (start != end)
            {
                for(int i = start; i < end; i++)
                {
                    swap(ref anagram[i], ref anagram[start]);
                    permute(anagrams, anagram, start + 1, end);
                    swap(ref anagram[i], ref anagram[start]);
                }
            }
            anagrams.Add(new String(anagram));
        }

        private static void swap(ref char a, ref char b)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }
    }
}