using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    // https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp
    public class StopSnippingMyWords
    {
        public static string SpinWords (string sentence)
        {
            string[] words = sentence.Split(" ");
            string result = "";

            foreach (string word in words)
            {
                if (word.Length < 5)
                {
                    result += word;
                }
                else
                {
                    for (int i = word.Length - 1; i >= 0; i--)
                    {
                        result += word[i];
                    }
                }
                result += " ";
            }

            return result.Trim();
        }
    }
}
