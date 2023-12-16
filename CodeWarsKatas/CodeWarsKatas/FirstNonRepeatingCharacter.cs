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
        /*// Inefficient but concise method v
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
        }*/
        public string FirstNonRepeat(string str)
        {
            // Create our dictionary that we will use to log the number of occurances of each letter
            Dictionary<char, int> counts = new Dictionary<char, int>();

            // Create a lower case version of our input string which we will iterate through to ensure case insensitivity
            string lowerStr = str.ToLower();

            // We populate our dictionary with the counts of each letter
            foreach (char letter in lowerStr)
            {
                if (counts.ContainsKey(letter))
                {
                    counts[letter]++;
                }
                else
                {
                    counts[letter] = 1;
                }
            }

            // We now to an indexed loop through our lower string, referring to each char as the key in our dictionary
            // If that key has a value of one. Then we return that letter, not from our lower string, but from the original input string
            for (int i = 0; i < lowerStr.Length; i++)
            {
                if (counts[lowerStr[i]] == 1)
                {
                    return str[i].ToString();
                }
            }

            // If string contains only duplicates then we are to simply return an empty string
            return "";
        }
    }
}
