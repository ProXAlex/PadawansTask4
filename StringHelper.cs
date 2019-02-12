using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
                throw new ArgumentNullException("Source cannot be null");
            if (str == string.Empty)
                throw new ArgumentException("String Cannot Be Empty.");
            int result = 0;
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach (char c in str)
            {
                foreach (char vowel in vowels)
                {
                    if (c == vowel)
                    {
                        result++;
                        continue;
                    } 
                }
                //if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    //    result++;
            }

            return result;
        }
    }
}
