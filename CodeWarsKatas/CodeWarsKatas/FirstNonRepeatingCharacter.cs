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
                char currentLetter = lowerString[i];

                if (lowerString.IndexOf(currentLetter) == lowerString.LastIndexOf(currentLetter))
                {
                    return str[i].ToString();
                }
            }

            return "";
        }
    }
}
