using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class FirstNonRepeatingCharacter
    {
        public string FirstNonRepeat(string str)
        {
            string lowerString = str.ToLower();

            for (int i = 0; i < lowerString.Length; i++)
            {
                char currentLetter = str[i];

                if (str.IndexOf(currentLetter) == str.LastIndexOf(currentLetter))
                {
                    return currentLetter.ToString();
                }
            }

            return "";
        }
    }
}
