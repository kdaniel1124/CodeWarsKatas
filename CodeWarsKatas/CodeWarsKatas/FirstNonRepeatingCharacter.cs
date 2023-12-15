using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    //https://www.codewars.com/kata/52bc74d4ac05d0945d00054e
    public class FirstNonRepeatingCharacter
    {
        public string FirstNonRepeat(string str)
        {
            // We make a lowercase version of our input string to loop through so we can be case insensative
            string lowerString = str.ToLower();

            for (int i = 0; i < lowerString.Length; i++)
            {
                // Stored each char in a variable call currentLetter just for readability
                char currentLetter = lowerString[i];

                // With this conditional we compare the (first)IndexOf and LastIndexOf the current letter
                // If first and last occurence are different indexes then we know it only occurs more than once
                if (lowerString.IndexOf(currentLetter) == lowerString.LastIndexOf(currentLetter))
                {
                    // We return the index from the original input as opposed to our lower case string
                    return str[i].ToString();
                }
            }

            // If we loop throught the whole string with only repeat characters then we are to simply return an empty string
            return "";
        }
    }
}
