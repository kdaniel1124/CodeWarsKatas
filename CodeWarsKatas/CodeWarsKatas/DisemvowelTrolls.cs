using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class DisemvowelTrolls
    {
        public string Disemvowel(string str)
        {
            List<string> vowelBank = new List<string> { "a", "e", "i", "o", "u" };

            string result = "";

            foreach(char letter in str)
            {
                if (!vowelBank.Contains(letter.ToString().ToLower()))
                {
                    result += letter;
                }
            }

            return result;
        }
    }
}
