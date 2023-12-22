using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    // https://www.codewars.com/kata/55466644b5d240d1d70000ba/train/csharp
    public class CandyProblem
    {
        public int GetMissingCandies(int[] candies)
        {
            if (candies.Length <= 1)
            {
                return -1;
            }

            int highest = candies.Max();

            int candiesToGive = 0;

            foreach(int count in candies)
            {
                candiesToGive += (highest - count);
            }

            return candiesToGive;
        }

    }
}
