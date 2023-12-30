using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    // https://www.codewars.com/kata/54ff3102c1bad923760001f3
    public class VowelCount
    {
        public int GetVowelCount(string str)
        {
            string[] vowelBank = { "a", "e", "i", "o", "u" };

            int vowelCount = 0;

            foreach(char letter in str)
            {
                if (vowelBank.Contains(letter.ToString().ToLower()))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
