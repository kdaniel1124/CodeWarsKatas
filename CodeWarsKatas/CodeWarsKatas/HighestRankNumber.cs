﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class HighestRankNumber
    {
        public int HighestRank(int[] arr)
        {
            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            List<int> highestCounts = new List<int>();

            int highestCount = 0;

            // We fill our dictionary by tallying how many times each number occurr in our array
            // At the end of each iteration we also check to see which number has the highest count of occurances
            foreach (int num in arr)
            {
                if (!numCounts.ContainsKey(num))
                {
                    numCounts[num] = 1;
                }
                else
                {
                    numCounts[num]++;
                }

                if (numCounts[num] > highestCount)
                {
                    highestCount = numCounts[num];
                }
            }

            foreach (KeyValuePair<int, int> kvp in numCounts)
            {
                if (kvp.Value == highestCount)
                {
                    highestCounts.Add(kvp.Key);
                }
            }

            return (highestCounts.Max());
        }
    }
}
