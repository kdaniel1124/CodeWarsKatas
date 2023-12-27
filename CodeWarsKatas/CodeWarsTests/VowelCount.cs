using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    public class VowelCount
    {
        public int GetVowelCount(string str)
        {
            char[] vowelBank = { 'a', 'e', 'i', 'o', 'u' };

            int vowelCount = 0;

            foreach(char letter in str)
            {
                if (vowelBank.Contains(letter))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
